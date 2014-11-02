using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageProcessing
{
    class Enhancments
    {
        public Bitmap Bright(Bitmap img,int offset)
        {
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color temp = img.GetPixel(i, j);
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
            double[,] nimg = new double[img.Width, img.Height];
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color temp = img.GetPixel(i, j);
                    int or = temp.R;
                    int og = temp.G;
                    int ob = temp.B;
                    double r = Math.Pow(temp.R,gamma);
                    double g = Math.Pow(temp.G, gamma);
                    double b = Math.Pow(temp.B, gamma);
                    or = Calc(0, (int)Math.Max(255, r), 0, 255, r);
                    og = Calc(0, (int)Math.Max(255, g), 0, 255, g);
                    ob = Calc(0, (int)Math.Max(255, b), 0, 255, b);
                    img.SetPixel(i,j,Color.FromArgb(or,og,ob));
                }
            }
            return img;
        }
        public Bitmap Match(Bitmap img1, Bitmap img2)
        {
            Bitmap res = new Bitmap(img1);
            int[,] hist = GetHist(img1);
            int[,] hist2 = GetHist(img2);
            int[,] reshist = new int[3, 256];
            int index;
            hist = HistEQ(hist);
            hist2 = HistEQ(hist2);
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

        private int[,] HistEQ(int[,] hist)
        {
            throw new NotImplementedException();
        }

        private int[,] GetHist(Bitmap img1)
        {
            throw new NotImplementedException();
        }

        private int[] Contrast(int[] hist)
        {
            throw new NotImplementedException();
        }
        private int getNearest(int[,] input1, int[,] input2, int i,int k)
        {
            int index=0;
            int min=Math.Abs(input1[i,0]-input2[i,0]);
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
        private int Calc(int oldmin, int oldMax, int NewMin, int newMax, double value)
        {

            return (int) ((value-oldmin)/(oldMax-oldmin))*(newMax-NewMin)+NewMin;
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
                        r1 = r1-r2;
                        g1 = g1 - g2;
                        b1 = b1 - b2;
                        r1 = crop(r1);
                        g1 = crop(g1);
                        b1 = crop(b1);
                        res.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }
                }
                return res;
            }
            return null;
        }
        public Bitmap BitSlice(Bitmap img,string mask)
        {
            int msk=Convert.ToInt32(mask,2);
             for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        int r = img.GetPixel(i, j).R&msk;
                        int g = img.GetPixel(i, j).G & msk;
                        int b = img.GetPixel(i, j).B & msk;
                        img.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
                return img;
        }
    }
   
}
