using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class mainForm : Form
    {
        public mainForm(){
            InitializeComponent();
            btnOpen.Select();
            cmboKirsch.SelectedIndex = 0;
        }

        Bitmap theBitmapImage;
        Image  imageToSave=null;

        private void btnOpen_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK){
                theBitmapImage = openImage(fileDialog);
                leftPictureBox.Image  = theBitmapImage;
                rightPictureBox.Image = getHistogramBitmap(theBitmapImage,null,256,256);
            }
        }

        private void btnOpenSecond_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK){
                Bitmap bitmap = openImage(fileDialog);
                middlePictureBox.Image = bitmap;
                rightPictureBox.Image  = getHistogramBitmap(bitmap,null,256,256);
            }
        }

        private Bitmap openImage(OpenFileDialog fileDialog){
            String imageFilePath = fileDialog.FileName.ToLower();
            Bitmap bitmap = null;
            if(imageFilePath.EndsWith(".jpg")  || imageFilePath.EndsWith(".png") ||
                imageFilePath.EndsWith(".gif") || imageFilePath.EndsWith(".bmp") ||
                imageFilePath.EndsWith(".tiff")|| imageFilePath.EndsWith(".tif")){
                bitmap = new Bitmap(imageFilePath);
            }
            else if(imageFilePath.EndsWith(".ppm"))
                bitmap = GetPPMBitmap(imageFilePath);
            else
                MessageBox.Show("This type of files is not supported... yet.\n(Are you sure it's an image?)",
                    "Not Supported", MessageBoxButtons.OK);
            return bitmap;
        }

        private Bitmap GetPPMBitmap(String filePath){
            var reader = new BinaryReader(new FileStream(filePath, FileMode.Open));
            
            reader.ReadChar(); //Eat 'P' of type
            char type = reader.ReadChar(); //PPM MagicNumber
            if(type!='3' && type!='6'){
                MessageBox.Show("This file is not a real .PPM file.\nA .PPM file can only be of type P3 or P6.",
                        "What?", MessageBoxButtons.OK);
                return null;
            }
            reader.ReadChar(); //Eat newline

            char temp;
            String widthStr="", heightStr="";
            if((temp = reader.ReadChar())=='#') //Comment
                while((temp = reader.ReadChar())!='\n'){ /*do nothing*/ }
            else widthStr += temp;

            while((temp=reader.ReadChar())!=' ') //Width
                widthStr+=temp;
            while((temp=reader.ReadChar())>='0' && temp<='9') //Height
                heightStr+=temp;
            
            if(reader.ReadChar()!='2' || reader.ReadChar()!='5' || reader.ReadChar()!='5'){ //Levels
                MessageBox.Show("Sorry, only PPM's of 255 levels are currently supported.",
                        "Nope", MessageBoxButtons.OK);
                return null;
            }

            reader.ReadChar(); //Eat newline
            int width  = int.Parse(widthStr),
                height = int.Parse(heightStr);

            Bitmap bitmap = new Bitmap(width, height);

            /*****P3*****/
            if(type=='3')
                for(int y=0; y<height; y++) //Read the pixels
                    for(int x=0; x<width; x++){
                        String r="", g="", b="";
                        while((temp=reader.ReadChar())!=' ') r+=temp;
                        while((temp=reader.ReadChar())!=' ') g+=temp;
                        while((temp=reader.ReadChar())!=' ') b+=temp;

                        Color color = Color.FromArgb(int.Parse(r), int.Parse(g), int.Parse(b));
                        bitmap.SetPixel(x, y, color);
                    }

            /*****P6*****/
            else if(type=='6')
                for(int y=0; y<height; y++) //Read the pixels
                    for(int x=0; x<width; x++){
                        Color color = Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
                        bitmap.SetPixel(x, y, color);
                    }

            //Done.
            reader.Close();
            reader = null;
            return bitmap;
        }

        /*private void pictureBox_Click(object sender, EventArgs e){
            ((PictureBox)sender).Image = null;
        }*/

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = ((PictureBox)sender);
            if(pictureBox.Image != null){
                toolTip.Active = true;
                toolTip.SetToolTip(pictureBox, "Double click to save");
            }
            else
                toolTip.Active = false;
        }

        private void pictureBox_DoubleClick(object sender, MouseEventArgs e){
            //Save the image.
            if(((PictureBox)sender).Image!=null){
                saveDialog.FileName = "image.png";
                saveDialog.Filter   = "PNG|*.png|All files|*.*";
                imageToSave = ((PictureBox)sender).Image;
                saveDialog.ShowDialog();
            }
        }

        private void saveDialog_FileOk(object sender, CancelEventArgs e){
            imageToSave.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            imageToSave = null;
        }

        private void btnTask1Apply_Click(object sender, EventArgs e){
            if(leftPictureBox.Image==null){
                MessageBox.Show("Sorry, we don't support 0×0 pictures yet.\nFuture updates? Who knows.",
                        "Empty", MessageBoxButtons.OK);
                return;
            }

            //The operation:
            int operation=0;
            if(rdioScale.Checked) operation=1; else if(rdioRotation.Checked) operation=2;
            else if(rdioShear.Checked) operation=3; else if(rdioAll.Checked) operation=4;
            else{
                MessageBox.Show("Choose an operation first.",
                        "NOOP (not n00b)", MessageBoxButtons.OK);
                return;
            }

            //Get operands:
            double scaleX=(double)numScaleX.Value, scaleY=(double)numScaleY.Value;
            double rotX=(double)numRotX.Value, rotY=(double)numRotY.Value, rotAngle=(double)numRotAngle.Value;
            double shearX=(double)numShearX.Value, shearY=(double)numShearY.Value;

            //Do it:
            rightPictureBox.Image = Transformations.Ops(theBitmapImage, operation, new double[]{scaleX,scaleY, rotX,rotY,rotAngle, shearX,shearY});
        }

        private Bitmap toGrayScale(Bitmap bitmap){
            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);
            for(int j=0; j<newBitmap.Height; j++)
                for(int i=0; i<newBitmap.Width; i++){
                    Color oldColor = bitmap.GetPixel(i, j);
                    int greyValue = (int)(0.2126*oldColor.R + 0.7152*oldColor.G + 0.0722*oldColor.B);
                    Color newColor = Color.FromArgb(greyValue,greyValue,greyValue);
                    newBitmap.SetPixel(i,j,newColor);
                }
            return newBitmap;
        }

        private Bitmap toNegative(Bitmap bitmap){
            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);
            for(int j=0; j<newBitmap.Height; j++)
                for(int i=0; i<newBitmap.Width; i++){
                    Color oldColor = bitmap.GetPixel(i, j);
                    int newR=255-oldColor.R, newG=255-oldColor.G, newB=255-oldColor.B;
                    Color newColor = Color.FromArgb(newR,newG,newB);
                    newBitmap.SetPixel(i,j,newColor);
                }
            return newBitmap;
        }

        public static int[,] getHistogramArray(Bitmap bitmap){
            int[,] histogram = new int[3,256];
            for(int j=0; j<bitmap.Height; j++)
                for(int i=0; i<bitmap.Width; i++){
                    Color pixel = bitmap.GetPixel(i,j);
                    histogram[0,pixel.R]++;
                    histogram[1,pixel.G]++;
                    histogram[2,pixel.B]++;
                }
            return histogram;
        }

        private Bitmap getHistogramBitmap(Bitmap bitmap, int[,] histogramArray, int histoWidth, int histoHeight){
            Bitmap histogramBitmap = new Bitmap(histoWidth, histoHeight);
            histogramArray = histogramArray==null ? getHistogramArray(bitmap) : histogramArray;

            int barWidth = histoWidth/256;
                barWidth = barWidth<=0 ? 1 : barWidth;
            double pixelCount = bitmap.Height*bitmap.Width;
            
            Pen penR = new Pen(Color.FromArgb(125,255,0,0), barWidth);
            Pen penG = new Pen(Color.FromArgb(125,0,255,0), barWidth);
            Pen penB = new Pen(Color.FromArgb(125,0,0,255), barWidth);

            for(int i=0; i<histogramArray.GetLength(1); i++){
                double probR = ((double)histogramArray[0,i]/pixelCount);
                double probG = ((double)histogramArray[1,i]/pixelCount);
                double probB = ((double)histogramArray[2,i]/pixelCount);

                int barHeightR = (int)(probR*histoHeight*20);
                int barHeightG = (int)(probG*histoHeight*20);
                int barHeightB = (int)(probB*histoHeight*20);

                using(Graphics graphics = Graphics.FromImage(histogramBitmap)){
                    graphics.DrawLine(penR, i*barWidth,histoHeight,i*barWidth,histoHeight-barHeightR); //Draw line into bitmap.
                    graphics.DrawLine(penG, i*barWidth,histoHeight,i*barWidth,histoHeight-barHeightG);
                    graphics.DrawLine(penB, i*barWidth,histoHeight,i*barWidth,histoHeight-barHeightB);
                }
            }

            return histogramBitmap;
        }

        private Bitmap contrast(Bitmap bitmap, int[,] histogram, int value){
            Bitmap newBitmap = new Bitmap(bitmap.Width,bitmap.Height);
            histogram = histogram==null ? getHistogramArray(bitmap) : histogram;

            int minR=-1, maxR=-1, minG=-1, maxG=-1, minB=-1, maxB=-1;

            for(int i=0; i<histogram.GetLength(1); i++){ //Get minimum.
                if(minR==-1) if(histogram[0,i]>0) minR=i;
                if(minG==-1) if(histogram[1,i]>0) minG=i;
                if(minB==-1) if(histogram[2,i]>0) minB=i;
            }
            for(int i=histogram.GetLength(1)-1; i>=0; i--){ //Get maximum.
                if(maxR==-1) if(histogram[0,i]>0) maxR=i;
                if(maxG==-1) if(histogram[1,i]>0) maxG=i;
                if(maxB==-1) if(histogram[2,i]>0) maxB=i;
            }

            for(int j=0; j<newBitmap.Height; j++)
                for(int i=0; i<newBitmap.Width; i++){
                    Color pixel = bitmap.GetPixel(i,j);
                    int newMinR=minR-value, newMaxR=maxR+value;
                    int newMinG=minG-value, newMaxG=maxG+value;
                    int newMinB=minB-value, newMaxB=maxB+value;
                    double newR = (double)((double)((double)pixel.R-(double)minR)/(double)((double)maxR-(double)minR)) * (double)((double)newMaxR-(double)newMinR)+(double)newMinR;
                    double newG = (double)((double)((double)pixel.G-(double)minG)/(double)((double)maxG-(double)minG)) * (double)((double)newMaxG-(double)newMinG)+(double)newMinG;
                    double newB = (double)((double)((double)pixel.B-(double)minB)/(double)((double)maxB-(double)minB)) * (double)((double)newMaxB-(double)newMinB)+(double)newMinB;

                    newR=newR>255?255:newR; newR=newR<0?0:newR;
                    newG=newG>255?255:newG; newG=newG<0?0:newG;
                    newB=newB>255?255:newB; newB=newB<0?0:newB;

                    //Console.WriteLine("{0},{1},{2} -- {3},{4},{5}", pixel.R,pixel.G,pixel.B,newR,newG,newB);
                    newBitmap.SetPixel(i,j,Color.FromArgb((int)newR,(int)newG,(int)newB));
                }
            return newBitmap;
        }

        public static int[,] getRoundArray(int[,] histogram, int width, int height){
            int[,] runningSum = new int[histogram.GetLength(0), histogram.GetLength(1)];
            int[,] round = new int[histogram.GetLength(0), histogram.GetLength(1)];
            runningSum[0,0]=histogram[0,0]; runningSum[1,0]=histogram[1,0]; runningSum[2,0]=histogram[2,0];

            for(int i=0; i<histogram.GetLength(0); i++)
                for(int j=1; j<histogram.GetLength(1); j++){
                    runningSum[i,j] = runningSum[i,j-1]+histogram[i,j];
                    double roundValue = ((double)runningSum[i,j] / ((double)width*(double)height)) * (double)histogram.GetLength(1)-1;
                    round[i,j] = (int)Math.Round(roundValue,0);
                    round[i,j] = round[i,j]<0 ? 0 : round[i,j];
                    round[i,j] = round[i,j]>255 ? 255 : round[i,j];
                    //Console.WriteLine("{0}+{1} = {2}",runningSum[i,i-1],histogram[i,i],runningSum[i,i]);
                    //Console.WriteLine("{0}/{1}*{2} = {3} ({4})",runningSum[i,i],width*height,histogram.GetLength(1)-1,roundValue,round[i,i]);
                }

            return round;
        }

        private Bitmap equalization(Bitmap bitmap, int[,] histogram){
            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            histogram = histogram == null ? getHistogramArray(bitmap) : histogram;

            int[,] round = getRoundArray(histogram,bitmap.Width,bitmap.Height);

            for(int j=0; j<bitmap.Height; j++)
                for(int i=0; i<bitmap.Width; i++){
                    Color oldColor = bitmap.GetPixel(i,j);
                    Color newColor = Color.FromArgb(round[0,oldColor.R], round[1,oldColor.G], round[2,oldColor.B]);
                    newBitmap.SetPixel(i,j,newColor);
                }

            return newBitmap;
        }


        private void btnGrayscale_Click(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            Bitmap bitmap = toGrayScale(theBitmapImage);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void btnNegative_Click(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            Bitmap bitmap = toNegative(theBitmapImage);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void btnEqualize_Click(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            Bitmap bitmap = equalization(theBitmapImage,null);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void slideContrast_ValueChanged(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            int value = ((TrackBar)sender).Value;
            Bitmap bitmap = contrast(theBitmapImage,null,value);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void slideBrightness_ValueChanged(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            int value = ((TrackBar)sender).Value;
            Bitmap bitmap = new Enhancments().Bright(theBitmapImage,value);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void slideGamma_ValueChanged(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            int value = ((TrackBar)sender).Value;
            Bitmap bitmap = new Enhancments().Gamma(theBitmapImage,(double)value/10);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void btnSlice_Click(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            Bitmap bitmap = new Enhancments().BitSlice(theBitmapImage,txtBitMask.Text);
            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void btnMatch_Click(object sender, EventArgs e){
            if(theBitmapImage==null||middlePictureBox.Image==null) return;
            Bitmap bitmap = new Enhancments().Match(theBitmapImage,(Bitmap)middlePictureBox.Image);
            rightPictureBox.Image = bitmap;
        }

        private void btnSubtract_Click(object sender, EventArgs e){
            if(theBitmapImage==null||middlePictureBox.Image==null) return;
            Bitmap bitmap = new Enhancments().Arithmetic(theBitmapImage,(Bitmap)middlePictureBox.Image,0,2);
            rightPictureBox.Image = bitmap;
        }

        private void btnAdd_Click(object sender, EventArgs e){
            if(theBitmapImage==null||middlePictureBox.Image==null) return;
            Bitmap bitmap = new Enhancments().Arithmetic(theBitmapImage,(Bitmap)middlePictureBox.Image,(double)numAddFraction.Value,1);
            rightPictureBox.Image = bitmap;
        }

        private void btnOrgnlHisto_Click(object sender, EventArgs e){
            if(theBitmapImage==null) return;
            middlePictureBox.Image=null; middlePictureBox.Refresh();
            rightPictureBox.Image = getHistogramBitmap(theBitmapImage,null,256,256);
        }

        private void btnTask3Apply_Click(object sender, EventArgs e){
            Bitmap bitmap = null;
            if(rdioMean.Checked)
                bitmap = filters.Mean(theBitmapImage, (int)numMeanMaskWidth.Value, (int)numMeanMaskHeight.Value, (int)numMeanOriginX.Value, (int)numMeanOriginY.Value);
            else if(rdioGaussian.Checked){
                if(numGaussMaskSize.Value==0) bitmap = filters.Gaussian(theBitmapImage, (double)numGaussSigma.Value);
                else bitmap = filters.Gaussian(theBitmapImage, (int)numGaussMaskSize.Value, (double)numGaussSigma.Value);
            }
            else if(rdioUnsharp.Checked)
                bitmap = filters.highBoost(theBitmapImage, (int)numUnsharpMaskSize.Value, (double)numUnsharpSigma.Value, (double)numUnsharpK.Value);
            else if(rdioLaplaceSharp.Checked)
                bitmap = filters.LaplacianSharpen(theBitmapImage, 1);
            else if(rdioKirschEdge.Checked){
                KirschType type;
                if(cmboKirsch.SelectedIndex==0) type=KirschType.Horizontal;
                else if(cmboKirsch.SelectedIndex==1) type=KirschType.Vertical;
                else if(cmboKirsch.SelectedIndex==2) type=KirschType.Diagonal1;
                else if(cmboKirsch.SelectedIndex==3) type=KirschType.Diagonal2;
                else type=KirschType.Horizontal;
                bitmap = filters.kirsch(theBitmapImage, type);
            }

            middlePictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void btnMatlabApply_Click(object sender, EventArgs e){
            if(rdioRtnx.Checked)
                middlePictureBox.Image = new Dll_Handler().Retinex(theBitmapImage, (double)numRtnxSigma.Value);
            else if(rdioLHE.Checked)
                middlePictureBox.Image = new Dll_Handler().LocalHistEQ(theBitmapImage, (int)numLHEWindow.Value);
            else if(rdioStats.Checked)
                middlePictureBox.Image = new Dll_Handler().LocalStat(theBitmapImage,
                    (int)numStatsWindow.Value, (double)numStatsE.Value,
                    (double)numStatsK0.Value, (double)numStatsK1.Value, (double)numStatsK2.Value);
        }
    }
}