using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OCR;
using HalconDotNet;
using ViewROI;

namespace libreCVmain
{
    public partial class frmOCR : FormBlack
    {
        OCR.OCR mlpOCR;
        HRegion sortedRegions;
        System.Windows.Forms.TextBox[] txt;
        HWindowControl[] HView;

        public frmOCR()
        {
            InitializeComponent();
            mlpOCR = new OCR.OCR();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            //
            /*
            this.txt[0] = new System.Windows.Forms.TextBox();
            gbCharclasses.Controls.Add(this.txt[0]);
            this.txt[0].Location = new System.Drawing.Point(6, 19);

            this.txt[1] = new System.Windows.Forms.TextBox();
            gbCharclasses.Controls.Add(this.txt[1]);
            this.txt[1].Location = new System.Drawing.Point(6, 50);
            */
        }


        private void btnTestOcr_Click(object sender, EventArgs e)
        {
            // HTuple tChar;
            // mlpOCR.fontName = "Industrial_0-9A-Z_NoRej";
            //mlpOCR.fontName = "DotPrint_0-9A-Z";

            mlpOCR.image.ReadImage(@"dataRep\Vision\Models\OCR\11seg.bmp");
            hWndView1.dispObject(mlpOCR.image);
            //
            button2.Enabled = true;
            button4.Enabled = true;
            //
            //mlpOCR.SegmentImage();
            //mlpOCR.segImage.WriteImage("bmp", 0, "segm.bmp");
            //hWndView1.dispObject(mlpOCR.segImage);
            //hWndView1.addIconicVar(mlpOCR.segImage);
            //tChar= mlpOCR.ClassifyMulti();
            //textBox1.Text = tChar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sortedRegions.CountObj(); i++)
            {
                HRegion selectedRegion = sortedRegions.SelectObj(i + 1);
                if( txt[i].Text !="")
                    mlpOCR.CreateTrainingFile(selectedRegion, mlpOCR.image, txt[i].Text);
            }
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sortedRegions = mlpOCR.GetSortedRegions(mlpOCR.image);
            txt = new System.Windows.Forms.TextBox[sortedRegions.CountObj()];
            HView = new HWindowControl[sortedRegions.CountObj()];
            //
            int wndSize = 100;
            int c = sortedRegions.CountObj();
            for (int i = 0; i < c; i++)
            {
                HRegion selectedRegion = sortedRegions.SelectObj(i + 1);

                HView[i] = new HWindowControl();
                HWndCtrl hWndControl = new HWndCtrl(HView[i]);

                HView[i].Size = new System.Drawing.Size(wndSize, wndSize);
                panelCharClass.Controls.Add(HView[i]);
                HView[i].Location = new System.Drawing.Point(15, 30 + (wndSize + 5) * i);

                int row1, row2;
                int col1, col2;
                int imgH, imgW;
                HObject imgO;

                selectedRegion.SmallestRectangle1(out row1, out col1, out row2, out col2);
                mlpOCR.image.GetImageSize(out imgH, out imgW);
                HImage img = selectedRegion.RegionToBin(255, 0, imgH, imgW);
                HOperatorSet.CropPart(img, out imgO, row1, col1, row2, col2);
                //HOperatorSet.GetImageSize(imgO,out imgH, out imgW);


                hWndControl.addIconicVar(imgO);
                hWndControl.repaint();
                //
                txt[i] = new System.Windows.Forms.TextBox();
                txt[i].Size = new System.Drawing.Size(wndSize, wndSize);
                txt[i].MaxLength = 1;
                panelCharClass.Controls.Add(txt[i]);
                txt[i].Location = new System.Drawing.Point(15 + wndSize + 5, 30 + (wndSize + 5) * i);
            }
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mlpOCR.trainClassifier();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           string[] text= mlpOCR.findText();
            txtResult.Lines = text;
        }
    }
}
