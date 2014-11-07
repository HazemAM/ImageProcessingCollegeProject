using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageProcessing
{
    class filters
    {
        static public Bitmap  Mean(Bitmap inp,int width,int height,int xOrig,int yOrig)
        {
            Bitmap res=new Bitmap(inp);
            Filter f = new Filter(width, height);
            f.CreateFilter(1/(width*height));
            res = LinearFilter(inp,f,xOrig,yOrig,PostProcessing.No);
            return res;
        }

        private static Bitmap LinearFilter(Bitmap inp, Filter f, int xOrig, int yOrig, PostProcessing postProcessing)
        {
            throw new NotImplementedException();
        }
        static public Bitmap LaplacianSharpen(Bitmap inp, int type)
        {
            Bitmap res = new Bitmap(inp);
            Filter f = new Filter(3,3);
            f.CreateFilter();
            double[,] filter = f.getFilter();
            if (type == 0)
            {
                filter[0, 0] = 0;
                filter[0, 1] = -1;
                filter[0, 2] = 0;
                filter[1, 0] = -1;
                filter[1, 1] = 5;
                filter[1, 2] = -1;
                filter[2, 0] = 0;
                filter[2, 1] = -1;
                filter[2, 2] = 0;
            }
            else if (type == 1)
            {
                filter[0, 0] = -1;
                filter[0, 1] = -1;
                filter[0, 2] = -1;
                filter[1, 0] = -1;
                filter[1, 1] = 9;
                filter[1, 2] = -1;
                filter[2, 0] = -1;
                filter[2, 1] = -1;
                filter[2, 2] = -1;
            }
            else if (type == 2)
            {
                filter[0, 0] = 0;
                filter[0, 1] = -1;
                filter[0, 2] = 0;
                filter[1, 0] = -1;
                filter[1, 1] = 4;
                filter[1, 2] = -1;
                filter[2, 0] = 0;
                filter[2, 1] = -1;
                filter[2, 2] = 0;
            }
            res = LinearFilter(inp, f, 1,1, PostProcessing.CutOff);
            return res;
        }
        static public Bitmap highBoost(Bitmap inp, int size,double sigma,double k)
        {
            Bitmap blurred=Gaussian(inp,size,sigma);
            Bitmap mask= new Enhancments().Arithmetic(inp, blurred, 1, 2);
            double[][,] main = getArr(inp);
            double[][,] msk = getArr(mask);
            for(int i=0;i<inp.Width;i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    main[0][i, j] += k * msk[0][i, j];
                    main[1][i, j] += k * msk[1][i, j];
                    main[2][i, j] += k * msk[2][i, j];
                    main[0][i, j] =crop(main[0][i, j]);
                    main[1][i, j] = crop(main[1][i, j]);
                    main[2][i, j] = crop(main[2][i, j]);
                }
            return getImg(inp,main);
        }

        private static double[][,] getArr(Bitmap inp)
        {
            double [][,] img=new double [3][,];
            img[0] = new double[inp.Width, inp.Height];
            img[1] = new double[inp.Width, inp.Height];
            img[2] = new double[inp.Width, inp.Height];
            for(int i=0;i<inp.Width;i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    Color temp=inp.GetPixel(i,j);
                    img[0][i,j] = temp.R;
                    img[1][i, j] = temp.G;
                    img[2][i, j] = temp.B;
                }
            return img;
        }
        private static Bitmap getImg(Bitmap inp,double [][,] arr)
        {
            Bitmap img = new Bitmap(inp);
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    img.SetPixel(i,j,Color.FromArgb((int)arr[0][i,j],(int)arr[1][i,j],(int)arr[2][i,j]));
                }
            return img;
        }
        private static double crop(double value)
        {
            if (value > 255)
                value = 255;
            else if (value < 0)
                value = 0;
            return value;
        }
        static public Bitmap kirsch(Bitmap inp, KirschType t)
        {
            Bitmap res = new Bitmap(inp);
            Filter f = new Filter(3, 3);
            double[,] filter = f.getFilter();
            if (t == KirschType.Horizontal)
            {
                filter[0, 0] = 5;
                filter[0, 1] = 5;
                filter[0, 2] = 5;
                filter[1, 0] = -3;
                filter[1, 1] = 0;
                filter[1, 2] = -3;
                filter[2, 0] = -3;
                filter[2, 1] = -3;
                filter[2, 2] = -3;
            }
            if (t == KirschType.Vertical)
            {
                filter[0, 0] = 5;
                filter[0, 1] = -3;
                filter[0, 2] = -3;
                filter[1, 0] = 5;
                filter[1, 1] = 0;
                filter[1, 2] = -3;
                filter[2, 0] = 5;
                filter[2, 1] = -3;
                filter[2, 2] = -3;
            }
            if (t == KirschType.Diagonal1) //diagonal \
            {
                filter[0, 0] = -3;
                filter[0, 1] = 5;
                filter[0, 2] = 5;
                filter[1, 0] = -3;
                filter[1, 1] = 0;
                filter[1, 2] = 5;
                filter[2, 0] = -3;
                filter[2, 1] = -3;
                filter[2, 2] = -3;
            }
            if (t == KirschType.Diagonal2)//diagonal /
            {
                filter[0, 0] = 5;
                filter[0, 1] = 5;
                filter[0, 2] = -3;
                filter[1, 0] = 5;
                filter[1, 1] = 0;
                filter[1, 2] = -3;
                filter[2, 0] = -3;
                filter[2, 1] = -3;
                filter[2, 2] = -3;
            }
            LinearFilter(inp,f,1,1,PostProcessing.Normalization);
            return res;
        }
        private static Bitmap Gaussian(Bitmap inp, int size, double sigma)
        {
            throw new NotImplementedException();
        }
    }
}
