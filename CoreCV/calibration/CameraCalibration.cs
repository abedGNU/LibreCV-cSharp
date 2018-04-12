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
    public partial class CameraCalibration : UserControl
    {
        public CameraCalibration()
        {
            InitializeComponent();
            this.camInterParamFound.lockModification(true);
        }
    }
}
