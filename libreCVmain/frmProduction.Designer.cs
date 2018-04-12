namespace libreCVmain
{
    partial class frmProduction
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
            this.btnGrabImage = new System.Windows.Forms.Button();
            this.hWndView1 = new ViewROI.HWndView();
            this.SuspendLayout();
            // 
            // btnGrabImage
            // 
            this.btnGrabImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGrabImage.FlatAppearance.BorderSize = 0;
            this.btnGrabImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabImage.ForeColor = System.Drawing.Color.White;
            this.btnGrabImage.Location = new System.Drawing.Point(169, 64);
            this.btnGrabImage.Name = "btnGrabImage";
            this.btnGrabImage.Size = new System.Drawing.Size(145, 41);
            this.btnGrabImage.TabIndex = 5;
            this.btnGrabImage.Text = "Grab image";
            this.btnGrabImage.UseVisualStyleBackColor = true;
            this.btnGrabImage.Click += new System.EventHandler(this.btnGrabImage_Click);
            // 
            // hWndView1
            // 
            this.hWndView1.BackColor = System.Drawing.Color.White;
            this.hWndView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWndView1.Location = new System.Drawing.Point(320, 50);
            this.hWndView1.Name = "hWndView1";
            this.hWndView1.Size = new System.Drawing.Size(688, 676);
            this.hWndView1.TabIndex = 4;
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 734);
            this.Controls.Add(this.btnGrabImage);
            this.Controls.Add(this.hWndView1);
            this.Name = "frmProduction";
            this.Text = "Production";
            this.Controls.SetChildIndex(this.hWndView1, 0);
            this.Controls.SetChildIndex(this.btnGrabImage, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewROI.HWndView hWndView1;
        private System.Windows.Forms.Button btnGrabImage;
    }
}