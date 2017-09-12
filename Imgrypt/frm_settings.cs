using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            txt_encImg.Text = Properties.Settings.Default.encImgDefault;
            txt_encMsg.Text = Properties.Settings.Default.encMsgDefault;
            txt_decImg.Text = Properties.Settings.Default.decImgDefault;
            txt_decPass.Text = Properties.Settings.Default.decPassDefault;
        }

        private void frm_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.encImgDefault = txt_encImg.Text;
            Properties.Settings.Default.encMsgDefault = txt_encMsg.Text;
            Properties.Settings.Default.decImgDefault = txt_decImg.Text;
            Properties.Settings.Default.decPassDefault = txt_decPass.Text;
            Properties.Settings.Default.Save();

            if (!backPressed)
                mainForm.Close();
            else
            {
                Point formLoc = new Point((this.Width + this.Location.X) / 2, this.Location.Y);
                this.mainForm.Location = formLoc;
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
    }
}
