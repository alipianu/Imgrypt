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
    class UnencryptedFile
    {
        /* File properties */
        private string srcImg = null;
        private string srcMsg = null;
        private string message = "";
        private string password = "";
        private Bitmap image = null;
        private int W, H;

        public UnencryptedFile(string imageSource, string messageSource)
        {
            /* Initialize properties */
            srcImg = imageSource;
            srcMsg = messageSource;

            image = (Bitmap)Image.FromFile(imageSource);
            H = image.Size.Height;
            W = image.Size.Width;
        }

        public void Encrypt()
        {
            /* Extract message from text file */
            GetMessage();

            /* Get maximum distance bewteen each secret pixel */
            int maxDistance = ((W * H) / message.Length) * 2;
            if (maxDistance < 2)
                maxDistance = 2;
            else if (maxDistance > 19998)
                maxDistance = 19998;


            /* Generate the secret char that indicates the last pixel */
            List<int> checkedVals = new List<int>(256);
            for (int i = 0; i < 256; i++)
                checkedVals.Add(0);

            Random randAscii = new Random();
            int charAscii = 127;
            int temp;

            while (!checkedVals.All(o => o == 1))
            {
                temp = randAscii.Next(0, 256);
                if (!message.Contains((char)temp))
                {
                    charAscii = temp;
                    break;
                }
                else
                {
                    if (checkedVals[temp] != 1)
                        checkedVals[temp] = 1;
                }
            }

            /* Get a seed where the secret pixels reach the bottom of the image, but do not surpass it */
            Random pixLoc = null;
            int seed = 0;
            int totalspacing = W * H;
            int[] spacingArray = new int[message.Length + 1];

            while (totalspacing >= W * H)
            {
                seed = GetRandSeed(6);  // Get random seed
                pixLoc = new Random(seed);  // Generate random location sequence from seed

                for (int i = 0; i <= message.Length; i++)
                {
                    spacingArray[i] = (pixLoc.Next(1, maxDistance + 1));
                    totalspacing += spacingArray[i];
                }
            }

            /* Generate password */
            if (maxDistance < 19998)
                password += maxDistance.ToString() + "_";
            password += seed.ToString();
            password += "_" + charAscii.ToString();


            /* Hide message */
            Color pixel = new Color();
            int nextPixLoc = 0;
            int currPixLoc = 0;
            int x;
            int y;

            for (int i = 0; i <= message.Length; i++)
            {
                // Get location of next secret char
                nextPixLoc = spacingArray[i];

                y = (currPixLoc + nextPixLoc) / W;
                x = (currPixLoc + nextPixLoc) - (y * W);
                if (x >= W || y >= H)
                    break;
                pixel = image.GetPixel(x, y);

                currPixLoc += nextPixLoc;

                if (nextPixLoc % 2 == 0)  // Store the secret char in 'r' value of the pixel
                {
                    if (i == message.Length)
                        pixel = Color.FromArgb(charAscii, pixel.G, pixel.B);
                    else
                    {
                        if (message[i] > 255)
                            pixel = Color.FromArgb(64, pixel.G, pixel.B);
                        else
                            pixel = Color.FromArgb(message[i], pixel.G, pixel.B);
                    }
                }
                else if (nextPixLoc % 3 == 0)  // Store the secret char in the 'g' value of the pixel
                {
                    if (i == message.Length)
                        pixel = Color.FromArgb(pixel.R, charAscii, pixel.B);
                    else
                    {
                        if (message[i] > 255)
                            pixel = Color.FromArgb(pixel.R, 64, pixel.B);
                        else
                            pixel = Color.FromArgb(pixel.R, message[i], pixel.B);
                    }
                }
                else  // Store the secret char in the 'b' value of the pixel
                {
                    if (i == message.Length)
                        pixel = Color.FromArgb(pixel.R, pixel.G, charAscii);
                    else
                    {
                        if (message[i] > 255)
                            pixel = Color.FromArgb(pixel.R, pixel.G, 64);
                        else
                            pixel = Color.FromArgb(pixel.R, pixel.G, message[i]);
                    }
                }

                // Update pixel
                image.SetPixel(x, y, pixel);
            }
        }

        private void GetMessage()
        {
            /* Extract message */
            message = File.ReadAllText(srcMsg);
        }

        public void SaveEncryptedImage(string outputDirectory)
        {
            /* Save new image */
            image.Save(outputDirectory + "\\encrypted.bmp");
        }

        public void SavePassword(string outputDirectory)
        {
            /* Write password to text file */
            File.WriteAllText(outputDirectory + "\\password.txt", password);
        }

        private int GetRandSeed(int seedlength)
        {
            int val = 0;
            string seed = "";

            Random rand = new Random();

            for (int i = 0; i < seedlength; i++)
            {
                val = rand.Next(1, 10);
                seed += val.ToString();
            }

            return Convert.ToInt32(seed);
        }
    }
}
