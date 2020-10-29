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
            Application.Exit(); 
        }
    }
}
