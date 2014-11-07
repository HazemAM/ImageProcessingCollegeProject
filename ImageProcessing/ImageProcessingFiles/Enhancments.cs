using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageProcessing
{
    class Enhancments
    {
        public Bitmap Bright(Bitmap bitmap, int offset)
        {
            Bitmap img = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color temp = bitmap.GetPixel(i, j);
                    int r = temp.R+offset;
                    int g = temp.G + offset;
                    int b = temp.B + offset;
                    r=crop(r);
                    g=crop(g);
                    b=crop(b);
                    img.SetPixel(i,j,Color.FromArgb(r,g,b));
                }
            }
            return img;
        }

        public Bitmap Gamma(Bitmap img, double gamma)
        {
            double[][,] res = new double[3] [,];
            res[0] = new double[img.Width, img.Height];
            res[1] = new double[img.Width, img.Height];
            res[2] = new double[img.Width, img.Height];
            Bitmap res2 = new Bitmap(img);
            double[] min = new double[] { 256, 256, 256 };
            double[] max = new double[] { -1, -1, -1 };
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color temp = img.GetPixel(i, j);
                    double r = Math.Pow(temp.R,gamma);
                    double g = Math.Pow(temp.G, gamma);
                    double b = Math.Pow(temp.B, gamma);
                    r = r < 0 ? 0 : r;
                    g = g < 0 ? 0 : g;
                    b = b < 0 ? 0 : b;
                    max[0]= r>max[0] ? r:max[0];
                    max[1] = g > max[1] ? g : max[1];
                    max[2] = b > max[2] ? b : max[2];
                    min[0] = r < min[0] ? r : min[0];
                    min[1] = g < min[1] ? g : min[1];
                    min[2] = b < min[2] ? b : min[2];
                    res[0][i,j]=r;
                    res[1][i, j] = g;
                    res[2][i, j] = b;
                }
            }
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    double or =res[0][i,j];
                    double og =res[1][i, j];
                    double ob =res[2][i, j];
                    or = Calc(min[0], max[0], 0, 255, or);
                    og = Calc(min[1], max[1], 0, 255, og);
                    ob = Calc(min[2], max[2], 0, 255, ob);
                    or = or > 255 ? 255 : or; or = or < 0 ? 0 : or;
                    og = og > 255 ? 255 : og; og = og < 0 ? 0 : og;
                    ob = ob > 255 ? 255 : ob; ob = ob < 0 ? 0 : ob;
                    res2.SetPixel(i, j, Color.FromArgb((int)or,(int) og,(int) ob));
                }
            }
            return res2;
        }

        public Bitmap Match(Bitmap img1, Bitmap img2)
        {
            Bitmap res = new Bitmap(img1);
            int[,] hist = mainForm.getHistogramArray(img1);
            int[,] hist2 = mainForm.getHistogramArray(img2);
            int[,] reshist = new int[3, 256];
            int index;
            hist = mainForm.getRoundArray(hist,img1.Width,img1.Height);
            hist2 = mainForm.getRoundArray(hist2,img2.Width,img2.Height);
            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; j <3 ; j++)
                {
                    index=getNearest(hist, hist2, j, i);
                    reshist[j, i] = hist2[j, index];
                }
            }
            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    byte r;
                    byte g;
                    byte b;
                    r=(byte)reshist[0,(int)img1.GetPixel(i,j).R];
                    g=(byte)reshist[1,(int)img1.GetPixel(i,j).G];
                    b=(byte)reshist[2,(int)img1.GetPixel(i,j).B];
                    res.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return res;
        }

        private int getNearest(int[,] input1, int[,] input2, int i,int k)
        {
            int index=0;
            int min = 256;
            int temp;
            for (int j = 0; j < 255; j++)
            {
                 temp=Math.Abs(input1[i,k]-input2[i,j]);
                 if (temp < min)
                 {
                     min = temp;
                     index = j;
                 }
            }
                return index;
        }

        private int crop(int value)
        {
            if (value > 255)
                value = 255;
            else if (value < 0)
                value = 0;
            return value;
        }

        private int Calc(double oldmin, double oldMax, int NewMin, int newMax, double value)
        {

            return (int)Math.Round(((value - oldmin) / (oldMax - oldmin)) * (newMax - NewMin) + NewMin);
        }

        public Bitmap Arithmetic(Bitmap img1, Bitmap img2, double fraction, int mode)
        {
            Bitmap res = new Bitmap(img1);
            Bitmap temp = new Bitmap(img2, img1.Size);
            if (mode == 1)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        int r1 = img1.GetPixel(i, j).R;
                        int g1 = img1.GetPixel(i, j).G;
                        int b1 = img1.GetPixel(i, j).B;
                        int r2 = temp.GetPixel(i, j).R;
                        int g2 = temp.GetPixel(i, j).G;
                        int b2 = temp.GetPixel(i, j).B;
                        r1 = (int)(r1 * fraction + r2 * (1 - fraction));
                        g1 = (int)(g1 * fraction + g2 * (1 - fraction));
                        b1 = (int)(b1 * fraction + b2 * (1 - fraction));
                        res.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }
                }
                return res;
            }
            else if (mode == 2)
            {
                double[] min = new double[] { 256, 256, 256 };
                double[] max = new double[] { -1, -1, -1 };
                double[][,] re = new double[3][,];
                re[0] = new double[img1.Width, img1.Height];
                re[1] = new double[img1.Width, img1.Height];
                re[2] = new double[img1.Width, img1.Height];
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        int r1 = img1.GetPixel(i, j).R;
                        int g1 = img1.GetPixel(i, j).G;
                        int b1 = img1.GetPixel(i, j).B;
                        int r2 = temp.GetPixel(i, j).R;
                        int g2 = temp.GetPixel(i, j).G;
                        int b2 = temp.GetPixel(i, j).B;
                        re[0][i,j] = r1-r2;
                        re[1][i, j] = g1 - g2;
                        re[2][i, j] = b1 - b2;
                        max[0] = re[0][i, j] > max[0] ? re[0][i, j] : max[0];
                        max[1] = re[1][i, j] > max[1] ? re[1][i, j] : max[1];
                        max[2] = re[2][i, j] > max[2] ? re[2][i, j] : max[2];
                        min[0] = re[0][i, j] < min[0] ? re[0][i, j] : min[0];
                        min[1] = re[1][i, j] < min[1] ? re[1][i, j] : min[1];
                        min[2] = re[2][i, j] < min[2] ? re[2][i, j] : min[2];
                        
                    }
                }
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        double or = re[0][i, j];
                        double og = re[1][i, j];
                        double ob = re[2][i, j];
                        or = Calc(min[0], max[0], 0, 255, or);
                        og = Calc(min[1], max[1], 0, 255, og);
                        ob = Calc(min[2], max[2], 0, 255, ob);
                        res.SetPixel(i, j, Color.FromArgb((int)or, (int)og, (int)ob));
                    }
                }
                return res;
            }
            return null;
        }

        public Bitmap BitSlice(Bitmap bitmap, string mask)
        {
            Bitmap img = new Bitmap(bitmap.Width, bitmap.Height);
            int msk=Convert.ToInt32(mask,2);
             for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        int r = bitmap.GetPixel(i, j).R&msk;
                        int g = bitmap.GetPixel(i, j).G&msk;
                        int b = bitmap.GetPixel(i, j).B&msk;
                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
                return img;
        }
    }
   
}
