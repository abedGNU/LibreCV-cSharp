namespace libreCVmain
{
    partial class frmOCR
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
            this.hWndView1 = new ViewROI.HWndView();
            this.btnTestOcr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCharClass = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hWndView1
            // 
            this.hWndView1.BackColor = System.Drawing.Color.White;
            this.hWndView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hWndView1.Location = new System.Drawing.Point(557, 34);
            this.hWndView1.Name = "hWndView1";
            this.hWndView1.Size = new System.Drawing.Size(688, 676);
            this.hWndView1.TabIndex = 6;
            // 
            // btnTestOcr
            // 
            this.btnTestOcr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTestOcr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTestOcr.FlatAppearance.BorderSize = 0;
            this.btnTestOcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestOcr.ForeColor = System.Drawing.Color.White;
            this.btnTestOcr.Location = new System.Drawing.Point(366, 120);
            this.btnTestOcr.Name = "btnTestOcr";
            this.btnTestOcr.Size = new System.Drawing.Size(145, 41);
            this.btnTestOcr.TabIndex = 7;
            this.btnTestOcr.Text = "Grab image";
            this.btnTestOcr.UseVisualStyleBackColor = false;
            this.btnTestOcr.Click += new System.EventHandler(this.btnTestOcr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(366, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create train file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(366, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Get chars";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelCharClass
            // 
            this.panelCharClass.AutoScroll = true;
            this.panelCharClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelCharClass.Location = new System.Drawing.Point(12, 12);
            this.panelCharClass.Name = "panelCharClass";
            this.panelCharClass.Size = new System.Drawing.Size(275, 698);
            this.panelCharClass.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(366, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Train OCR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(366, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 41);
            this.button4.TabIndex = 16;
            this.button4.Text = "Find text";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(366, 457);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(145, 90);
            this.txtResult.TabIndex = 17;
            // 
            // frmOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 722);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelCharClass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTestOcr);
            this.Controls.Add(this.hWndView1);
            this.Name = "frmOCR";
            this.Text = "frmOCR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViewROI.HWndView hWndView1;
        private System.Windows.Forms.Button btnTestOcr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelCharClass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtResult;
    }
}