namespace ViewROI
{
    partial class HWndView
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
            this.viewPort = new HalconDotNet.HWindowControl();
            this.groupBoxViewFunction = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NoneButton = new System.Windows.Forms.RadioButton();
            this.ZoomButton = new System.Windows.Forms.RadioButton();
            this.ZoomUpDown = new System.Windows.Forms.NumericUpDown();
            this.MoveButton = new System.Windows.Forms.RadioButton();
            this.ClearWindButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.scrollBarX = new System.Windows.Forms.HScrollBar();
            this.scrollBarY = new System.Windows.Forms.VScrollBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxDiagnostic = new System.Windows.Forms.ListBox();
            this.groupBoxViewFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPort
            // 
            this.viewPort.BackColor = System.Drawing.Color.Black;
            this.viewPort.BorderColor = System.Drawing.Color.Black;
            this.viewPort.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.viewPort.Location = new System.Drawing.Point(3, 65);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(640, 480);
            this.viewPort.TabIndex = 0;
            this.viewPort.WindowSize = new System.Drawing.Size(640, 480);
            // 
            // groupBoxViewFunction
            // 
            this.groupBoxViewFunction.Controls.Add(this.label4);
            this.groupBoxViewFunction.Controls.Add(this.NoneButton);
            this.groupBoxViewFunction.Controls.Add(this.ZoomButton);
            this.groupBoxViewFunction.Controls.Add(this.ZoomUpDown);
            this.groupBoxViewFunction.Controls.Add(this.MoveButton);
            this.groupBoxViewFunction.Location = new System.Drawing.Point(3, 11);
            this.groupBoxViewFunction.Name = "groupBoxViewFunction";
            this.groupBoxViewFunction.Size = new System.Drawing.Size(331, 48);
            this.groupBoxViewFunction.TabIndex = 2;
            this.groupBoxViewFunction.TabStop = false;
            this.groupBoxViewFunction.Text = "View Interaction";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(301, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoneButton
            // 
            this.NoneButton.Checked = true;
            this.NoneButton.Location = new System.Drawing.Point(24, 16);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(72, 24);
            this.NoneButton.TabIndex = 2;
            this.NoneButton.TabStop = true;
            this.NoneButton.Text = "none";
            this.NoneButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoneButton.CheckedChanged += new System.EventHandler(this.NoneButton_CheckedChanged);
            // 
            // ZoomButton
            // 
            this.ZoomButton.Location = new System.Drawing.Point(176, 16);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Size = new System.Drawing.Size(60, 24);
            this.ZoomButton.TabIndex = 1;
            this.ZoomButton.Text = "zoom";
            this.ZoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ZoomButton.CheckedChanged += new System.EventHandler(this.ZoomButton_CheckedChanged);
            // 
            // ZoomUpDown
            // 
            this.ZoomUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ZoomUpDown.Location = new System.Drawing.Point(242, 18);
            this.ZoomUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ZoomUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ZoomUpDown.Name = "ZoomUpDown";
            this.ZoomUpDown.Size = new System.Drawing.Size(56, 20);
            this.ZoomUpDown.TabIndex = 13;
            this.ZoomUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ZoomUpDown.ValueChanged += new System.EventHandler(this.ZoomUpDown_ValueChanged);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(104, 16);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(64, 24);
            this.MoveButton.TabIndex = 0;
            this.MoveButton.Text = "move ";
            this.MoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoveButton.CheckedChanged += new System.EventHandler(this.MoveButton_CheckedChanged);
            // 
            // ClearWindButton
            // 
            this.ClearWindButton.Location = new System.Drawing.Point(450, 15);
            this.ClearWindButton.Name = "ClearWindButton";
            this.ClearWindButton.Size = new System.Drawing.Size(88, 40);
            this.ClearWindButton.TabIndex = 10;
            this.ClearWindButton.Text = "Clear Window";
            this.ClearWindButton.Click += new System.EventHandler(this.ClearWindButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(356, 15);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(88, 40);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset View";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // scrollBarX
            // 
            this.scrollBarX.LargeChange = 5;
            this.scrollBarX.Location = new System.Drawing.Point(3, 548);
            this.scrollBarX.Name = "scrollBarX";
            this.scrollBarX.Size = new System.Drawing.Size(640, 21);
            this.scrollBarX.TabIndex = 11;
            this.scrollBarX.Value = 50;
            this.scrollBarX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarX_Scroll);
            // 
            // scrollBarY
            // 
            this.scrollBarY.LargeChange = 5;
            this.scrollBarY.Location = new System.Drawing.Point(646, 65);
            this.scrollBarY.Name = "scrollBarY";
            this.scrollBarY.Size = new System.Drawing.Size(21, 480);
            this.scrollBarY.TabIndex = 12;
            this.scrollBarY.Value = 50;
            this.scrollBarY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarY_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 573);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 100);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(3, 3);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(625, 68);
            this.listBoxResults.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxDiagnostic);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diagnostic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxDiagnostic
            // 
            this.listBoxDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDiagnostic.FormattingEnabled = true;
            this.listBoxDiagnostic.Location = new System.Drawing.Point(3, 3);
            this.listBoxDiagnostic.Name = "listBoxDiagnostic";
            this.listBoxDiagnostic.Size = new System.Drawing.Size(625, 68);
            this.listBoxDiagnostic.TabIndex = 0;
            // 
            // HWndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.scrollBarY);
            this.Controls.Add(this.scrollBarX);
            this.Controls.Add(this.ClearWindButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.groupBoxViewFunction);
            this.Controls.Add(this.viewPort);
            this.Name = "HWndView";
            this.Size = new System.Drawing.Size(677, 680);
            this.Load += new System.EventHandler(this.HWndView_Load);
            this.groupBoxViewFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZoomUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl viewPort;
        private System.Windows.Forms.GroupBox groupBoxViewFunction;
        private System.Windows.Forms.RadioButton NoneButton;
        private System.Windows.Forms.RadioButton ZoomButton;
        private System.Windows.Forms.RadioButton MoveButton;
        private System.Windows.Forms.Button ClearWindButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.HScrollBar scrollBarX;
        private System.Windows.Forms.VScrollBar scrollBarY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ZoomUpDown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListBox listBoxResults;
        public System.Windows.Forms.ListBox listBoxDiagnostic;
    }
}
