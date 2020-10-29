namespace Text_Editor_V1._0
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topBar = new System.Windows.Forms.Panel();
            this.filenameLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Panel();
            this.versionLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.separatorTwo = new System.Windows.Forms.Panel();
            this.isBackColor = new System.Windows.Forms.CheckBox();
            this.whiteColor = new System.Windows.Forms.Panel();
            this.blackColor = new System.Windows.Forms.Panel();
            this.colorswatchBtn = new System.Windows.Forms.Button();
            this.separatorOne = new System.Windows.Forms.Panel();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.regularCheckBox = new System.Windows.Forms.CheckBox();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.FontLabel = new System.Windows.Forms.Label();
            this.fontList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTxtBox = new System.Windows.Forms.RichTextBox();
            this.topBar.SuspendLayout();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.topBar.Controls.Add(this.filenameLbl);
            this.topBar.Controls.Add(this.closeBtn);
            this.topBar.Controls.Add(this.appName);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(900, 25);
            this.topBar.TabIndex = 0;
            // 
            // filenameLbl
            // 
            this.filenameLbl.AutoSize = true;
            this.filenameLbl.Location = new System.Drawing.Point(75, 6);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(0, 13);
            this.filenameLbl.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(151)))), ((int)(((byte)(16)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = global::Text_Editor_V1._0.Properties.Resources.favicon1;
            this.closeBtn.Location = new System.Drawing.Point(860, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 25);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Hacen Beirut Hd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(510, 1);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(105, 24);
            this.appName.TabIndex = 0;
            this.appName.Text = "Type-awsome";
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.dashboard.Controls.Add(this.versionLbl);
            this.dashboard.Controls.Add(this.exitBtn);
            this.dashboard.Controls.Add(this.saveBtn);
            this.dashboard.Controls.Add(this.separatorTwo);
            this.dashboard.Controls.Add(this.isBackColor);
            this.dashboard.Controls.Add(this.whiteColor);
            this.dashboard.Controls.Add(this.blackColor);
            this.dashboard.Controls.Add(this.colorswatchBtn);
            this.dashboard.Controls.Add(this.separatorOne);
            this.dashboard.Controls.Add(this.italicCheckBox);
            this.dashboard.Controls.Add(this.underlineCheckBox);
            this.dashboard.Controls.Add(this.boldCheckBox);
            this.dashboard.Controls.Add(this.regularCheckBox);
            this.dashboard.Controls.Add(this.fontSize);
            this.dashboard.Controls.Add(this.sizeLabel);
            this.dashboard.Controls.Add(this.FontLabel);
            this.dashboard.Controls.Add(this.fontList);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboard.Location = new System.Drawing.Point(0, 25);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(200, 475);
            this.dashboard.TabIndex = 1;
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(81, 437);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(29, 13);
            this.versionLbl.TabIndex = 14;
            this.versionLbl.Text = "V1.0";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(24, 393);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(151, 23);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(24, 354);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(151, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // separatorTwo
            // 
            this.separatorTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.separatorTwo.Location = new System.Drawing.Point(25, 330);
            this.separatorTwo.Name = "separatorTwo";
            this.separatorTwo.Size = new System.Drawing.Size(150, 2);
            this.separatorTwo.TabIndex = 9;
            // 
            // isBackColor
            // 
            this.isBackColor.AutoSize = true;
            this.isBackColor.Location = new System.Drawing.Point(163, 245);
            this.isBackColor.Name = "isBackColor";
            this.isBackColor.Size = new System.Drawing.Size(15, 14);
            this.isBackColor.TabIndex = 11;
            this.isBackColor.UseVisualStyleBackColor = true;
            // 
            // whiteColor
            // 
            this.whiteColor.BackColor = System.Drawing.Color.White;
            this.whiteColor.Location = new System.Drawing.Point(108, 269);
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(30, 30);
            this.whiteColor.TabIndex = 10;
            this.whiteColor.Click += new System.EventHandler(this.blackColor_Click);
            // 
            // blackColor
            // 
            this.blackColor.BackColor = System.Drawing.Color.Black;
            this.blackColor.Location = new System.Drawing.Point(63, 269);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(30, 30);
            this.blackColor.TabIndex = 9;
            this.blackColor.Click += new System.EventHandler(this.blackColor_Click);
            // 
            // colorswatchBtn
            // 
            this.colorswatchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.colorswatchBtn.FlatAppearance.BorderSize = 0;
            this.colorswatchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorswatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorswatchBtn.ForeColor = System.Drawing.Color.White;
            this.colorswatchBtn.Location = new System.Drawing.Point(25, 240);
            this.colorswatchBtn.Name = "colorswatchBtn";
            this.colorswatchBtn.Size = new System.Drawing.Size(132, 23);
            this.colorswatchBtn.TabIndex = 0;
            this.colorswatchBtn.Text = "Color swatch";
            this.colorswatchBtn.UseVisualStyleBackColor = false;
            this.colorswatchBtn.Click += new System.EventHandler(this.colorswatchBtn_Click);
            // 
            // separatorOne
            // 
            this.separatorOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.separatorOne.Location = new System.Drawing.Point(25, 214);
            this.separatorOne.Name = "separatorOne";
            this.separatorOne.Size = new System.Drawing.Size(150, 2);
            this.separatorOne.TabIndex = 8;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(109, 168);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 7;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.fontList_SelectedValueChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(18, 168);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 6;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.fontList_SelectedValueChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(109, 133);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.boldCheckBox.TabIndex = 5;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.fontList_SelectedValueChanged);
            // 
            // regularCheckBox
            // 
            this.regularCheckBox.AutoSize = true;
            this.regularCheckBox.Checked = true;
            this.regularCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.regularCheckBox.Location = new System.Drawing.Point(18, 133);
            this.regularCheckBox.Name = "regularCheckBox";
            this.regularCheckBox.Size = new System.Drawing.Size(63, 17);
            this.regularCheckBox.TabIndex = 4;
            this.regularCheckBox.Text = "Regular";
            this.regularCheckBox.UseVisualStyleBackColor = true;
            this.regularCheckBox.CheckedChanged += new System.EventHandler(this.fontList_SelectedValueChanged);
            // 
            // fontSize
            // 
            this.fontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.fontSize.ForeColor = System.Drawing.Color.White;
            this.fontSize.Location = new System.Drawing.Point(0, 93);
            this.fontSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(200, 20);
            this.fontSize.TabIndex = 3;
            this.fontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontList_SelectedValueChanged);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Hacen Beirut Hd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.sizeLabel.Location = new System.Drawing.Point(1, 66);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(42, 24);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size";
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FontLabel.Font = new System.Drawing.Font("Hacen Beirut Hd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.FontLabel.Location = new System.Drawing.Point(0, 0);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(46, 24);
            this.FontLabel.TabIndex = 1;
            this.FontLabel.Text = "Font";
            // 
            // fontList
            // 
            this.fontList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.fontList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontList.ForeColor = System.Drawing.Color.White;
            this.fontList.FormattingEnabled = true;
            this.fontList.Location = new System.Drawing.Point(0, 27);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(200, 21);
            this.fontList.TabIndex = 0;
            this.fontList.Text = "Arial";
            this.fontList.SelectedValueChanged += new System.EventHandler(this.fontList_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(18)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 25);
            this.panel1.TabIndex = 2;
            // 
            // mainTxtBox
            // 
            this.mainTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTxtBox.Location = new System.Drawing.Point(200, 25);
            this.mainTxtBox.Name = "mainTxtBox";
            this.mainTxtBox.Size = new System.Drawing.Size(700, 450);
            this.mainTxtBox.TabIndex = 0;
            this.mainTxtBox.Text = "";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.mainTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type-awsome";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox mainTxtBox;
        private System.Windows.Forms.ComboBox fontList;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Panel separatorOne;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox regularCheckBox;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button colorswatchBtn;
        private System.Windows.Forms.CheckBox isBackColor;
        private System.Windows.Forms.Panel whiteColor;
        private System.Windows.Forms.Panel blackColor;
        private System.Windows.Forms.Panel separatorTwo;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label filenameLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}

