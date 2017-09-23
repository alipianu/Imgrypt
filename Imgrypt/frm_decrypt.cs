using System;
using System.Drawing;
using System.Windows.Forms;

namespace Imgrypt
{
    public partial class frm_decrypt : Form
    {
        // Globals
        private string[] acceptedImgFormats;
        private string imgDefaultFolder;
        private bool backPressed = false;
        private Form mainForm = null;
        public string password = null;


        public frm_decrypt(Form form)
        {
            // Initialize components
            InitializeComponent();
            mainForm = form as frm_prompt;

            // Load data from app settings
            acceptedImgFormats = MiscUtils.LoadAcceptedFormats(Properties.Settings.Default.acceptedImageFormats);
            imgDefaultFolder = Properties.Settings.Default.decImgDefault;

            // Display error provider on form startup
            err_img.SetError(txt_imgLoc, "An image file is required. Supported formats are: " + Properties.Settings.Default.acceptedImageFormats);
            err_dest.SetError(txt_destLoc, "An output path is required");
        }


        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (txt_imgLoc.BackColor == Color.LightGreen && txt_destLoc.BackColor == Color.LightGreen)
            {
                // Switch current form with getPass form
                frm_getPass getPass = new frm_getPass(this);
                MiscUtils.SetNewFormLocation(this, getPass);
                getPass.Show();
                this.Hide();
            }
            else
            {
                // Play windows error sound
                System.Media.SystemSounds.Exclamation.Play();
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            backPressed = true;
            this.Close();
        }


        private void btn_brsImg_Click(object sender, EventArgs e)
        {
            // Update image location textbox
            ofd_loadLoc.InitialDirectory = imgDefaultFolder;
            ofd_loadLoc.Title = "Browse For Image File";
            if (ofd_loadLoc.ShowDialog().ToString() == "OK")
            {
                this.txt_imgLoc.Text = ofd_loadLoc.FileName;
            }
        }


        private void btn_brsDest_Click(object sender, EventArgs e)
        {
            // Update destination location textbox
            fbd_loadLoc.ShowDialog();
            txt_destLoc.Text = fbd_loadLoc.SelectedPath;
        }


        private void frm_decrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show main form if back button was pressed, otherwise close application
            if (!backPressed)
                mainForm.Close();
            else
            {
                MiscUtils.SetNewFormLocation(this, mainForm);
                this.mainForm.Show();
            }
        }


        private void txt_imgLoc_TextChanged(object sender, EventArgs e)
        {
            // Update the textbox
            string itemRequired = "An image file is required. Supported formats are: " + Properties.Settings.Default.acceptedImageFormats;
            string itemNotSupported = "This format is not supported. Supported formats are: " + Properties.Settings.Default.acceptedImageFormats;
            MiscUtils.UpdateTextBox(txt_imgLoc, err_img, itemRequired, true, itemNotSupported, true, acceptedImgFormats);
        }


        private void txt_destLoc_TextChanged(object sender, EventArgs e)
        {
            // Update the textbox
            string itemRequired = "An output path is required";
            MiscUtils.UpdateTextBox(txt_destLoc, err_dest, itemRequired, true, null, false, null);
        }

        private void frm_decrypt_VisibleChanged(object sender, EventArgs e)
        {
            if (password != null)
            {
                // Decrypt the file
                EncryptedFile eImageFile = new EncryptedFile(txt_imgLoc.Text, password);
                eImageFile.Decrypt();
                eImageFile.SaveMessage(txt_destLoc.Text);

                // Reset all textboxes
                txt_imgLoc.Text = "";
                txt_destLoc.Text = "";

                // Forget password
                password = null;
            }
        }
    }
}