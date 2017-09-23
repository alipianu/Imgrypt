using System;
using System.Drawing;
using System.Windows.Forms;

namespace Imgrypt
{
    public partial class frm_encrypt : Form
    {
        // Globals
        private string[] acceptedImgFormats = null;
        private string[] acceptedTxtFormats = null;
        private string imgDefaultFolder = null;
        private string msgDefaultFolder = null;
        private bool backPressed = false;
        private Form mainForm = null;
        public string password = null;


        public frm_encrypt(Form form)
        {
            // Initialize components
            InitializeComponent();
            mainForm = form as frm_prompt;

            // Load data from app settings
            acceptedImgFormats = MiscUtils.LoadAcceptedFormats(Properties.Settings.Default.acceptedImageFormats);
            acceptedTxtFormats = MiscUtils.LoadAcceptedFormats(Properties.Settings.Default.acceptedTextFormats);
            imgDefaultFolder = Properties.Settings.Default.encImgDefault;
            msgDefaultFolder = Properties.Settings.Default.encMsgDefault;

            // Display error provider upon form startup
            err_img.SetError(txt_imgLoc, "An image file is required. Supported formats are: " + Properties.Settings.Default.acceptedImageFormats);
            err_msg.SetError(txt_msgLoc, "A text file is required. Supported formats are: " + Properties.Settings.Default.acceptedTextFormats);
            err_dest.SetError(txt_destLoc, "An output path is required");
        }


        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (txt_imgLoc.BackColor == Color.LightGreen && txt_msgLoc.BackColor == Color.LightGreen && txt_destLoc.BackColor == Color.LightGreen)
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


        private void btn_brsMsg_Click(object sender, EventArgs e)
        {
            // Update message location textbox
            ofd_loadLoc.InitialDirectory = imgDefaultFolder;
            ofd_loadLoc.Title = "Browse For Text File";
            if (ofd_loadLoc.ShowDialog().ToString() == "OK")
            {
                this.txt_msgLoc.Text = ofd_loadLoc.FileName;
            }
        }


        private void btn_brsDest_Click(object sender, EventArgs e)
        {
            // Update destination location textbox
            fbd_loadLoc.ShowDialog();
            txt_destLoc.Text = fbd_loadLoc.SelectedPath;
        }


        private void frm_encrypt_FormClosed(object sender, FormClosedEventArgs e)
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
            // Update textbox error provider and color
            string itemRequired = "An image file is required. Supported formats are: " + Properties.Settings.Default.acceptedImageFormats;
            string itemNotSupported = "This format is not supported. Supported formats are: " + Properties.Settings.Default.acceptedImageFormats;
            MiscUtils.UpdateTextBox(txt_imgLoc, err_img, itemRequired, true, itemNotSupported, true, acceptedImgFormats);
        }


        private void txt_msgLoc_TextChanged(object sender, EventArgs e)
        {
            // Update textbox error provider and color
            string itemRequired = "A text file is required. Supported formats are: " + Properties.Settings.Default.acceptedTextFormats;
            string itemNotSupported = "This format is not supported. Supported formats are: " + Properties.Settings.Default.acceptedTextFormats;
            MiscUtils.UpdateTextBox(txt_msgLoc, err_msg, itemRequired, true, itemNotSupported, true, acceptedTxtFormats);
        }


        private void txt_destLoc_TextChanged(object sender, EventArgs e)
        {
            // Update textbox error provider and color
            string itemRequired = "An output path is required";
            MiscUtils.UpdateTextBox(txt_destLoc, err_dest, itemRequired, true, null, false, null);
        }

        private void frm_encrypt_VisibleChanged(object sender, EventArgs e)
        {
            if (password != null)
            {
                // Encrypt the file
                UnencryptedFile uImageFile = new UnencryptedFile(txt_imgLoc.Text, txt_msgLoc.Text, password);
                uImageFile.Encrypt();
                uImageFile.SaveEncryptedImage(txt_destLoc.Text);

                // Reset all textboxes
                txt_imgLoc.Text = "";
                txt_msgLoc.Text = "";
                txt_destLoc.Text = "";

                // Forget password
                password = null;
            }
        }
    }
}