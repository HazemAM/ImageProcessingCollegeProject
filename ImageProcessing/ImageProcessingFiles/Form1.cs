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
        }

        Bitmap theBitmapImage;

        private void btnOpen_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK){
                //Open the image:
                string imageFilePath = fileDialog.FileName.ToLower();
                if(imageFilePath.EndsWith(".jpg") || imageFilePath.EndsWith(".png") ||
                   imageFilePath.EndsWith(".gif") || imageFilePath.EndsWith(".bmp")){
                    theBitmapImage = new Bitmap(imageFilePath);
                }
                else if(imageFilePath.EndsWith(".ppm")){
                    theBitmapImage = GetPPMBitmap(imageFilePath);
                    /*MessageBox.Show("Hmm...\nWe promise to support PPM files in the future.",
                        "Not Supported", MessageBoxButtons.OK);*/
                }
                else{
                    MessageBox.Show("This type of files is not supported... yet.\n(Are you sure it's an image?)", "Not Supported", MessageBoxButtons.OK);
                    return;
                }
                leftPictureBox.Image = theBitmapImage;
            }
        }

        private void rightPictureBox_Click(object sender, EventArgs e){
            rightPictureBox.Image = null;
        }

        private void rightPictureBox_MouseHover(object sender, EventArgs e){
            if(rightPictureBox.Image != null){
                toolTip.Active = true;
                toolTip.SetToolTip(rightPictureBox, "Click to remove");
            }
            else
                toolTip.Active = false;
        }

        private String[] PPMToString(String filePath){
            String theFile = "";
            String type="", widthHeight="", levels="";

            String line = "";
            int counter = 1;
            short headerMax = 3;

            try{
                StreamReader file = new StreamReader(filePath);
                while((line=file.ReadLine()) != null){ //instead of myFile.ReadToEnd().
                    if(counter<=headerMax){
                        switch(counter){
                        case 1:
                            type = line;
                            break;
                        case 2:
                            if(line.StartsWith("#")) headerMax = 4;
                            else widthHeight = line;
                            break;
                        case 3:
                            if (headerMax == 3) levels = line;
                            else if (headerMax == 4) widthHeight = line;
                            break;
                        case 4:
                            levels = line;
                            break;
                        }
                    }
                    else{
                        theFile += line;
                    }
                    
                    counter++;
                }
            } catch(Exception e){
                Console.WriteLine("The file could not be read:"+" "+e.Message);
                return null;
            }

            return (new String[] {type,widthHeight,levels,theFile});
        }

        private Bitmap GetPPMBitmap(string filePath){
            String[] theWholeFile = PPMToString(filePath);
            String[] WH = theWholeFile[1].Split(' ');
            String[] fileData = theWholeFile[3].Split(' ');
            int width  = int.Parse(WH[0]);
            int height = int.Parse(WH[1]);

            if(!theWholeFile[0].Equals("P3")){
                MessageBox.Show("Only P3 type is currently supported.",
                        "Not Supported", MessageBoxButtons.OK);
                return null;
            }

            Bitmap bmp = new Bitmap(width, height);

            /*METHOD 1: USING SetPixel()*/
            int c = 0; //RGB data counter
            for(int i=0; i<height; i++){
                for(int j=0; j<width; j++){
                    Color color = Color.FromArgb(byte.Parse(fileData[c]),byte.Parse(fileData[c+1]),byte.Parse(fileData[c+2]));
                    bmp.SetPixel(j,i,color);
                    c += 3;
                }
            }

            /*METHOD 2: USING LockBits() // UNFINISHED, WORKS WITH PROBLEMS*/
                //PixelFormat format = PixelFormat.Format24bppRgb; //The pixel format.
                //Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height); //The piece of image to work on

                ////Locking Bitmap's bits into memory.
                //BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, format);

                ////Getting the address of the first line.
                //IntPtr ptr = bmpData.Scan0;

                ////The array to hold the bitmap bytes in.
                //int numBytes = bmp.Width * bmp.Height * 3; //bmpData.Stride*bmp.Height;
                //byte[] rgbValues = new byte[numBytes];

                ////Copy the RGB values into the array.
                //Marshal.Copy(ptr, rgbValues, 0, numBytes);

                ////Converting and copying.
                //for (int i = 0; i < rgbValues.Length; i++)
                //{
                //    rgbValues[i] = byte.Parse(fileData[i]);
                //}

                ////Copy the RGB values back to the bitmap.
                //Marshal.Copy(rgbValues, 0, ptr, numBytes);

                ////Unlock the bits.
                //bmp.UnlockBits(bmpData);

            //Done.
            return bmp;
        }
    }
}