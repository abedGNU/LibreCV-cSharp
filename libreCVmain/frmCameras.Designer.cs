namespace libreCVmain
{
    partial class frmCameras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCameras));
            this.lvDeviceMemory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRenameDevice = new System.Windows.Forms.Button();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.btnCopyDevice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumDevices = new System.Windows.Forms.Label();
            this.btnLive = new System.Windows.Forms.Button();
            this.btnGrab = new System.Windows.Forms.Button();
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.lvDeviceConnected = new System.Windows.Forms.ListView();
            this.clmDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInterface = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchDevices = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.hWndView1 = new ViewROI.HWndView();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDeviceMemory
            // 
            this.lvDeviceMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDeviceMemory.Location = new System.Drawing.Point(6, 19);
            this.lvDeviceMemory.Name = "lvDeviceMemory";
            this.lvDeviceMemory.Size = new System.Drawing.Size(368, 478);
            this.lvDeviceMemory.TabIndex = 0;
            this.lvDeviceMemory.UseCompatibleStateImageBehavior = false;
            this.lvDeviceMemory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Camera name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Interface";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRenameDevice);
            this.groupBox1.Controls.Add(this.lvDeviceMemory);
            this.groupBox1.Controls.Add(this.btnRemoveDevice);
            this.groupBox1.Controls.Add(this.btnCopyDevice);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1215, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 577);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices in memory";
            // 
            // btnRenameDevice
            // 
            this.btnRenameDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameDevice.ForeColor = System.Drawing.Color.White;
            this.btnRenameDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnRenameDevice.Image")));
            this.btnRenameDevice.Location = new System.Drawing.Point(380, 215);
            this.btnRenameDevice.Name = "btnRenameDevice";
            this.btnRenameDevice.Size = new System.Drawing.Size(108, 90);
            this.btnRenameDevice.TabIndex = 11;
            this.btnRenameDevice.Text = "Rename";
            this.btnRenameDevice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRenameDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRenameDevice.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDevice.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveDevice.Image")));
            this.btnRemoveDevice.Location = new System.Drawing.Point(380, 119);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(108, 90);
            this.btnRemoveDevice.TabIndex = 10;
            this.btnRemoveDevice.Text = "Remove";
            this.btnRemoveDevice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            // 
            // btnCopyDevice
            // 
            this.btnCopyDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyDevice.ForeColor = System.Drawing.Color.White;
            this.btnCopyDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyDevice.Image")));
            this.btnCopyDevice.Location = new System.Drawing.Point(380, 20);
            this.btnCopyDevice.Name = "btnCopyDevice";
            this.btnCopyDevice.Size = new System.Drawing.Size(108, 90);
            this.btnCopyDevice.TabIndex = 9;
            this.btnCopyDevice.Text = "Copy";
            this.btnCopyDevice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopyDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopyDevice.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumDevices);
            this.groupBox2.Controls.Add(this.btnLive);
            this.groupBox2.Controls.Add(this.btnGrab);
            this.groupBox2.Controls.Add(this.cmbInterface);
            this.groupBox2.Controls.Add(this.lvDeviceConnected);
            this.groupBox2.Controls.Add(this.btnSearchDevices);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(699, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 577);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connected devices";
            // 
            // lblNumDevices
            // 
            this.lblNumDevices.Location = new System.Drawing.Point(10, 527);
            this.lblNumDevices.Name = "lblNumDevices";
            this.lblNumDevices.Size = new System.Drawing.Size(136, 23);
            this.lblNumDevices.TabIndex = 16;
            this.lblNumDevices.Text = "Number of devices:  0";
            // 
            // btnLive
            // 
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.ForeColor = System.Drawing.Color.White;
            this.btnLive.Image = ((System.Drawing.Image)(resources.GetObject("btnLive.Image")));
            this.btnLive.Location = new System.Drawing.Point(13, 407);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(108, 90);
            this.btnLive.TabIndex = 14;
            this.btnLive.Text = "Live";
            this.btnLive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLive.UseVisualStyleBackColor = true;
            // 
            // btnGrab
            // 
            this.btnGrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrab.ForeColor = System.Drawing.Color.White;
            this.btnGrab.Image = ((System.Drawing.Image)(resources.GetObject("btnGrab.Image")));
            this.btnGrab.Location = new System.Drawing.Point(13, 311);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(108, 90);
            this.btnGrab.TabIndex = 13;
            this.btnGrab.Text = "Grab image";
            this.btnGrab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // cmbInterface
            // 
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Location = new System.Drawing.Point(13, 118);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(107, 21);
            this.cmbInterface.TabIndex = 8;
            this.cmbInterface.SelectedValueChanged += new System.EventHandler(this.cmbInterface_SelectedValueChanged);
            // 
            // lvDeviceConnected
            // 
            this.lvDeviceConnected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDevice,
            this.clmInterface});
            this.lvDeviceConnected.FullRowSelect = true;
            this.lvDeviceConnected.GridLines = true;
            this.lvDeviceConnected.Location = new System.Drawing.Point(135, 19);
            this.lvDeviceConnected.Name = "lvDeviceConnected";
            this.lvDeviceConnected.Size = new System.Drawing.Size(255, 478);
            this.lvDeviceConnected.TabIndex = 0;
            this.lvDeviceConnected.UseCompatibleStateImageBehavior = false;
            this.lvDeviceConnected.View = System.Windows.Forms.View.Details;
            // 
            // clmDevice
            // 
            this.clmDevice.Text = "Device";
            this.clmDevice.Width = 150;
            // 
            // clmInterface
            // 
            this.clmInterface.Text = "Interface";
            this.clmInterface.Width = 95;
            // 
            // btnSearchDevices
            // 
            this.btnSearchDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDevices.ForeColor = System.Drawing.Color.White;
            this.btnSearchDevices.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDevices.Image")));
            this.btnSearchDevices.Location = new System.Drawing.Point(12, 19);
            this.btnSearchDevices.Name = "btnSearchDevices";
            this.btnSearchDevices.Size = new System.Drawing.Size(108, 90);
            this.btnSearchDevices.TabIndex = 7;
            this.btnSearchDevices.Text = "Find \r\nconnected\r\ndevices";
            this.btnSearchDevices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearchDevices.UseVisualStyleBackColor = true;
            this.btnSearchDevices.Click += new System.EventHandler(this.btnSearchDevices_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.ForeColor = System.Drawing.Color.White;
            this.btnAddDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDevice.Image")));
            this.btnAddDevice.Location = new System.Drawing.Point(1101, 22);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(108, 90);
            this.btnAddDevice.TabIndex = 8;
            this.btnAddDevice.Text = "Add device";
            this.btnAddDevice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // hWndView1
            // 
            this.hWndView1.Location = new System.Drawing.Point(12, 12);
            this.hWndView1.Name = "hWndView1";
            this.hWndView1.Size = new System.Drawing.Size(677, 680);
            this.hWndView1.TabIndex = 9;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(1102, 119);
            this.txtDeviceName.MaxLength = 100;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(100, 20);
            this.txtDeviceName.TabIndex = 10;
            // 
            // frmCameras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1732, 701);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.hWndView1);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCameras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cameras";
            this.Load += new System.EventHandler(this.frmCameras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDeviceMemory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDeviceConnected;
        private System.Windows.Forms.Button btnSearchDevices;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnRenameDevice;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Button btnCopyDevice;
        private System.Windows.Forms.ComboBox cmbInterface;
        private System.Windows.Forms.ColumnHeader clmDevice;
        private System.Windows.Forms.ColumnHeader clmInterface;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.Button btnGrab;
        private ViewROI.HWndView hWndView1;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblNumDevices;
    }
}