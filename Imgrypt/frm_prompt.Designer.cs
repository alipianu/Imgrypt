namespace Imgrypt
{
    partial class frm_prompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prompt));
            this.pnl_prompt = new System.Windows.Forms.Panel();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.tt_help = new System.Windows.Forms.ToolTip(this.components);
            this.tt_settings = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_prompt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_prompt
            // 
            this.pnl_prompt.Controls.Add(this.pb_help);
            this.pnl_prompt.Controls.Add(this.pb_settings);
            this.pnl_prompt.Controls.Add(this.btn_decrypt);
            this.pnl_prompt.Controls.Add(this.btn_encrypt);
            this.pnl_prompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_prompt.Location = new System.Drawing.Point(0, 0);
            this.pnl_prompt.Name = "pnl_prompt";
            this.pnl_prompt.Size = new System.Drawing.Size(333, 105);
            this.pnl_prompt.TabIndex = 0;
            // 
            // pb_help
            // 
            this.pb_help.BackColor = System.Drawing.Color.Transparent;
            this.pb_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_help.Image = global::Imgrypt.Properties.Resources.help;
            this.pb_help.Location = new System.Drawing.Point(253, 6);
            this.pb_help.Name = "pb_help";
            this.pb_help.Size = new System.Drawing.Size(30, 30);
            this.pb_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_help.TabIndex = 3;
            this.pb_help.TabStop = false;
            this.pb_help.Click += new System.EventHandler(this.pb_help_Click);
            // 
            // pb_settings
            // 
            this.pb_settings.BackColor = System.Drawing.Color.Transparent;
            this.pb_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_settings.Image = global::Imgrypt.Properties.Resources.settings;
            this.pb_settings.Location = new System.Drawing.Point(291, 6);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(30, 30);
            this.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_settings.TabIndex = 2;
            this.pb_settings.TabStop = false;
            this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decrypt.Location = new System.Drawing.Point(174, 42);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(147, 52);
            this.btn_decrypt.TabIndex = 1;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encrypt.Location = new System.Drawing.Point(12, 42);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(147, 52);
            this.btn_encrypt.TabIndex = 0;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // frm_prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 105);
            this.Controls.Add(this.pnl_prompt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imgrypt";
            this.pnl_prompt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_prompt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.ToolTip tt_help;
        private System.Windows.Forms.ToolTip tt_settings;
    }
}