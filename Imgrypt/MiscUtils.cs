using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Imgrypt
{
    static class MiscUtils
    {
        // Updates textboxes and their error provider after choosing a file or folder
        public static void UpdateTextBox(TextBox textBox, ErrorProvider errorProvider, string noItemError, bool checkForItem, string notSupportedError, bool checkForSupported, string[] acceptedFormats)
        {
            // Reset textbox and error provider
            errorProvider.Clear();
            textBox.BackColor = Color.White;

            // Show error if present, otherwise set textbox color to green
            if (checkForItem && textBox.Text == "")
                errorProvider.SetError(textBox, noItemError);
            else if (checkForSupported && !MiscUtils.FileExtIsGood(textBox.Text, acceptedFormats))
                errorProvider.SetError(textBox, notSupportedError);
            else
                textBox.BackColor = Color.LightGreen;
        }


        // Checks if a file path ends in a supported format (eg: .bmp, .jpg, .txt)
        public static bool FileExtIsGood(string directory, string[] acceptedFormats)
        {
            string ext = directory.Substring(directory.LastIndexOf('.') + 1);
            foreach (var format in acceptedFormats)
            {
                if (ext == format)
                    return true;
            }
            return false;
        }


        // Returns and array of accepted format strings from a string of accepted formats separated by '.'
        // Example: ".bmp .jpg .txt" -> ["bmp", "jpg", "txt"]
        public static string[] LoadAcceptedFormats(string acceptedFormatsStr)
        {
            string[] acceptedFormats = acceptedFormatsStr.Replace(" ", "").Split('.');
            List<string> result = new List<string>();
            foreach (var format in acceptedFormats)
            {
                if (!string.IsNullOrEmpty(format))
                    result.Add(format);
            }
            return result.ToArray();
        }


        // Sets the location of the new form so that it's centered on the old form
        public static void SetNewFormLocation(Form oldForm, Form newForm)
        {
            newForm.Location = new Point(oldForm.Location.X + oldForm.Width / 2 - newForm.Width / 2, oldForm.Location.Y);
        }
    }
}