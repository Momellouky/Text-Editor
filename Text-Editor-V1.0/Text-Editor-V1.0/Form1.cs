using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Text_Editor_V1._0
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

            // Load font into font listbox
            FontFamily[] fontToLoad = FontFamily.Families; 
            foreach(FontFamily font in fontToLoad)
            {
                fontList.Items.Add(font.Name); 
            }

            // richTextBox default setting.

            Font defaultFont = new Font("Arial", 12, FontStyle.Regular);
            mainTxtBox.Font = defaultFont;
            mainTxtBox.ForeColor = Color.FromArgb(255, 0, 0, 0);
            mainTxtBox.BackColor = Color.White;

        }

        private void setFont()
        {
            string fontName = "Arial";
            if ( fontList.SelectedIndex > -1 )
            {
                fontName = fontList.SelectedItem.ToString();
            }
            int fontSizeValue = (int)fontSize.Value;

            FontStyle fontStyle = FontStyle.Regular;
            if (regularCheckBox.Checked) fontStyle = FontStyle.Regular;
            if (boldCheckBox.Checked) fontStyle = FontStyle.Bold;
            if (underlineCheckBox.Checked) fontStyle = FontStyle.Underline;
            if (italicCheckBox.Checked) fontStyle = FontStyle.Italic;

            Font actualFont = new Font(fontName, fontSizeValue, fontStyle);
            mainTxtBox.SelectionFont = actualFont;
        }

        private void fontList_SelectedValueChanged(object sender, EventArgs e)
        {
            setFont(); 
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            NeedToClose = true; 
            Application.Exit(); 
        }

        private void setColor(Color color)
        {
            if (isBackColor.Checked)
            {
                mainTxtBox.SelectionBackColor = color; 
            }
            else
            {
                mainTxtBox.SelectionColor = color; 
            }    
        }
        private void blackColor_Click(object sender, EventArgs e)
        {
            setColor(((Panel)sender).BackColor); 
        }

        private void colorswatchBtn_Click(object sender, EventArgs e)
        {
            ColorDialog newColorDialog = new ColorDialog();
            DialogResult showColorSwatches = newColorDialog.ShowDialog(); 

            if(showColorSwatches == DialogResult.OK)
            {
                if (isBackColor.Checked) 
                    mainTxtBox.SelectionBackColor = newColorDialog.Color; 
                else
                {
                    mainTxtBox.SelectionColor = newColorDialog.Color; 
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\Untitled.txt";

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save File | Type-Awsome";
            saveFile.Filter = "Text Files |*.txt";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFile.FileName = "Untitled"; 
            DialogResult showSaveWindow = saveFile.ShowDialog(); 

            try
            {
                if (showSaveWindow == DialogResult.OK)
                {
                    string name = Path.GetFileName(saveFile.FileName);
                    string pathFile = saveFile.FileName;
                    string content = mainTxtBox.Text;
                    File.WriteAllText(pathFile, content); 
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error"); 
            }

        }

        bool NeedToClose = false; 
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!NeedToClose)
            { 
                e.Cancel = true;
                this.Hide();
                notifyIcon.ShowBalloonTip(1000, "Type-Awsome", "Type-awsome is still running safly. ",ToolTipIcon.Info);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); 
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show(); 
        }

        private void mainTxtBox_TextChanged(object sender, EventArgs e)
        {
            int counter = mainTxtBox.Text.Length;
            if ( mainTxtBox.Text.Contains("\n"))
            {
                charCounter.Text = (counter - 1).ToString(); 
            }
            else
            {
                charCounter.Text = counter.ToString();
            }


        }
    }
}
