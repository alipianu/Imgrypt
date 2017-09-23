using System;
using System.Windows.Forms;

namespace Imgrypt
{
    public partial class frm_settings : Form
    { 
        // Globals
        private bool backPressed = false;
        private frm_prompt mainForm = null;

        public frm_settings(Form form)
        {
            // Initialize components
            InitializeComponent();
            mainForm = form as frm_prompt;

            // Setup split container
            sc_settings.SplitterDistance = pnl_settings.Height - btn_back.Height;

            // Load settings
            txt_encImg.Text = Properties.Settings.Default.encImgDefault;
            txt_encMsg.Text = Properties.Settings.Default.encMsgDefault;
            txt_decImg.Text = Properties.Settings.Default.decImgDefault;
        }

        private void frm_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save settings
            Properties.Settings.Default.encImgDefault = txt_encImg.Text;
            Properties.Settings.Default.encMsgDefault = txt_encMsg.Text;
            Properties.Settings.Default.decImgDefault = txt_decImg.Text;
            Properties.Settings.Default.Save();

            // Show main form if back button was pressed, otherwise close application
            if (!backPressed)
                mainForm.Close();
            else
            {
                MiscUtils.SetNewFormLocation(this, mainForm);
                this.mainForm.Show();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            backPressed = true;
            this.Close();
        }

        private void btn_encImg_Click(object sender, EventArgs e)
        {
            // Update default encrypt image location textbox
            fbd_defaultFolder.SelectedPath = txt_encImg.Text;
            fbd_defaultFolder.ShowDialog();
            txt_encImg.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_encMsg_Click(object sender, EventArgs e)
        {
            // Update default encrypt message location textbox
            fbd_defaultFolder.SelectedPath = txt_encMsg.Text;
            fbd_defaultFolder.ShowDialog();
            txt_encMsg.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_decImg_Click(object sender, EventArgs e)
        {
            // Update default decrypt image location textbox
            fbd_defaultFolder.SelectedPath = txt_decImg.Text;
            fbd_defaultFolder.ShowDialog();
            txt_decImg.Text = fbd_defaultFolder.SelectedPath;
        }
    }
}
