namespace _62024_Antoni_Piwowarski_GraphicsEditorPL
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBucket = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnLineB = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTheBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readABitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStar = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(965, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 50);
            this.label1.TabIndex = 31;
            this.label1.Text = "Change eraser\r\nsize";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBucket
            // 
            this.btnBucket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBucket.Image = ((System.Drawing.Image)(resources.GetObject("btnBucket.Image")));
            this.btnBucket.Location = new System.Drawing.Point(755, 47);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(48, 43);
            this.btnBucket.TabIndex = 29;
            this.btnBucket.UseVisualStyleBackColor = true;
            this.btnBucket.Click += new System.EventHandler(this.btnBucket_Click);
            this.btnBucket.MouseEnter += new System.EventHandler(this.btnBucket_MouseEnter);
            this.btnBucket.MouseLeave += new System.EventHandler(this.btnBucket_MouseLeave);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangle.Image")));
            this.btnTriangle.Location = new System.Drawing.Point(591, 46);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(48, 42);
            this.btnTriangle.TabIndex = 28;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            this.btnTriangle.MouseEnter += new System.EventHandler(this.btnTriangle_MouseEnter);
            this.btnTriangle.MouseLeave += new System.EventHandler(this.btnTriangle_MouseLeave);
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkFill.Location = new System.Drawing.Point(863, 54);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(83, 30);
            this.chkFill.TabIndex = 27;
            this.chkFill.Text = "filled";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.chkFill_CheckedChanged);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(483, 46);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(48, 43);
            this.btnRectangle.TabIndex = 26;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            this.btnRectangle.MouseEnter += new System.EventHandler(this.btnRectangle_MouseEnter);
            this.btnRectangle.MouseLeave += new System.EventHandler(this.btnRectangle_MouseLeave);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSquare.Image = ((System.Drawing.Image)(resources.GetObject("btnSquare.Image")));
            this.btnSquare.Location = new System.Drawing.Point(537, 46);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(48, 43);
            this.btnSquare.TabIndex = 25;
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            this.btnSquare.MouseEnter += new System.EventHandler(this.btnSquare_MouseEnter);
            this.btnSquare.MouseLeave += new System.EventHandler(this.btnSquare_MouseLeave);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(943, 71);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(210, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 24;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnEraser
            // 
            this.btnEraser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.Location = new System.Drawing.Point(809, 47);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(48, 45);
            this.btnEraser.TabIndex = 23;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            this.btnEraser.MouseEnter += new System.EventHandler(this.btnEraser_MouseEnter);
            this.btnEraser.MouseLeave += new System.EventHandler(this.btnEraser_MouseLeave);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnColor.Location = new System.Drawing.Point(701, 47);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(48, 42);
            this.btnColor.TabIndex = 22;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnLineB
            // 
            this.btnLineB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLineB.Image = ((System.Drawing.Image)(resources.GetObject("btnLineB.Image")));
            this.btnLineB.Location = new System.Drawing.Point(321, 46);
            this.btnLineB.Name = "btnLineB";
            this.btnLineB.Size = new System.Drawing.Size(48, 42);
            this.btnLineB.TabIndex = 21;
            this.btnLineB.UseVisualStyleBackColor = true;
            this.btnLineB.Click += new System.EventHandler(this.bntLineB_Click);
            this.btnLineB.MouseEnter += new System.EventHandler(this.bntLineB_MouseEnter);
            this.btnLineB.MouseLeave += new System.EventHandler(this.bntLineB_MouseLeave);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(429, 46);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(48, 43);
            this.btnEllipse.TabIndex = 20;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            this.btnEllipse.MouseEnter += new System.EventHandler(this.btnEllipse_MouseEnter);
            this.btnEllipse.MouseLeave += new System.EventHandler(this.btnEllipse_MouseLeave);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.Location = new System.Drawing.Point(375, 45);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(48, 43);
            this.btnCircle.TabIndex = 19;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            this.btnCircle.MouseEnter += new System.EventHandler(this.btnCircle_MouseEnter);
            this.btnCircle.MouseLeave += new System.EventHandler(this.btnCircle_MouseLeave);
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(265, 46);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(48, 42);
            this.btnLine.TabIndex = 18;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            this.btnLine.MouseEnter += new System.EventHandler(this.btnLine_MouseEnter);
            this.btnLine.MouseLeave += new System.EventHandler(this.btnLine_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(108, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1110, 531);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNone.Image = ((System.Drawing.Image)(resources.GetObject("btnNone.Image")));
            this.btnNone.Location = new System.Drawing.Point(157, 46);
            this.btnNone.Name = "btnNone";
            this.btnNone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNone.Size = new System.Drawing.Size(48, 42);
            this.btnNone.TabIndex = 16;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            this.btnNone.MouseEnter += new System.EventHandler(this.btnNone_MouseEnter);
            this.btnNone.MouseLeave += new System.EventHandler(this.btnNone_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTheBitmapToolStripMenuItem,
            this.readABitmapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveTheBitmapToolStripMenuItem
            // 
            this.saveTheBitmapToolStripMenuItem.Name = "saveTheBitmapToolStripMenuItem";
            this.saveTheBitmapToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveTheBitmapToolStripMenuItem.Text = "Save the bitmap";
            this.saveTheBitmapToolStripMenuItem.Click += new System.EventHandler(this.saveTheBitmapToolStripMenuItem_Click);
            // 
            // readABitmapToolStripMenuItem
            // 
            this.readABitmapToolStripMenuItem.Name = "readABitmapToolStripMenuItem";
            this.readABitmapToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.readABitmapToolStripMenuItem.Text = "Read a bitmap";
            this.readABitmapToolStripMenuItem.Click += new System.EventHandler(this.readABitmapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(28, 21);
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(28, 21);
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(77, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "X     Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(77, 76);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 21);
            this.lblX.TabIndex = 33;
            this.lblX.Text = "0";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(119, 76);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 21);
            this.lblY.TabIndex = 34;
            this.lblY.Text = "0";
            // 
            // btnStar
            // 
            this.btnStar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStar.Image = ((System.Drawing.Image)(resources.GetObject("btnStar.Image")));
            this.btnStar.Location = new System.Drawing.Point(647, 47);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(48, 41);
            this.btnStar.TabIndex = 35;
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            this.btnStar.MouseEnter += new System.EventHandler(this.btnStar_MouseEnter);
            this.btnStar.MouseLeave += new System.EventHandler(this.btnStar_MouseLeave);
            // 
            // btnPen
            // 
            this.btnPen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.Location = new System.Drawing.Point(211, 46);
            this.btnPen.Name = "btnPen";
            this.btnPen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPen.Size = new System.Drawing.Size(48, 42);
            this.btnPen.TabIndex = 36;
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            this.btnPen.MouseEnter += new System.EventHandler(this.btnPen_MouseEnter);
            this.btnPen.MouseLeave += new System.EventHandler(this.btnPen_MouseLeave);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1154, 71);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(131, 45);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 37;
            this.trackBar2.Value = 3;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1152, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 50);
            this.label3.TabIndex = 38;
            this.label3.Text = "Change pen\r\nthickness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(1241, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 63);
            this.btnClear.TabIndex = 39;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 691);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBucket);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.chkFill);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnLineB);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Antoni Piwowarski 62024";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBucket;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnLineB;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTheBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readABitmapToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
    }
}

