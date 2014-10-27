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
            this.grpboxTask1 = new System.Windows.Forms.GroupBox();
            this.rdioAll = new System.Windows.Forms.RadioButton();
            this.rdioShear = new System.Windows.Forms.RadioButton();
            this.rdioRotation = new System.Windows.Forms.RadioButton();
            this.rdioScale = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpboxTask1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(391, 31);
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
            this.numRotX.Location = new System.Drawing.Point(108, 44);
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
            this.numRotY.Location = new System.Drawing.Point(159, 44);
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
            this.numRotAngle.Location = new System.Drawing.Point(210, 44);
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
            this.numRotAngle.Size = new System.Drawing.Size(38, 20);
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
            this.numScaleY.Location = new System.Drawing.Point(159, 19);
            this.numScaleY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.numScaleX.Location = new System.Drawing.Point(108, 19);
            this.numScaleX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.numShearY.Location = new System.Drawing.Point(159, 69);
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
            this.numShearX.Location = new System.Drawing.Point(108, 69);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(914, 561);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnOpen, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.grpboxTask1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(908, 125);
            this.tableLayoutPanel3.TabIndex = 3;
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
            this.grpboxTask1.Size = new System.Drawing.Size(379, 119);
            this.grpboxTask1.TabIndex = 2;
            this.grpboxTask1.TabStop = false;
            this.grpboxTask1.Text = "Task 1";
            // 
            // rdioAll
            // 
            this.rdioAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioAll.AutoSize = true;
            this.rdioAll.Location = new System.Drawing.Point(37, 92);
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
            this.rdioShear.Location = new System.Drawing.Point(37, 69);
            this.rdioShear.Name = "rdioShear";
            this.rdioShear.Size = new System.Drawing.Size(53, 17);
            this.rdioShear.TabIndex = 17;
            this.rdioShear.TabStop = true;
            this.rdioShear.Text = "Shear";
            this.rdioShear.UseVisualStyleBackColor = true;
            // 
            // rdioRotation
            // 
            this.rdioRotation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioRotation.AutoSize = true;
            this.rdioRotation.Location = new System.Drawing.Point(37, 45);
            this.rdioRotation.Name = "rdioRotation";
            this.rdioRotation.Size = new System.Drawing.Size(65, 17);
            this.rdioRotation.TabIndex = 16;
            this.rdioRotation.TabStop = true;
            this.rdioRotation.Text = "Rotation";
            this.rdioRotation.UseVisualStyleBackColor = true;
            // 
            // rdioScale
            // 
            this.rdioScale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdioScale.AutoSize = true;
            this.rdioScale.Location = new System.Drawing.Point(37, 21);
            this.rdioScale.Name = "rdioScale";
            this.rdioScale.Size = new System.Drawing.Size(52, 17);
            this.rdioScale.TabIndex = 15;
            this.rdioScale.TabStop = true;
            this.rdioScale.Text = "Scale";
            this.rdioScale.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnApply.Location = new System.Drawing.Point(271, 42);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(63, 44);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.leftPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightPictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 430);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPictureBox.Location = new System.Drawing.Point(0, 0);
            this.leftPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(457, 430);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.leftPictureBox.TabIndex = 0;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_DoubleClick);
            this.leftPictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPictureBox.Location = new System.Drawing.Point(457, 0);
            this.rightPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(457, 430);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rightPictureBox.TabIndex = 11;
            this.rightPictureBox.TabStop = false;
            this.rightPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_DoubleClick);
            this.rightPictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "jpg";
            this.saveDialog.FileName = "image";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDialog_FileOk);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
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
            this.grpboxTask1.ResumeLayout(false);
            this.grpboxTask1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
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
    }
}

