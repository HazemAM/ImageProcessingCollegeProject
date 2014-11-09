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
            f.CreateFilter( (double)1/((double)width*(double)height) );
            res = LinearFilter(inp,f,xOrig,yOrig,PostProcessing.No);
            return res;
        }

        private static Bitmap LinearFilter(Bitmap bitmap, Filter f, int originX, int originY, PostProcessing postProcessing)
        {
            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);
            double[,,] image = new double[3,bitmap.Width,bitmap.Height];

            double[,] mask = f.getFilter();
            int maskWidth = mask.GetLength(0);
            int maskHeight = mask.GetLength(1);

            double minR=double.MaxValue, minG=double.MaxValue, minB=double.MaxValue;
            double maxR=double.MinValue, maxG=double.MinValue, maxB=double.MinValue;

            for(int i=0; i<bitmap.Width; i++)
                for(int j=0; j<bitmap.Height; j++){
                    //Anything here happens to every pixel in the bitmap. Be careful.

                    //Applying mask:
                    double newR=0, newG=0, newB=0;
                    for(int k=0, a=i-originX; k<maskWidth; k++,a++) //K: mask width index. A: image pixel index.
                        for(int l=0, b=j-originY; l<maskHeight; l++,b++){
                            int newX=0, newY=0; //New positions if out of image boundaries.
                            if(a<0) newX=0;
                            else if(a>bitmap.Width-1)  newX=bitmap.Width-1;
                            else newX=a;
                            if(b<0) newY=0;
                            else if(b>bitmap.Height-1) newY=bitmap.Height-1;
                            else newY=b;

                            Color thePixel = bitmap.GetPixel(newX,newY);
                            newR += (double)thePixel.R * mask[k,l];
                            newG += (double)thePixel.G * mask[k,l];
                            newB += (double)thePixel.B * mask[k,l];
                        }

                    minR = newR<minR ? newR : minR; //Minimum value for normalization.
                    minG = newG<minG ? newG : minG;
                    minB = newB<minB ? newB : minB;

                    maxR = newR>maxR ? newR : maxR; //Maximum value for normalization.
                    maxG = newG>maxG ? newG : maxG;
                    maxB = newB>maxB ? newB : maxB;
                    
                    switch(postProcessing){
                        case(PostProcessing.CutOff):
                            newR = crop(newR);
                            newG = crop(newG);
                            newB = crop(newB);
                            break;
                        case(PostProcessing.Abs):
                            newR = Math.Abs(newR);
                            newG = Math.Abs(newG);
                            newB = Math.Abs(newB);
                            break;
                    }

                    //If normalization, add to matrix instead of setting the pixel:
                    if(postProcessing==PostProcessing.Normalization){
                        image[0,i,j] = newR;
                        image[1,i,j] = newG;
                        image[2,i,j] = newB;
                    }
                    else newBitmap.SetPixel(i,j, Color.FromArgb((int)newR,(int)newG,(int)newB));
                }

            if(postProcessing==PostProcessing.Normalization)
                normalize(newBitmap,image, minR,minG,minB, maxR,maxG,maxB);
            
            return newBitmap;
        }

        private static void normalize(Bitmap newBitmap, double[,,] image, double minR,double minG,double minB, double maxR,double maxG,double maxB){
            for(int i=0; i<image.GetLength(1); i++)
                for(int j=0; j<image.GetLength(2); j++){
                    double newR = crop( Enhancments.Calc(minR,maxR, 0,255, image[0,i,j]) );
                    double newG = crop( Enhancments.Calc(minG,maxG, 0,255, image[1,i,j]) );
                    double newB = crop( Enhancments.Calc(minB,maxB, 0,255, image[2,i,j]) );

                    Color newPixel = Color.FromArgb((int)newR, (int)newG, (int)newB);
                    newBitmap.SetPixel(i,j,newPixel);
                }
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
        static public Bitmap highBoost(Bitmap inp,double size,double sigma,double k)
        {
            double[][,] main = getArr(inp);
            Bitmap blurred;
            if(size==0) blurred = Gaussian(inp,sigma);
            else blurred = Gaussian(inp,(int)size,sigma);
            double[][,] blu = getArr(blurred);
            double[][,] msk = new double [3][,];
            msk[0] = new double[inp.Width, inp.Height];
            msk[1] = new double[inp.Width, inp.Height];
            msk[2] = new double[inp.Width, inp.Height];
            for (int i = 0; i < inp.Width; i++)
                for (int j = 0; j < inp.Height; j++)
                {
                    msk[0][i, j] = main[0][i, j] - blu[0][i, j];
                    msk[1][i, j] = main[1][i, j] - blu[1][i, j];
                    msk[2][i, j] = main[2][i, j] - blu[2][i, j];
                }
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
        public static double crop(double value)
        {
            if(value>255)    value=255;
            else if(value<0) value=0;
            return value;
        }
        static public Bitmap kirsch(Bitmap inp, KirschType t)
        {
            Bitmap res = new Bitmap(inp);
            Filter f = new Filter(3, 3);
            f.CreateFilter();
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
            res = LinearFilter(inp,f,1,1,PostProcessing.Normalization);
            return res;
        }
        
        public static Bitmap Gaussian(Bitmap bitmap, int maskSize, double sigma){
            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);

            Filter f = new Filter(maskSize,maskSize);
            f.CreateFilter();
            double[,] mask = f.getFilter();

            double sum=0, x=-((double)maskSize/2), y=0;
            for(int i=0; i<mask.GetLength(0); i++,x++){
                y = -((double)maskSize/2);
                for(int j=0; j<mask.GetLength(0); j++,y++){
                    mask[i,j] = gaussianCalc(x,y,sigma);
                    sum += mask[i,j];
                }
            }

            for(int i=0; i<mask.GetLength(0); i++) //Normalizing (to: mask.Sum()=1)
                for(int j=0; j<mask.GetLength(0); j++)
                    mask[i,j] /= sum;

            newBitmap = LinearFilter(bitmap, f, (int)maskSize/2, (int)maskSize/2, PostProcessing.No);
            return newBitmap;
        }

        public static Bitmap Gaussian(Bitmap bitmap, double sigma){
            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);

            double maskSize = (2*((3.7*sigma)-0.5))+1;
            maskSize = (int)maskSize;

            Filter f = new Filter((int)maskSize,(int)maskSize);
            f.CreateFilter();
            double[,] mask = f.getFilter();

            double x=-((double)maskSize/2), y=0;
            for(int i=0; i<mask.GetLength(0); i++,x++){
                y = -((double)maskSize/2);
                for(int j=0; j<mask.GetLength(0); j++,y++){
                    double value = 1/(2*Math.PI*Math.Pow(sigma,2));
                    mask[i,j] = value * gaussianCalc(x,y,sigma);
                }
            }

            newBitmap = LinearFilter(bitmap, f, (int)maskSize/2, (int)maskSize/2, PostProcessing.No);
            return newBitmap;
        }

        private static double gaussianCalc(double x, double y, double sigma)
        {
            return Math.Exp(  -(((Math.Pow(x,2))+(Math.Pow(y,2)))/(2*(Math.Pow(sigma,2))))  );
        }
    }
}
