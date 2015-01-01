using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class mainForm : Form
    {
        List<string> supported = new List<string> {"png", "jpg", "bmp", "tif", "tiff", "gif", "ppm"};
        Bitmap theOriginalImage;
        Bitmap sliderCache;

        public mainForm(){
            InitializeComponent();
            
            btnOpen.Select();
            cmboKirsch.SelectedIndex = 0;
            cmboCustomPost.SelectedIndex = 0;
            showMiddleImage(false);

            leftPictureBox.AllowDrop = true;
            middlePictureBox.AllowDrop = true;

            setSliderListeners();
        }

        private void btnOpen_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK){
                Bitmap bitmap = openImage(fileDialog.FileName);

                if(bitmap != null){
                    theOriginalImage = bitmap;
                    leftPictureBox.Image  = theOriginalImage;
                    rightPictureBox.Image = getHistogramBitmap(theOriginalImage,null,256,256);
                }
            }
        }

        private void btnOpenSecond_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK){
                Bitmap bitmap = openImage(fileDialog.FileName);

                if(bitmap != null){
                    middlePictureBox.Image = bitmap;
                    rightPictureBox.Image  = getHistogramBitmap(bitmap,null,256,256);

                    chckSecondImage.Checked = true;
                }
            }
        }

        private Bitmap openImage(String filePath){
            string extension = Path.GetExtension(filePath).ToLower();
            extension = extension.Substring(1, extension.Length-1);

            Bitmap bitmap = null;
            if(extension == "ppm")
                bitmap = GetPPMBitmap(filePath);
            else if(supported.Contains(extension))
                bitmap = new Bitmap(filePath);
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
            if( (sender as PictureBox).Image != null ){
                imageSaveDialog.FileName = "image";
                imageSaveDialog.Filter   = "BMP|*.bmp|PNG|*.png|All files|*.*";
                Image imageToSave = (sender as PictureBox).Image;
                
                if(imageSaveDialog.ShowDialog() == DialogResult.OK){
                    ImageFormat format;
                    string extension = Path.GetExtension(imageSaveDialog.FileName);
                    
                    if(extension.ToLower()==".png") format=ImageFormat.Png;
                    else format=ImageFormat.Bmp;

                    imageToSave.Save(imageSaveDialog.FileName, format);
                    imageToSave = null;
                }
            }
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
            leftPictureBox.Image = Transformations.Ops((Bitmap)leftPictureBox.Image, operation, new double[]{scaleX,scaleY, rotX,rotY,rotAngle, shearX,shearY});
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
                    double roundValue = ((double)runningSum[i,j] / ((double)width*(double)height)) * ((double)histogram.GetLength(1)-1);
                    round[i,j] = (int)Math.Round(Math.Round(roundValue, 1, MidpointRounding.AwayFromZero), 0, MidpointRounding.AwayFromZero);
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
            Bitmap sourceImage = leftPictureBox.Image as Bitmap;
            if (sourceImage == null) return;

            Bitmap result = toGrayScale(sourceImage);
            leftPictureBox.Image = result;
            rightPictureBox.Image = getHistogramBitmap(result,null,256,256);
        }

        private void btnNegative_Click(object sender, EventArgs e){
            Bitmap sourceImage = leftPictureBox.Image as Bitmap;
            if(sourceImage==null) return;

            Bitmap result = toNegative(sourceImage);
            leftPictureBox.Image = result;
            rightPictureBox.Image = getHistogramBitmap(result,null,256,256);
        }

        private void btnEqualize_Click(object sender, EventArgs e){
            Bitmap sourceImage = leftPictureBox.Image as Bitmap;
            if(sourceImage==null) return;

            Bitmap result = equalization(sourceImage, null);
            leftPictureBox.Image = result;
            rightPictureBox.Image = getHistogramBitmap(result,null,256,256);
        }

        private void slideContrast_ValueChanged(object sender, EventArgs e){
            Bitmap sourceImage = sliderCache;
            if(sourceImage==null) return;

            int value = (sender as TrackBar).Value;
            Bitmap bitmap = contrast(sourceImage, null, value);
            leftPictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);

            toolTip.SetToolTip(sender as TrackBar, value.ToString());
        }

        private void slideBrightness_ValueChanged(object sender, EventArgs e){
            Bitmap sourceImage = sliderCache;
            if(sourceImage==null) return;

            int value = (sender as TrackBar).Value;
            Bitmap bitmap = new Enhancments().Bright(sourceImage, value);
            leftPictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);

            toolTip.SetToolTip(sender as TrackBar, value.ToString());
        }

        private void slideGamma_ValueChanged(object sender, EventArgs e){
            Bitmap sourceImage = sliderCache;
            if(sourceImage==null) return;

            double value = (double)(sender as TrackBar).Value / 10;
            Bitmap bitmap = new Enhancments().Gamma(sourceImage, value);
            leftPictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);

            toolTip.SetToolTip(sender as TrackBar, value.ToString());
        }

        private void btnSlice_Click(object sender, EventArgs e){
            Bitmap sourceImage = leftPictureBox.Image as Bitmap;
            if(sourceImage==null) return;

            Bitmap bitmap = new Enhancments().BitSlice(sourceImage, txtBitMask.Text);
            leftPictureBox.Image = bitmap;
            rightPictureBox.Image = getHistogramBitmap(bitmap,null,256,256);
        }

        private void btnMatch_Click(object sender, EventArgs e){
            Bitmap firstSourceImage = leftPictureBox.Image as Bitmap;
            Bitmap secondSourceImage = middlePictureBox.Image as Bitmap;
            if(firstSourceImage==null || secondSourceImage==null) return;

            Bitmap result = new Enhancments().Match(firstSourceImage, secondSourceImage);
            leftPictureBox.Image = result;

            rightPictureBox.Image = getHistogramBitmap(result,null,256,256);
            chckSecondImage.Checked = false;
        }

        private void btnSubtract_Click(object sender, EventArgs e){
            Bitmap firstSourceImage = leftPictureBox.Image as Bitmap;
            Bitmap secondSourceImage = middlePictureBox.Image as Bitmap;
            if(firstSourceImage==null || secondSourceImage==null) return;
            
            Bitmap result = new Enhancments().Arithmetic(firstSourceImage, secondSourceImage, 0,2);
            leftPictureBox.Image = result;

            rightPictureBox.Image = getHistogramBitmap(result,null,256,256);
            chckSecondImage.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e){
            Bitmap firstSourceImage = leftPictureBox.Image as Bitmap;
            Bitmap secondSourceImage = middlePictureBox.Image as Bitmap;
            if(firstSourceImage==null || secondSourceImage==null) return;

            Bitmap result = new Enhancments().Arithmetic(firstSourceImage, secondSourceImage, (double)numAddFraction.Value, 1);
            leftPictureBox.Image = result;

            rightPictureBox.Image = getHistogramBitmap(result,null,256,256);
            chckSecondImage.Checked = false;
        }

        private void btnRestoreOriginal_Click(object sender, EventArgs e){
            Bitmap sourceImage = theOriginalImage;
            if(sourceImage==null) return;

            leftPictureBox.Image=sourceImage; middlePictureBox.Refresh();
            rightPictureBox.Image = getHistogramBitmap(sourceImage,null,256,256);
        }

        private void btnTask3Apply_Click(object sender, EventArgs e){
            Bitmap sourceImage = leftPictureBox.Image as Bitmap;
            if(sourceImage == null) return;

            Bitmap resultImage = null;
            if(rdioMean.Checked)
                resultImage = Filters.Mean(sourceImage, (int)numMeanMaskWidth.Value, (int)numMeanMaskHeight.Value, (int)numMeanOriginX.Value, (int)numMeanOriginY.Value);
            else if(rdioGaussian.Checked){
                if(numGaussSigma.Value==0) return;
                if(numGaussMaskSize.Value==0) resultImage = Filters.Gaussian(sourceImage, (double)numGaussSigma.Value);
                else resultImage = Filters.Gaussian(sourceImage, (int)numGaussMaskSize.Value, (double)numGaussSigma.Value);
            }
            else if(rdioUnsharp.Checked)
                resultImage = Filters.highBoost(sourceImage, (int)numUnsharpMaskSize.Value, (double)numUnsharpSigma.Value, (double)numUnsharpK.Value);
            else if(rdioLaplaceSharp.Checked)
                resultImage = Filters.LaplacianSharpen(sourceImage, 1);
            else if(rdioKirschEdge.Checked){
                KirschType type;
                if(cmboKirsch.SelectedIndex==0) type=KirschType.Horizontal;
                else if(cmboKirsch.SelectedIndex==1) type=KirschType.Vertical;
                else if(cmboKirsch.SelectedIndex==2) type=KirschType.Diagonal1;
                else if(cmboKirsch.SelectedIndex==3) type=KirschType.Diagonal2;
                else type=KirschType.Horizontal;
                resultImage = Filters.kirsch(sourceImage, type);
            }

            leftPictureBox.Image = resultImage;
            rightPictureBox.Image = getHistogramBitmap(resultImage,null,256,256);
        }

        private void btnMatlabApply_Click(object sender, EventArgs e){
            Bitmap sourceImage = leftPictureBox.Image as Bitmap;
            if(sourceImage==null || rdioMLGaussian.Checked) return;

            Bitmap result = null;
            if(rdioRtnx.Checked)
                result = new DLLHandler().Retinex(sourceImage, (double)numRtnxSigma.Value);
            else if(rdioLHE.Checked)
                result = new DLLHandler().LocalHistEQ(sourceImage, (int)numLHEWindow.Value);
            else if(rdioStats.Checked)
                result = new DLLHandler().LocalStat(sourceImage,
                    (int)numStatsWindow.Value, (double)numStatsE.Value,
                    (double)numStatsK0.Value, (double)numStatsK1.Value, (double)numStatsK2.Value);
            //MATLAB gaussian filter is handled within the slider listener.

            leftPictureBox.Image = result;
            rightPictureBox.Image = getHistogramBitmap(result, null, 256, 256);
        }

        private void slideMLGaussian_Scroll(object sender, EventArgs e){
            Bitmap sourceImage = sliderCache;
            if(sourceImage==null) return;
            rdioMLGaussian.Checked = true;

            Bitmap result = null;
            double sigma = (double)(sender as TrackBar).Value / 10;
            if(sigma==0) return;

            if(sigma>0) result = new DLLHandler().GaussianBlur(sourceImage, sigma);
            leftPictureBox.Image = result;
            rightPictureBox.Image  = getHistogramBitmap(result, null, 256, 256);

            toolTip.SetToolTip(sender as TrackBar, sigma.ToString());
        }

        private void btnCustomApply_Click(object sender, EventArgs e){
            if(leftPictureBox.Image==null) return;

            String[] tempMaskString = txtCustomFilter.Text.Split(new String[]{Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            int maskWidth = tempMaskString[0].Split(new String[]{" "}, StringSplitOptions.RemoveEmptyEntries).Length;

            FilterNode f = new FilterNode(tempMaskString.GetLength(0),maskWidth); f.CreateFilter();
            double[,] mask = f.getFilter();

            try{
                for(int i=0; i<tempMaskString.Length; i++){
                    String[] tempMaskRowString = tempMaskString[i].Split(new String[]{" "}, StringSplitOptions.RemoveEmptyEntries);
                    for(int j=0; j<tempMaskRowString.Length; j++)
                        mask[i,j] = double.Parse(tempMaskRowString[j]);
                }
            } catch {
                MessageBox.Show("The mask is not in a right format.", "Format error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PostProcessing post = PostProcessing.No;
            switch(cmboCustomPost.SelectedIndex){
                case 0: post=PostProcessing.No; break;
                case 1: post=PostProcessing.Normalization; break;
                case 2: post=PostProcessing.Abs; break;
                case 3: post=PostProcessing.CutOff; break;
            }

            Bitmap bitmap = null;
            try{
                bitmap = Filters.LinearFilter(leftPictureBox.Image as Bitmap, f, (int)numCustomOriginX.Value, (int)numCustomOriginY.Value, post);
                leftPictureBox.Image = bitmap;
                rightPictureBox.Image = getHistogramBitmap(bitmap, null, 256, 256);
            } catch {
                MessageBox.Show("Something went wrong.\nMake sure you choose the right post-processing method.","Watch out!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showMiddleImage(bool show){
            if(show){
                imagesTableLayoutPanel.ColumnStyles[1].SizeType = SizeType.Percent;
                imagesTableLayoutPanel.ColumnStyles[1].Width = 50.0f;
            }
            else{
                middlePictureBox.Image = null;
                imagesTableLayoutPanel.ColumnStyles[1].SizeType = SizeType.Absolute;
                imagesTableLayoutPanel.ColumnStyles[1].Width = 0;
            }
        }

        private void chckSecondImage_CheckedChanged(object sender, EventArgs e){
            showMiddleImage( (sender as CheckBox).Checked );
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e){
            string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
            string extension = Path.GetExtension(filePaths[0]).ToLower();
            extension = extension.Substring(1, extension.Length-1);

            if(supported.Contains(extension))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e){
            PictureBox pictureBox = (sender as PictureBox);
            string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
            pictureBox.Image = theOriginalImage = openImage(filePaths[0]);

            if(pictureBox == leftPictureBox)
                rightPictureBox.Image = getHistogramBitmap(pictureBox.Image as Bitmap, null, 256, 256);
        }

        private void setSliderListeners(){
            slideContrast.Enter += slider_GotAndLostFocus;
            slideContrast.LostFocus += slider_GotAndLostFocus;

            slideBrightness.Enter += slider_GotAndLostFocus;
            slideGamma.LostFocus += slider_GotAndLostFocus;

            slideGamma.Enter += slider_GotAndLostFocus;
            slideGamma.LostFocus += slider_GotAndLostFocus;

            slideMLGaussian.Enter += slider_GotAndLostFocus;
            slideMLGaussian.LostFocus += slider_GotAndLostFocus;
        }

        private void slider_GotAndLostFocus(object sender, EventArgs e){
            sliderCache = leftPictureBox.Image as Bitmap;
        }

        private void btnOpenMask_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            
            if(fileDialog.ShowDialog() == DialogResult.OK)
                if(File.Exists(fileDialog.FileName)){
                    txtCustomFilter.Text = File.ReadAllText(fileDialog.FileName);
                    txtCustomFilter.Focus();
                }
        }

        private void btnSaveMask_Click(object sender, EventArgs e){
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = "mask";
            saveDialog.Filter = "Text files|*.txt|All files|*.*";

            if(saveDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveDialog.FileName, txtCustomFilter.Text);
        }
    }
}