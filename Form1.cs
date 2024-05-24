using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace _62024_Antoni_Piwowarski_GraphicsEditorPL
{
    public partial class Form1 : Form
    {
        Bitmap apbitmap, apbitmapClone;
        int apx0, apy0;
        enum Tools { apNone, apLine, apCircle, apElipse, apLineB, apEraser, apSquare, apRectangle, apTriangle, apBucket, apStar, apPen };
        Tools aptool = Tools.apNone;
        bool apmouseDown = false;
        Color apcolor = Color.Red;
        bool apFillChecked = false;
        Color apbackgroundColor = Color.White;
        int aperaserSize = 30;
        int apthickness = 3;
        Stack<Bitmap> apundoStack = new Stack<Bitmap>();
        Stack<Bitmap> apredoStack = new Stack<Bitmap>();
        List<Point> appoints = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            apbitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.KeyPreview = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((aptool != Tools.apNone) && (e.Button == MouseButtons.Left))
            {
                apmouseDown = true;
                apx0 = e.X;
                apy0 = e.Y;

                Bitmap apcurrentBitmap = new Bitmap(apbitmap);
                apundoStack.Push(apcurrentBitmap);

                apredoStack.Clear();
            }
            if(aptool == Tools.apPen)
            {
                appoints.Clear();
                appoints.Add(e.Location);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((aptool != Tools.apNone) && (apmouseDown))
            {
                apbitmapClone = (Bitmap)apbitmap.Clone();
                switch (aptool)
                {
                    case Tools.apLine:
                        MyGraphics.myLine(apx0, apy0, e.X, e.Y, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apCircle:
                        float apr = (float)Math.Sqrt((apx0 - e.X) * (apx0 - e.X) + (apy0 - e.Y) * (apy0 - e.Y));
                        MyGraphics.myCircle(apx0, apy0, apr, apFillChecked, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apElipse:
                        MyGraphics.myElipse(apx0, apy0, e.X, e.Y, apFillChecked, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apLineB:
                        MyGraphics.myLineB(apx0, apy0, e.X, e.Y, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apSquare:
                        int apside = Math.Max(Math.Abs(apx0 - e.X), Math.Abs(apy0 - e.Y));
                        MyGraphics.mySquare(apx0, apy0, apside, apFillChecked, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apRectangle:
                        int apwidth = Math.Abs(apx0 - e.X);
                        int apheight = Math.Abs(apy0 - e.Y);
                        MyGraphics.myRectangle(apx0, apy0, apwidth, apheight, apFillChecked, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apTriangle:
                        int apx2 = apx0 + (e.X - apx0) * 2;
                        int apy2 = apy0;

                        int apapexX = (apx0 + e.X) / 2;
                        int apapexY = apy0 - Math.Abs(e.X - apx0) / 2;

                        MyGraphics.myTriangle(apx0, apy0, e.X, e.Y, apapexX, apapexY, apFillChecked, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apEraser:
                        MyGraphics.myEraser(e.X, e.Y, apbitmap, pictureBox1, apbackgroundColor, aperaserSize);
                        pictureBox1.Image = apbitmap;
                        break;
                    case Tools.apStar:
                        int apcenterX = (apx0 + e.X) / 2;
                        int apcenterY = (apy0 + e.Y) / 2;
                        int apouterRadius = (int)Math.Sqrt(Math.Pow(e.X - apx0, 2) + Math.Pow(e.Y - apy0, 2)) / 2;
                        int apinnerRadius = apouterRadius / 2;

                        MyGraphics.myStar(apcenterX, apcenterY, apouterRadius, apinnerRadius, apFillChecked, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apPen:
                        if (appoints.Count > 1)
                        {
                            using (Graphics apg = Graphics.FromImage(apbitmap))
                            {
                                Pen appen = new Pen(apcolor, apthickness);
                                for (int i = 1; i < appoints.Count; i++)
                                {
                                    apg.DrawLine(appen, appoints[i - 1], appoints[i]);
                                }
                            }
                            pictureBox1.Image = apbitmap;
                            appoints.Clear();
                        }
                        break;
            }
                apmouseDown = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
            if ((aptool != Tools.apNone) && (apmouseDown))
            {
                apbitmapClone = (Bitmap)apbitmap.Clone();
                switch (aptool)
                {
                    case Tools.apLine:
                        MyGraphics.myLine(apx0, apy0, e.X, e.Y, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apCircle:
                        float r = (float)Math.Sqrt((apx0 - e.X) * (apx0 - e.X) + (apy0 - e.Y) * (apy0 - e.Y));
                        MyGraphics.myCircle(apx0, apy0, r, false, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apElipse:
                        MyGraphics.myElipse(apx0, apy0, e.X, e.Y, false, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apLineB:
                        MyGraphics.myLineB(apx0, apy0, e.X, e.Y, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apSquare:
                        int side = Math.Max(Math.Abs(apx0 - e.X), Math.Abs(apy0 - e.Y));
                        MyGraphics.mySquare(apx0, apy0, side, false, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apRectangle:
                        int apwidth = Math.Abs(apx0 - e.X);
                        int apheight = Math.Abs(apy0 - e.Y);
                        MyGraphics.myRectangle(apx0, apy0, apwidth, apheight, false, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apTriangle:
                        int apx2 = apx0 + (e.X - apx0) * 2;
                        int apy2 = apy0;

                        int apapexX = (apx0 + e.X) / 2;
                        int apapexY = apy0 - Math.Abs(e.X - apx0) / 2;

                        MyGraphics.myTriangle(apx0, apy0, e.X, e.Y, apapexX, apapexY, false, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apEraser:
                        using (Graphics apg = Graphics.FromImage(apbitmapClone))
                        {
                            if (e.Button == MouseButtons.Left)
                            {
                                MyGraphics.myEraser(e.X, e.Y, apbitmap, pictureBox1, apbackgroundColor, aperaserSize);

                                Pen aperaserOutlinePen = new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
                                int apoutlineX = e.X - aperaserSize / 2;
                                int apoutlineY = e.Y - aperaserSize / 2;
                                apg.DrawRectangle(aperaserOutlinePen, apoutlineX, apoutlineY, aperaserSize, aperaserSize);
                                aperaserOutlinePen.Dispose();
                            }
                        }
                        break;
                    case Tools.apStar:
                        int apcenterX = (apx0 + e.X) / 2;
                        int apcenterY = (apy0 + e.Y) / 2;
                        int apouterRadius = (int)Math.Sqrt(Math.Pow(e.X - apx0, 2) + Math.Pow(e.Y - apy0, 2)) / 2;
                        int apinnerRadius = apouterRadius / 2;

                        MyGraphics.myStar(apcenterX, apcenterY, apouterRadius, apinnerRadius, false, apbitmap, pictureBox1, apcolor);
                        break;
                    case Tools.apPen:
                        appoints.Add(e.Location);
                        if (appoints.Count > 1)
                        {
                            using (Graphics apg = Graphics.FromImage(apbitmap))
                            {
                                Pen appen = new Pen(apcolor, apthickness);
                                for (int i = 1; i < appoints.Count; i++)
                                {
                                    apg.DrawLine(appen, appoints[i - 1], appoints[i]);
                                }
                            }
                            pictureBox1.Image = apbitmap;
                        }
                        break;
                }
                if ((aptool == Tools.apEraser) && (apmouseDown) && (e.Button == MouseButtons.Left))
                {
                    pictureBox1.Image = apbitmapClone;
                }
                else
                    apbitmap = apbitmapClone;
            }
            else if (aptool == Tools.apEraser)
            {
                Bitmap aptempBitmap = (Bitmap)apbitmap.Clone();
                using (Graphics apg = Graphics.FromImage(aptempBitmap))
                {
                    Brush apbrush = new SolidBrush(Color.FromArgb(191, pictureBox1.BackColor));
                    
                    Pen aperaserOutlinePen = new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
                    int apoutlineX = e.X - aperaserSize / 2;
                    int apoutlineY = e.Y - aperaserSize / 2;
                    apg.FillRectangle(apbrush, apoutlineX, apoutlineY, aperaserSize, aperaserSize);
                    apg.DrawRectangle(aperaserOutlinePen, apoutlineX, apoutlineY, aperaserSize, aperaserSize);
                    aperaserOutlinePen.Dispose();
                }
                pictureBox1.Image = aptempBitmap;
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (aptool == Tools.apBucket)
            {
                MyGraphics.FloodFill(e.X, e.Y, apcolor, apbitmap);
                //Color innerColor = apbitmap.GetPixel(e.X, e.Y);
                //MyGraphics.myColorFill(e.X, e.Y, apbitmap, apcolor, innerColor);
                //MyGraphics.myColorFill2(e.X, e.Y, apbitmap, apcolor, innerColor);
                pictureBox1.Image = apbitmap;
            }
        }
        private void btnNone_Click(object sender, EventArgs e)
        {
            aptool = Tools.apNone;
            this.Cursor = Cursors.Default;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            aptool = Tools.apLine;
            this.Cursor = Cursors.Default;
        }

        private void bntLineB_Click(object sender, EventArgs e)
        {
            aptool = Tools.apLineB;
            this.Cursor = Cursors.Default;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            aptool = Tools.apCircle;
            this.Cursor = Cursors.Default;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            aptool = Tools.apElipse;
            this.Cursor = Cursors.Default;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            aptool = Tools.apRectangle;
            this.Cursor = Cursors.Default;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            aptool = Tools.apSquare;
            this.Cursor = Cursors.Default;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            aptool = Tools.apTriangle;
            this.Cursor = Cursors.Default;
        }
        private void btnStar_Click(object sender, EventArgs e)
        {
            aptool = Tools.apStar;
            this.Cursor = Cursors.Default;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog apDialog = new ColorDialog();
            apDialog.Color = btnColor.BackColor;

            if (apDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = apDialog.Color;
                apcolor = apDialog.Color;
            }
        }

        private void btnBucket_Click(object sender, EventArgs e)
        {
            aptool = Tools.apBucket;
            byte[] apcursorBytes = BucketIcon.bucket;

            using (MemoryStream apmemoryStream = new MemoryStream(apcursorBytes))
            {
                this.Cursor = new Cursor(apmemoryStream);
            }
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            aptool = Tools.apEraser;
            this.Cursor = Cursors.Default;
        }

        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            apFillChecked = chkFill.Checked;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int apval = trackBar1.Value + 10;
            aperaserSize = apval;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int apval = trackBar2.Value;
            apthickness = apval;
        }
        private void saveTheBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("There is no image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog apsaveFileDialog = new SaveFileDialog())
            {
                apsaveFileDialog.Title = "Save Image As";
                apsaveFileDialog.Filter = "PNG Image|*.png";

                apsaveFileDialog.FileName = "image.png";

                if (apsaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap apbitmap = new Bitmap(pictureBox1.Image);

                        apbitmap.Save(apsaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);

                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception apex)
                    {
                        MessageBox.Show($"Failed to save the image. Error: {apex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void readABitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog apopenFileDialog = new OpenFileDialog())
            {
                apopenFileDialog.Title = "Open Image";
                apopenFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

                if (apopenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Bitmap aploadedBitmap = new Bitmap(apopenFileDialog.FileName);

                        if (apbitmap != null) apbitmap.Dispose();
                        apbitmap = new Bitmap(aploadedBitmap.Width, aploadedBitmap.Height);

                        using (Graphics apg = Graphics.FromImage(apbitmap))
                        {
                            apg.DrawImage(aploadedBitmap, 0, 0);
                        }

                        pictureBox1.Image = apbitmap;

                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    }
                    catch (Exception apex)
                    {
                        MessageBox.Show($"Failed to load the image. Error: {apex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (aptool == Tools.apBucket)
                aptool = Tools.apNone;
        }

        private void btnNone_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("None", btnNone);
        }

        private void btnNone_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnLine_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Line", btnLine);
        }

        private void btnLine_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void bntLineB_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Line made using bresenham algorithm", btnLineB);
        }

        private void bntLineB_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnCircle_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Circle", btnCircle);
        }

        private void btnCircle_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnEllipse_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Ellipse", btnEllipse);
        }

        private void btnEllipse_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnRectangle_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Rectangle", btnRectangle);
        }

        private void btnRectangle_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnSquare_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Square", btnSquare);
        }

        private void btnSquare_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnTriangle_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Triangle", btnTriangle);
        }

        private void btnTriangle_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnColor_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Choose a color", btnColor);
        }

        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void btnBucket_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Fill", btnBucket);
        }

        private void btnBucket_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }
        private void btnEraser_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Erase", btnEraser);
        }

        private void btnEraser_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }
        private void btnStar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Star", btnStar);
        }

        private void btnStar_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }
        private void btnPen_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Pen", btnPen);
        }

        private void btnPen_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Clear the entire bitmap", btnClear);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult apdialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apdialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Undo()
        {
            if (apundoStack.Count > 0)
            {
                apredoStack.Push(new Bitmap(apbitmap));

                apbitmap = apundoStack.Pop();
                pictureBox1.Image = apbitmap;
            }
        }
        private void Redo() 
        {
            if (apredoStack.Count > 0)
            {
                apundoStack.Push(new Bitmap(apbitmap));

                apbitmap = apredoStack.Pop();
                pictureBox1.Image = apbitmap;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            aptool = Tools.apPen;
            this.Cursor = Cursors.Cross;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (apbitmap != null)
            {
                Bitmap apcurrentBitmap = new Bitmap(apbitmap);
                apundoStack.Push(apcurrentBitmap);

                using (var g = Graphics.FromImage(apbitmap))
                {
                    g.Clear(pictureBox1.BackColor);
                }

                pictureBox1.Image = apbitmap;

                appoints.Clear();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                Redo();
                e.Handled = true;
            }
        }
    }
}
