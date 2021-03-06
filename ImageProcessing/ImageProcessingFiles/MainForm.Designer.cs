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
            this.numShearX = new System.Windows.Forms.NumericUpDown();
            this.numScaleY = new System.Windows.Forms.NumericUpDown();
            this.numShearY = new System.Windows.Forms.NumericUpDown();
            this.numScaleX = new System.Windows.Forms.NumericUpDown();
            this.numRotAngle = new System.Windows.Forms.NumericUpDown();
            this.numRotY = new System.Windows.Forms.NumericUpDown();
            this.numRotX = new System.Windows.Forms.NumericUpDown();
            this.numGaussMaskSize = new System.Windows.Forms.NumericUpDown();
            this.numGaussSigma = new System.Windows.Forms.NumericUpDown();
            this.numMeanMaskWidth = new System.Windows.Forms.NumericUpDown();
            this.numUnsharpSigma = new System.Windows.Forms.NumericUpDown();
            this.numMeanMaskHeight = new System.Windows.Forms.NumericUpDown();
            this.numUnsharpMaskSize = new System.Windows.Forms.NumericUpDown();
            this.numMeanOriginX = new System.Windows.Forms.NumericUpDown();
            this.numMeanOriginY = new System.Windows.Forms.NumericUpDown();
            this.numUnsharpK = new System.Windows.Forms.NumericUpDown();
            this.rdioLHE = new System.Windows.Forms.RadioButton();
            this.numStatsE = new System.Windows.Forms.NumericUpDown();
            this.numStatsWindow = new System.Windows.Forms.NumericUpDown();
            this.numStatsK1 = new System.Windows.Forms.NumericUpDown();
            this.numStatsK0 = new System.Windows.Forms.NumericUpDown();
            this.numStatsK2 = new System.Windows.Forms.NumericUpDown();
            this.numLHEWindow = new System.Windows.Forms.NumericUpDown();
            this.numRtnxSigma = new System.Windows.Forms.NumericUpDown();
            this.numCustomOriginX = new System.Windows.Forms.NumericUpDown();
            this.numCustomOriginY = new System.Windows.Forms.NumericUpDown();
            this.cmboCustomPost = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rdioMLGaussian = new System.Windows.Forms.RadioButton();
            this.btnMatlabApply = new System.Windows.Forms.Button();
            this.rdioStats = new System.Windows.Forms.RadioButton();
            this.rdioRtnx = new System.Windows.Forms.RadioButton();
            this.slideMLGaussian = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmboKirsch = new System.Windows.Forms.ComboBox();
            this.rdioLaplaceSharp = new System.Windows.Forms.RadioButton();
            this.rdioKirschEdge = new System.Windows.Forms.RadioButton();
            this.rdioMean = new System.Windows.Forms.RadioButton();
            this.btnTask3Apply = new System.Windows.Forms.Button();
            this.rdioGaussian = new System.Windows.Forms.RadioButton();
            this.rdioUnsharp = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtCustomFilter = new System.Windows.Forms.TextBox();
            this.btnCustomApply = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTask1Apply = new System.Windows.Forms.Button();
            this.rdioAll = new System.Windows.Forms.RadioButton();
            this.rdioShear = new System.Windows.Forms.RadioButton();
            this.rdioRotation = new System.Windows.Forms.RadioButton();
            this.rdioScale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chckSecondImage = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrgnlHisto = new System.Windows.Forms.Button();
            this.numAddFraction = new System.Windows.Forms.NumericUpDown();
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
            this.slideGamma = new System.Windows.Forms.TrackBar();
            this.slideBrightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.slideContrast = new System.Windows.Forms.TrackBar();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.imagesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.imageSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenMask = new System.Windows.Forms.Button();
            this.btnSaveMask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaussMaskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaussSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanMaskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnsharpSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanMaskHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnsharpMaskSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanOriginX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanOriginY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnsharpK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsK0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsK2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLHEWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRtnxSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomOriginX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomOriginY)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideMLGaussian)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddFraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideContrast)).BeginInit();
            this.imagesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(3, 19);
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
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.AutoPopDelay = 0;
            this.toolTip.InitialDelay = 0;
            this.toolTip.ReshowDelay = 0;
            // 
            // numShearX
            // 
            this.numShearX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numShearX.DecimalPlaces = 2;
            this.numShearX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numShearX.Location = new System.Drawing.Point(166, 60);
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
            // numScaleY
            // 
            this.numScaleY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numScaleY.DecimalPlaces = 2;
            this.numScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScaleY.Location = new System.Drawing.Point(217, 10);
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
            // numShearY
            // 
            this.numShearY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numShearY.DecimalPlaces = 2;
            this.numShearY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numShearY.Location = new System.Drawing.Point(217, 60);
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
            // numScaleX
            // 
            this.numScaleX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numScaleX.DecimalPlaces = 2;
            this.numScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numScaleX.Location = new System.Drawing.Point(166, 10);
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
            // numRotAngle
            // 
            this.numRotAngle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRotAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRotAngle.Location = new System.Drawing.Point(268, 35);
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
            // numRotY
            // 
            this.numRotY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRotY.Location = new System.Drawing.Point(217, 35);
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
            // numRotX
            // 
            this.numRotX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRotX.Location = new System.Drawing.Point(166, 35);
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
            // numGaussMaskSize
            // 
            this.numGaussMaskSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numGaussMaskSize.Location = new System.Drawing.Point(177, 25);
            this.numGaussMaskSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGaussMaskSize.Name = "numGaussMaskSize";
            this.numGaussMaskSize.Size = new System.Drawing.Size(48, 20);
            this.numGaussMaskSize.TabIndex = 24;
            this.toolTip.SetToolTip(this.numGaussMaskSize, "Mask Size");
            // 
            // numGaussSigma
            // 
            this.numGaussSigma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numGaussSigma.DecimalPlaces = 1;
            this.numGaussSigma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numGaussSigma.Location = new System.Drawing.Point(228, 25);
            this.numGaussSigma.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGaussSigma.Name = "numGaussSigma";
            this.numGaussSigma.Size = new System.Drawing.Size(48, 20);
            this.numGaussSigma.TabIndex = 25;
            this.toolTip.SetToolTip(this.numGaussSigma, "Sigma");
            // 
            // numMeanMaskWidth
            // 
            this.numMeanMaskWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMeanMaskWidth.Location = new System.Drawing.Point(177, 3);
            this.numMeanMaskWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMeanMaskWidth.Name = "numMeanMaskWidth";
            this.numMeanMaskWidth.Size = new System.Drawing.Size(48, 20);
            this.numMeanMaskWidth.TabIndex = 20;
            this.toolTip.SetToolTip(this.numMeanMaskWidth, "Mask Width");
            // 
            // numUnsharpSigma
            // 
            this.numUnsharpSigma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUnsharpSigma.DecimalPlaces = 1;
            this.numUnsharpSigma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUnsharpSigma.Location = new System.Drawing.Point(228, 47);
            this.numUnsharpSigma.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUnsharpSigma.Name = "numUnsharpSigma";
            this.numUnsharpSigma.Size = new System.Drawing.Size(48, 20);
            this.numUnsharpSigma.TabIndex = 27;
            this.toolTip.SetToolTip(this.numUnsharpSigma, "Sigma");
            // 
            // numMeanMaskHeight
            // 
            this.numMeanMaskHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMeanMaskHeight.Location = new System.Drawing.Point(228, 3);
            this.numMeanMaskHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMeanMaskHeight.Name = "numMeanMaskHeight";
            this.numMeanMaskHeight.Size = new System.Drawing.Size(48, 20);
            this.numMeanMaskHeight.TabIndex = 21;
            this.toolTip.SetToolTip(this.numMeanMaskHeight, "Mask Height");
            // 
            // numUnsharpMaskSize
            // 
            this.numUnsharpMaskSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUnsharpMaskSize.Location = new System.Drawing.Point(177, 47);
            this.numUnsharpMaskSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUnsharpMaskSize.Name = "numUnsharpMaskSize";
            this.numUnsharpMaskSize.Size = new System.Drawing.Size(48, 20);
            this.numUnsharpMaskSize.TabIndex = 26;
            this.toolTip.SetToolTip(this.numUnsharpMaskSize, "Mask Size");
            // 
            // numMeanOriginX
            // 
            this.numMeanOriginX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMeanOriginX.Location = new System.Drawing.Point(279, 3);
            this.numMeanOriginX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMeanOriginX.Name = "numMeanOriginX";
            this.numMeanOriginX.Size = new System.Drawing.Size(48, 20);
            this.numMeanOriginX.TabIndex = 22;
            this.toolTip.SetToolTip(this.numMeanOriginX, "Origin X");
            // 
            // numMeanOriginY
            // 
            this.numMeanOriginY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMeanOriginY.Location = new System.Drawing.Point(330, 3);
            this.numMeanOriginY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMeanOriginY.Name = "numMeanOriginY";
            this.numMeanOriginY.Size = new System.Drawing.Size(48, 20);
            this.numMeanOriginY.TabIndex = 23;
            this.toolTip.SetToolTip(this.numMeanOriginY, "Origin Y");
            // 
            // numUnsharpK
            // 
            this.numUnsharpK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUnsharpK.DecimalPlaces = 1;
            this.numUnsharpK.Location = new System.Drawing.Point(279, 47);
            this.numUnsharpK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUnsharpK.Name = "numUnsharpK";
            this.numUnsharpK.Size = new System.Drawing.Size(48, 20);
            this.numUnsharpK.TabIndex = 28;
            this.toolTip.SetToolTip(this.numUnsharpK, "K value");
            // 
            // rdioLHE
            // 
            this.rdioLHE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioLHE.AutoSize = true;
            this.rdioLHE.Location = new System.Drawing.Point(52, 36);
            this.rdioLHE.Name = "rdioLHE";
            this.rdioLHE.Size = new System.Drawing.Size(46, 17);
            this.rdioLHE.TabIndex = 28;
            this.rdioLHE.Text = "LHE";
            this.toolTip.SetToolTip(this.rdioLHE, "Local Histogram Equalization");
            this.rdioLHE.UseVisualStyleBackColor = true;
            // 
            // numStatsE
            // 
            this.numStatsE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStatsE.DecimalPlaces = 2;
            this.numStatsE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numStatsE.Location = new System.Drawing.Point(174, 60);
            this.numStatsE.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatsE.Name = "numStatsE";
            this.numStatsE.Size = new System.Drawing.Size(48, 20);
            this.numStatsE.TabIndex = 39;
            this.toolTip.SetToolTip(this.numStatsE, "E value");
            // 
            // numStatsWindow
            // 
            this.numStatsWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStatsWindow.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numStatsWindow.Location = new System.Drawing.Point(123, 60);
            this.numStatsWindow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatsWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStatsWindow.Name = "numStatsWindow";
            this.numStatsWindow.Size = new System.Drawing.Size(48, 20);
            this.numStatsWindow.TabIndex = 38;
            this.toolTip.SetToolTip(this.numStatsWindow, "Window Size");
            this.numStatsWindow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numStatsK1
            // 
            this.numStatsK1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStatsK1.DecimalPlaces = 2;
            this.numStatsK1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numStatsK1.Location = new System.Drawing.Point(277, 60);
            this.numStatsK1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatsK1.Name = "numStatsK1";
            this.numStatsK1.Size = new System.Drawing.Size(48, 20);
            this.numStatsK1.TabIndex = 41;
            this.toolTip.SetToolTip(this.numStatsK1, "K1");
            // 
            // numStatsK0
            // 
            this.numStatsK0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStatsK0.DecimalPlaces = 2;
            this.numStatsK0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numStatsK0.Location = new System.Drawing.Point(226, 60);
            this.numStatsK0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatsK0.Name = "numStatsK0";
            this.numStatsK0.Size = new System.Drawing.Size(48, 20);
            this.numStatsK0.TabIndex = 40;
            this.toolTip.SetToolTip(this.numStatsK0, "K0");
            // 
            // numStatsK2
            // 
            this.numStatsK2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numStatsK2.DecimalPlaces = 2;
            this.numStatsK2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numStatsK2.Location = new System.Drawing.Point(328, 60);
            this.numStatsK2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStatsK2.Name = "numStatsK2";
            this.numStatsK2.Size = new System.Drawing.Size(48, 20);
            this.numStatsK2.TabIndex = 42;
            this.toolTip.SetToolTip(this.numStatsK2, "K2");
            // 
            // numLHEWindow
            // 
            this.numLHEWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numLHEWindow.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLHEWindow.Location = new System.Drawing.Point(123, 35);
            this.numLHEWindow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLHEWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLHEWindow.Name = "numLHEWindow";
            this.numLHEWindow.Size = new System.Drawing.Size(48, 20);
            this.numLHEWindow.TabIndex = 37;
            this.toolTip.SetToolTip(this.numLHEWindow, "Window Size");
            this.numLHEWindow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRtnxSigma
            // 
            this.numRtnxSigma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numRtnxSigma.DecimalPlaces = 2;
            this.numRtnxSigma.Location = new System.Drawing.Point(123, 10);
            this.numRtnxSigma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRtnxSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numRtnxSigma.Name = "numRtnxSigma";
            this.numRtnxSigma.Size = new System.Drawing.Size(48, 20);
            this.numRtnxSigma.TabIndex = 36;
            this.toolTip.SetToolTip(this.numRtnxSigma, "Sigma");
            this.numRtnxSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCustomOriginX
            // 
            this.numCustomOriginX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCustomOriginX.Location = new System.Drawing.Point(338, 10);
            this.numCustomOriginX.Name = "numCustomOriginX";
            this.numCustomOriginX.Size = new System.Drawing.Size(47, 20);
            this.numCustomOriginX.TabIndex = 22;
            this.toolTip.SetToolTip(this.numCustomOriginX, "Origin X");
            // 
            // numCustomOriginY
            // 
            this.numCustomOriginY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numCustomOriginY.Location = new System.Drawing.Point(390, 10);
            this.numCustomOriginY.Name = "numCustomOriginY";
            this.numCustomOriginY.Size = new System.Drawing.Size(47, 20);
            this.numCustomOriginY.TabIndex = 23;
            this.toolTip.SetToolTip(this.numCustomOriginY, "Origin Y");
            // 
            // cmboCustomPost
            // 
            this.cmboCustomPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmboCustomPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCustomPost.FormattingEnabled = true;
            this.cmboCustomPost.Items.AddRange(new object[] {
            "(Without)",
            "Normalization",
            "Absolute",
            "Cut-off"});
            this.cmboCustomPost.Location = new System.Drawing.Point(338, 32);
            this.cmboCustomPost.Name = "cmboCustomPost";
            this.cmboCustomPost.Size = new System.Drawing.Size(99, 21);
            this.cmboCustomPost.TabIndex = 36;
            this.toolTip.SetToolTip(this.cmboCustomPost, "Post Processing");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.imagesTableLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.54971F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1165, 561);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 414);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1159, 144);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 138);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdioMLGaussian);
            this.tabPage3.Controls.Add(this.numRtnxSigma);
            this.tabPage3.Controls.Add(this.numLHEWindow);
            this.tabPage3.Controls.Add(this.numStatsK2);
            this.tabPage3.Controls.Add(this.numStatsK1);
            this.tabPage3.Controls.Add(this.numStatsK0);
            this.tabPage3.Controls.Add(this.btnMatlabApply);
            this.tabPage3.Controls.Add(this.rdioStats);
            this.tabPage3.Controls.Add(this.rdioLHE);
            this.tabPage3.Controls.Add(this.rdioRtnx);
            this.tabPage3.Controls.Add(this.numStatsE);
            this.tabPage3.Controls.Add(this.numStatsWindow);
            this.tabPage3.Controls.Add(this.slideMLGaussian);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(496, 112);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filters [MATLAB]";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rdioMLGaussian
            // 
            this.rdioMLGaussian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioMLGaussian.AutoSize = true;
            this.rdioMLGaussian.Location = new System.Drawing.Point(52, 83);
            this.rdioMLGaussian.Name = "rdioMLGaussian";
            this.rdioMLGaussian.Size = new System.Drawing.Size(69, 17);
            this.rdioMLGaussian.TabIndex = 44;
            this.rdioMLGaussian.Text = "Gaussian";
            this.rdioMLGaussian.UseVisualStyleBackColor = true;
            // 
            // btnMatlabApply
            // 
            this.btnMatlabApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatlabApply.Location = new System.Drawing.Point(404, 36);
            this.btnMatlabApply.Name = "btnMatlabApply";
            this.btnMatlabApply.Size = new System.Drawing.Size(63, 44);
            this.btnMatlabApply.TabIndex = 43;
            this.btnMatlabApply.Text = "Apply";
            this.btnMatlabApply.UseVisualStyleBackColor = true;
            this.btnMatlabApply.Click += new System.EventHandler(this.btnMatlabApply_Click);
            // 
            // rdioStats
            // 
            this.rdioStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioStats.AutoSize = true;
            this.rdioStats.Location = new System.Drawing.Point(52, 60);
            this.rdioStats.Name = "rdioStats";
            this.rdioStats.Size = new System.Drawing.Size(70, 17);
            this.rdioStats.TabIndex = 29;
            this.rdioStats.Text = "Statistical";
            this.rdioStats.UseVisualStyleBackColor = true;
            // 
            // rdioRtnx
            // 
            this.rdioRtnx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioRtnx.AutoSize = true;
            this.rdioRtnx.Checked = true;
            this.rdioRtnx.Location = new System.Drawing.Point(52, 12);
            this.rdioRtnx.Name = "rdioRtnx";
            this.rdioRtnx.Size = new System.Drawing.Size(61, 17);
            this.rdioRtnx.TabIndex = 27;
            this.rdioRtnx.TabStop = true;
            this.rdioRtnx.Text = "Retinex";
            this.rdioRtnx.UseVisualStyleBackColor = true;
            // 
            // slideMLGaussian
            // 
            this.slideMLGaussian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slideMLGaussian.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slideMLGaussian.LargeChange = 10;
            this.slideMLGaussian.Location = new System.Drawing.Point(115, 83);
            this.slideMLGaussian.Margin = new System.Windows.Forms.Padding(0);
            this.slideMLGaussian.Maximum = 200;
            this.slideMLGaussian.Name = "slideMLGaussian";
            this.slideMLGaussian.Size = new System.Drawing.Size(143, 45);
            this.slideMLGaussian.TabIndex = 3;
            this.slideMLGaussian.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideMLGaussian.Scroll += new System.EventHandler(this.slideMLGaussian_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmboKirsch);
            this.tabPage2.Controls.Add(this.numUnsharpK);
            this.tabPage2.Controls.Add(this.numMeanOriginX);
            this.tabPage2.Controls.Add(this.numMeanOriginY);
            this.tabPage2.Controls.Add(this.rdioLaplaceSharp);
            this.tabPage2.Controls.Add(this.rdioKirschEdge);
            this.tabPage2.Controls.Add(this.rdioMean);
            this.tabPage2.Controls.Add(this.btnTask3Apply);
            this.tabPage2.Controls.Add(this.rdioGaussian);
            this.tabPage2.Controls.Add(this.numGaussMaskSize);
            this.tabPage2.Controls.Add(this.rdioUnsharp);
            this.tabPage2.Controls.Add(this.numGaussSigma);
            this.tabPage2.Controls.Add(this.numMeanMaskWidth);
            this.tabPage2.Controls.Add(this.numUnsharpSigma);
            this.tabPage2.Controls.Add(this.numMeanMaskHeight);
            this.tabPage2.Controls.Add(this.numUnsharpMaskSize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 112);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmboKirsch
            // 
            this.cmboKirsch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmboKirsch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboKirsch.FormattingEnabled = true;
            this.cmboKirsch.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Diagonal 1 (\\)",
            "Diagonal 2 (/)"});
            this.cmboKirsch.Location = new System.Drawing.Point(177, 69);
            this.cmboKirsch.Name = "cmboKirsch";
            this.cmboKirsch.Size = new System.Drawing.Size(99, 21);
            this.cmboKirsch.TabIndex = 35;
            // 
            // rdioLaplaceSharp
            // 
            this.rdioLaplaceSharp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioLaplaceSharp.AutoSize = true;
            this.rdioLaplaceSharp.Location = new System.Drawing.Point(44, 90);
            this.rdioLaplaceSharp.Name = "rdioLaplaceSharp";
            this.rdioLaplaceSharp.Size = new System.Drawing.Size(128, 17);
            this.rdioLaplaceSharp.TabIndex = 29;
            this.rdioLaplaceSharp.Text = "Laplacian Sharpening";
            this.rdioLaplaceSharp.UseVisualStyleBackColor = true;
            // 
            // rdioKirschEdge
            // 
            this.rdioKirschEdge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioKirschEdge.AutoSize = true;
            this.rdioKirschEdge.Location = new System.Drawing.Point(44, 69);
            this.rdioKirschEdge.Name = "rdioKirschEdge";
            this.rdioKirschEdge.Size = new System.Drawing.Size(131, 17);
            this.rdioKirschEdge.TabIndex = 31;
            this.rdioKirschEdge.Text = "Kirsch Edge Detection";
            this.rdioKirschEdge.UseVisualStyleBackColor = true;
            // 
            // rdioMean
            // 
            this.rdioMean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioMean.AutoSize = true;
            this.rdioMean.Checked = true;
            this.rdioMean.Location = new System.Drawing.Point(44, 5);
            this.rdioMean.Name = "rdioMean";
            this.rdioMean.Size = new System.Drawing.Size(73, 17);
            this.rdioMean.TabIndex = 19;
            this.rdioMean.TabStop = true;
            this.rdioMean.Text = "Mean Blur";
            this.rdioMean.UseVisualStyleBackColor = true;
            // 
            // btnTask3Apply
            // 
            this.btnTask3Apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTask3Apply.Location = new System.Drawing.Point(388, 33);
            this.btnTask3Apply.Name = "btnTask3Apply";
            this.btnTask3Apply.Size = new System.Drawing.Size(63, 44);
            this.btnTask3Apply.TabIndex = 19;
            this.btnTask3Apply.Text = "Apply";
            this.btnTask3Apply.UseVisualStyleBackColor = true;
            this.btnTask3Apply.Click += new System.EventHandler(this.btnTask3Apply_Click);
            // 
            // rdioGaussian
            // 
            this.rdioGaussian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioGaussian.AutoSize = true;
            this.rdioGaussian.Location = new System.Drawing.Point(44, 26);
            this.rdioGaussian.Name = "rdioGaussian";
            this.rdioGaussian.Size = new System.Drawing.Size(90, 17);
            this.rdioGaussian.TabIndex = 28;
            this.rdioGaussian.Text = "Gaussian Blur";
            this.rdioGaussian.UseVisualStyleBackColor = true;
            // 
            // rdioUnsharp
            // 
            this.rdioUnsharp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioUnsharp.AutoSize = true;
            this.rdioUnsharp.Location = new System.Drawing.Point(44, 48);
            this.rdioUnsharp.Name = "rdioUnsharp";
            this.rdioUnsharp.Size = new System.Drawing.Size(65, 17);
            this.rdioUnsharp.TabIndex = 30;
            this.rdioUnsharp.Text = "Unsharp";
            this.rdioUnsharp.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSaveMask);
            this.tabPage4.Controls.Add(this.btnOpenMask);
            this.tabPage4.Controls.Add(this.cmboCustomPost);
            this.tabPage4.Controls.Add(this.numCustomOriginY);
            this.tabPage4.Controls.Add(this.numCustomOriginX);
            this.tabPage4.Controls.Add(this.txtCustomFilter);
            this.tabPage4.Controls.Add(this.btnCustomApply);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(496, 112);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Custom Filter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtCustomFilter
            // 
            this.txtCustomFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomFilter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomFilter.Location = new System.Drawing.Point(133, 10);
            this.txtCustomFilter.Multiline = true;
            this.txtCustomFilter.Name = "txtCustomFilter";
            this.txtCustomFilter.Size = new System.Drawing.Size(198, 92);
            this.txtCustomFilter.TabIndex = 21;
            this.txtCustomFilter.Text = " 0  -2   0\r\n-2   9  -2\r\n 0  -2   0";
            // 
            // btnCustomApply
            // 
            this.btnCustomApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomApply.Location = new System.Drawing.Point(337, 59);
            this.btnCustomApply.Name = "btnCustomApply";
            this.btnCustomApply.Size = new System.Drawing.Size(63, 44);
            this.btnCustomApply.TabIndex = 20;
            this.btnCustomApply.Text = "Apply";
            this.btnCustomApply.UseVisualStyleBackColor = true;
            this.btnCustomApply.Click += new System.EventHandler(this.btnCustomApply_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTask1Apply);
            this.tabPage1.Controls.Add(this.rdioAll);
            this.tabPage1.Controls.Add(this.numRotX);
            this.tabPage1.Controls.Add(this.rdioShear);
            this.tabPage1.Controls.Add(this.numRotY);
            this.tabPage1.Controls.Add(this.rdioRotation);
            this.tabPage1.Controls.Add(this.numRotAngle);
            this.tabPage1.Controls.Add(this.rdioScale);
            this.tabPage1.Controls.Add(this.numScaleX);
            this.tabPage1.Controls.Add(this.numShearY);
            this.tabPage1.Controls.Add(this.numScaleY);
            this.tabPage1.Controls.Add(this.numShearX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transformations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTask1Apply
            // 
            this.btnTask1Apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTask1Apply.Location = new System.Drawing.Point(329, 33);
            this.btnTask1Apply.Name = "btnTask1Apply";
            this.btnTask1Apply.Size = new System.Drawing.Size(63, 44);
            this.btnTask1Apply.TabIndex = 4;
            this.btnTask1Apply.Text = "Apply";
            this.btnTask1Apply.UseVisualStyleBackColor = true;
            this.btnTask1Apply.Click += new System.EventHandler(this.btnTask1Apply_Click);
            // 
            // rdioAll
            // 
            this.rdioAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioAll.AutoSize = true;
            this.rdioAll.Checked = true;
            this.rdioAll.Location = new System.Drawing.Point(95, 83);
            this.rdioAll.Name = "rdioAll";
            this.rdioAll.Size = new System.Drawing.Size(42, 17);
            this.rdioAll.TabIndex = 18;
            this.rdioAll.TabStop = true;
            this.rdioAll.Text = "(All)";
            this.rdioAll.UseVisualStyleBackColor = true;
            // 
            // rdioShear
            // 
            this.rdioShear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioShear.AutoSize = true;
            this.rdioShear.Location = new System.Drawing.Point(95, 60);
            this.rdioShear.Name = "rdioShear";
            this.rdioShear.Size = new System.Drawing.Size(53, 17);
            this.rdioShear.TabIndex = 17;
            this.rdioShear.Text = "Shear";
            this.rdioShear.UseVisualStyleBackColor = true;
            // 
            // rdioRotation
            // 
            this.rdioRotation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioRotation.AutoSize = true;
            this.rdioRotation.Location = new System.Drawing.Point(95, 36);
            this.rdioRotation.Name = "rdioRotation";
            this.rdioRotation.Size = new System.Drawing.Size(65, 17);
            this.rdioRotation.TabIndex = 16;
            this.rdioRotation.Text = "Rotation";
            this.rdioRotation.UseVisualStyleBackColor = true;
            // 
            // rdioScale
            // 
            this.rdioScale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdioScale.AutoSize = true;
            this.rdioScale.Location = new System.Drawing.Point(95, 12);
            this.rdioScale.Name = "rdioScale";
            this.rdioScale.Size = new System.Drawing.Size(52, 17);
            this.rdioScale.TabIndex = 15;
            this.rdioScale.Text = "Scale";
            this.rdioScale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chckSecondImage);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(513, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 138);
            this.panel1.TabIndex = 19;
            // 
            // chckSecondImage
            // 
            this.chckSecondImage.AutoSize = true;
            this.chckSecondImage.Location = new System.Drawing.Point(21, 115);
            this.chckSecondImage.Name = "chckSecondImage";
            this.chckSecondImage.Size = new System.Drawing.Size(94, 17);
            this.chckSecondImage.TabIndex = 4;
            this.chckSecondImage.Text = "Second image";
            this.chckSecondImage.UseVisualStyleBackColor = true;
            this.chckSecondImage.CheckedChanged += new System.EventHandler(this.chckSecondImage_CheckedChanged);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.Location = new System.Drawing.Point(3, 84);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 27);
            this.button9.TabIndex = 3;
            this.button9.Text = "Open Second Image";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnOpenSecond_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrgnlHisto);
            this.groupBox1.Controls.Add(this.numAddFraction);
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
            this.groupBox1.Controls.Add(this.slideGamma);
            this.groupBox1.Controls.Add(this.slideBrightness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slideContrast);
            this.groupBox1.Controls.Add(this.btnGrayscale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(651, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enhancements";
            // 
            // btnOrgnlHisto
            // 
            this.btnOrgnlHisto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOrgnlHisto.Location = new System.Drawing.Point(319, 95);
            this.btnOrgnlHisto.Name = "btnOrgnlHisto";
            this.btnOrgnlHisto.Size = new System.Drawing.Size(178, 23);
            this.btnOrgnlHisto.TabIndex = 21;
            this.btnOrgnlHisto.Text = "Restore Original Image";
            this.btnOrgnlHisto.UseVisualStyleBackColor = true;
            this.btnOrgnlHisto.Click += new System.EventHandler(this.btnRestoreOriginal_Click);
            // 
            // numAddFraction
            // 
            this.numAddFraction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numAddFraction.DecimalPlaces = 2;
            this.numAddFraction.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numAddFraction.Location = new System.Drawing.Point(276, 51);
            this.numAddFraction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddFraction.Name = "numAddFraction";
            this.numAddFraction.Size = new System.Drawing.Size(42, 20);
            this.numAddFraction.TabIndex = 20;
            this.toolTip.SetToolTip(this.numAddFraction, "Adding fraction");
            this.numAddFraction.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gamma:";
            // 
            // btnSlice
            // 
            this.btnSlice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSlice.Location = new System.Drawing.Point(144, 97);
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
            this.txtBitMask.Location = new System.Drawing.Point(68, 99);
            this.txtBitMask.Name = "txtBitMask";
            this.txtBitMask.Size = new System.Drawing.Size(75, 20);
            this.txtBitMask.TabIndex = 12;
            this.txtBitMask.Text = "10000000";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bit-Mask:";
            // 
            // btnNegative
            // 
            this.btnNegative.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNegative.Location = new System.Drawing.Point(319, 72);
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
            this.btnSubtract.Location = new System.Drawing.Point(408, 49);
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
            this.btnAdd.Location = new System.Drawing.Point(319, 49);
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
            this.btnMatch.Location = new System.Drawing.Point(408, 26);
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
            this.btnEqualize.Location = new System.Drawing.Point(319, 26);
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
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brightness:";
            // 
            // slideGamma
            // 
            this.slideGamma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.slideGamma.LargeChange = 2;
            this.slideGamma.Location = new System.Drawing.Point(60, 74);
            this.slideGamma.Margin = new System.Windows.Forms.Padding(0);
            this.slideGamma.Maximum = 100;
            this.slideGamma.Name = "slideGamma";
            this.slideGamma.Size = new System.Drawing.Size(143, 45);
            this.slideGamma.TabIndex = 5;
            this.slideGamma.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideGamma.Value = 10;
            this.slideGamma.ValueChanged += new System.EventHandler(this.slideGamma_ValueChanged);
            // 
            // slideBrightness
            // 
            this.slideBrightness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.slideBrightness.LargeChange = 15;
            this.slideBrightness.Location = new System.Drawing.Point(60, 50);
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
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contrast:";
            // 
            // slideContrast
            // 
            this.slideContrast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.slideContrast.LargeChange = 15;
            this.slideContrast.Location = new System.Drawing.Point(60, 27);
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
            this.btnGrayscale.Location = new System.Drawing.Point(408, 72);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(89, 23);
            this.btnGrayscale.TabIndex = 0;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // imagesTableLayoutPanel
            // 
            this.imagesTableLayoutPanel.ColumnCount = 3;
            this.imagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.imagesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.imagesTableLayoutPanel.Controls.Add(this.rightPictureBox, 0, 0);
            this.imagesTableLayoutPanel.Controls.Add(this.middlePictureBox, 0, 0);
            this.imagesTableLayoutPanel.Controls.Add(this.leftPictureBox, 0, 0);
            this.imagesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.imagesTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.imagesTableLayoutPanel.Name = "imagesTableLayoutPanel";
            this.imagesTableLayoutPanel.RowCount = 1;
            this.imagesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imagesTableLayoutPanel.Size = new System.Drawing.Size(1165, 411);
            this.imagesTableLayoutPanel.TabIndex = 13;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPictureBox.Location = new System.Drawing.Point(864, 0);
            this.rightPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(301, 411);
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
            this.middlePictureBox.Location = new System.Drawing.Point(432, 0);
            this.middlePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(432, 411);
            this.middlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.middlePictureBox.TabIndex = 12;
            this.middlePictureBox.TabStop = false;
            this.middlePictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.middlePictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
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
            this.leftPictureBox.Size = new System.Drawing.Size(432, 411);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.leftPictureBox.TabIndex = 0;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.leftPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            this.leftPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_DoubleClick);
            this.leftPictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // imageSaveDialog
            // 
            this.imageSaveDialog.DefaultExt = "jpg";
            this.imageSaveDialog.FileName = "image";
            // 
            // btnOpenMask
            // 
            this.btnOpenMask.Location = new System.Drawing.Point(52, 10);
            this.btnOpenMask.Name = "btnOpenMask";
            this.btnOpenMask.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMask.TabIndex = 37;
            this.btnOpenMask.Text = "Open Mask";
            this.btnOpenMask.UseVisualStyleBackColor = true;
            this.btnOpenMask.Click += new System.EventHandler(this.btnOpenMask_Click);
            // 
            // btnSaveMask
            // 
            this.btnSaveMask.Location = new System.Drawing.Point(52, 33);
            this.btnSaveMask.Name = "btnSaveMask";
            this.btnSaveMask.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMask.TabIndex = 38;
            this.btnSaveMask.Text = "Save Mask";
            this.btnSaveMask.UseVisualStyleBackColor = true;
            this.btnSaveMask.Click += new System.EventHandler(this.btnSaveMask_Click);
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaussMaskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGaussSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanMaskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnsharpSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanMaskHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnsharpMaskSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanOriginX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeanOriginY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnsharpK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsK0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStatsK2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLHEWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRtnxSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomOriginX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomOriginY)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideMLGaussian)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddFraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideContrast)).EndInit();
            this.imagesTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel imagesTableLayoutPanel;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.SaveFileDialog imageSaveDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numAddFraction;
        private System.Windows.Forms.Button btnOrgnlHisto;
        private System.Windows.Forms.TrackBar slideGamma;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTask1Apply;
        private System.Windows.Forms.RadioButton rdioAll;
        private System.Windows.Forms.NumericUpDown numRotX;
        private System.Windows.Forms.RadioButton rdioShear;
        private System.Windows.Forms.NumericUpDown numRotY;
        private System.Windows.Forms.RadioButton rdioRotation;
        private System.Windows.Forms.NumericUpDown numRotAngle;
        private System.Windows.Forms.RadioButton rdioScale;
        private System.Windows.Forms.NumericUpDown numScaleX;
        private System.Windows.Forms.NumericUpDown numShearY;
        private System.Windows.Forms.NumericUpDown numScaleY;
        private System.Windows.Forms.NumericUpDown numShearX;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdioLaplaceSharp;
        private System.Windows.Forms.RadioButton rdioKirschEdge;
        private System.Windows.Forms.RadioButton rdioMean;
        private System.Windows.Forms.Button btnTask3Apply;
        private System.Windows.Forms.RadioButton rdioGaussian;
        private System.Windows.Forms.NumericUpDown numGaussMaskSize;
        private System.Windows.Forms.RadioButton rdioUnsharp;
        private System.Windows.Forms.NumericUpDown numGaussSigma;
        private System.Windows.Forms.NumericUpDown numMeanMaskWidth;
        private System.Windows.Forms.NumericUpDown numUnsharpSigma;
        private System.Windows.Forms.NumericUpDown numMeanMaskHeight;
        private System.Windows.Forms.NumericUpDown numUnsharpMaskSize;
        private System.Windows.Forms.NumericUpDown numMeanOriginX;
        private System.Windows.Forms.NumericUpDown numMeanOriginY;
        private System.Windows.Forms.NumericUpDown numUnsharpK;
        private System.Windows.Forms.ComboBox cmboKirsch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMatlabApply;
        private System.Windows.Forms.RadioButton rdioStats;
        private System.Windows.Forms.RadioButton rdioLHE;
        private System.Windows.Forms.RadioButton rdioRtnx;
        private System.Windows.Forms.NumericUpDown numStatsE;
        private System.Windows.Forms.NumericUpDown numStatsWindow;
        private System.Windows.Forms.NumericUpDown numRtnxSigma;
        private System.Windows.Forms.NumericUpDown numLHEWindow;
        private System.Windows.Forms.NumericUpDown numStatsK2;
        private System.Windows.Forms.NumericUpDown numStatsK1;
        private System.Windows.Forms.NumericUpDown numStatsK0;
        private System.Windows.Forms.TrackBar slideMLGaussian;
        private System.Windows.Forms.RadioButton rdioMLGaussian;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtCustomFilter;
        private System.Windows.Forms.Button btnCustomApply;
        private System.Windows.Forms.NumericUpDown numCustomOriginY;
        private System.Windows.Forms.NumericUpDown numCustomOriginX;
        private System.Windows.Forms.ComboBox cmboCustomPost;
        private System.Windows.Forms.CheckBox chckSecondImage;
        private System.Windows.Forms.Button btnSaveMask;
        private System.Windows.Forms.Button btnOpenMask;
    }
}

