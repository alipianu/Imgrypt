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
            this.btn_back = new System.Windows.Forms.Button();
            this.fbd_defaultFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tp_decrypt = new System.Windows.Forms.TabPage();
            this.lbl_decImg = new System.Windows.Forms.Label();
            this.lbl_decPass = new System.Windows.Forms.Label();
            this.lbl_decDest = new System.Windows.Forms.Label();
            this.txt_decImg = new System.Windows.Forms.TextBox();
            this.txt_decPass = new System.Windows.Forms.TextBox();
            this.txt_decDest = new System.Windows.Forms.TextBox();
            this.btn_decImg = new System.Windows.Forms.Button();
            this.btn_decPass = new System.Windows.Forms.Button();
            this.btn_decDest = new System.Windows.Forms.Button();
            this.tp_encrypt = new System.Windows.Forms.TabPage();
            this.lbl_encImg = new System.Windows.Forms.Label();
            this.lbl_encMsg = new System.Windows.Forms.Label();
            this.lbl_encDest = new System.Windows.Forms.Label();
            this.txt_encImg = new System.Windows.Forms.TextBox();
            this.txt_encMsg = new System.Windows.Forms.TextBox();
            this.txt_encDest = new System.Windows.Forms.TextBox();
            this.btn_encImg = new System.Windows.Forms.Button();
            this.btn_encMsg = new System.Windows.Forms.Button();
            this.btn_encDest = new System.Windows.Forms.Button();
            this.tc_settings = new System.Windows.Forms.TabControl();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_settings)).BeginInit();
            this.sc_settings.Panel1.SuspendLayout();
            this.sc_settings.Panel2.SuspendLayout();
            this.sc_settings.SuspendLayout();
            this.tp_decrypt.SuspendLayout();
            this.tp_encrypt.SuspendLayout();
            this.tc_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.sc_settings);
            this.pnl_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_settings.Location = new System.Drawing.Point(0, 0);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(647, 322);
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
            this.sc_settings.Size = new System.Drawing.Size(647, 322);
            this.sc_settings.SplitterDistance = 263;
            this.sc_settings.TabIndex = 1;
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
            // tp_decrypt
            // 
            this.tp_decrypt.BackColor = System.Drawing.Color.White;
            this.tp_decrypt.Controls.Add(this.btn_decDest);
            this.tp_decrypt.Controls.Add(this.btn_decPass);
            this.tp_decrypt.Controls.Add(this.btn_decImg);
            this.tp_decrypt.Controls.Add(this.txt_decDest);
            this.tp_decrypt.Controls.Add(this.txt_decPass);
            this.tp_decrypt.Controls.Add(this.txt_decImg);
            this.tp_decrypt.Controls.Add(this.lbl_decDest);
            this.tp_decrypt.Controls.Add(this.lbl_decPass);
            this.tp_decrypt.Controls.Add(this.lbl_decImg);
            this.tp_decrypt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tp_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_decrypt.Location = new System.Drawing.Point(4, 29);
            this.tp_decrypt.Name = "tp_decrypt";
            this.tp_decrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tp_decrypt.Size = new System.Drawing.Size(639, 230);
            this.tp_decrypt.TabIndex = 1;
            this.tp_decrypt.Text = "Decrypt";
            // 
            // lbl_decImg
            // 
            this.lbl_decImg.AutoSize = true;
            this.lbl_decImg.Location = new System.Drawing.Point(16, 17);
            this.lbl_decImg.Name = "lbl_decImg";
            this.lbl_decImg.Size = new System.Drawing.Size(192, 20);
            this.lbl_decImg.TabIndex = 11;
            this.lbl_decImg.Text = "Default Image File Folder:";
            // 
            // lbl_decPass
            // 
            this.lbl_decPass.AutoSize = true;
            this.lbl_decPass.Location = new System.Drawing.Point(16, 91);
            this.lbl_decPass.Name = "lbl_decPass";
            this.lbl_decPass.Size = new System.Drawing.Size(216, 20);
            this.lbl_decPass.TabIndex = 12;
            this.lbl_decPass.Text = "Default Password File Folder:";
            // 
            // lbl_decDest
            // 
            this.lbl_decDest.AutoSize = true;
            this.lbl_decDest.Location = new System.Drawing.Point(16, 166);
            this.lbl_decDest.Name = "lbl_decDest";
            this.lbl_decDest.Size = new System.Drawing.Size(150, 20);
            this.lbl_decDest.TabIndex = 13;
            this.lbl_decDest.Text = "Default Destination:";
            // 
            // txt_decImg
            // 
            this.txt_decImg.BackColor = System.Drawing.Color.White;
            this.txt_decImg.Enabled = false;
            this.txt_decImg.Location = new System.Drawing.Point(20, 41);
            this.txt_decImg.Name = "txt_decImg";
            this.txt_decImg.Size = new System.Drawing.Size(493, 26);
            this.txt_decImg.TabIndex = 14;
            // 
            // txt_decPass
            // 
            this.txt_decPass.BackColor = System.Drawing.Color.White;
            this.txt_decPass.Enabled = false;
            this.txt_decPass.Location = new System.Drawing.Point(20, 114);
            this.txt_decPass.Name = "txt_decPass";
            this.txt_decPass.Size = new System.Drawing.Size(493, 26);
            this.txt_decPass.TabIndex = 15;
            // 
            // txt_decDest
            // 
            this.txt_decDest.BackColor = System.Drawing.Color.White;
            this.txt_decDest.Enabled = false;
            this.txt_decDest.Location = new System.Drawing.Point(20, 189);
            this.txt_decDest.Name = "txt_decDest";
            this.txt_decDest.Size = new System.Drawing.Size(493, 26);
            this.txt_decDest.TabIndex = 16;
            // 
            // btn_decImg
            // 
            this.btn_decImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decImg.Location = new System.Drawing.Point(529, 35);
            this.btn_decImg.Name = "btn_decImg";
            this.btn_decImg.Size = new System.Drawing.Size(89, 39);
            this.btn_decImg.TabIndex = 17;
            this.btn_decImg.Text = "Change";
            this.btn_decImg.UseVisualStyleBackColor = true;
            this.btn_decImg.Click += new System.EventHandler(this.btn_decImg_Click);
            // 
            // btn_decPass
            // 
            this.btn_decPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decPass.Location = new System.Drawing.Point(529, 108);
            this.btn_decPass.Name = "btn_decPass";
            this.btn_decPass.Size = new System.Drawing.Size(89, 39);
            this.btn_decPass.TabIndex = 18;
            this.btn_decPass.Text = "Change";
            this.btn_decPass.UseVisualStyleBackColor = true;
            this.btn_decPass.Click += new System.EventHandler(this.btn_decPass_Click);
            // 
            // btn_decDest
            // 
            this.btn_decDest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decDest.Location = new System.Drawing.Point(529, 183);
            this.btn_decDest.Name = "btn_decDest";
            this.btn_decDest.Size = new System.Drawing.Size(89, 39);
            this.btn_decDest.TabIndex = 19;
            this.btn_decDest.Text = "Change";
            this.btn_decDest.UseVisualStyleBackColor = true;
            this.btn_decDest.Click += new System.EventHandler(this.btn_decDest_Click);
            // 
            // tp_encrypt
            // 
            this.tp_encrypt.Controls.Add(this.btn_encDest);
            this.tp_encrypt.Controls.Add(this.btn_encMsg);
            this.tp_encrypt.Controls.Add(this.btn_encImg);
            this.tp_encrypt.Controls.Add(this.txt_encDest);
            this.tp_encrypt.Controls.Add(this.txt_encMsg);
            this.tp_encrypt.Controls.Add(this.txt_encImg);
            this.tp_encrypt.Controls.Add(this.lbl_encDest);
            this.tp_encrypt.Controls.Add(this.lbl_encMsg);
            this.tp_encrypt.Controls.Add(this.lbl_encImg);
            this.tp_encrypt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tp_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_encrypt.Location = new System.Drawing.Point(4, 29);
            this.tp_encrypt.Name = "tp_encrypt";
            this.tp_encrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tp_encrypt.Size = new System.Drawing.Size(639, 230);
            this.tp_encrypt.TabIndex = 0;
            this.tp_encrypt.Text = "Encrypt";
            this.tp_encrypt.UseVisualStyleBackColor = true;
            // 
            // lbl_encImg
            // 
            this.lbl_encImg.AutoSize = true;
            this.lbl_encImg.Location = new System.Drawing.Point(16, 17);
            this.lbl_encImg.Name = "lbl_encImg";
            this.lbl_encImg.Size = new System.Drawing.Size(192, 20);
            this.lbl_encImg.TabIndex = 20;
            this.lbl_encImg.Text = "Default Image File Folder:";
            // 
            // lbl_encMsg
            // 
            this.lbl_encMsg.AutoSize = true;
            this.lbl_encMsg.Location = new System.Drawing.Point(16, 91);
            this.lbl_encMsg.Name = "lbl_encMsg";
            this.lbl_encMsg.Size = new System.Drawing.Size(212, 20);
            this.lbl_encMsg.TabIndex = 21;
            this.lbl_encMsg.Text = "Default Message File Folder:";
            // 
            // lbl_encDest
            // 
            this.lbl_encDest.AutoSize = true;
            this.lbl_encDest.Location = new System.Drawing.Point(16, 166);
            this.lbl_encDest.Name = "lbl_encDest";
            this.lbl_encDest.Size = new System.Drawing.Size(150, 20);
            this.lbl_encDest.TabIndex = 22;
            this.lbl_encDest.Text = "Default Destination:";
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
            // txt_encMsg
            // 
            this.txt_encMsg.BackColor = System.Drawing.Color.White;
            this.txt_encMsg.Enabled = false;
            this.txt_encMsg.Location = new System.Drawing.Point(20, 114);
            this.txt_encMsg.Name = "txt_encMsg";
            this.txt_encMsg.Size = new System.Drawing.Size(493, 26);
            this.txt_encMsg.TabIndex = 24;
            // 
            // txt_encDest
            // 
            this.txt_encDest.BackColor = System.Drawing.Color.White;
            this.txt_encDest.Enabled = false;
            this.txt_encDest.Location = new System.Drawing.Point(20, 189);
            this.txt_encDest.Name = "txt_encDest";
            this.txt_encDest.Size = new System.Drawing.Size(493, 26);
            this.txt_encDest.TabIndex = 25;
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
            // btn_encMsg
            // 
            this.btn_encMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encMsg.Location = new System.Drawing.Point(529, 108);
            this.btn_encMsg.Name = "btn_encMsg";
            this.btn_encMsg.Size = new System.Drawing.Size(89, 39);
            this.btn_encMsg.TabIndex = 27;
            this.btn_encMsg.Text = "Change";
            this.btn_encMsg.UseVisualStyleBackColor = true;
            this.btn_encMsg.Click += new System.EventHandler(this.btn_encMsg_Click);
            // 
            // btn_encDest
            // 
            this.btn_encDest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encDest.Location = new System.Drawing.Point(529, 183);
            this.btn_encDest.Name = "btn_encDest";
            this.btn_encDest.Size = new System.Drawing.Size(89, 39);
            this.btn_encDest.TabIndex = 28;
            this.btn_encDest.Text = "Change";
            this.btn_encDest.UseVisualStyleBackColor = true;
            this.btn_encDest.Click += new System.EventHandler(this.btn_encDest_Click);
            // 
            // tc_settings
            // 
            this.tc_settings.Controls.Add(this.tp_encrypt);
            this.tc_settings.Controls.Add(this.tp_decrypt);
            this.tc_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tc_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_settings.Location = new System.Drawing.Point(0, 0);
            this.tc_settings.Name = "tc_settings";
            this.tc_settings.SelectedIndex = 0;
            this.tc_settings.Size = new System.Drawing.Size(647, 263);
            this.tc_settings.TabIndex = 0;
            this.tc_settings.SelectedIndexChanged += new System.EventHandler(this.tc_settings_SelectedIndexChanged);
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 322);
            this.Controls.Add(this.pnl_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 378);
            this.MinimumSize = new System.Drawing.Size(669, 378);
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imgrypt - Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_settings_FormClosed);
            this.pnl_settings.ResumeLayout(false);
            this.sc_settings.Panel1.ResumeLayout(false);
            this.sc_settings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_settings)).EndInit();
            this.sc_settings.ResumeLayout(false);
            this.tp_decrypt.ResumeLayout(false);
            this.tp_decrypt.PerformLayout();
            this.tp_encrypt.ResumeLayout(false);
            this.tp_encrypt.PerformLayout();
            this.tc_settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.SplitContainer sc_settings;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.FolderBrowserDialog fbd_defaultFolder;
        private System.Windows.Forms.TabControl tc_settings;
        private System.Windows.Forms.TabPage tp_encrypt;
        private System.Windows.Forms.Button btn_encDest;
        private System.Windows.Forms.Button btn_encMsg;
        private System.Windows.Forms.Button btn_encImg;
        private System.Windows.Forms.TextBox txt_encDest;
        private System.Windows.Forms.TextBox txt_encMsg;
        private System.Windows.Forms.TextBox txt_encImg;
        private System.Windows.Forms.Label lbl_encDest;
        private System.Windows.Forms.Label lbl_encMsg;
        private System.Windows.Forms.Label lbl_encImg;
        private System.Windows.Forms.TabPage tp_decrypt;
        private System.Windows.Forms.Button btn_decDest;
        private System.Windows.Forms.Button btn_decPass;
        private System.Windows.Forms.Button btn_decImg;
        private System.Windows.Forms.TextBox txt_decDest;
        private System.Windows.Forms.TextBox txt_decPass;
        private System.Windows.Forms.TextBox txt_decImg;
        private System.Windows.Forms.Label lbl_decDest;
        private System.Windows.Forms.Label lbl_decPass;
        private System.Windows.Forms.Label lbl_decImg;
    }
}