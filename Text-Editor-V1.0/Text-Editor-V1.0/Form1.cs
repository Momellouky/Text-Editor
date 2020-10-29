using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // set default font to Arial

            Font defaultFont = new Font("Arial", 12, FontStyle.Regular);
            fontList.Text = defaultFont.Name;

            // richTextBox default setting.

            mainTxtBox.Font = defaultFont;
            mainTxtBox.ForeColor = Color.FromArgb(255, 0, 0, 0);
            mainTxtBox.BackColor = Color.White;
        }
    }
}
