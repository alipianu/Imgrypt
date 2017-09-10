using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Imgrypt
{
    public partial class frm_settings : Form
    { 
        bool backPressed = false;

        private frm_prompt mainForm = null;
        public frm_settings(Form form)
        {
            mainForm = form as frm_prompt;

            InitializeComponent();

            sc_settings.SplitterDistance = pnl_settings.Height - btn_back.Height - 3;

            txt_encImg.Text = ConfigurationManager.AppSettings["encImgDefault"];
            txt_encMsg.Text = ConfigurationManager.AppSettings["encMsgDefault"];
            txt_encDest.Text = ConfigurationManager.AppSettings["encDestDefault"];
            txt_decImg.Text = ConfigurationManager.AppSettings["decImgDefault"];
            txt_decPass.Text = ConfigurationManager.AppSettings["decPassDefault"];
            txt_decDest.Text = ConfigurationManager.AppSettings["decDestDefault"];
        }

        private void frm_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["encImgDefault"].Value = txt_encImg.Text;
            config.AppSettings.Settings["encMsgDefault"].Value = txt_encMsg.Text;
            config.AppSettings.Settings["encDestDefault"].Value = txt_encDest.Text;
            config.AppSettings.Settings["decImgDefault"].Value = txt_decImg.Text;
            config.AppSettings.Settings["decPassDefault"].Value = txt_decPass.Text;
            config.AppSettings.Settings["decDestDefault"].Value = txt_decDest.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            if (!backPressed)
                mainForm.Close();
            else
            {
                Point formLoc = new Point((this.Width + this.Location.X) / 2, this.Location.Y);
                this.mainForm.Location = formLoc;
                this.mainForm.Show();
            }
        }

        private void tc_settings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_settings.SelectedTab == tc_settings.TabPages["tp_encrypt"])
            {

            }
            else if (tc_settings.SelectedTab == tc_settings.TabPages["tp_decrypt"])
            {

            }
            else if (tc_settings.SelectedTab == tc_settings.TabPages["tp_options"])
            {

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            backPressed = true;
            this.Close();
        }

        private void btn_encImg_Click(object sender, EventArgs e)
        {
            fbd_defaultFolder.SelectedPath = txt_encImg.Text;
            fbd_defaultFolder.ShowDialog();
            txt_encImg.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_encMsg_Click(object sender, EventArgs e)
        {
            fbd_defaultFolder.SelectedPath = txt_encMsg.Text;
            fbd_defaultFolder.ShowDialog();
            txt_encMsg.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_encDest_Click(object sender, EventArgs e)
        {
            fbd_defaultFolder.SelectedPath = txt_encDest.Text;
            fbd_defaultFolder.ShowDialog();
            txt_encDest.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_decImg_Click(object sender, EventArgs e)
        {
            fbd_defaultFolder.SelectedPath = txt_decImg.Text;
            fbd_defaultFolder.ShowDialog();
            txt_decImg.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_decPass_Click(object sender, EventArgs e)
        {
            fbd_defaultFolder.SelectedPath = txt_decPass.Text;
            fbd_defaultFolder.ShowDialog();
            txt_decPass.Text = fbd_defaultFolder.SelectedPath;
        }

        private void btn_decDest_Click(object sender, EventArgs e)
        {
            fbd_defaultFolder.SelectedPath = txt_decDest.Text;
            fbd_defaultFolder.ShowDialog();
            txt_decDest.Text = fbd_defaultFolder.SelectedPath;
        }
    }
}
