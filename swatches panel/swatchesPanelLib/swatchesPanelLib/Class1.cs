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
            // refix logic. 
            //List<int> bgColorCode = new List<int>();
            
            int tempWidth = 51;
            for (int counter = 0; counter < colorCode.Length; counter++)
            {
                PictureBox ColorBox = new PictureBox();

                ColorBox.Width = color_square_width;
                ColorBox.Height = color_square_height;

                //ColorBox.BackColor = Color.FromArgb(colorCode[counter]);
                Color _Color = ColorTranslator.FromHtml(colorCode[counter]);
                ColorBox.BackColor = _Color;
                if (tempWidth >= mainPanel.Right - 51)
                {
                    int newtempWidth = 51; 
                    ColorBox.Location = new Point(newtempWidth, close_btn.Height + color_square_height + 37*2);
                    newtempWidth += color_square_height + 20; // this code needs to be rechecked ( may be logic issues ) 
                }
                else
                {
                    ColorBox.Location = new Point(tempWidth, close_btn.Height + 37);
                }
                

                mainPanel.Controls.Add(ColorBox);
                

                tempWidth += color_square_height + 20;
                if (counter == colorCode.Length) ColorBox.Dispose(); // # this code need to be checked.
            }

            mainPanel.Show();
            
            
        }
    }
}
