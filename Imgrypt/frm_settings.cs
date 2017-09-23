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
            LoadOutputFormat(gb_imgOutput, Properties.Settings.Default.encImgOutputFormat);
            LoadOutputFormat(gb_msgOutput, Properties.Settings.Default.decMsgOutputFormat);
            txt_imgOutput.Text = Properties.Settings.Default.encImgOutputName;
            txt_msgOutput.Text = Properties.Settings.Default.decMsgOutputName;
        }

        private void frm_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Set output names to default if left blank
            if (txt_imgOutput.Text == "")
                txt_imgOutput.Text = "encrypted";
            if (txt_msgOutput.Text == "")
                txt_msgOutput.Text = "message";

            // Save settings
            Properties.Settings.Default.encImgDefault = txt_encImg.Text;
            Properties.Settings.Default.encMsgDefault = txt_encMsg.Text;
            Properties.Settings.Default.decImgDefault = txt_decImg.Text;
            Properties.Settings.Default.encImgOutputFormat = SetOutputFormat(gb_imgOutput);
            Properties.Settings.Default.decMsgOutputFormat = SetOutputFormat(gb_msgOutput);
            Properties.Settings.Default.encImgOutputName = txt_imgOutput.Text;
            Properties.Settings.Default.decMsgOutputName = txt_msgOutput.Text;
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

        private void tc_settings_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adjust form height according to selected tab page
            if (tc_settings.SelectedTab == tc_settings.TabPages["tp_locations"])
                this.Height = 265;
            else if (tc_settings.SelectedTab == tc_settings.TabPages["tp_encrOptions"])
                this.Height = gb_imgOutput.Height + btn_back.Height + 100;
            else
                this.Height = gb_imgOutput.Height + btn_back.Height + 80;
        }

        private string SetOutputFormat(Control container)
        {
            // Return output format of selected radio button
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Checked)
                    return radio.Text.Substring(radio.Text.IndexOf('(') + 1, radio.Text.IndexOf(')') - 1 - radio.Text.IndexOf('('));
            }
            return null;
        }

        private void LoadOutputFormat(Control container, string ext)
        {
            // Return output format of selected radio button
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Text.Contains(ext))
                    radio.Checked = true;
            }
        }

        private void btn_imgOutput_Click(object sender, EventArgs e)
        {
            // Reset image output name to default
            txt_imgOutput.Text = "encrypted";
        }

        private void btn_msgOutput_Click(object sender, EventArgs e)
        {
            // Reset message output name to default
            txt_msgOutput.Text = "message";
        }

        private void txt_imgOutput_TextChanged(object sender, EventArgs e)
        {
            // Remove spaces from word
            MiscUtils.RemoveSpacesFromTextbox(txt_imgOutput, false);
        }

        private void txt_msgOutput_TextChanged(object sender, EventArgs e)
        {
            // Remove spaces from word
            MiscUtils.RemoveSpacesFromTextbox(txt_msgOutput, false);
        }
    }
}
