namespace Imgrypt
{
    partial class frm_getPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_getPass));
            this.pnl_choosePass = new System.Windows.Forms.Panel();
            this.grp_word3 = new System.Windows.Forms.GroupBox();
            this.txt_word3 = new System.Windows.Forms.TextBox();
            this.grp_word2 = new System.Windows.Forms.GroupBox();
            this.txt_word2 = new System.Windows.Forms.TextBox();
            this.grp_word1 = new System.Windows.Forms.GroupBox();
            this.txt_word1 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_choosePass = new System.Windows.Forms.Label();
            this.err_word1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_word2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_word3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_choosePass.SuspendLayout();
            this.grp_word3.SuspendLayout();
            this.grp_word2.SuspendLayout();
            this.grp_word1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_word1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_word2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_word3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_choosePass
            // 
            this.pnl_choosePass.Controls.Add(this.grp_word3);
            this.pnl_choosePass.Controls.Add(this.grp_word2);
            this.pnl_choosePass.Controls.Add(this.grp_word1);
            this.pnl_choosePass.Controls.Add(this.btn_cancel);
            this.pnl_choosePass.Controls.Add(this.btn_ok);
            this.pnl_choosePass.Controls.Add(this.lbl_choosePass);
            this.pnl_choosePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_choosePass.Location = new System.Drawing.Point(0, 0);
            this.pnl_choosePass.Name = "pnl_choosePass";
            this.pnl_choosePass.Size = new System.Drawing.Size(558, 221);
            this.pnl_choosePass.TabIndex = 2;
            // 
            // grp_word3
            // 
            this.grp_word3.Controls.Add(this.txt_word3);
            this.grp_word3.Location = new System.Drawing.Point(370, 69);
            this.grp_word3.Name = "grp_word3";
            this.grp_word3.Size = new System.Drawing.Size(169, 68);
            this.grp_word3.TabIndex = 3;
            this.grp_word3.TabStop = false;
            this.grp_word3.Text = "Word 3";
            // 
            // txt_word3
            // 
            this.txt_word3.BackColor = System.Drawing.Color.White;
            this.txt_word3.Location = new System.Drawing.Point(19, 28);
            this.txt_word3.MaxLength = 9;
            this.txt_word3.Name = "txt_word3";
            this.txt_word3.Size = new System.Drawing.Size(108, 26);
            this.txt_word3.TabIndex = 3;
            this.txt_word3.TextChanged += new System.EventHandler(this.txt_word3_TextChanged);
            // 
            // grp_word2
            // 
            this.grp_word2.Controls.Add(this.txt_word2);
            this.grp_word2.Location = new System.Drawing.Point(195, 69);
            this.grp_word2.Name = "grp_word2";
            this.grp_word2.Size = new System.Drawing.Size(169, 68);
            this.grp_word2.TabIndex = 2;
            this.grp_word2.TabStop = false;
            this.grp_word2.Text = "Word 2";
            // 
            // txt_word2
            // 
            this.txt_word2.BackColor = System.Drawing.Color.White;
            this.txt_word2.Location = new System.Drawing.Point(19, 28);
            this.txt_word2.MaxLength = 9;
            this.txt_word2.Name = "txt_word2";
            this.txt_word2.Size = new System.Drawing.Size(108, 26);
            this.txt_word2.TabIndex = 2;
            this.txt_word2.TextChanged += new System.EventHandler(this.txt_word2_TextChanged);
            // 
            // grp_word1
            // 
            this.grp_word1.Controls.Add(this.txt_word1);
            this.grp_word1.Location = new System.Drawing.Point(20, 69);
            this.grp_word1.Name = "grp_word1";
            this.grp_word1.Size = new System.Drawing.Size(169, 68);
            this.grp_word1.TabIndex = 1;
            this.grp_word1.TabStop = false;
            this.grp_word1.Text = "Word 1";
            // 
            // txt_word1
            // 
            this.txt_word1.BackColor = System.Drawing.Color.White;
            this.txt_word1.Location = new System.Drawing.Point(19, 28);
            this.txt_word1.MaxLength = 9;
            this.txt_word1.Name = "txt_word1";
            this.txt_word1.Size = new System.Drawing.Size(108, 26);
            this.txt_word1.TabIndex = 1;
            this.txt_word1.TextChanged += new System.EventHandler(this.txt_word1_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(120, 159);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(147, 52);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Location = new System.Drawing.Point(282, 159);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(147, 52);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_choosePass
            // 
            this.lbl_choosePass.AutoSize = true;
            this.lbl_choosePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choosePass.Location = new System.Drawing.Point(156, 22);
            this.lbl_choosePass.Name = "lbl_choosePass";
            this.lbl_choosePass.Size = new System.Drawing.Size(255, 25);
            this.lbl_choosePass.TabIndex = 0;
            this.lbl_choosePass.Text = "Choose a 3 word password:";
            // 
            // err_word1
            // 
            this.err_word1.ContainerControl = this;
            // 
            // err_word2
            // 
            this.err_word2.ContainerControl = this;
            // 
            // err_word3
            // 
            this.err_word3.ContainerControl = this;
            // 
            // frm_getPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 221);
            this.Controls.Add(this.pnl_choosePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_getPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imgrypt - Choose Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_getPass_FormClosed);
            this.pnl_choosePass.ResumeLayout(false);
            this.pnl_choosePass.PerformLayout();
            this.grp_word3.ResumeLayout(false);
            this.grp_word3.PerformLayout();
            this.grp_word2.ResumeLayout(false);
            this.grp_word2.PerformLayout();
            this.grp_word1.ResumeLayout(false);
            this.grp_word1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_word1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_word2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_word3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_choosePass;
        private System.Windows.Forms.TextBox txt_word1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_choosePass;
        private System.Windows.Forms.GroupBox grp_word1;
        private System.Windows.Forms.GroupBox grp_word3;
        private System.Windows.Forms.TextBox txt_word3;
        private System.Windows.Forms.GroupBox grp_word2;
        private System.Windows.Forms.TextBox txt_word2;
        private System.Windows.Forms.ErrorProvider err_word1;
        private System.Windows.Forms.ErrorProvider err_word2;
        private System.Windows.Forms.ErrorProvider err_word3;
    }
}