using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleImageViewer
{
    class Program
    {
        //C:\Users\boxin\Documents\bitmaptest\carrr.png
        static void Main(string[] args)
        {
            while (true)
            {
                //C:\Users\boxin\Documents\Games\Console Image Renderer\img.png
                Console.WriteLine("Type image directory: ");
                string directory = Console.ReadLine();
                directory.Replace(@"\", "/");
                Bitmap bmp = new Bitmap(directory);
                string toprint = "";
                int allpx = bmp.Width * bmp.Height;
                int currentpx = 0;

                Console.WriteLine("(As INT) How much do you want to divide the img resolution by? usually 10-15 for hi res and 5-10 for low");
                int divide = int.Parse(Console.ReadLine());
                string addtop = "";
                toprint = "||";
                for (int i = 0; i < bmp.Height / divide; i++)
                {
                    addtop += "-";
                }
                addtop += "\n";
                toprint += addtop + addtop;
                for (int x = 0; x < bmp.Height / divide; x++)
                {
                    for (int y = 0; y < bmp.Width / divide; y++)
                    {
                        currentpx++;
                        string toadd = "  ";
                        Color pixel = bmp.GetPixel(y * divide, x * divide);
                        if (pixel.R + pixel.G + pixel.B + pixel.A > 0)
                        {

                            if ((pixel.R + pixel.G + pixel.B) >= 5 * 3)
                            {
                                toadd = "-.";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 25 * 3)
                            {
                                toadd = "^.";
                            }

                            if ((pixel.R + pixel.G + pixel.B) >= 50 * 3)
                            {
                                toadd = "^,";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 80 * 3)
                            {
                                toadd = "^^";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 120 * 3)
                            {
                                toadd = "^%";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 150 * 3)
                            {
                                toadd = "<>";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 170 * 3)
                            {
                                toadd = "&>";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 190 * 3)
                            {
                                toadd = "&#";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 200 * 3)
                            {
                                toadd = "&&";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 220 * 3)
                            {
                                toadd = "##";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 235 * 3)
                            {
                                toadd = "%%";
                            }
                            if ((pixel.R + pixel.G + pixel.B) >= 250 * 3)
                            {
                                toadd = "@@";
                            }


                        }

                        Console.WriteLine(currentpx + "," + float.Parse(currentpx/divide + "")/( float.Parse(allpx/divide+"")));
                        toprint += toadd;
                    }
                    toprint += "||\n||";
                }
                Console.WriteLine(toprint);
            }
            
            while (true)
            {

            }
        }
    }
}
