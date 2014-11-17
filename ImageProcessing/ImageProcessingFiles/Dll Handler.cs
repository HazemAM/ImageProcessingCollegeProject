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
            double[][,] im = getArr(inp);
            MWArray re = handler1.LocalHE((MWNumericArray)im[0], size);
            double[,] tem = (double[,])re.ToArray();
            re = handler1.LocalHE((MWNumericArray)im[1], size);
            double[,] tem1 = (double[,])re.ToArray();
            re = handler1.LocalHE((MWNumericArray)im[2], size);
            double[,] tem2 = (double[,])re.ToArray();
            res = getImg(inp, tem, tem1, tem2);
            return res;
        }
        public Bitmap LocalStat(Bitmap inp, double size, double E, double K0, double K1, double K2)
        {
            Bitmap res = new Bitmap(inp);
            double[][,] im = getArr(inp);
            MWArray re = handler1.LocalStatistics((MWNumericArray)im[0], size, E, K0, K1, K2);
            double[,] tem = (double[,])re.ToArray();
            re = handler1.LocalStatistics((MWNumericArray)im[1], size, E, K0, K1, K2);
            double[,] tem1 = (double[,])re.ToArray();
            re = handler1.LocalStatistics((MWNumericArray)im[2], size, E, K0, K1, K2);
            double[,] tem2 = (double[,])re.ToArray();
            res = getImg(inp, tem, tem1, tem2);
            return res;
        }
        public Bitmap Retinex(Bitmap inp, double sigma)
        {
            Bitmap res = new Bitmap(inp);
            double[][,] im = getArr(inp);
            MWArray re = handler1.SSR((MWNumericArray)im[0], sigma);
            byte[,] tem = (byte[,])re.ToArray();
            re = handler1.SSR((MWNumericArray)im[1], sigma);
            byte[,] tem1 = (byte[,])re.ToArray();
            re = handler1.SSR((MWNumericArray)im[2], sigma);
            byte[,] tem2 = (byte[,])re.ToArray();
            res = getImg(inp, tem, tem1, tem2);
            return res;
        }
        private static double[][,] getArr(Bitmap inp)
        {
            double[][,] img = new double[3][,];
            img[0] = new double[inp.Width, inp.Height];
            img[1] = new double[inp.Width, inp.Height];
            img[2] = new double[inp.Width, inp.Height];
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    Color temp = inp.GetPixel(i, j);
                    img[0][i, j] = temp.R;
                    img[1][i, j] = temp.G;
                    img[2][i, j] = temp.B;
                }
            return img;
        }
        
        private static Bitmap getImg(Bitmap inp, double[,] arr, double[,] arr1, double[,] arr2)
        {
            Bitmap img = new Bitmap(inp);
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)arr[i, j], (int)arr1[i, j], (int)arr2[i, j]));
                }
            return img;
        }
        private static Bitmap getImg(Bitmap inp, byte[,] arr, byte[,] arr1, byte[,] arr2)
        {
            Bitmap img = new Bitmap(inp);
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    img.SetPixel(i, j, Color.FromArgb((int)arr[i, j], (int)arr1[i, j], (int)arr2[i, j]));
                }
            return img;
        }
    }
}
