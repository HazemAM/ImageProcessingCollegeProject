using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ImageProcessing
{
    public class Transformations
    {

        public static Bitmap Ops(Bitmap OrigBuf, int id, double[] opprands)
        {
            float angle = 0;
            float X = (float)opprands[0];
            float Y = (float)opprands[1];
            Matrix W = new Matrix();
            // 1= scaling, 2=roating,3=shearing,4=all
            switch (id)
            {
                case 1:// in case of scaling 1st input is X,2nd input is Y,3rd intput is ignored
                    W.Scale(X, Y);
                    break;
                case 2:// in case of roatating 1st input is Xpos of center of rotation,2nd input is Ypos of center of rotation,3rd intput is the angle
                    angle = (float)opprands[2];
                    W.RotateAt(angle, new PointF((int)X, (int)Y),MatrixOrder.Prepend);
                    break;
                case 3:// in case of shearing 1st input is X,2nd input is Y,3rd intput is ignored
                    W.Shear(X, Y);
                    break;
                case 4://in case of all 1st 2 opperands scale next 3 rotate and last 2 shear
                    W.Scale(X, Y);
                    angle = (float)opprands[2];
                    W.RotateAt(angle, new PointF((int)opprands[3], (int)opprands[4]), MatrixOrder.Prepend);
                    W.Shear((float)opprands[5],(float) opprands[6]);
                    break;
                default:
                    MessageBox.Show("Wrong id");
                    return null;
            }

            return GeometricLinearTransform(OrigBuf, W);
        }
        private static Bitmap GeometricLinearTransform(Bitmap OrigBuf, Matrix W)
        {
            Bitmap NewBuf;
            int maxH = OrigBuf.Height;
            int maxW = OrigBuf.Width;
            Color[,] org = new Color[maxW, maxH];
            for (int i = 0; i < maxW; i++)
                for (int j = 0; j < maxH; j++)
                {
                    org[i, j] = OrigBuf.GetPixel(i, j);
                }
            PointF[] arr = new PointF[] { new PointF(0, 0), new PointF(maxW, 0), new PointF(0, maxH), new PointF(maxW, maxH) };
            try
            {
                W.TransformPoints(arr);
                PointF m=arr[0];
                PointF n = arr[0];
                foreach (PointF item in arr)
                {
                    n.X = Math.Min (n.X, item.X);
                    n.Y = Math.Min (n.Y, item.Y);
                    m.X = Math.Max (m.X, item.X);
                    m.Y = Math.Max(m.Y, item.Y);
                }
                W.Translate(-n.X, -n.Y, MatrixOrder.Append);
                if (!W.IsInvertible)
                {
                    MessageBox.Show("invalid Transformation");
                    return null;
                }
                W.Invert();
                NewBuf = new Bitmap((int)(m.X - n.X), (int)(m.Y - n.Y));
                for (int i = 0; i < (int)(m.X - n.X); i++)
                    for (int j = 0; j < (int)(m.Y - n.Y); j++)
                    {
                        PointF[] temp = { new PointF(i, j) };
                        W.TransformPoints(temp);
                        if (temp[0].X > 0 && temp[0].X < maxW - 1)
                        {
                            if (temp[0].Y > 0 && temp[0].Y < maxH - 1)
                            {
                                double oldX = (double)temp[0].X;
                                double oldY = (double)temp[0].Y;
                                int X1 = (int)Math.Floor(oldX);
                                int X2 = X1 + 1;
                                int Y1 = (int)Math.Floor(oldY); ;
                                int Y2 = Y1 + 1; ;
                                Color P1 = org[X1, Y1];
                                Color P2 = org[X2, Y1];
                                Color P3 = org[X1, Y2];
                                Color P4 = org[X2, Y2];
                                double XF = oldX - X1;
                                double YF = oldY - Y1;
                                byte r = (byte)((P1.R * (1 - XF)) + (P2.R * XF));
                                byte g = (byte)((P1.G * (1 - XF)) + (P2.G * XF));
                                byte b = (byte)((P1.B * (1 - XF)) + (P2.B * XF));
                                Color Z1 = Color.FromArgb(r, g, b);
                                r = (byte)((P3.R * (1 - XF)) + (P4.R * XF));
                                g = (byte)((P3.G * (1 - XF)) + (P4.G * XF));
                                b = (byte)((P3.B * (1 - XF)) + (P4.B * XF));
                                Color Z2 = Color.FromArgb(r, g, b);
                                r = (byte)((Z1.R * (1 - YF)) + (Z2.R * YF));
                                g = (byte)((Z1.G * (1 - YF)) + (Z2.G * YF));
                                b = (byte)((Z2.B * (1 - YF)) + (Z2.B * YF));
                                NewBuf.SetPixel(i, j, Color.FromArgb(r, g, b));
                            }
                            else
                            {
                                NewBuf.SetPixel(i, j, Color.Black);
                            }
                        }
                        else
                        {
                            NewBuf.SetPixel(i, j, Color.Black);
                        }
                    }
                return NewBuf;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return null;
            }
        }

    }
}
