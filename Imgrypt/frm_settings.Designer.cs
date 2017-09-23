namespace Imgrypt
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.sc_settings = new System.Windows.Forms.SplitContainer();
            this.tc_settings = new System.Windows.Forms.TabControl();
            this.tp_locations = new System.Windows.Forms.TabPage();
            this.btn_decImg = new System.Windows.Forms.Button();
            this.txt_decImg = new System.Windows.Forms.TextBox();
            this.txt_encMsg = new System.Windows.Forms.TextBox();
            this.txt_encImg = new System.Windows.Forms.TextBox();
            this.lbl_decImg = new System.Windows.Forms.Label();
            this.btn_encMsg = new System.Windows.Forms.Button();
            this.btn_encImg = new System.Windows.Forms.Button();
            this.lbl_encMsg = new System.Windows.Forms.Label();
            this.lbl_encImg = new System.Windows.Forms.Label();
            this.tp_encrOptions = new System.Windows.Forms.TabPage();
            this.btn_imgOutput = new System.Windows.Forms.Button();
            this.txt_imgOutput = new System.Windows.Forms.TextBox();
            this.lbl_imgOutput = new System.Windows.Forms.Label();
            this.gb_imgOutput = new System.Windows.Forms.GroupBox();
            this.rbtn_img1 = new System.Windows.Forms.RadioButton();
            this.rbtn_img3 = new System.Windows.Forms.RadioButton();
            this.rbtn_img2 = new System.Windows.Forms.RadioButton();
            this.tp_decrOptions = new System.Windows.Forms.TabPage();
            this.btn_msgOutput = new System.Windows.Forms.Button();
            this.txt_msgOutput = new System.Windows.Forms.TextBox();
            this.lbl_msgOutput = new System.Windows.Forms.Label();
            this.gb_msgOutput = new System.Windows.Forms.GroupBox();
            this.rbtn_msg2 = new System.Windows.Forms.RadioButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.fbd_defaultFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.rbtn_msg1 = new System.Windows.Forms.RadioButton();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_settings)).BeginInit();
            this.sc_settings.Panel1.SuspendLayout();
            this.sc_settings.Panel2.SuspendLayout();
            this.sc_settings.SuspendLayout();
            this.tc_settings.SuspendLayout();
            this.tp_locations.SuspendLayout();
            this.tp_encrOptions.SuspendLayout();
            this.gb_imgOutput.SuspendLayout();
            this.tp_decrOptions.SuspendLayout();
            this.gb_msgOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.sc_settings);
            this.pnl_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_settings.Location = new System.Drawing.Point(0, 0);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(647, 347);
            this.pnl_settings.TabIndex = 0;
            // 
            // sc_settings
            // 
            this.sc_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_settings.IsSplitterFixed = true;
            this.sc_settings.Location = new System.Drawing.Point(0, 0);
            this.sc_settings.Name = "sc_settings";
            this.sc_settings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_settings.Panel1
            // 
            this.sc_settings.Panel1.Controls.Add(this.tc_settings);
            // 
            // sc_settings.Panel2
            // 
            this.sc_settings.Panel2.Controls.Add(this.btn_back);
            this.sc_settings.Panel2MinSize = 40;
            this.sc_settings.Size = new System.Drawing.Size(647, 347);
            this.sc_settings.SplitterDistance = 296;
            this.sc_settings.TabIndex = 1;
            // 
            // tc_settings
            // 
            this.tc_settings.Controls.Add(this.tp_locations);
            this.tc_settings.Controls.Add(this.tp_encrOptions);
            this.tc_settings.Controls.Add(this.tp_decrOptions);
            this.tc_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tc_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_settings.Location = new System.Drawing.Point(0, 0);
            this.tc_settings.Name = "tc_settings";
            this.tc_settings.SelectedIndex = 0;
            this.tc_settings.Size = new System.Drawing.Size(647, 296);
            this.tc_settings.TabIndex = 0;
            this.tc_settings.SelectedIndexChanged += new System.EventHandler(this.tc_settings_SelectedIndexChanged);
            // 
            // tp_locations
            // 
            this.tp_locations.Controls.Add(this.btn_decImg);
            this.tp_locations.Controls.Add(this.txt_decImg);
            this.tp_locations.Controls.Add(this.txt_encMsg);
            this.tp_locations.Controls.Add(this.txt_encImg);
            this.tp_locations.Controls.Add(this.lbl_decImg);
            this.tp_locations.Controls.Add(this.btn_encMsg);
            this.tp_locations.Controls.Add(this.btn_encImg);
            this.tp_locations.Controls.Add(this.lbl_encMsg);
            this.tp_locations.Controls.Add(this.lbl_encImg);
            this.tp_locations.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tp_locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_locations.Location = new System.Drawing.Point(4, 29);
            this.tp_locations.Name = "tp_locations";
            this.tp_locations.Padding = new System.Windows.Forms.Padding(3);
            this.tp_locations.Size = new System.Drawing.Size(639, 263);
            this.tp_locations.TabIndex = 0;
            this.tp_locations.Text = "Default File Locations";
            this.tp_locations.UseVisualStyleBackColor = true;
            // 
            // btn_decImg
            // 
            this.btn_decImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decImg.Location = new System.Drawing.Point(528, 178);
            this.btn_decImg.Name = "btn_decImg";
            this.btn_decImg.Size = new System.Drawing.Size(89, 39);
            this.btn_decImg.TabIndex = 3;
            this.btn_decImg.Text = "Change";
            this.btn_decImg.UseVisualStyleBackColor = true;
            this.btn_decImg.Click += new System.EventHandler(this.btn_decImg_Click);
            // 
            // txt_decImg
            // 
            this.txt_decImg.BackColor = System.Drawing.Color.White;
            this.txt_decImg.Enabled = false;
            this.txt_decImg.Location = new System.Drawing.Point(19, 184);
            this.txt_decImg.Name = "txt_decImg";
            this.txt_decImg.Size = new System.Drawing.Size(493, 26);
            this.txt_decImg.TabIndex = 3;
            this.txt_decImg.TabStop = false;
            // 
            // txt_encMsg
            // 
            this.txt_encMsg.BackColor = System.Drawing.Color.White;
            this.txt_encMsg.Enabled = false;
            this.txt_encMsg.Location = new System.Drawing.Point(20, 112);
            this.txt_encMsg.Name = "txt_encMsg";
            this.txt_encMsg.Size = new System.Drawing.Size(493, 26);
            this.txt_encMsg.TabIndex = 2;
            this.txt_encMsg.TabStop = false;
            // 
            // txt_encImg
            // 
            this.txt_encImg.BackColor = System.Drawing.Color.White;
            this.txt_encImg.Enabled = false;
            this.txt_encImg.Location = new System.Drawing.Point(20, 41);
            this.txt_encImg.Name = "txt_encImg";
            this.txt_encImg.Size = new System.Drawing.Size(493, 26);
            this.txt_encImg.TabIndex = 1;
            this.txt_encImg.TabStop = false;
            // 
            // lbl_decImg
            // 
            this.lbl_decImg.AutoSize = true;
            this.lbl_decImg.Location = new System.Drawing.Point(15, 160);
            this.lbl_decImg.Name = "lbl_decImg";
            this.lbl_decImg.Size = new System.Drawing.Size(251, 20);
            this.lbl_decImg.TabIndex = 28;
            this.lbl_decImg.Text = "Default Decrypt Image File Folder:";
            // 
            // btn_encMsg
            // 
            this.btn_encMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encMsg.Location = new System.Drawing.Point(529, 106);
            this.btn_encMsg.Name = "btn_encMsg";
            this.btn_encMsg.Size = new System.Drawing.Size(89, 39);
            this.btn_encMsg.TabIndex = 2;
            this.btn_encMsg.Text = "Change";
            this.btn_encMsg.UseVisualStyleBackColor = true;
            this.btn_encMsg.Click += new System.EventHandler(this.btn_encMsg_Click);
            // 
            // btn_encImg
            // 
            this.btn_encImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encImg.Location = new System.Drawing.Point(529, 35);
            this.btn_encImg.Name = "btn_encImg";
            this.btn_encImg.Size = new System.Drawing.Size(89, 39);
            this.btn_encImg.TabIndex = 1;
            this.btn_encImg.Text = "Change";
            this.btn_encImg.UseVisualStyleBackColor = true;
            this.btn_encImg.Click += new System.EventHandler(this.btn_encImg_Click);
            // 
            // lbl_encMsg
            // 
            this.lbl_encMsg.AutoSize = true;
            this.lbl_encMsg.Location = new System.Drawing.Point(16, 89);
            this.lbl_encMsg.Name = "lbl_encMsg";
            this.lbl_encMsg.Size = new System.Drawing.Size(270, 20);
            this.lbl_encMsg.TabIndex = 21;
            this.lbl_encMsg.Text = "Default Encrypt Message File Folder:";
            // 
            // lbl_encImg
            // 
            this.lbl_encImg.AutoSize = true;
            this.lbl_encImg.Location = new System.Drawing.Point(16, 17);
            this.lbl_encImg.Name = "lbl_encImg";
            this.lbl_encImg.Size = new System.Drawing.Size(250, 20);
            this.lbl_encImg.TabIndex = 20;
            this.lbl_encImg.Text = "Default Encrypt Image File Folder:";
            // 
            // tp_encrOptions
            // 
            this.tp_encrOptions.Controls.Add(this.btn_imgOutput);
            this.tp_encrOptions.Controls.Add(this.txt_imgOutput);
            this.tp_encrOptions.Controls.Add(this.lbl_imgOutput);
            this.tp_encrOptions.Controls.Add(this.gb_imgOutput);
            this.tp_encrOptions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tp_encrOptions.Location = new System.Drawing.Point(4, 29);
            this.tp_encrOptions.Name = "tp_encrOptions";
            this.tp_encrOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tp_encrOptions.Size = new System.Drawing.Size(639, 263);
            this.tp_encrOptions.TabIndex = 1;
            this.tp_encrOptions.Text = "Encrypt Options";
            this.tp_encrOptions.UseVisualStyleBackColor = true;
            // 
            // btn_imgOutput
            // 
            this.btn_imgOutput.Location = new System.Drawing.Point(433, 99);
            this.btn_imgOutput.Name = "btn_imgOutput";
            this.btn_imgOutput.Size = new System.Drawing.Size(142, 36);
            this.btn_imgOutput.TabIndex = 4;
            this.btn_imgOutput.Text = "Reset to Default";
            this.btn_imgOutput.UseVisualStyleBackColor = true;
            this.btn_imgOutput.Click += new System.EventHandler(this.btn_imgOutput_Click);
            // 
            // txt_imgOutput
            // 
            this.txt_imgOutput.Location = new System.Drawing.Point(390, 65);
            this.txt_imgOutput.MaxLength = 24;
            this.txt_imgOutput.Name = "txt_imgOutput";
            this.txt_imgOutput.Size = new System.Drawing.Size(229, 26);
            this.txt_imgOutput.TabIndex = 3;
            this.txt_imgOutput.TextChanged += new System.EventHandler(this.txt_imgOutput_TextChanged);
            // 
            // lbl_imgOutput
            // 
            this.lbl_imgOutput.AutoSize = true;
            this.lbl_imgOutput.Location = new System.Drawing.Point(425, 37);
            this.lbl_imgOutput.Name = "lbl_imgOutput";
            this.lbl_imgOutput.Size = new System.Drawing.Size(153, 20);
            this.lbl_imgOutput.TabIndex = 2;
            this.lbl_imgOutput.Text = "Image Output Name";
            // 
            // gb_imgOutput
            // 
            this.gb_imgOutput.Controls.Add(this.rbtn_img1);
            this.gb_imgOutput.Controls.Add(this.rbtn_img3);
            this.gb_imgOutput.Controls.Add(this.rbtn_img2);
            this.gb_imgOutput.Location = new System.Drawing.Point(21, 17);
            this.gb_imgOutput.Name = "gb_imgOutput";
            this.gb_imgOutput.Size = new System.Drawing.Size(348, 130);
            this.gb_imgOutput.TabIndex = 1;
            this.gb_imgOutput.TabStop = false;
            this.gb_imgOutput.Text = "Image Output Format";
            // 
            // rbtn_img1
            // 
            this.rbtn_img1.AutoSize = true;
            this.rbtn_img1.Checked = true;
            this.rbtn_img1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_img1.Location = new System.Drawing.Point(14, 28);
            this.rbtn_img1.Name = "rbtn_img1";
            this.rbtn_img1.Size = new System.Drawing.Size(202, 24);
            this.rbtn_img1.TabIndex = 0;
            this.rbtn_img1.TabStop = true;
            this.rbtn_img1.Text = "Same as input (Default)";
            this.rbtn_img1.UseVisualStyleBackColor = true;
            // 
            // rbtn_img3
            // 
            this.rbtn_img3.AutoSize = true;
            this.rbtn_img3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_img3.Location = new System.Drawing.Point(14, 88);
            this.rbtn_img3.Name = "rbtn_img3";
            this.rbtn_img3.Size = new System.Drawing.Size(133, 24);
            this.rbtn_img3.TabIndex = 2;
            this.rbtn_img3.TabStop = true;
            this.rbtn_img3.Text = "Bitmap (.bmp)";
            this.rbtn_img3.UseVisualStyleBackColor = true;
            // 
            // rbtn_img2
            // 
            this.rbtn_img2.AutoSize = true;
            this.rbtn_img2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_img2.Location = new System.Drawing.Point(14, 58);
            this.rbtn_img2.Name = "rbtn_img2";
            this.rbtn_img2.Size = new System.Drawing.Size(268, 24);
            this.rbtn_img2.TabIndex = 1;
            this.rbtn_img2.TabStop = true;
            this.rbtn_img2.Text = "Portable Network Graphics (.png)";
            this.rbtn_img2.UseVisualStyleBackColor = true;
            // 
            // tp_decrOptions
            // 
            this.tp_decrOptions.Controls.Add(this.btn_msgOutput);
            this.tp_decrOptions.Controls.Add(this.txt_msgOutput);
            this.tp_decrOptions.Controls.Add(this.lbl_msgOutput);
            this.tp_decrOptions.Controls.Add(this.gb_msgOutput);
            this.tp_decrOptions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tp_decrOptions.Location = new System.Drawing.Point(4, 29);
            this.tp_decrOptions.Name = "tp_decrOptions";
            this.tp_decrOptions.Size = new System.Drawing.Size(639, 263);
            this.tp_decrOptions.TabIndex = 2;
            this.tp_decrOptions.Text = "Decrypt Options";
            this.tp_decrOptions.UseVisualStyleBackColor = true;
            // 
            // btn_msgOutput
            // 
            this.btn_msgOutput.Location = new System.Drawing.Point(433, 83);
            this.btn_msgOutput.Name = "btn_msgOutput";
            this.btn_msgOutput.Size = new System.Drawing.Size(142, 36);
            this.btn_msgOutput.TabIndex = 7;
            this.btn_msgOutput.Text = "Reset to Default";
            this.btn_msgOutput.UseVisualStyleBackColor = true;
            this.btn_msgOutput.Click += new System.EventHandler(this.btn_msgOutput_Click);
            // 
            // txt_msgOutput
            // 
            this.txt_msgOutput.Location = new System.Drawing.Point(390, 49);
            this.txt_msgOutput.MaxLength = 24;
            this.txt_msgOutput.Name = "txt_msgOutput";
            this.txt_msgOutput.Size = new System.Drawing.Size(229, 26);
            this.txt_msgOutput.TabIndex = 6;
            this.txt_msgOutput.TextChanged += new System.EventHandler(this.txt_msgOutput_TextChanged);
            // 
            // lbl_msgOutput
            // 
            this.lbl_msgOutput.AutoSize = true;
            this.lbl_msgOutput.Location = new System.Drawing.Point(416, 21);
            this.lbl_msgOutput.Name = "lbl_msgOutput";
            this.lbl_msgOutput.Size = new System.Drawing.Size(173, 20);
            this.lbl_msgOutput.TabIndex = 5;
            this.lbl_msgOutput.Text = "Message Output Name";
            // 
            // gb_msgOutput
            // 
            this.gb_msgOutput.Controls.Add(this.rbtn_msg1);
            this.gb_msgOutput.Controls.Add(this.rbtn_msg2);
            this.gb_msgOutput.Location = new System.Drawing.Point(21, 17);
            this.gb_msgOutput.Name = "gb_msgOutput";
            this.gb_msgOutput.Size = new System.Drawing.Size(348, 99);
            this.gb_msgOutput.TabIndex = 1;
            this.gb_msgOutput.TabStop = false;
            this.gb_msgOutput.Text = "Message Output Format";
            // 
            // rbtn_msg2
            // 
            this.rbtn_msg2.AutoSize = true;
            this.rbtn_msg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_msg2.Location = new System.Drawing.Point(14, 58);
            this.rbtn_msg2.Name = "rbtn_msg2";
            this.rbtn_msg2.Size = new System.Drawing.Size(221, 24);
            this.rbtn_msg2.TabIndex = 1;
            this.rbtn_msg2.TabStop = true;
            this.rbtn_msg2.Text = "Microsoft Word File (.docx)";
            this.rbtn_msg2.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(245, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(147, 52);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // fbd_defaultFolder
            // 
            this.fbd_defaultFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // rbtn_msg1
            // 
            this.rbtn_msg1.AutoSize = true;
            this.rbtn_msg1.Checked = true;
            this.rbtn_msg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_msg1.Location = new System.Drawing.Point(14, 28);
            this.rbtn_msg1.Name = "rbtn_msg1";
            this.rbtn_msg1.Size = new System.Drawing.Size(128, 24);
            this.rbtn_msg1.TabIndex = 0;
            this.rbtn_msg1.TabStop = true;
            this.rbtn_msg1.Text = "Text File (.txt)";
            this.rbtn_msg1.UseVisualStyleBackColor = true;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 347);
            this.Controls.Add(this.pnl_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imgrypt - Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_settings_FormClosed);
            this.pnl_settings.ResumeLayout(false);
            this.sc_settings.Panel1.ResumeLayout(false);
            this.sc_settings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_settings)).EndInit();
            this.sc_settings.ResumeLayout(false);
            this.tc_settings.ResumeLayout(false);
            this.tp_locations.ResumeLayout(false);
            this.tp_locations.PerformLayout();
            this.tp_encrOptions.ResumeLayout(false);
            this.tp_encrOptions.PerformLayout();
            this.gb_imgOutput.ResumeLayout(false);
            this.gb_imgOutput.PerformLayout();
            this.tp_decrOptions.ResumeLayout(false);
            this.tp_decrOptions.PerformLayout();
            this.gb_msgOutput.ResumeLayout(false);
            this.gb_msgOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.SplitContainer sc_settings;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.FolderBrowserDialog fbd_defaultFolder;
        private System.Windows.Forms.TabControl tc_settings;
        private System.Windows.Forms.TabPage tp_locations;
        private System.Windows.Forms.Button btn_decImg;
        private System.Windows.Forms.TextBox txt_decImg;
        private System.Windows.Forms.TextBox txt_encMsg;
        private System.Windows.Forms.TextBox txt_encImg;
        private System.Windows.Forms.Label lbl_decImg;
        private System.Windows.Forms.Button btn_encMsg;
        private System.Windows.Forms.Button btn_encImg;
        private System.Windows.Forms.Label lbl_encMsg;
        private System.Windows.Forms.Label lbl_encImg;
        private System.Windows.Forms.TabPage tp_encrOptions;
        private System.Windows.Forms.GroupBox gb_imgOutput;
        private System.Windows.Forms.RadioButton rbtn_img1;
        private System.Windows.Forms.RadioButton rbtn_img3;
        private System.Windows.Forms.RadioButton rbtn_img2;
        private System.Windows.Forms.TabPage tp_decrOptions;
        private System.Windows.Forms.GroupBox gb_msgOutput;
        private System.Windows.Forms.RadioButton rbtn_msg2;
        private System.Windows.Forms.Label lbl_imgOutput;
        private System.Windows.Forms.TextBox txt_imgOutput;
        private System.Windows.Forms.Button btn_imgOutput;
        private System.Windows.Forms.Button btn_msgOutput;
        private System.Windows.Forms.TextBox txt_msgOutput;
        private System.Windows.Forms.Label lbl_msgOutput;
        private System.Windows.Forms.RadioButton rbtn_msg1;
    }
}