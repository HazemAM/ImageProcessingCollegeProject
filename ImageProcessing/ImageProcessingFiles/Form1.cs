﻿using System;
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
            rdioScale.Checked = true;
        }

        Bitmap theBitmapImage;
        Image  imageToSave=null;

        private void btnOpen_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog()==DialogResult.OK){
                //Open the image:
                String imageFilePath = fileDialog.FileName.ToLower();
                if(imageFilePath.EndsWith(".jpg") || imageFilePath.EndsWith(".png") ||
                   imageFilePath.EndsWith(".gif") || imageFilePath.EndsWith(".bmp")){
                    theBitmapImage = new Bitmap(imageFilePath);
                }
                else if(imageFilePath.EndsWith(".ppm"))
                    theBitmapImage = GetPPMBitmap(imageFilePath);
                else{
                    MessageBox.Show("This type of files is not supported... yet.\n(Are you sure it's an image?)",
                        "Not Supported", MessageBoxButtons.OK);
                    return;
                }
                leftPictureBox.Image = theBitmapImage;
            }
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

        private void pictureBox_DoubleClick(object sender, EventArgs e){
            //Save the image.
            if(((PictureBox)sender).Image!=null){
                saveDialog.FileName = "image.jpg";
                saveDialog.Filter   = "JPEG|*.jpg|All files|*.*";
                imageToSave = ((PictureBox)sender).Image;
                saveDialog.ShowDialog();
            }
        }

        private void saveDialog_FileOk(object sender, CancelEventArgs e){
            imageToSave.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            imageToSave = null;
        }

        private void btnApply_Click(object sender, EventArgs e){
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
    }
}