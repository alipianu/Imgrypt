using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Configuration;

namespace Imgrypt
{
    class EncryptedFile
    {
        // File properties
        private string srcImg = null;
        private string srcPass = null;
        private string message = "";
        private string password = "";
        private Bitmap image = null;
        private int W, H;

        public EncryptedFile(string imageSource, string passwordSource)
        {
            // Initialize properties
            srcImg = imageSource;
            srcPass = passwordSource;

            image = new Bitmap(imageSource);
            H = image.Size.Height;
            W = image.Size.Width;
        }

        public void Decrypt()
        {
            // Extract message from text file
            GetPassword();

            // Get the maximum distance between secret pixels, the seed, and the terminating ascii character from the password
            int maxDistance = 0;
            int seed = 0;
            int charAscii = 0;
            if ((password.Length - password.Replace("_", "").Length) == 1)
            {
                maxDistance = 9999 * 2;
                seed = Convert.ToInt32(password.Substring(0, password.LastIndexOf("_")));
            }
            else
            {
                maxDistance = (Convert.ToInt32(password.Substring(0, password.IndexOf("_"))));
                seed = Convert.ToInt32(password.Substring(password.IndexOf("_") + 1, password.LastIndexOf("_") + -1 - password.IndexOf("_")));
            }
            charAscii = Convert.ToInt32(password.Substring(password.LastIndexOf("_") + 1, password.Length - 1 - password.LastIndexOf("_")));


            // Generate random location sequence from seed
            Random pixLoc = new Random(Convert.ToInt32(seed));


            Color pixel = new Color();
            int nextPixLoc = 0;
            int loc = 0;
            int x;
            int y;
            int secretchar = 0;

            while (nextPixLoc < (W * H))
            {
                // Get location of next secret char
                nextPixLoc = pixLoc.Next(1, maxDistance + 1);

                // Get correct pixel
                y = (loc + nextPixLoc) / W;
                x = (loc + nextPixLoc) - (y * W);
                if (x >= W || y >= H)
                    break;
                pixel = image.GetPixel(x, y);

                loc += nextPixLoc;

                // Get secret character stored in pixel
                if (nextPixLoc % 2 == 0)
                    secretchar = pixel.R;
                else if (nextPixLoc % 3 == 0)
                    secretchar = pixel.G;
                else
                    secretchar = pixel.B;

                // Exit if current pixel contains terminating char, otherwise concatenate onto message
                if (secretchar != charAscii)
                    message += (char)secretchar;
                else
                    break;
            }
        }

        private void GetPassword()
        {
            // Extract password
            password = File.ReadAllText(srcPass);
        }

        public void SaveMessage(string outputDirectory)
        {
            // Write messsage to text file
            File.WriteAllText(outputDirectory + "\\message.txt", message);
        }

        private string VerifyPassword()
        {
            if (true)
            {
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
