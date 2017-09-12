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
            this.tp_encrypt = new System.Windows.Forms.TabPage();
            this.btn_encMsg = new System.Windows.Forms.Button();
            this.btn_encImg = new System.Windows.Forms.Button();
            this.txt_encMsg = new System.Windows.Forms.TextBox();
            this.txt_encImg = new System.Windows.Forms.TextBox();
            this.lbl_encMsg = new System.Windows.Forms.Label();
            this.lbl_encImg = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.fbd_defaultFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_decPass = new System.Windows.Forms.Button();
            this.btn_decImg = new System.Windows.Forms.Button();
            this.txt_decPass = new System.Windows.Forms.TextBox();
            this.txt_decImg = new System.Windows.Forms.TextBox();
            this.lbl_decPass = new System.Windows.Forms.Label();
            this.lbl_decImg = new System.Windows.Forms.Label();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_settings)).BeginInit();
            this.sc_settings.Panel1.SuspendLayout();
            this.sc_settings.Panel2.SuspendLayout();
            this.sc_settings.SuspendLayout();
            this.tc_settings.SuspendLayout();
            this.tp_encrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.sc_settings);
            this.pnl_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_settings.Location = new System.Drawing.Point(0, 0);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(647, 410);
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
            this.sc_settings.Size = new System.Drawing.Size(647, 410);
            this.sc_settings.SplitterDistance = 334;
            this.sc_settings.TabIndex = 1;
            // 
            // tc_settings
            // 
            this.tc_settings.Controls.Add(this.tp_encrypt);
            this.tc_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tc_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_settings.Location = new System.Drawing.Point(0, 0);
            this.tc_settings.Name = "tc_settings";
            this.tc_settings.SelectedIndex = 0;
            this.tc_settings.Size = new System.Drawing.Size(647, 334);
            this.tc_settings.TabIndex = 0;
            // 
            // tp_encrypt
            // 
            this.tp_encrypt.Controls.Add(this.btn_decPass);
            this.tp_encrypt.Controls.Add(this.btn_decImg);
            this.tp_encrypt.Controls.Add(this.txt_decPass);
            this.tp_encrypt.Controls.Add(this.txt_decImg);
            this.tp_encrypt.Controls.Add(this.lbl_decPass);
            this.tp_encrypt.Controls.Add(this.lbl_decImg);
            this.tp_encrypt.Controls.Add(this.btn_encMsg);
            this.tp_encrypt.Controls.Add(this.btn_encImg);
            this.tp_encrypt.Controls.Add(this.txt_encMsg);
            this.tp_encrypt.Controls.Add(this.txt_encImg);
            this.tp_encrypt.Controls.Add(this.lbl_encMsg);
            this.tp_encrypt.Controls.Add(this.lbl_encImg);
            this.tp_encrypt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tp_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_encrypt.Location = new System.Drawing.Point(4, 29);
            this.tp_encrypt.Name = "tp_encrypt";
            this.tp_encrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tp_encrypt.Size = new System.Drawing.Size(639, 301);
            this.tp_encrypt.TabIndex = 0;
            this.tp_encrypt.Text = "Default File Locations";
            this.tp_encrypt.UseVisualStyleBackColor = true;
            // 
            // btn_encMsg
            // 
            this.btn_encMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encMsg.Location = new System.Drawing.Point(529, 106);
            this.btn_encMsg.Name = "btn_encMsg";
            this.btn_encMsg.Size = new System.Drawing.Size(89, 39);
            this.btn_encMsg.TabIndex = 27;
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
            this.btn_encImg.TabIndex = 26;
            this.btn_encImg.Text = "Change";
            this.btn_encImg.UseVisualStyleBackColor = true;
            this.btn_encImg.Click += new System.EventHandler(this.btn_encImg_Click);
            // 
            // txt_encMsg
            // 
            this.txt_encMsg.BackColor = System.Drawing.Color.White;
            this.txt_encMsg.Enabled = false;
            this.txt_encMsg.Location = new System.Drawing.Point(20, 112);
            this.txt_encMsg.Name = "txt_encMsg";
            this.txt_encMsg.Size = new System.Drawing.Size(493, 26);
            this.txt_encMsg.TabIndex = 24;
            // 
            // txt_encImg
            // 
            this.txt_encImg.BackColor = System.Drawing.Color.White;
            this.txt_encImg.Enabled = false;
            this.txt_encImg.Location = new System.Drawing.Point(20, 41);
            this.txt_encImg.Name = "txt_encImg";
            this.txt_encImg.Size = new System.Drawing.Size(493, 26);
            this.txt_encImg.TabIndex = 23;
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
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(245, -2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(147, 52);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // fbd_defaultFolder
            // 
            this.fbd_defaultFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btn_decPass
            // 
            this.btn_decPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decPass.Location = new System.Drawing.Point(528, 250);
            this.btn_decPass.Name = "btn_decPass";
            this.btn_decPass.Size = new System.Drawing.Size(89, 39);
            this.btn_decPass.TabIndex = 33;
            this.btn_decPass.Text = "Change";
            this.btn_decPass.UseVisualStyleBackColor = true;
            this.btn_decPass.Click += new System.EventHandler(this.btn_decPass_Click);
            // 
            // btn_decImg
            // 
            this.btn_decImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decImg.Location = new System.Drawing.Point(528, 178);
            this.btn_decImg.Name = "btn_decImg";
            this.btn_decImg.Size = new System.Drawing.Size(89, 39);
            this.btn_decImg.TabIndex = 32;
            this.btn_decImg.Text = "Change";
            this.btn_decImg.UseVisualStyleBackColor = true;
            this.btn_decImg.Click += new System.EventHandler(this.btn_decImg_Click);
            // 
            // txt_decPass
            // 
            this.txt_decPass.BackColor = System.Drawing.Color.White;
            this.txt_decPass.Enabled = false;
            this.txt_decPass.Location = new System.Drawing.Point(19, 256);
            this.txt_decPass.Name = "txt_decPass";
            this.txt_decPass.Size = new System.Drawing.Size(493, 26);
            this.txt_decPass.TabIndex = 31;
            // 
            // txt_decImg
            // 
            this.txt_decImg.BackColor = System.Drawing.Color.White;
            this.txt_decImg.Enabled = false;
            this.txt_decImg.Location = new System.Drawing.Point(19, 184);
            this.txt_decImg.Name = "txt_decImg";
            this.txt_decImg.Size = new System.Drawing.Size(493, 26);
            this.txt_decImg.TabIndex = 30;
            // 
            // lbl_decPass
            // 
            this.lbl_decPass.AutoSize = true;
            this.lbl_decPass.Location = new System.Drawing.Point(15, 233);
            this.lbl_decPass.Name = "lbl_decPass";
            this.lbl_decPass.Size = new System.Drawing.Size(275, 20);
            this.lbl_decPass.TabIndex = 29;
            this.lbl_decPass.Text = "Default Decrypt Password File Folder:";
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
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.pnl_settings);
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
            this.tp_encrypt.ResumeLayout(false);
            this.tp_encrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.SplitContainer sc_settings;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.FolderBrowserDialog fbd_defaultFolder;
        private System.Windows.Forms.TabControl tc_settings;
        private System.Windows.Forms.TabPage tp_encrypt;
        private System.Windows.Forms.Button btn_encMsg;
        private System.Windows.Forms.Button btn_encImg;
        private System.Windows.Forms.TextBox txt_encMsg;
        private System.Windows.Forms.TextBox txt_encImg;
        private System.Windows.Forms.Label lbl_encMsg;
        private System.Windows.Forms.Label lbl_encImg;
        private System.Windows.Forms.Button btn_decPass;
        private System.Windows.Forms.Button btn_decImg;
        private System.Windows.Forms.TextBox txt_decPass;
        private System.Windows.Forms.TextBox txt_decImg;
        private System.Windows.Forms.Label lbl_decPass;
        private System.Windows.Forms.Label lbl_decImg;
    }
}