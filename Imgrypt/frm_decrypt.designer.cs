namespace Imgrypt
{
    partial class frm_decrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_decrypt));
            this.pnl_decrypt = new System.Windows.Forms.Panel();
            this.btn_brsDest = new System.Windows.Forms.Button();
            this.btn_brsImg = new System.Windows.Forms.Button();
            this.txt_destLoc = new System.Windows.Forms.TextBox();
            this.txt_imgLoc = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.lbl_destLoc = new System.Windows.Forms.Label();
            this.lbl_imgLoc = new System.Windows.Forms.Label();
            this.err_img = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_dest = new System.Windows.Forms.ErrorProvider(this.components);
            this.fbd_loadLoc = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_loadLoc = new System.Windows.Forms.OpenFileDialog();
            this.pnl_decrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_dest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_decrypt
            // 
            this.pnl_decrypt.Controls.Add(this.btn_brsDest);
            this.pnl_decrypt.Controls.Add(this.btn_brsImg);
            this.pnl_decrypt.Controls.Add(this.txt_destLoc);
            this.pnl_decrypt.Controls.Add(this.txt_imgLoc);
            this.pnl_decrypt.Controls.Add(this.btn_back);
            this.pnl_decrypt.Controls.Add(this.btn_decrypt);
            this.pnl_decrypt.Controls.Add(this.lbl_destLoc);
            this.pnl_decrypt.Controls.Add(this.lbl_imgLoc);
            this.pnl_decrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_decrypt.Location = new System.Drawing.Point(0, 0);
            this.pnl_decrypt.Name = "pnl_decrypt";
            this.pnl_decrypt.Size = new System.Drawing.Size(678, 231);
            this.pnl_decrypt.TabIndex = 1;
            // 
            // btn_brsDest
            // 
            this.btn_brsDest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brsDest.Location = new System.Drawing.Point(562, 112);
            this.btn_brsDest.Name = "btn_brsDest";
            this.btn_brsDest.Size = new System.Drawing.Size(89, 39);
            this.btn_brsDest.TabIndex = 2;
            this.btn_brsDest.Text = "Browse";
            this.btn_brsDest.UseVisualStyleBackColor = true;
            this.btn_brsDest.Click += new System.EventHandler(this.btn_brsDest_Click);
            // 
            // btn_brsImg
            // 
            this.btn_brsImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brsImg.Location = new System.Drawing.Point(562, 39);
            this.btn_brsImg.Name = "btn_brsImg";
            this.btn_brsImg.Size = new System.Drawing.Size(89, 39);
            this.btn_brsImg.TabIndex = 1;
            this.btn_brsImg.Text = "Browse";
            this.btn_brsImg.UseVisualStyleBackColor = true;
            this.btn_brsImg.Click += new System.EventHandler(this.btn_brsImg_Click);
            // 
            // txt_destLoc
            // 
            this.txt_destLoc.BackColor = System.Drawing.Color.White;
            this.txt_destLoc.Enabled = false;
            this.txt_destLoc.Location = new System.Drawing.Point(28, 118);
            this.txt_destLoc.Name = "txt_destLoc";
            this.txt_destLoc.Size = new System.Drawing.Size(493, 26);
            this.txt_destLoc.TabIndex = 2;
            this.txt_destLoc.TextChanged += new System.EventHandler(this.txt_destLoc_TextChanged);
            // 
            // txt_imgLoc
            // 
            this.txt_imgLoc.BackColor = System.Drawing.Color.White;
            this.txt_imgLoc.Enabled = false;
            this.txt_imgLoc.Location = new System.Drawing.Point(28, 45);
            this.txt_imgLoc.Name = "txt_imgLoc";
            this.txt_imgLoc.Size = new System.Drawing.Size(493, 26);
            this.txt_imgLoc.TabIndex = 1;
            this.txt_imgLoc.TextChanged += new System.EventHandler(this.txt_imgLoc_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(180, 168);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(147, 52);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decrypt.Location = new System.Drawing.Point(342, 168);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(147, 52);
            this.btn_decrypt.TabIndex = 0;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // lbl_destLoc
            // 
            this.lbl_destLoc.AutoSize = true;
            this.lbl_destLoc.Location = new System.Drawing.Point(24, 95);
            this.lbl_destLoc.Name = "lbl_destLoc";
            this.lbl_destLoc.Size = new System.Drawing.Size(94, 20);
            this.lbl_destLoc.TabIndex = 1;
            this.lbl_destLoc.Text = "Destination:";
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
            // err_img
            // 
            this.err_img.ContainerControl = this;
            // 
            // err_dest
            // 
            this.err_dest.ContainerControl = this;
            // 
            // fbd_loadLoc
            // 
            this.fbd_loadLoc.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ofd_loadLoc
            // 
            this.ofd_loadLoc.InitialDirectory = "C:\\";
            this.ofd_loadLoc.Title = "Browse For File";
            // 
            // frm_decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 231);
            this.Controls.Add(this.pnl_decrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_decrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imgrypt - Decrypt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_decrypt_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.frm_decrypt_VisibleChanged);
            this.pnl_decrypt.ResumeLayout(false);
            this.pnl_decrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_dest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_decrypt;
        private System.Windows.Forms.Button btn_brsDest;
        private System.Windows.Forms.Button btn_brsImg;
        private System.Windows.Forms.TextBox txt_destLoc;
        private System.Windows.Forms.TextBox txt_imgLoc;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label lbl_destLoc;
        private System.Windows.Forms.Label lbl_imgLoc;
        private System.Windows.Forms.ErrorProvider err_img;
        private System.Windows.Forms.ErrorProvider err_dest;
        private System.Windows.Forms.FolderBrowserDialog fbd_loadLoc;
        private System.Windows.Forms.OpenFileDialog ofd_loadLoc;
    }
}