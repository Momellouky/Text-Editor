using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using BunifuAnimatorNS;
using System.Globalization;
using System.IO; 

namespace swatchesPanelLib
{
    public class Class1
    {
        /* 
       * STEPS:
       * ----------------------
       * load form 
       * load close btn 
       * load default color 
       * load color panel
       * load rgb textboxes
       * ----------------------
       */

        // default values. 

        public static int panel_width  = 500;
        public static int panel_height = 300;
        public enum primary_color { 
            red     = 21, 
            green   = 33, 
            blue    = 61
        };

        public enum secondary_color { 
            red = 242, 
            green = 156, 
            blue = 17 
        };

        public static int color_square_width  = 35;
        public static int color_square_height = 34;

        public int color_panel_width  = 400;
        public int color_panel_height = 70;

        public static  string btn_font       = "Microsoft Sans Serif";
        public static  double font_size      = 7.5;
        static FontStyle default_font_style = FontStyle.Bold;



        // load form 
        static Form mainPanel = new Form();
        public static  Form loadForm()
        {
            

            // set mainPanel properties. 
            mainPanel.Width = panel_width;
            mainPanel.Height = panel_height;

           

            mainPanel.BackColor = Color.FromArgb((int)primary_color.red, (int)primary_color.green, (int)primary_color.blue);
            mainPanel.FormBorderStyle = FormBorderStyle.None;
            //mainPanel.MinimizeBox = false;
            //mainPanel.MaximizeBox = false; 
            

            mainPanel.StartPosition = FormStartPosition.CenterScreen;
            //mainPanel.ShowDialog();

            return mainPanel; 
        }

        static Button close_btn = new Button();
        public static void CreateCloseBtn()
        {
            

            //close_btn.Visible = true; 

            close_btn.Width = panel_width;
            close_btn.Height = 20;

            close_btn.BackColor = Color.FromArgb(
                (int)secondary_color.red, 
                (int)secondary_color.green, 
                (int)secondary_color.blue);

            close_btn.ForeColor = Color.FromArgb(
                (int)primary_color.red, 
                (int)primary_color.green,
                (int)primary_color.blue); 

            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.FlatAppearance.BorderSize = 0;

            close_btn.Location = new Point(0, 0);

            close_btn.Text = "Close";
            close_btn.Font = new Font(btn_font,(float)font_size,default_font_style);

            mainPanel.Controls.Add(close_btn);
        }

        public static void createDefaultColors(string[] colorCode )
        {

            // need to add max color. 
            // add new color btn. 

            /* Docs: 
             * This function creates and shows colors in the color swatches form. 
             * number of colors shown = number of color codes given in the string array colorCode.
             */

            int v_margin = close_btn.Height + 37; // 37 = to a margin defined by the designer.
            int width = 51,
                h_margin = 20,
                height = v_margin,
                max_number = 15;

            StreamWriter sw = new StreamWriter("file.txt");
            sw.WriteLine("Created fromc code to check where is my file."); 
            sw.Close(); 




            for (int counter = 1; counter <= colorCode.Length; counter++)
            {
                if (counter == max_number + 1)
                    break; 
                PictureBox ColorBox = new PictureBox();
                //PictureBox addColorBtn = new PictureBox(); 


                ColorBox.Width = color_square_width;
                ColorBox.Height = color_square_height;

                //addColorBtn.Width = color_square_width;
                //addColorBtn.Height = color_square_height; 

                if (counter == colorCode.Length || counter == max_number )
                {
                    //ColorBox.Image = Image.FromFile(@"C:\Users\Mohamed Mellouky\Desktop\addColorBtn.png");
                    ColorBox.Image = Image.FromFile(@"..\..\..\..\icon\addColorBtn.png");
                }
                else
                {
                    Color _Color = ColorTranslator.FromHtml(colorCode[counter - 1]);
                    ColorBox.BackColor = _Color;
                }

                //addColorBtn.Image = Image.FromFile("addColorBtn.png");


                if (width >= mainPanel.Right - 51)
                {
                    width = 51;
                    v_margin ++;
                    height += v_margin; 
                }
                ColorBox.Location = new Point(width, height);
                //addColorBtn.Location = new Point(width + h_margin, height);

                mainPanel.Controls.Add(ColorBox);
                //mainPanel.Controls.Add(addColorBtn); 
                

                width += color_square_height + h_margin;
            }

            mainPanel.Show();
            
            
        }
    }
}
