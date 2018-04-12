using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCV
{
    public partial class CamInterParameter : UserControl
    {
        public DataType.stcameraParameter cameraPar;
        #region properies
        public decimal Sx
        {
            set
            {
                SxUpDown.Value = value;
            }
            // set { cameraName = value; }
        }

        public decimal Sy
        {
            set
            {
                SyUpDown.Value = value;
            }
            // set { cameraName = value; }
        }

        public decimal kappa
        {
            set
            {
                kappaLabel.Text = value.ToString();
            }
            // set { cameraName = value; }
        }
        #endregion

        public CamInterParameter()
        {
            InitializeComponent();
        }

        public void lockModification(bool bLock)
        {
            SxUpDown.ReadOnly = bLock;
            SyUpDown.ReadOnly = bLock;
            FocalLengthUpDown.ReadOnly = bLock;
            CamTypComboBox.Enabled = !bLock;
        }

        public void viewCameraParam(DataType.stcameraParameter param)
        {
            CamTypComboBox.Text = param.CameraType.ToString();
            SxUpDown.Value = param.Sx;
            SyUpDown.Value = param.Sy;
            FocalLengthUpDown.Value = param.focalLength;

            kappaLabel.Text = param.kappa.ToString();
            CxResultLabel.Text = param.Cx.ToString();
            CyResultLabel.Text = param.Cy.ToString();

            ImgHResultLabel.Text = param.imgHeight.ToString();
            ImgWResultLabel.Text = param.imgWidth.ToString();
        }
    }
}
