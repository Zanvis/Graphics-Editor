using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62024_Antoni_Piwowarski_GraphicsEditorPL
{
    internal class MyGraphics
    {
        public static void myLine(int apx0, int apy0, int apx1, int apy1, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            int apheight = apbitmap.Height - 1;
            int apwidth = apbitmap.Width - 1;
            int apdl;
            // horizontal line
            if (apy0 == apy1)
            {
                apdl = Math.Abs(apx1 - apx0);
                int apdxii;
                int apxii = apx0;
                if (apx0 < apx1) apdxii = 1; else apdxii = -1;
                for (int api = 0; api <= apdl; api++)
                {
                    if ((apxii > 1) && (apxii < apwidth) && (apy0 > 1) && (apy0 < apheight))
                        apbitmap.SetPixel(apxii, apy0, apcolor);
                    apxii += apdxii;
                }
                appictureBox.Image = apbitmap;
                return;
            }
            // vertical line
            if (apx0 == apx1)
            {
                apdl = Math.Abs(apy1 - apy0);
                int apdyii;
                int apyii = apy0;
                if (apy0 < apy1) apdyii = 1; else apdyii = -1;
                for (int api = 0; api <= apdl; api++)
                {
                    if ((apx0 > 1) && (apx0 < apwidth) && (apyii > 1) && (apyii < apheight))
                        apbitmap.SetPixel(apx0, apyii, apcolor);
                    apyii += apdyii;
                }
                appictureBox.Image = apbitmap;
                return;
            }
            // slope line
            float apdx = 0, apdy = 0;
            float apxi = apx0, apyi = apy0;
            float apm = (float)(apy1 - apy0) / (apx1 - apx0);
            if (Math.Abs(apx1 - apx0) >= Math.Abs(apy1 - apy0))
            {
                if (apx0 < apx1) apdx = 1; else apdx = -1;
                apdl = Math.Abs(apx1 - apx0);
                apdy = apm * apdx;
            }
            else
            {
                if (apy0 < apy1) apdy = 1; else apdy = -1;
                apdl = Math.Abs(apy1 - apy0);
                apdx = apdy / apm;
            }
            for (int api = 0; api <= apdl; api++)
            {
                if ((apxi > 1) && (apxi < apwidth) && (apyi > 1) && (apyi < apheight))
                    apbitmap.SetPixel((int)apxi, (int)apyi, apcolor);
                apxi += apdx; apyi += apdy;
            }
            appictureBox.Image = apbitmap;
        } // end of myLine
        public static void myCircle(int apx0, int apy0, float apr, bool apfillChecked, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            int apwidth = apbitmap.Width;
            int apheight = apbitmap.Height;

            if (apfillChecked)
            {
                for (int apy = (int)(apy0 - apr); apy <= (apy0 + apr); apy++)
                {
                    for (int apx = (int)(apx0 - apr); apx <= (apx0 + apr); apx++)
                    {
                        if ((apx - apx0) * (apx - apx0) + (apy - apy0) * (apy - apy0) <= apr * apr)
                        {
                            if (apx > 0 && apx < apwidth && apy > 0 && apy < apheight)
                            {
                                apbitmap.SetPixel(apx, apy, apcolor);
                            }
                        }
                    }
                }
            }
            else
            {
                int apiteration = (apr <= 50) ? 360 : (apr <= 100) ? 720 : 1440;
                float apcoefficient = (apr <= 50) ? 1 : (apr <= 100) ? 0.5f : 0.25f;
                for (int api = 0; api < apiteration; api++)
                {
                    int apxi = (int)(apx0 + apr * Math.Cos(api * apcoefficient * Math.PI / 180));
                    int apyi = (int)(apy0 + apr * Math.Sin(api * apcoefficient * Math.PI / 180));
                    if (apxi > 0 && apxi < apwidth && apyi > 0 && apyi < apheight)
                    {
                        apbitmap.SetPixel(apxi, apyi, apcolor);
                    }
                }
            }
            appictureBox.Image = apbitmap;
        }// end of MyCircle
        public static void myElipse(int apx0, int apy0, int apa, int apb, bool apfillChecked, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            int apwidth = apbitmap.Width;
            int apheight = apbitmap.Height;

            if (apfillChecked)
            {
                for (int apy = apy0 - apb; apy <= apy0 + apb; apy++)
                {
                    for (int apx = apx0 - apa; apx <= apx0 + apa; apx++)
                    {
                        if (((apx - apx0) * (apx - apx0)) / (float)(apa * apa) + ((apy - apy0) * (apy - apy0)) / (float)(apb * apb) <= 1)
                        {
                            if (apx >= 0 && apx < apwidth && apy >= 0 && apy < apheight)
                            {
                                apbitmap.SetPixel(apx, apy, apcolor);
                            }
                        }
                    }
                }
            }
            else
            {
                int apmax = Math.Max(apa, apb);
                int apiteration = (apmax <= 50) ? 360 : (apmax <= 100) ? 720 : 1440;
                float apcoefficient = (apmax <= 50) ? 1 : (apmax <= 100) ? 0.5f : 0.25f;
                for (int api = 0; api < apiteration; api++)
                {
                    int apxi = (int)(apx0 + apa * Math.Cos(api * apcoefficient * Math.PI / 180));
                    int apyi = (int)(apy0 + apb * Math.Sin(api * apcoefficient * Math.PI / 180));
                    if (apxi > 0 && apxi < apwidth && apyi > 0 && apyi < apheight)
                    {
                        apbitmap.SetPixel(apxi, apyi, apcolor);
                    }
                }
            }
            appictureBox.Image = apbitmap;
        }// end of myElipse
        public static void myLineB(int apx0, int apy0, int apx1, int apy1, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            int apwidth = apbitmap.Width - 1;
            int apheight = apbitmap.Height - 1;
            int apw = apx1 - apx0;
            int aph = apy1 - apy0;
            int apdx1 = 0, apdy1 = 0, apdx2 = 0, apdy2 = 0;
            if (apw < 0) apdx1 = -1; else if (apw > 0) apdx1 = 1;
            if (aph < 0) apdy1 = -1; else if (aph > 0) apdy1 = 1;
            if (apw < 0) apdx2 = -1; else if (apw > 0) apdx2 = 1;
            int aplongest = Math.Abs(apw);
            int apshortest = Math.Abs(aph);
            if (!(aplongest > apshortest))
            {
                aplongest = Math.Abs(aph);
                apshortest = Math.Abs(apw);
                if (aph < 0) apdy2 = -1; else if (aph > 0) apdy2 = 1;
                apdx2 = 0;
            }
            int apnumerator = aplongest >> 1;
            for (int api = 0; api <= aplongest; api++)
            {
                if ((apx0 > 1) && (apx0 < apwidth) && (apy0 > 1) && (apy0 < apheight))
                    apbitmap.SetPixel(apx0, apy0, apcolor);
                apnumerator += apshortest;
                if (!(apnumerator < aplongest))
                {
                    apnumerator -= aplongest;
                    apx0 += apdx1;
                    apy0 += apdy1;
                }
                else
                {
                    apx0 += apdx2;
                    apy0 += apdy2;
                }
            }
            appictureBox.Image = apbitmap;
        }// end of myLineB
        public static void myEraser(int apx, int apy, Bitmap apbitmap, PictureBox appictureBox, Color apbackgroundColor, int aperaserSize)
        {
            using (Graphics apg = Graphics.FromImage(apbitmap))
            {
                using (SolidBrush apbrush = new SolidBrush(apbackgroundColor))
                {
                    int aprectX = apx - aperaserSize / 2;
                    int aprectY = apy - aperaserSize / 2;

                    apg.FillRectangle(apbrush, aprectX, aprectY, aperaserSize, aperaserSize);
                }
            }
            appictureBox.Invalidate();
        }// end of myEraser
        public static void mySquare(int apx0, int apy0, int apside, bool apfillChecked, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            int apwidth = apbitmap.Width;
            int apheight = apbitmap.Height;

            int apx1 = apx0 - apside / 2;
            int apy1 = apy0 - apside / 2;
            int apx2 = apx0 + apside / 2;
            int apy2 = apy0 + apside / 2;

            if (apfillChecked)
            {
                for (int apy = Math.Max(apy1, 0); apy <= Math.Min(apy2, apheight - 1); apy++)
                {
                    for (int apx = Math.Max(apx1, 0); apx <= Math.Min(apx2, apwidth - 1); apx++)
                    {
                        apbitmap.SetPixel(apx, apy, apcolor);
                    }
                }
            }
            else
            {
                for (int apx = apx1; apx <= apx2; apx++)
                {
                    if (apx >= 0 && apx < apwidth)
                    {
                        if (apy1 >= 0 && apy1 < apheight) apbitmap.SetPixel(apx, apy1, apcolor);
                        if (apy2 >= 0 && apy2 < apheight) apbitmap.SetPixel(apx, apy2, apcolor);
                    }
                }
                for (int apy = apy1; apy <= apy2; apy++)
                {
                    if (apy >= 0 && apy < apheight)
                    {
                        if (apx1 >= 0 && apx1 < apwidth) apbitmap.SetPixel(apx1, apy, apcolor);
                        if (apx2 >= 0 && apx2 < apwidth) apbitmap.SetPixel(apx2, apy, apcolor);
                    }
                }
            }

            appictureBox.Image = apbitmap;
        }// end of mySquare
        public static void myRectangle(int apx0, int apy0, int apwidth, int apheight, bool apfill, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            int apbitmapWidth = apbitmap.Width - 1;
            int apbitmapHeight = apbitmap.Height - 1;

            int apx1 = apx0 - apwidth / 2;
            int apy1 = apy0 - apheight / 2;
            int apx2 = apx0 + apwidth / 2;
            int apy2 = apy0 + apheight / 2;

            int apxStart = Math.Max(apx1, 0);
            int apyStart = Math.Max(apy1, 0);
            int apxEnd = Math.Min(apx1 + apwidth, apbitmapWidth);
            int apyEnd = Math.Min(apy1 + apheight, apbitmapHeight);

            if (!apfill)
            {
                for (int apx = apx1; apx <= apx2; apx++)
                {
                    if (apx > 0 && apx < apbitmapWidth)
                    {
                        if (apy1 > 0 && apy1 < apbitmapHeight) apbitmap.SetPixel(apx, apy1, apcolor);
                        if (apy2 > 0 && apy2 < apbitmapHeight) apbitmap.SetPixel(apx, apy2, apcolor);
                    }
                }
                for (int apy = apy1; apy <= apy2; apy++)
                {
                    if (apy > 0 && apy < apbitmapHeight)
                    {
                        if (apx1 > 0 && apx1 < apbitmapWidth) apbitmap.SetPixel(apx1, apy, apcolor);
                        if (apx2 > 0 && apx2 < apbitmapWidth) apbitmap.SetPixel(apx2, apy, apcolor);
                    }
                }
            }
            else
            {
                for (int apx = apxStart; apx < apxEnd; apx++)
                {
                    for (int apy = apyStart; apy < apyEnd; apy++)
                    {
                        apbitmap.SetPixel(apx, apy, apcolor);
                    }
                }
            }
            appictureBox.Image = apbitmap;
        }// end of myRectangle
        public static void myTriangle(int apx0, int apy0, int apx1, int apy1, int apx2, int apy2, bool apfillChecked, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            if (apfillChecked)
            {
                using (Graphics apg = Graphics.FromImage(apbitmap))
                {
                    Point[] aptrianglePoints = { new Point(apx0, apy0), new Point(apx1, apy1), new Point(apx2, apy2) };

                    apg.FillPolygon(new SolidBrush(apcolor), aptrianglePoints);
                }
            }
            else
            {
                myLine(apx0, apy0, apx1, apy1, apbitmap, appictureBox, apcolor);
                myLine(apx1, apy1, apx2, apy2, apbitmap, appictureBox, apcolor);
                myLine(apx2, apy2, apx0, apy0, apbitmap, appictureBox, apcolor);
            }

            appictureBox.Image = apbitmap;
        }// end of myTriangle
        public static void FloodFill(int apx, int apy, Color apfillColor, Bitmap apbitmap)
        {
            Color aptargetColor = apbitmap.GetPixel(apx, apy);

            if (aptargetColor.ToArgb() == apfillColor.ToArgb())
                return;

            Queue<Point> apqueue = new Queue<Point>();
            apqueue.Enqueue(new Point(apx, apy));

            while (apqueue.Count > 0)
            {
                Point p = apqueue.Dequeue();
                if (p.X < 0 || p.X >= (apbitmap.Width - 1) || p.Y < 0 || p.Y >= (apbitmap.Height - 1))
                    continue;

                Color apcurrentColor = apbitmap.GetPixel(p.X, p.Y);
                if (apcurrentColor.ToArgb() == aptargetColor.ToArgb())
                {
                    apbitmap.SetPixel(p.X, p.Y, apfillColor);

                    apqueue.Enqueue(new Point(p.X - 1, p.Y));
                    apqueue.Enqueue(new Point(p.X + 1, p.Y));
                    apqueue.Enqueue(new Point(p.X, p.Y - 1));
                    apqueue.Enqueue(new Point(p.X, p.Y + 1));
                }
            }
        }// end of FloodFill
        public static void myStar(int apcenterX, int apcenterY, int apouterRadius, int apinnerRadius, bool apfillChecked, Bitmap apbitmap, PictureBox appictureBox, Color apcolor)
        {
            Graphics apg = Graphics.FromImage(apbitmap);
            
            int appoints = 5;

            double apouterAngle = 2 * Math.PI / appoints;
            double apinnerAngle = apouterAngle / 2;

            Point[] apstarPoints = new Point[appoints * 2];


            for (int api = 0, apj = 0; api < appoints * 2; api += 2, apj++)
            {
                apstarPoints[api] = new Point(
                    apcenterX + (int)(apouterRadius * Math.Cos(apj * apouterAngle)),
                    apcenterY + (int)(apouterRadius * Math.Sin(apj * apouterAngle))
                );

                apstarPoints[api + 1] = new Point(
                    apcenterX + (int)(apinnerRadius * Math.Cos(apj * apouterAngle + apinnerAngle)),
                    apcenterY + (int)(apinnerRadius * Math.Sin(apj * apouterAngle + apinnerAngle))
                );
            }

            if (apfillChecked)
            {
                apg.FillPolygon(new SolidBrush(apcolor), apstarPoints);
            }
            else
            {
                for (int api = 0; api < appoints * 2; api++)
                {
                    int apnextIndex = (api + 1) % (appoints * 2);
                    myLine(apstarPoints[api].X, apstarPoints[api].Y, apstarPoints[apnextIndex].X, apstarPoints[apnextIndex].Y, apbitmap, appictureBox, apcolor);
                }
            }

            appictureBox.Image = apbitmap;
        }// end of myStar
        public static void myColorFill(int x, int y, Bitmap bitmap, Color fillColor, Color innerColor)
        {
            if(x > 1 && x < bitmap.Width && y > 1 && y < bitmap.Height)
            {
                if (bitmap.GetPixel(x, y) == innerColor)
                    bitmap.SetPixel(x, y, fillColor);
                else
                    return;
                myColorFill(x + 1, y, bitmap, fillColor, innerColor);
                myColorFill(x - 1, y, bitmap, fillColor, innerColor);
                myColorFill(x, y + 1 , bitmap, fillColor, innerColor);
                myColorFill(x, y - 1, bitmap, fillColor, innerColor);
            }
        }// end of myColorFill
        public static void myColorFill2(int x, int y, Bitmap bitmap, Color fillColor, Color borderColor)
        {
            if (x > 1 && x < bitmap.Width && y > 1 && y < bitmap.Height)
            {
                if (bitmap.GetPixel(x, y) != borderColor && bitmap.GetPixel(x,y) != fillColor)
                    bitmap.SetPixel(x, y, fillColor);
                else
                    return;
                myColorFill2(x + 1, y, bitmap, fillColor, borderColor);
                myColorFill2(x - 1, y, bitmap, fillColor, borderColor);
                myColorFill2(x, y + 1, bitmap, fillColor, borderColor);
                myColorFill2(x, y - 1, bitmap, fillColor, borderColor);
            }
        }// end of myColorFill2
    }
}
