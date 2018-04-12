namespace CoreCV
{
    partial class CameraCalibration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.StatusCalibLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CamTypComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadDescrFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.buttonSaveCalibration = new System.Windows.Forms.Button();
            this.tabInterParam = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.buttonSaveCamParams = new System.Windows.Forms.Button();
            this.buttonImportParams = new System.Windows.Forms.Button();
            this.camInterParamStart = new CoreCV.CamInterParameter();
            this.tabPageFound = new System.Windows.Forms.TabPage();
            this.camInterParamFound = new CoreCV.CamInterParameter();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDefaultParams = new System.Windows.Forms.Button();
            this.hWndView1 = new ViewROI.HWndView();
            this.camExternParameter = new CoreCV.CamExternParameter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabInterParam.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(358, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 24);
            this.label20.TabIndex = 38;
            this.label20.Text = " pixels";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(13, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 24);
            this.label22.TabIndex = 37;
            this.label22.Text = "Mean Error";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ErrorLabel.Location = new System.Drawing.Point(77, 82);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(280, 24);
            this.ErrorLabel.TabIndex = 36;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(13, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 24);
            this.label21.TabIndex = 35;
            this.label21.Text = "Status";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusCalibLabel
            // 
            this.StatusCalibLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusCalibLabel.Location = new System.Drawing.Point(77, 47);
            this.StatusCalibLabel.Name = "StatusCalibLabel";
            this.StatusCalibLabel.Size = new System.Drawing.Size(280, 24);
            this.StatusCalibLabel.TabIndex = 34;
            this.StatusCalibLabel.Text = "No calibration data available";
            this.StatusCalibLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorLabel);
            this.groupBox1.Controls.Add(this.CamTypComboBox);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StatusCalibLabel);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 121);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // CamTypComboBox
            // 
            this.CamTypComboBox.Location = new System.Drawing.Point(77, 18);
            this.CamTypComboBox.Name = "CamTypComboBox";
            this.CamTypComboBox.Size = new System.Drawing.Size(280, 21);
            this.CamTypComboBox.TabIndex = 45;
            this.CamTypComboBox.Text = "camera name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Camera";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescr
            // 
            this.textBoxDescr.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxDescr.Location = new System.Drawing.Point(107, 17);
            this.textBoxDescr.Name = "textBoxDescr";
            this.textBoxDescr.ReadOnly = true;
            this.textBoxDescr.Size = new System.Drawing.Size(144, 20);
            this.textBoxDescr.TabIndex = 45;
            this.textBoxDescr.Text = ".descr";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(257, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "mm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThicknessUpDown
            // 
            this.ThicknessUpDown.DecimalPlaces = 3;
            this.ThicknessUpDown.Location = new System.Drawing.Point(107, 43);
            this.ThicknessUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ThicknessUpDown.Name = "ThicknessUpDown";
            this.ThicknessUpDown.Size = new System.Drawing.Size(144, 20);
            this.ThicknessUpDown.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thickness(z)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLoadDescrFile
            // 
            this.buttonLoadDescrFile.Location = new System.Drawing.Point(324, 19);
            this.buttonLoadDescrFile.Name = "buttonLoadDescrFile";
            this.buttonLoadDescrFile.Size = new System.Drawing.Size(100, 50);
            this.buttonLoadDescrFile.TabIndex = 41;
            this.buttonLoadDescrFile.Text = "Load File";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Description File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ThicknessUpDown);
            this.groupBox2.Controls.Add(this.textBoxDescr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonLoadDescrFile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 80);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calibration plate";
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Enabled = false;
            this.buttonCalibrate.Location = new System.Drawing.Point(1133, 28);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(100, 50);
            this.buttonCalibrate.TabIndex = 42;
            this.buttonCalibrate.Text = "Calibrate";
            // 
            // buttonSaveCalibration
            // 
            this.buttonSaveCalibration.Enabled = false;
            this.buttonSaveCalibration.Location = new System.Drawing.Point(1133, 84);
            this.buttonSaveCalibration.Name = "buttonSaveCalibration";
            this.buttonSaveCalibration.Size = new System.Drawing.Size(100, 50);
            this.buttonSaveCalibration.TabIndex = 43;
            this.buttonSaveCalibration.Text = "Save calibration";
            // 
            // tabInterParam
            // 
            this.tabInterParam.Controls.Add(this.tabPageStart);
            this.tabInterParam.Controls.Add(this.tabPageFound);
            this.tabInterParam.Location = new System.Drawing.Point(7, 215);
            this.tabInterParam.Name = "tabInterParam";
            this.tabInterParam.SelectedIndex = 0;
            this.tabInterParam.Size = new System.Drawing.Size(430, 320);
            this.tabInterParam.TabIndex = 47;
            // 
            // tabPageStart
            // 
            this.tabPageStart.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageStart.Controls.Add(this.buttonSaveCamParams);
            this.tabPageStart.Controls.Add(this.buttonImportParams);
            this.tabPageStart.Controls.Add(this.camInterParamStart);
            this.tabPageStart.Location = new System.Drawing.Point(4, 22);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(422, 294);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "Start parameters";
            // 
            // buttonSaveCamParams
            // 
            this.buttonSaveCamParams.Location = new System.Drawing.Point(320, 27);
            this.buttonSaveCamParams.Name = "buttonSaveCamParams";
            this.buttonSaveCamParams.Size = new System.Drawing.Size(100, 50);
            this.buttonSaveCamParams.TabIndex = 62;
            this.buttonSaveCamParams.Text = "Save parameter";
            // 
            // buttonImportParams
            // 
            this.buttonImportParams.Location = new System.Drawing.Point(320, 83);
            this.buttonImportParams.Name = "buttonImportParams";
            this.buttonImportParams.Size = new System.Drawing.Size(100, 50);
            this.buttonImportParams.TabIndex = 61;
            this.buttonImportParams.Text = "Import Parameters";
            // 
            // camInterParamStart
            // 
            this.camInterParamStart.Location = new System.Drawing.Point(0, 0);
            this.camInterParamStart.Name = "camInterParamStart";
            this.camInterParamStart.Size = new System.Drawing.Size(314, 291);
            this.camInterParamStart.TabIndex = 33;
            // 
            // tabPageFound
            // 
            this.tabPageFound.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFound.Controls.Add(this.camInterParamFound);
            this.tabPageFound.Controls.Add(this.button1);
            this.tabPageFound.Location = new System.Drawing.Point(4, 22);
            this.tabPageFound.Name = "tabPageFound";
            this.tabPageFound.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFound.Size = new System.Drawing.Size(422, 294);
            this.tabPageFound.TabIndex = 1;
            this.tabPageFound.Text = "Found parameters";
            // 
            // camInterParamFound
            // 
            this.camInterParamFound.Location = new System.Drawing.Point(0, 0);
            this.camInterParamFound.Name = "camInterParamFound";
            this.camInterParamFound.Size = new System.Drawing.Size(314, 295);
            this.camInterParamFound.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 63;
            this.button1.Text = "Save parameter";
            // 
            // buttonDefaultParams
            // 
            this.buttonDefaultParams.Location = new System.Drawing.Point(1133, 207);
            this.buttonDefaultParams.Name = "buttonDefaultParams";
            this.buttonDefaultParams.Size = new System.Drawing.Size(100, 50);
            this.buttonDefaultParams.TabIndex = 63;
            this.buttonDefaultParams.Text = "Reset Parameters";
            // 
            // hWndView1
            // 
            this.hWndView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWndView1.Location = new System.Drawing.Point(450, 3);
            this.hWndView1.Name = "hWndView1";
            this.hWndView1.Size = new System.Drawing.Size(677, 577);
            this.hWndView1.TabIndex = 64;
            // 
            // camExternParameter
            // 
            this.camExternParameter.Location = new System.Drawing.Point(7, 537);
            this.camExternParameter.Name = "camExternParameter";
            this.camExternParameter.Size = new System.Drawing.Size(437, 123);
            this.camExternParameter.TabIndex = 32;
            // 
            // CameraCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hWndView1);
            this.Controls.Add(this.buttonDefaultParams);
            this.Controls.Add(this.tabInterParam);
            this.Controls.Add(this.buttonSaveCalibration);
            this.Controls.Add(this.buttonCalibrate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.camExternParameter);
            this.Name = "CameraCalibration";
            this.Size = new System.Drawing.Size(1246, 666);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabInterParam.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageFound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CamExternParameter camExternParameter;
        private CamInterParameter camInterParamStart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label StatusCalibLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDescr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThicknessUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadDescrFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.Button buttonSaveCalibration;
        private System.Windows.Forms.ComboBox CamTypComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabInterParam;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TabPage tabPageFound;
        private System.Windows.Forms.Button buttonDefaultParams;
        private System.Windows.Forms.Button buttonSaveCamParams;
        private System.Windows.Forms.Button buttonImportParams;
        private System.Windows.Forms.Button button1;
        private CamInterParameter camInterParamFound;
        private ViewROI.HWndView hWndView1;
    }
}
