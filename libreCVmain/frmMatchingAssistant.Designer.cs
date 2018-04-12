namespace libreCVmain
{
    partial class frmMatchingAssistant
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
            this.hWndView1 = new ViewROI.HWndView();
            this.btnGrabImage = new System.Windows.Forms.Button();
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.listBoxOperations = new System.Windows.Forms.ListBox();
            this.stripMenuOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeMatchingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOperations = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.stripMenuCamera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuOperations.SuspendLayout();
            this.stripMenuCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // hWndView1
            // 
            this.hWndView1.BackColor = System.Drawing.Color.White;
            this.hWndView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWndView1.Location = new System.Drawing.Point(557, 34);
            this.hWndView1.Name = "hWndView1";
            this.hWndView1.Size = new System.Drawing.Size(688, 676);
            this.hWndView1.TabIndex = 5;
            // 
            // btnGrabImage
            // 
            this.btnGrabImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGrabImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGrabImage.FlatAppearance.BorderSize = 0;
            this.btnGrabImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabImage.ForeColor = System.Drawing.Color.White;
            this.btnGrabImage.Location = new System.Drawing.Point(406, 44);
            this.btnGrabImage.Name = "btnGrabImage";
            this.btnGrabImage.Size = new System.Drawing.Size(145, 41);
            this.btnGrabImage.TabIndex = 6;
            this.btnGrabImage.Text = "Grab image";
            this.btnGrabImage.UseVisualStyleBackColor = false;
            this.btnGrabImage.Click += new System.EventHandler(this.btnGrabImage_Click);
            // 
            // cmbInterface
            // 
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Location = new System.Drawing.Point(28, 44);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(142, 21);
            this.cmbInterface.TabIndex = 9;
            // 
            // listBoxOperations
            // 
            this.listBoxOperations.FormattingEnabled = true;
            this.listBoxOperations.Location = new System.Drawing.Point(28, 116);
            this.listBoxOperations.Name = "listBoxOperations";
            this.listBoxOperations.Size = new System.Drawing.Size(142, 251);
            this.listBoxOperations.TabIndex = 12;
            // 
            // stripMenuOperations
            // 
            this.stripMenuOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oCRToolStripMenuItem,
            this.shapeMatchingToolStripMenuItem});
            this.stripMenuOperations.Name = "stripMenuOperations";
            this.stripMenuOperations.Size = new System.Drawing.Size(143, 48);
            // 
            // oCRToolStripMenuItem
            // 
            this.oCRToolStripMenuItem.Name = "oCRToolStripMenuItem";
            this.oCRToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.oCRToolStripMenuItem.Text = "OCR";
            // 
            // shapeMatchingToolStripMenuItem
            // 
            this.shapeMatchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeMatchingToolStripMenuItem1});
            this.shapeMatchingToolStripMenuItem.Name = "shapeMatchingToolStripMenuItem";
            this.shapeMatchingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.shapeMatchingToolStripMenuItem.Text = "2D matching";
            // 
            // shapeMatchingToolStripMenuItem1
            // 
            this.shapeMatchingToolStripMenuItem1.Name = "shapeMatchingToolStripMenuItem1";
            this.shapeMatchingToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.shapeMatchingToolStripMenuItem1.Text = "Shape matching";
            // 
            // btnOperations
            // 
            this.btnOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnOperations.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOperations.FlatAppearance.BorderSize = 0;
            this.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperations.ForeColor = System.Drawing.Color.White;
            this.btnOperations.Location = new System.Drawing.Point(28, 84);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Size = new System.Drawing.Size(77, 26);
            this.btnOperations.TabIndex = 15;
            this.btnOperations.Text = "Operations";
            this.btnOperations.UseVisualStyleBackColor = false;
            this.btnOperations.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCamera.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamera.ForeColor = System.Drawing.Color.White;
            this.btnCamera.Location = new System.Drawing.Point(28, 12);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(77, 26);
            this.btnCamera.TabIndex = 16;
            this.btnCamera.Text = "Camera";
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // stripMenuCamera
            // 
            this.stripMenuCamera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.stripMenuCamera.Name = "stripMenuCamera";
            this.stripMenuCamera.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // frmMatchingAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 722);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnOperations);
            this.Controls.Add(this.listBoxOperations);
            this.Controls.Add(this.cmbInterface);
            this.Controls.Add(this.btnGrabImage);
            this.Controls.Add(this.hWndView1);
            this.Name = "frmMatchingAssistant";
            this.Text = "Matching assistant";
            this.stripMenuOperations.ResumeLayout(false);
            this.stripMenuCamera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewROI.HWndView hWndView1;
        private System.Windows.Forms.Button btnGrabImage;
        private System.Windows.Forms.ComboBox cmbInterface;
        private System.Windows.Forms.ListBox listBoxOperations;
        private System.Windows.Forms.ContextMenuStrip stripMenuOperations;
        private System.Windows.Forms.ToolStripMenuItem oCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeMatchingToolStripMenuItem1;
        private System.Windows.Forms.Button btnOperations;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ContextMenuStrip stripMenuCamera;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}