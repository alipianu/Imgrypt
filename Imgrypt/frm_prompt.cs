using System;
using System.Windows.Forms;

namespace Imgrypt
{
    public partial class frm_prompt : Form
    {
        public frm_prompt()
        {
            // Initialize components
            InitializeComponent();
            tip_help.SetToolTip(pb_help, "Help");
            tip_settings.SetToolTip(pb_settings, "Settings");
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            // Switch current form with encrypt form
            frm_encrypt encrypt = new frm_encrypt(this);
            MiscUtils.SetNewFormLocation(this, encrypt);
            encrypt.Show();
            this.Hide();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            // Switch current form with decrypt form
            frm_decrypt decrypt = new frm_decrypt(this);
            MiscUtils.SetNewFormLocation(this, decrypt);
            decrypt.Show();
            this.Hide();
        }

        private void pb_help_Click(object sender, EventArgs e)
        {
            // Go to documentation
            System.Diagnostics.Process.Start("https://github.com/alipianu/Imgrypt");
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            // Switch current form with settings form
            frm_settings settings = new frm_settings(this);
            MiscUtils.SetNewFormLocation(this, settings);
            settings.Show();
            this.Hide();
        }
    }
}
