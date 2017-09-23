using System;
using System.Linq;
using System.Drawing;
using System.IO;

namespace Imgrypt
{
    class UnencryptedFile
    {
        // File properties
        private readonly string message = null;
        private readonly string password = null;
        private readonly int W, H;
        private Bitmap image = null;

        public UnencryptedFile(string imageSource, string messageSource, string password)
        {
            /* Initialize properties */
            this.message = GetMessage(messageSource);
            this.password = password;
            this.image = (Bitmap)Image.FromFile(imageSource);
            this.H = image.Size.Height;
            this.W = image.Size.Width;
        }

        public void Encrypt()
        {
            // Setup new pixel
            Color pixel = new Color();

            // Extract 3 words from password
            string[] pWords = password.Split(' ');

            // Generate random int sequences
            Random randPosition = new Random(GenerateSeed(pWords[0]));
            Random randDataChar = new Random(GenerateSeed(pWords[1]));
            Random randDifference = new Random(GenerateSeed(pWords[2]));

            // Calculate max char distance
            int maxCharDistance = (W * H) / message.Length;
            int[] maxCharDistPixel = new int[3];
            int total = maxCharDistance;
            for (int i = 0; i < maxCharDistPixel.Length; i++)
            {
                if (total >= 255)
                {
                    maxCharDistPixel[i] = 255;
                    total /= 255;
                }
                else
                {
                    maxCharDistPixel[i] = total;
                    total = 1;
                }
            }
            maxCharDistance = maxCharDistPixel[0] * maxCharDistPixel[1] * maxCharDistPixel[2];

            // Store max char distance in first position of randPosition
            int maxCharDistPosition = randPosition.Next(1, W * H);
            int maxCharY = maxCharDistPosition / W;
            int maxCharX = maxCharDistPosition - maxCharY * W;
            pixel = Color.FromArgb(maxCharDistPixel[0], maxCharDistPixel[1], maxCharDistPixel[2]);
            image.SetPixel(maxCharX, maxCharY, pixel);

            // Generate secret char pixel value that indicates last pixel
            int charAscii = 127;
            for (int i = 0; i < 256; i++)
            {
                if (!message.Contains((char)i))
                {
                    charAscii = i;
                    break;
                }
            }

            // Store secret char pixel value in second position of randPosition
            int charAsciiPosition = randPosition.Next(1, W * H);
            if (charAsciiPosition == maxCharDistPosition)
                charAsciiPosition++;
            int charAsciiY = charAsciiPosition / W;
            int charAsciiX = charAsciiPosition - charAsciiY * W;
            switch (randDataChar.Next(0, 3))
            {
                case 0:
                    pixel = Color.FromArgb(charAscii, pixel.G, pixel.B);
                    break;
                case 1:
                    pixel = Color.FromArgb(pixel.R, charAscii, pixel.B);
                    break;
                default:
                    pixel = Color.FromArgb(pixel.R, pixel.G, charAscii);
                    break;
            }
            image.SetPixel(charAsciiX, charAsciiY, pixel);

            // Hide the message
            int nextPixLoc, currPixLoc = 0;
            int x, y;
            int a, b;
            int secretChar;
            int newR = 0, newG = 0, newB = 0;
            int nthDifference = 0;
            for (int i = 0; i <= message.Length; i++)
            {
                if (i < message.Length)
                {
                    // Set the secret character to '@' if greater than 255
                    secretChar = (int)message[i];
                    if (secretChar > 255)
                        secretChar = 64;
                }
                else
                    secretChar = charAscii;

                // Get location of next secret char
                nextPixLoc = randPosition.Next(1, maxCharDistance + 1);

                // Calculate next secret char pixel
                y = (currPixLoc + nextPixLoc) / W;
                x = (currPixLoc + nextPixLoc) - (y * W);
                if (x >= W || y >= H)
                    break;
                else if ((x == maxCharX && y == maxCharY) || (x == charAsciiX && y == charAsciiY))
                    x++;
                currPixLoc += nextPixLoc;

                // Get pixel
                pixel = image.GetPixel(x, y);

                // Calculate new pixel's RGB values
                switch (randDataChar.Next(0, 3))
                {
                    case 0:  // R stores secret char
                        switch (randDataChar.Next(0, 2))
                        {
                            case 0:  // G ends in nth difference (where n < 10) && B contains charSum operation specifier
                                newR = -1;
                                for (int j = 0; j < 10; j++)
                                {
                                    int diff = randDifference.Next(0, 256);
                                    if (diff > secretChar)
                                    {
                                        a = diff + secretChar;
                                        b = diff - secretChar;

                                        if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = a;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 1;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.R - b) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = b;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = secretChar + diff;
                                        b = secretChar - diff;

                                        if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = a;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 3;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.R - b) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = b;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 4;
                                            }
                                        }
                                    }
                                }
                                // Set new G
                                newG = ((int)Math.Floor(pixel.G / 10.0)) * 10;
                                if (newG == 250)
                                    newG = 240;
                                newG += nthDifference;
                                break;
                            default:  // B ends in nth difference (where n < 10) && G contains charSum operation specifier
                                newR = -1;
                                for (int j = 0; j < 10; j++)
                                {
                                    int diff = randDifference.Next(0, 256);
                                    if (diff > secretChar)
                                    {
                                        a = diff + secretChar;
                                        b = diff - secretChar;

                                        if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = a;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 1;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.R - b) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = b;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = secretChar + diff;
                                        b = secretChar - diff;

                                        if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.R - a) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = a;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 3;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.R - b) < Math.Abs(pixel.R - newR) || newR == -1)
                                            {
                                                newR = b;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 4;
                                            }
                                        }
                                    }
                                }
                                // Set new B
                                newB = ((int)Math.Floor(pixel.B / 10.0)) * 10;
                                if (newB == 250)
                                    newB = 240;
                                newB += nthDifference;
                                break;
                        }
                        break;
                    case 1:  // G stores secret char
                        switch (randDataChar.Next(0, 2))
                        {
                            case 0:  // R ends in nth difference (where n < 10) && B contains charSum operation specifier
                                newG = -1;
                                for (int j = 0; j < 10; j++)
                                {
                                    int diff = randDifference.Next(0, 256);
                                    if (diff > secretChar)
                                    {
                                        a = diff + secretChar;
                                        b = diff - secretChar;

                                        if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = a;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 1;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.G - b) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = b;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = secretChar + diff;
                                        b = secretChar - diff;

                                        if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = a;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 3;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.G - b) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = b;
                                                nthDifference = j;
                                                newB = (((int)Math.Floor(pixel.B / 10.0)) * 10) + 4;
                                            }
                                        }
                                    }
                                }
                                // Set new R
                                newR = ((int)Math.Floor(pixel.R / 10.0)) * 10;
                                if (newR == 250)
                                    newR = 240;
                                newR += nthDifference;
                                break;
                            default:  // B ends in nth difference (where n < 10) && R contains charSum operation specifier
                                newG = -1;
                                for (int j = 0; j < 10; j++)
                                {
                                    int diff = randDifference.Next(0, 256);
                                    if (diff > secretChar)
                                    {
                                        a = diff + secretChar;
                                        b = diff - secretChar;

                                        if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = a;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 1;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.G - b) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = b;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = secretChar + diff;
                                        b = secretChar - diff;

                                        if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.G - a) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = a;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 3;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.G - b) < Math.Abs(pixel.G - newG) || newG == -1)
                                            {
                                                newG = b;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 4;
                                            }
                                        }
                                    }
                                }
                                // Set new B
                                newB = ((int)Math.Floor(pixel.B / 10.0)) * 10;
                                if (newB == 250)
                                    newB = 240;
                                newB += nthDifference;
                                break;
                        }
                        break;
                    default:  // B stores secret char
                        switch (randDataChar.Next(0, 2))
                        {
                            case 0:  // R ends in nth difference (where n < 10) && G contains charSum operation specifier
                                newB = -1;
                                for (int j = 0; j < 10; j++)
                                {
                                    int diff = randDifference.Next(0, 256);
                                    if (diff > secretChar)
                                    {
                                        a = diff + secretChar;
                                        b = diff - secretChar;

                                        if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = a;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 1;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.B - b) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = b;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = secretChar + diff;
                                        b = secretChar - diff;

                                        if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = a;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 3;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.B - b) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = b;
                                                nthDifference = j;
                                                newG = (((int)Math.Floor(pixel.G / 10.0)) * 10) + 4;
                                            }
                                        }
                                    }
                                }
                                // Set new R
                                newR = ((int)Math.Floor(pixel.R / 10.0)) * 10;
                                if (newR == 250)
                                    newR = 240;
                                newR += nthDifference;
                                break;
                            default:  // G ends in nth difference (where n < 10) && R contains charSum operation specifier
                                newB = -1;
                                for (int j = 0; j < 10; j++)
                                {
                                    int diff = randDifference.Next(0, 256);
                                    if (diff > secretChar)
                                    {
                                        a = diff + secretChar;
                                        b = diff - secretChar;

                                        if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = a;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 1;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.B - b) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = b;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 2;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = secretChar + diff;
                                        b = secretChar - diff;

                                        if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - b) && a < 256)
                                        {
                                            if (Math.Abs(pixel.B - a) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = a;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 3;
                                            }
                                        }
                                        else
                                        {
                                            if (Math.Abs(pixel.B - b) < Math.Abs(pixel.B - newB) || newB == -1)
                                            {
                                                newB = b;
                                                nthDifference = j;
                                                newR = (((int)Math.Floor(pixel.R / 10.0)) * 10) + 4;
                                            }
                                        }
                                    }
                                }
                                // Set new G
                                newG = ((int)Math.Floor(pixel.G / 10.0)) * 10;
                                if (newG == 250)
                                    newG = 240;
                                newG += nthDifference;
                                break;
                        }
                        break;
                }

                // Update pixel
                pixel = Color.FromArgb(newR, newG, newB);
                image.SetPixel(x, y, pixel);
            }
        }


        private int GenerateSeed(string str)
        {
            string seed = "";
            Random rand = null;
            foreach (char c in str)
            {
                rand = new Random(c);
                seed += rand.Next(0, 10).ToString();
            }
            return Int32.Parse(seed);
        }

        private string GetMessage(string messageSource)
        {
            /* Extract message */
            return File.ReadAllText(messageSource);
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
    }
}