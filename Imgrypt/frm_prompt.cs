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
    public partial class frm_prompt : Form
    {
        // Global Variables
        public bool encryptChosen = false;

        public frm_prompt()
        {
            InitializeComponent();

            tt_help.SetToolTip(pb_help, "Help");
            tt_settings.SetToolTip(pb_settings, "Settings");
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            encryptChosen = true;

            frm_loadInfo encrypt = new frm_loadInfo(this);

            Point formLoc = new Point((this.Width + this.Location.X) / 2, this.Location.Y);
            encrypt.Location = formLoc;

            encrypt.Show();
            this.Hide();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            encryptChosen = false;

            frm_loadInfo decrypt = new frm_loadInfo(this);

            Point formLoc = new Point((this.Width + this.Location.X) / 2, this.Location.Y);
            decrypt.Location = formLoc;

            decrypt.Show();
            this.Hide();
        }

        private void pb_help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fileName: "https://github.com/alipianu");
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            frm_settings settings = new frm_settings(this);

            Point formLoc = new Point((this.Width + this.Location.X) / 2, this.Location.Y);
            settings.Location = formLoc;

            settings.Show();
            this.Hide();
        }
    }
}
