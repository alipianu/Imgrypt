using System;
using System.Drawing;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace Imgrypt
{
    class EncryptedFile
    {
        // File properties
        private readonly string password = "";
        private readonly int W, H;
        private Bitmap image = null;
        private string message = "";

        public EncryptedFile(string imageSource, string password)
        {
            // Initialize properties
            this.password = password;
            image = (Bitmap)Image.FromFile(imageSource);
            H = image.Size.Height;
            W = image.Size.Width;
        }

        public void Decrypt()
        {
            // Setup new pixel
            Color pixel = new Color();

            // Extract 3 words from password
            string[] pWords = password.Split(' ');

            // Generate random int sequences
            Random randPosition = new Random(GenerateSeed(pWords[0]));
            Random randDataChar = new Random(GenerateSeed(pWords[1]));
            Random randDifference = new Random(GenerateSeed(pWords[2]));

            // Get maxCharDistance
            int maxCharDistPosition = randPosition.Next(1, W * H);
            int maxCharY = maxCharDistPosition / W;
            int maxCharX = maxCharDistPosition - maxCharY * W;
            pixel = image.GetPixel(maxCharX, maxCharY);
            int maxCharDistance = pixel.R * pixel.G * pixel.B;

            // Get secret pixel ascii value that indicates last pixel
            int charAscii;
            int charAsciiPosition = randPosition.Next(1, W * H);
            if (charAsciiPosition == maxCharDistPosition)
                charAsciiPosition++;
            int charAsciiY = charAsciiPosition / W;
            int charAsciiX = charAsciiPosition - charAsciiY * W;
            pixel = image.GetPixel(charAsciiX, charAsciiY);
            switch (randDataChar.Next(0, 3))
            {
                case 0:
                    charAscii = pixel.R;
                    break;
                case 1:
                    charAscii = pixel.G;
                    break;
                default:
                    charAscii = pixel.B;
                    break;
            }

            // Extract the message
            int nextPixLoc = 0, currPixLoc = 0;
            int x, y;
            int secretChar;
            int[] differenceArray = new int[10];
            int diff;

            while (nextPixLoc < W * H)
            {
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

                // Get first 10 diferences
                for (int j = 0; j < 10; j++)
                    differenceArray[j] = randDifference.Next(0, 256);

                // Get secret character from pixel
                switch (randDataChar.Next(0, 3))
                {
                    case 0:  // R contains secret char
                        switch (randDataChar.Next(0, 2))
                        {
                            case 0:  // G ends in nth difference (where n < 10) && B contains charSum operation specifier
                                diff = differenceArray[pixel.G % 10];
                                switch (pixel.B % 10)
                                {
                                    case 1:
                                        secretChar = pixel.R - diff;
                                        break;
                                    case 2:
                                        secretChar = diff - pixel.R;
                                        break;
                                    case 3:
                                        secretChar = pixel.R - diff;
                                        break;
                                    default:
                                        secretChar = diff + pixel.R;
                                        break;
                                }
                                break;
                            default:  // B ends in nth difference (where n < 10) && G contains charSum operation specifier
                                diff = differenceArray[pixel.B % 10];
                                switch (pixel.G % 10)
                                {
                                    case 1:
                                        secretChar = pixel.R - diff;
                                        break;
                                    case 2:
                                        secretChar = diff - pixel.R;
                                        break;
                                    case 3:
                                        secretChar = pixel.R - diff;
                                        break;
                                    default:
                                        secretChar = diff + pixel.R;
                                        break;
                                }
                                break;
                        }
                        break;
                    case 1:  // G contains secret char
                        switch (randDataChar.Next(0, 2))
                        {
                            case 0:  // R ends in nth difference (where n < 10) && B contains charSum operation specifier
                                diff = differenceArray[pixel.R % 10];
                                switch (pixel.B % 10)
                                {
                                    case 1:
                                        secretChar = pixel.G - diff;
                                        break;
                                    case 2:
                                        secretChar = diff - pixel.G;
                                        break;
                                    case 3:
                                        secretChar = pixel.G - diff;
                                        break;
                                    default:
                                        secretChar = diff + pixel.G;
                                        break;
                                }
                                break;
                            default:  // B ends in nth difference (where n < 10) && R contains charSum operation specifier
                                diff = differenceArray[pixel.B % 10];
                                switch (pixel.R % 10)
                                {
                                    case 1:
                                        secretChar = pixel.G - diff;
                                        break;
                                    case 2:
                                        secretChar = diff - pixel.G;
                                        break;
                                    case 3:
                                        secretChar = pixel.G - diff;
                                        break;
                                    default:
                                        secretChar = diff + pixel.G;
                                        break;
                                }
                                break;
                        }
                        break;
                    default:  // B contains secret char
                        switch (randDataChar.Next(0, 2))
                        {
                            case 0:  // R ends in nth difference (where n < 10) && G contains charSum operation specifier
                                diff = differenceArray[pixel.R % 10];
                                switch (pixel.G % 10)
                                {
                                    case 1:
                                        secretChar = pixel.B - diff;
                                        break;
                                    case 2:
                                        secretChar = diff - pixel.B;
                                        break;
                                    case 3:
                                        secretChar = pixel.B - diff;
                                        break;
                                    default:
                                        secretChar = diff + pixel.B;
                                        break;
                                }
                                break;
                            default:  // G ends in nth difference (where n < 10) && R contains charSum operation specifier
                                diff = differenceArray[pixel.G % 10];
                                switch (pixel.R % 10)
                                {
                                    case 1:
                                        secretChar = pixel.B - diff;
                                        break;
                                    case 2:
                                        secretChar = diff - pixel.B;
                                        break;
                                    case 3:
                                        secretChar = pixel.B - diff;
                                        break;
                                    default:
                                        secretChar = diff + pixel.B;
                                        break;
                                }
                                break;
                        }
                        break;
                }

                if (secretChar == charAscii)
                    break;
                else
                    message += (char)secretChar;
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

        public void SaveMessage(string outputDirectory, string messageName, string messageExt)
        {
            object missing = Type.Missing;

            // Save message
            switch (messageExt)
            {
                case ".docx":  // Store in Microsoft Word file
                    // Create word application
                    Application word = new Application();
                    // Set animation status of word application
                    word.ShowAnimation = false;
                    // Set word application visibility to false
                    word.Visible = false;
                    // Create new document
                    Document doc = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    // Add text to document
                    doc.Content.SetRange(0, 0);
                    doc.Content.Text = message;
                    doc.SaveAs2(outputDirectory + "\\" + messageName + messageExt);
                    doc.Close();
                    break;
                default:  // Store in text file
                    File.WriteAllText(outputDirectory + "\\" + messageName + messageExt, message);
                    break;
            }
        }
    }
}
