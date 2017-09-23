using System;
using System.Windows.Forms;

namespace Imgrypt
{
    public partial class frm_getPass : Form
    {
        // Globals
        private bool cancelPressed = false;
        private frm_encrypt encryptMainForm = null;
        private frm_decrypt decryptMainForm = null;

        public frm_getPass(Form form)
        {
            // Initialize components
            InitializeComponent();

            // Change form information according to encrypting/decrypting scenario
            if (form.Name == "frm_encrypt")
            {
                encryptMainForm = form as frm_encrypt;
                this.Text = "Choose Password";
                this.lbl_choosePass.Text = "Choose a 3 word password:";
            }
            else
            {
                decryptMainForm = form as frm_decrypt;
                this.Text = "Enter Password";
                this.lbl_choosePass.Text = "Enter the 3 word password:";
            }

            // Display error provider upon form startup
            err_word1.SetError(txt_word1, "Word must be at least 1 character long");
            err_word2.SetError(txt_word2, "Word must be at least 1 character long");
            err_word3.SetError(txt_word3, "Word must be at least 1 character long");
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_word1.Text.Length > 0 && txt_word2.Text.Length > 0 && txt_word3.Text.Length > 0)
            {
                // Send password to previous form
                if (encryptMainForm != null)
                    encryptMainForm.password = txt_word1.Text + " " + txt_word2.Text + " " + txt_word3.Text;
                else
                    decryptMainForm.password = txt_word1.Text + " " + txt_word2.Text + " " + txt_word3.Text;

                // Close getPass form as if the user pressed cancel
                cancelPressed = true;
                this.Close();
            }
            else
            {
                // Play windows error sound
                System.Media.SystemSounds.Exclamation.Play();
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancelPressed = true;
            this.Close();
        }


        private void frm_getPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (encryptMainForm != null)
            {
                // Show encrypt form if cancel button was pressed, otherwise close application
                if (!cancelPressed)
                    encryptMainForm.Close();
                else
                {
                    MiscUtils.SetNewFormLocation(this, this.encryptMainForm);
                    this.encryptMainForm.Show();
                }
            }
            else
            {
                // Show decrypt form if cancel button was pressed, otherwise close application
                if (!cancelPressed)
                    decryptMainForm.Close();
                else
                {
                    MiscUtils.SetNewFormLocation(this, this.decryptMainForm);
                    this.decryptMainForm.Show();
                }
            }
        }


        private void txt_word1_TextChanged(object sender, EventArgs e)
        {
            // Remove spaces from word
            MiscUtils.RemoveSpacesFromTextbox(txt_word1, true);

            // Show error provider if user has not input any characters
            if (txt_word1.Text.Length > 0)
                err_word1.Clear();
            if (txt_word1.Text.Length == 0)
                err_word1.SetError(txt_word1, "Word must be at least 1 character long");
        }


        private void txt_word2_TextChanged(object sender, EventArgs e)
        {
            // Remove spaces from word
            MiscUtils.RemoveSpacesFromTextbox(txt_word2, true);

            // Show error provider if user has not input any characters
            if (txt_word2.Text.Length > 0)
                err_word2.Clear();
            if (txt_word2.Text.Length == 0)
                err_word2.SetError(txt_word2, "Word must be at least 1 character long");
        }


        private void txt_word3_TextChanged(object sender, EventArgs e)
        {
            // Remove spaces from word
            MiscUtils.RemoveSpacesFromTextbox(txt_word3, true);

            // Show error provider if user has not input any characters
            if (txt_word3.Text.Length > 0)
                err_word3.Clear();
            if (txt_word3.Text.Length == 0)
                err_word3.SetError(txt_word3, "Word must be at least 1 character long");
        }
    }
}
