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
    public partial class frm_loadInfo : Form
    {
        List<string> acceptedImgFormats = new List<string>();
        List<string> acceptedTxtFormats = new List<string>();

        bool backPressed = false;
        string imgDefaultFolder;
        string textDefaultFolder;

        private frm_prompt mainForm = null;
        public frm_loadInfo(Form form)
        {
            mainForm = form as frm_prompt;

            InitializeComponent();

            LoadAcceptedFormats();

            ep_img.SetError(txt_imgLoc, "An image file is required. Supported formats are: .bmp, .jpg, .png");
            ep_text.SetError(txt_textLoc, "A text file is required. Supported formats are: .txt");
            ep_dest.SetError(txt_destLoc, "An output path is required");

            if (mainForm.encryptChosen == false)
            {
                lbl_textLoc.Text = "Password File:";
                this.Text = "Imgrypt - Decrypt";
                btn_go.Text = "Decrypt";
            }

            if (mainForm.encryptChosen == true)
            {
                imgDefaultFolder = Properties.Settings.Default.encImgDefault;
                textDefaultFolder = Properties.Settings.Default.encMsgDefault;
            }
            else
            {
                imgDefaultFolder = Properties.Settings.Default.decImgDefault;
                textDefaultFolder = Properties.Settings.Default.decPassDefault;
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (txt_textLoc.BackColor == Color.LightGreen && txt_imgLoc.BackColor == Color.LightGreen && txt_destLoc.BackColor == Color.LightGreen)
            {

                if (mainForm.encryptChosen)
                {
                    // Encrypt the file
                    UnencryptedFile uImageFile = new UnencryptedFile(txt_imgLoc.Text, txt_textLoc.Text);
                    uImageFile.Encrypt();
                    uImageFile.SaveEncryptedImage(txt_destLoc.Text);
                    uImageFile.SavePassword(txt_destLoc.Text);
                }
                else
                {
                    // Decrypt the file
                    EncryptedFile eImageFile = new EncryptedFile(txt_imgLoc.Text, txt_textLoc.Text);
                    eImageFile.Decrypt();
                    eImageFile.SaveMessage(txt_destLoc.Text);
                }
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
            ofd_loadInfo.InitialDirectory = imgDefaultFolder;
            ofd_loadInfo.Title = "Browse For Image File";
            if (ofd_loadInfo.ShowDialog().ToString() == "OK")
            {
                this.txt_imgLoc.Text = ofd_loadInfo.FileName;
            }
        }

        private void btn_brsMess_Click(object sender, EventArgs e)
        {
            ofd_loadInfo.InitialDirectory = textDefaultFolder;
            ofd_loadInfo.Title = "Browse For Text File";
            if (ofd_loadInfo.ShowDialog().ToString() == "OK")
            {
                this.txt_textLoc.Text = ofd_loadInfo.FileName;
            }
        }

        private void btn_brsDest_Click(object sender, EventArgs e)
        {
            fbd_loadInfo.ShowDialog();
            txt_destLoc.Text = fbd_loadInfo.SelectedPath;
        }

        private void frm_encrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!backPressed)
                mainForm.Close();
            else
            {
                Point formLoc = new Point((this.Width + this.Location.X) / 2, this.Location.Y);
                this.mainForm.Location = formLoc;
                this.mainForm.Show();
            }
        }

        private void txt_imgLoc_TextChanged(object sender, EventArgs e)
        {
            ep_img.Clear();
            txt_imgLoc.BackColor = Color.White;
            if (txt_imgLoc.Text == "")
            {
                ep_img.SetError(txt_imgLoc, "An image file is required. Supported formats are: .bmp, .jpg, .png");
            }
            else if (!FileExtIsGood(txt_imgLoc.Text, acceptedImgFormats))
            {
                ep_img.SetError(txt_imgLoc, "This format is not supported. Supported formats are: .bmp, .jpg, .png");
            }
            else
            {
                txt_imgLoc.BackColor = Color.LightGreen;
            }
        }

        private void txt_messLoc_TextChanged(object sender, EventArgs e)
        {
            ep_text.Clear();
            txt_textLoc.BackColor = Color.White;
            if (txt_textLoc.Text == "")
            {
                ep_text.SetError(txt_textLoc, "A text file is required. Supported formats are: .txt");
            }
            else if (!FileExtIsGood(txt_textLoc.Text, acceptedTxtFormats))
            {
                ep_text.SetError(txt_textLoc, "This format is not supported. Supported formats are: .txt");
            }
            else
            {
                txt_textLoc.BackColor = Color.LightGreen;
            }
        }

        private void txt_destLoc_TextChanged(object sender, EventArgs e)
        {
            ep_dest.Clear();
            txt_destLoc.BackColor = Color.White;
            if (txt_destLoc.Text == "")
            {
                ep_dest.SetError(txt_destLoc, "An output path is required");
            }
            else
            {
                txt_destLoc.BackColor = Color.LightGreen;
            }
        }

        private bool FileExtIsGood(string directory, List<string> acceptedFormats)
        {
            int extLoc = directory.LastIndexOf('.');
            string ext = directory.Substring(extLoc, (directory.Length) - extLoc);

            bool accepted = false;

            for (int i = 0; i < acceptedFormats.Capacity; i++)
            {
                if (ext == acceptedFormats[i])
                {
                    accepted = true;
                    break;
                }
            }

            return accepted;
        }

        private void LoadAcceptedFormats()
        {
            string imgFormats = Properties.Settings.Default.acceptedImageFormats;
            string txtFormats = Properties.Settings.Default.acceptedTextFormats;

            acceptedImgFormats.Capacity = NumOccurences(imgFormats, ".");
            while (imgFormats.Contains("."))
            {
                acceptedImgFormats.Add(imgFormats.Substring(imgFormats.LastIndexOf("."), imgFormats.Length - imgFormats.LastIndexOf(".")));
                imgFormats = imgFormats.Substring(0, imgFormats.LastIndexOf("."));
            }

            acceptedTxtFormats.Capacity = NumOccurences(txtFormats, ".");
            while (txtFormats.Contains("."))
            {
                acceptedTxtFormats.Add(txtFormats.Substring(txtFormats.LastIndexOf("."), txtFormats.Length - txtFormats.LastIndexOf(".")));
                txtFormats = txtFormats.Substring(0, txtFormats.LastIndexOf("."));
            }
        }

        private int NumOccurences(string str, string searchstr)
        {
            int total = 0;
            int loc = 0;

            if (str.Contains("."))
            {
                while (true)
                {
                    loc = str.IndexOf(searchstr, loc);

                    if (loc == str.LastIndexOf(searchstr))
                    {
                        total++;
                        break;
                    }
                    else
                    {
                        loc++;
                        total++;
                    }
                }
            }

            return total;
        }
    }
}