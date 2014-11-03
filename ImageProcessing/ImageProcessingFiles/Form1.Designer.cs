namespace ImageProcessing
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnOpen = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numRotX = new System.Windows.Forms.NumericUpDown();
            this.numRotY = new System.Windows.Forms.NumericUpDown();
            this.numRotAngle = new System.Windows.Forms.NumericUpDown();
            this.numScaleY = new System.Windows.Forms.NumericUpDown();
            this.numScaleX = new System.Windows.Forms.NumericUpDown();
            this.numShearY = new System.Windows.Forms.NumericUpDown();
            this.numShearX = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.grpboxTask1 = new System.Windows.Forms.GroupBox();
            this.rdioAll = new System.Windows.Forms.RadioButton();
            this.rdioShear = new System.Windows.Forms.RadioButton();
            this.rdioRotation = new System.Windows.Forms.RadioButton();
            this.rdioScale = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGamma = new System.Windows.Forms.NumericUpDown();
            this.btnGamma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlice = new System.Windows.Forms.Button();
            this.txtBitMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnEqualize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.slideBrightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.slideContrast = new System.Windows.Forms.TrackBar();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.numAddFraction = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpboxTask1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideContrast)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddFraction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(3, 18);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 62);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            // 
            // numRotX
            // 
            this.numRotX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numRotX.Location = new System.Drawing.Point(171, 44);
            this.numRotX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRotX.Name = "numRotX";
            this.numRotX.Size = new System.Drawing.Size(48, 20);
            this.numRotX.TabIndex = 6;
            this.toolTip.SetToolTip(this.numRotX, "X value");
            // 
            // numRotY
            // 
            this.numRotY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numRotY.Location = new System.Drawing.Point(222, 44);
            this.numRotY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRotY.Name = "numRotY";
            this.numRotY.Size = new System.Drawing.Size(48, 20);
            this.numRotY.TabIndex = 7;
            this.toolTip.SetToolTip(this.numRotY, "Y value");
            // 
            // numRotAngle
            // 
            this.numRotAngle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numRotAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRotAngle.Location = new System.Drawing.Point(273, 44);
            this.numRotAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numRotAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numRotAngle.Name = "numRotAngle";
            this.numRotAngle.Size = new System.Drawing.Size(48, 20);
            this.numRotAngle.TabIndex = 8;
            this.toolTip.SetToolTip(this.numRotAngle, "Rotation angle");
            // 
            // numScaleY
            // 
            this.numScaleY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numScaleY.DecimalPlaces = 2;
            this.numScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScaleY.Location = new System.Drawing.Point(222, 19);
            this.numScaleY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numScaleY.Name = "numScaleY";
            this.numScaleY.Size = new System.Drawing.Size(48, 20);
            this.numScaleY.TabIndex = 11;
            this.toolTip.SetToolTip(this.numScaleY, "Y value");
            this.numScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numScaleX
            // 
            this.numScaleX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numScaleX.DecimalPlaces = 2;
            this.numScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScaleX.Location = new System.Drawing.Point(171, 19);
            this.numScaleX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numScaleX.Name = "numScaleX";
            this.numScaleX.Size = new System.Drawing.Size(48, 20);
            this.numScaleX.TabIndex = 10;
            this.toolTip.SetToolTip(this.numScaleX, "X value");
            this.numScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numShearY
            // 
            this.numShearY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numShearY.DecimalPlaces = 2;
            this.numShearY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numShearY.Location = new System.Drawing.Point(222, 69);
            this.numShearY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numShearY.Name = "numShearY";
            this.numShearY.Size = new System.Drawing.Size(48, 20);
            this.numShearY.TabIndex = 14;
            this.toolTip.SetToolTip(this.numShearY, "Y value");
            // 
            // numShearX
            // 
            this.numShearX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numShearX.DecimalPlaces = 2;
            this.numShearX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numShearX.Location = new System.Drawing.Point(171, 69);
            this.numShearX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numShearX.Name = "numShearX";
            this.numShearX.Size = new System.Drawing.Size(48, 20);
            this.numShearX.TabIndex = 13;
            this.toolTip.SetToolTip(this.numShearX, "X value");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.54971F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1165, 561);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.grpboxTask1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1159, 125);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(513, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 119);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 27);
            this.button9.TabIndex = 3;
            this.button9.Text = "Open Second Image";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnOpenSecond_Click);
            // 
            // grpboxTask1
            // 
            this.grpboxTask1.Controls.Add(this.rdioAll);
            this.grpboxTask1.Controls.Add(this.rdioShear);
            this.grpboxTask1.Controls.Add(this.rdioRotation);
            this.grpboxTask1.Controls.Add(this.rdioScale);
            this.grpboxTask1.Controls.Add(this.numShearY);
            this.grpboxTask1.Controls.Add(this.numShearX);
            this.grpboxTask1.Controls.Add(this.numScaleY);
            this.grpboxTask1.Controls.Add(this.numScaleX);
            this.grpboxTask1.Controls.Add(this.numRotAngle);
            this.grpboxTask1.Controls.Add(this.numRotY);
            this.grpboxTask1.Controls.Add(this.numRotX);
            this.grpboxTask1.Controls.Add(this.btnApply);
            this.grpboxTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxTask1.Location = new System.Drawing.Point(3, 3);
            this.grpboxTask1.Name = "grpboxTask1";
            this.grpboxTask1.Size = new System.Drawing.Size(504, 119);
            this.grpboxTask1.TabIndex = 2;
            this.grpboxTask1.TabStop = false;
            this.grpboxTask1.Text = "Task 1";
            // 
            // rdioAll
            // 
            this.rdioAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioAll.AutoSize = true;
            this.rdioAll.Checked = true;
            this.rdioAll.Location = new System.Drawing.Point(100, 92);
            this.rdioAll.Name = "rdioAll";
            this.rdioAll.Size = new System.Drawing.Size(42, 17);
            this.rdioAll.TabIndex = 18;
            this.rdioAll.TabStop = true;
            this.rdioAll.Text = "(All)";
            this.rdioAll.UseVisualStyleBackColor = true;
            // 
            // rdioShear
            // 
            this.rdioShear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioShear.AutoSize = true;
            this.rdioShear.Location = new System.Drawing.Point(100, 69);
            this.rdioShear.Name = "rdioShear";
            this.rdioShear.Size = new System.Drawing.Size(53, 17);
            this.rdioShear.TabIndex = 17;
            this.rdioShear.Text = "Shear";
            this.rdioShear.UseVisualStyleBackColor = true;
            // 
            // rdioRotation
            // 
            this.rdioRotation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioRotation.AutoSize = true;
            this.rdioRotation.Location = new System.Drawing.Point(100, 45);
            this.rdioRotation.Name = "rdioRotation";
            this.rdioRotation.Size = new System.Drawing.Size(65, 17);
            this.rdioRotation.TabIndex = 16;
            this.rdioRotation.Text = "Rotation";
            this.rdioRotation.UseVisualStyleBackColor = true;
            // 
            // rdioScale
            // 
            this.rdioScale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioScale.AutoSize = true;
            this.rdioScale.Location = new System.Drawing.Point(100, 21);
            this.rdioScale.Name = "rdioScale";
            this.rdioScale.Size = new System.Drawing.Size(52, 17);
            this.rdioScale.TabIndex = 15;
            this.rdioScale.Text = "Scale";
            this.rdioScale.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnApply.Location = new System.Drawing.Point(334, 42);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(63, 44);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numAddFraction);
            this.groupBox1.Controls.Add(this.numGamma);
            this.groupBox1.Controls.Add(this.btnGamma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSlice);
            this.groupBox1.Controls.Add(this.txtBitMask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnNegative);
            this.groupBox1.Controls.Add(this.btnSubtract);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnMatch);
            this.groupBox1.Controls.Add(this.btnEqualize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slideBrightness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slideContrast);
            this.groupBox1.Controls.Add(this.btnGrayscale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(651, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task 2";
            // 
            // numGamma
            // 
            this.numGamma.DecimalPlaces = 3;
            this.numGamma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numGamma.Location = new System.Drawing.Point(68, 64);
            this.numGamma.Name = "numGamma";
            this.numGamma.Size = new System.Drawing.Size(75, 20);
            this.numGamma.TabIndex = 18;
            this.numGamma.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnGamma
            // 
            this.btnGamma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGamma.Location = new System.Drawing.Point(144, 62);
            this.btnGamma.Name = "btnGamma";
            this.btnGamma.Size = new System.Drawing.Size(52, 23);
            this.btnGamma.TabIndex = 17;
            this.btnGamma.Text = "Apply";
            this.btnGamma.UseVisualStyleBackColor = true;
            this.btnGamma.Click += new System.EventHandler(this.btnGamma_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gamma:";
            // 
            // btnSlice
            // 
            this.btnSlice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSlice.Location = new System.Drawing.Point(144, 88);
            this.btnSlice.Name = "btnSlice";
            this.btnSlice.Size = new System.Drawing.Size(52, 23);
            this.btnSlice.TabIndex = 13;
            this.btnSlice.Text = "Slice";
            this.btnSlice.UseVisualStyleBackColor = true;
            this.btnSlice.Click += new System.EventHandler(this.btnSlice_Click);
            // 
            // txtBitMask
            // 
            this.txtBitMask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBitMask.Location = new System.Drawing.Point(68, 90);
            this.txtBitMask.Name = "txtBitMask";
            this.txtBitMask.Size = new System.Drawing.Size(75, 20);
            this.txtBitMask.TabIndex = 12;
            this.txtBitMask.Text = "10000000";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bit-Mask:";
            // 
            // btnNegative
            // 
            this.btnNegative.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNegative.Location = new System.Drawing.Point(319, 76);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(89, 23);
            this.btnNegative.TabIndex = 10;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubtract.Location = new System.Drawing.Point(408, 53);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(89, 23);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(319, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMatch.Location = new System.Drawing.Point(408, 30);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(89, 23);
            this.btnMatch.TabIndex = 7;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnEqualize
            // 
            this.btnEqualize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEqualize.Location = new System.Drawing.Point(319, 30);
            this.btnEqualize.Name = "btnEqualize";
            this.btnEqualize.Size = new System.Drawing.Size(89, 23);
            this.btnEqualize.TabIndex = 6;
            this.btnEqualize.Text = "Equalize";
            this.btnEqualize.UseVisualStyleBackColor = true;
            this.btnEqualize.Click += new System.EventHandler(this.btnEqualize_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brightness:";
            // 
            // slideBrightness
            // 
            this.slideBrightness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.slideBrightness.LargeChange = 15;
            this.slideBrightness.Location = new System.Drawing.Point(60, 40);
            this.slideBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.slideBrightness.Maximum = 100;
            this.slideBrightness.Minimum = -100;
            this.slideBrightness.Name = "slideBrightness";
            this.slideBrightness.Size = new System.Drawing.Size(143, 45);
            this.slideBrightness.TabIndex = 5;
            this.slideBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideBrightness.ValueChanged += new System.EventHandler(this.slideBrightness_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contrast:";
            // 
            // slideContrast
            // 
            this.slideContrast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.slideContrast.LargeChange = 15;
            this.slideContrast.Location = new System.Drawing.Point(60, 18);
            this.slideContrast.Margin = new System.Windows.Forms.Padding(0);
            this.slideContrast.Maximum = 100;
            this.slideContrast.Minimum = -100;
            this.slideContrast.Name = "slideContrast";
            this.slideContrast.Size = new System.Drawing.Size(143, 45);
            this.slideContrast.TabIndex = 3;
            this.slideContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideContrast.ValueChanged += new System.EventHandler(this.slideContrast_ValueChanged);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGrayscale.Location = new System.Drawing.Point(408, 76);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(89, 23);
            this.btnGrayscale.TabIndex = 0;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rightPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.middlePictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.leftPictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 430);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPictureBox.Location = new System.Drawing.Point(776, 0);
            this.rightPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(389, 430);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rightPictureBox.TabIndex = 13;
            this.rightPictureBox.TabStop = false;
            this.rightPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_DoubleClick);
            this.rightPictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.middlePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePictureBox.Location = new System.Drawing.Point(388, 0);
            this.middlePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(388, 430);
            this.middlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.middlePictureBox.TabIndex = 12;
            this.middlePictureBox.TabStop = false;
            this.middlePictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_DoubleClick);
            this.middlePictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPictureBox.Location = new System.Drawing.Point(0, 0);
            this.leftPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(388, 430);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.leftPictureBox.TabIndex = 0;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_DoubleClick);
            this.leftPictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "jpg";
            this.saveDialog.FileName = "image";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDialog_FileOk);
            // 
            // numAddFraction
            // 
            this.numAddFraction.DecimalPlaces = 2;
            this.numAddFraction.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numAddFraction.Location = new System.Drawing.Point(276, 55);
            this.numAddFraction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddFraction.Name = "numAddFraction";
            this.numAddFraction.Size = new System.Drawing.Size(42, 20);
            this.numAddFraction.TabIndex = 20;
            this.numAddFraction.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpboxTask1.ResumeLayout(false);
            this.grpboxTask1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideContrast)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddFraction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.GroupBox grpboxTask1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown numRotAngle;
        private System.Windows.Forms.NumericUpDown numRotY;
        private System.Windows.Forms.NumericUpDown numRotX;
        private System.Windows.Forms.RadioButton rdioScale;
        private System.Windows.Forms.NumericUpDown numShearY;
        private System.Windows.Forms.NumericUpDown numShearX;
        private System.Windows.Forms.NumericUpDown numScaleY;
        private System.Windows.Forms.NumericUpDown numScaleX;
        private System.Windows.Forms.RadioButton rdioShear;
        private System.Windows.Forms.RadioButton rdioRotation;
        private System.Windows.Forms.RadioButton rdioAll;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar slideContrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar slideBrightness;
        private System.Windows.Forms.Button btnEqualize;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSlice;
        private System.Windows.Forms.TextBox txtBitMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGamma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGamma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numAddFraction;
    }
}

