using System;
using System.Collections.Generic;
using System.Text;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MatlabFilters;
using System.Drawing;

namespace ImageProcessing
{
    class Dll_Handler
    {
        private MLFilters handler1;
        public Dll_Handler()
        {
            handler1 = new MLFilters();
        }
        public Bitmap LocalHistEQ(Bitmap inp, double size)
        {
            Bitmap res = new Bitmap(inp);
            double[,,]im=getArr(inp);
            MWArray re=handler1.LocalHE((MWNumericArray)im,size);
            double[,,]tem=(double[,,])re.ToArray();
            res=getImg(inp,tem);
            return res;
        }
        public Bitmap LocalStat(Bitmap inp, double size,double E,double K0,double K1,double K2)
        {
            Bitmap res = new Bitmap(inp);
            double[,,]im=getArr(inp);
            MWArray re=handler1.LocalStatistics((MWNumericArray)im,size,E,K0,K1,K2);
            double[, ,] tem = (double[,,])re.ToArray();
            res=getImg(inp,tem);
            return res;
        }
        public Bitmap Retinex(Bitmap inp, double sigma)
        {
            Bitmap res = new Bitmap(inp);
            double[, ,] im = getArr(inp);
            MWArray re = handler1.SSR((MWNumericArray)im, sigma);
            double[, ,] tem = (double[, ,])re.ToArray();
            res = getImg(inp, tem);
            return res;
        }
        private static double[,,] getArr(Bitmap inp)
        {
            double[,,] img = new double[inp.Width, inp.Height, 3];
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    Color temp = inp.GetPixel(i, j);
                    img[i, j,0] = temp.R;
                    img[i, j,1] = temp.G;
                    img[i, j,2] = temp.B;
                }
            return img;
        }
        private static Bitmap getImg(Bitmap inp, double[,,] arr)
        {
            Bitmap img = new Bitmap(inp);
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)arr[i, j,0], (int)arr[i, j,1], (int)arr[i, j,2]));
                }
            return img;
        }
    }
}
