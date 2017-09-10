namespace Imgrypt
{
    partial class frm_loadInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loadInfo));
            this.pnl_loadInfo = new System.Windows.Forms.Panel();
            this.btn_brsDest = new System.Windows.Forms.Button();
            this.btn_brsText = new System.Windows.Forms.Button();
            this.btn_brsImg = new System.Windows.Forms.Button();
            this.txt_destLoc = new System.Windows.Forms.TextBox();
            this.txt_textLoc = new System.Windows.Forms.TextBox();
            this.txt_imgLoc = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.lbl_destLoc = new System.Windows.Forms.Label();
            this.lbl_textLoc = new System.Windows.Forms.Label();
            this.lbl_imgLoc = new System.Windows.Forms.Label();
            this.fbd_loadInfo = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_loadInfo = new System.Windows.Forms.OpenFileDialog();
            this.ep_img = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_text = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_dest = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_loadInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_dest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_loadInfo
            // 
            this.pnl_loadInfo.Controls.Add(this.btn_brsDest);
            this.pnl_loadInfo.Controls.Add(this.btn_brsText);
            this.pnl_loadInfo.Controls.Add(this.btn_brsImg);
            this.pnl_loadInfo.Controls.Add(this.txt_destLoc);
            this.pnl_loadInfo.Controls.Add(this.txt_textLoc);
            this.pnl_loadInfo.Controls.Add(this.txt_imgLoc);
            this.pnl_loadInfo.Controls.Add(this.btn_back);
            this.pnl_loadInfo.Controls.Add(this.btn_go);
            this.pnl_loadInfo.Controls.Add(this.lbl_destLoc);
            this.pnl_loadInfo.Controls.Add(this.lbl_textLoc);
            this.pnl_loadInfo.Controls.Add(this.lbl_imgLoc);
            this.pnl_loadInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_loadInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_loadInfo.Name = "pnl_loadInfo";
            this.pnl_loadInfo.Size = new System.Drawing.Size(679, 299);
            this.pnl_loadInfo.TabIndex = 0;
            // 
            // btn_brsDest
            // 
            this.btn_brsDest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brsDest.Location = new System.Drawing.Point(562, 188);
            this.btn_brsDest.Name = "btn_brsDest";
            this.btn_brsDest.Size = new System.Drawing.Size(89, 39);
            this.btn_brsDest.TabIndex = 10;
            this.btn_brsDest.Text = "Browse";
            this.btn_brsDest.UseVisualStyleBackColor = true;
            this.btn_brsDest.Click += new System.EventHandler(this.btn_brsDest_Click);
            // 
            // btn_brsText
            // 
            this.btn_brsText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brsText.Location = new System.Drawing.Point(562, 112);
            this.btn_brsText.Name = "btn_brsText";
            this.btn_brsText.Size = new System.Drawing.Size(89, 39);
            this.btn_brsText.TabIndex = 9;
            this.btn_brsText.Text = "Browse";
            this.btn_brsText.UseVisualStyleBackColor = true;
            this.btn_brsText.Click += new System.EventHandler(this.btn_brsMess_Click);
            // 
            // btn_brsImg
            // 
            this.btn_brsImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brsImg.Location = new System.Drawing.Point(562, 39);
            this.btn_brsImg.Name = "btn_brsImg";
            this.btn_brsImg.Size = new System.Drawing.Size(89, 39);
            this.btn_brsImg.TabIndex = 8;
            this.btn_brsImg.Text = "Browse";
            this.btn_brsImg.UseVisualStyleBackColor = true;
            this.btn_brsImg.Click += new System.EventHandler(this.btn_brsImg_Click);
            // 
            // txt_destLoc
            // 
            this.txt_destLoc.BackColor = System.Drawing.Color.White;
            this.txt_destLoc.Enabled = false;
            this.txt_destLoc.Location = new System.Drawing.Point(28, 193);
            this.txt_destLoc.Name = "txt_destLoc";
            this.txt_destLoc.Size = new System.Drawing.Size(493, 26);
            this.txt_destLoc.TabIndex = 7;
            this.txt_destLoc.TextChanged += new System.EventHandler(this.txt_destLoc_TextChanged);
            // 
            // txt_textLoc
            // 
            this.txt_textLoc.BackColor = System.Drawing.Color.White;
            this.txt_textLoc.Enabled = false;
            this.txt_textLoc.Location = new System.Drawing.Point(28, 118);
            this.txt_textLoc.Name = "txt_textLoc";
            this.txt_textLoc.Size = new System.Drawing.Size(493, 26);
            this.txt_textLoc.TabIndex = 6;
            this.txt_textLoc.TextChanged += new System.EventHandler(this.txt_messLoc_TextChanged);
            // 
            // txt_imgLoc
            // 
            this.txt_imgLoc.BackColor = System.Drawing.Color.White;
            this.txt_imgLoc.Enabled = false;
            this.txt_imgLoc.Location = new System.Drawing.Point(28, 45);
            this.txt_imgLoc.Name = "txt_imgLoc";
            this.txt_imgLoc.Size = new System.Drawing.Size(493, 26);
            this.txt_imgLoc.TabIndex = 5;
            this.txt_imgLoc.TextChanged += new System.EventHandler(this.txt_imgLoc_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(180, 244);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(147, 52);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_go
            // 
            this.btn_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go.Location = new System.Drawing.Point(342, 244);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(147, 52);
            this.btn_go.TabIndex = 3;
            this.btn_go.Text = "Encrypt";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // lbl_destLoc
            // 
            this.lbl_destLoc.AutoSize = true;
            this.lbl_destLoc.Location = new System.Drawing.Point(24, 170);
            this.lbl_destLoc.Name = "lbl_destLoc";
            this.lbl_destLoc.Size = new System.Drawing.Size(94, 20);
            this.lbl_destLoc.TabIndex = 2;
            this.lbl_destLoc.Text = "Destination:";
            // 
            // lbl_textLoc
            // 
            this.lbl_textLoc.AutoSize = true;
            this.lbl_textLoc.Location = new System.Drawing.Point(24, 95);
            this.lbl_textLoc.Name = "lbl_textLoc";
            this.lbl_textLoc.Size = new System.Drawing.Size(107, 20);
            this.lbl_textLoc.TabIndex = 1;
            this.lbl_textLoc.Text = "Message File:";
            // 
            // lbl_imgLoc
            // 
            this.lbl_imgLoc.AutoSize = true;
            this.lbl_imgLoc.Location = new System.Drawing.Point(24, 21);
            this.lbl_imgLoc.Name = "lbl_imgLoc";
            this.lbl_imgLoc.Size = new System.Drawing.Size(87, 20);
            this.lbl_imgLoc.TabIndex = 0;
            this.lbl_imgLoc.Text = "Image File:";
            // 
            // fbd_loadInfo
            // 
            this.fbd_loadInfo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ofd_loadInfo
            // 
            this.ofd_loadInfo.InitialDirectory = "C:\\";
            this.ofd_loadInfo.Title = "Browse For File";
            // 
            // ep_img
            // 
            this.ep_img.ContainerControl = this;
            // 
            // ep_text
            // 
            this.ep_text.ContainerControl = this;
            // 
            // ep_dest
            // 
            this.ep_dest.ContainerControl = this;
            // 
            // frm_loadInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 299);
            this.Controls.Add(this.pnl_loadInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 355);
            this.MinimumSize = new System.Drawing.Size(701, 355);
            this.Name = "frm_loadInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imgrypt - Encrypt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_encrypt_FormClosed);
            this.pnl_loadInfo.ResumeLayout(false);
            this.pnl_loadInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_dest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_loadInfo;
        private System.Windows.Forms.Button btn_brsDest;
        private System.Windows.Forms.Button btn_brsText;
        private System.Windows.Forms.Button btn_brsImg;
        private System.Windows.Forms.TextBox txt_destLoc;
        private System.Windows.Forms.TextBox txt_textLoc;
        private System.Windows.Forms.TextBox txt_imgLoc;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label lbl_destLoc;
        private System.Windows.Forms.Label lbl_textLoc;
        private System.Windows.Forms.Label lbl_imgLoc;
        private System.Windows.Forms.FolderBrowserDialog fbd_loadInfo;
        private System.Windows.Forms.OpenFileDialog ofd_loadInfo;
        private System.Windows.Forms.ErrorProvider ep_img;
        private System.Windows.Forms.ErrorProvider ep_text;
        private System.Windows.Forms.ErrorProvider ep_dest;
    }
}