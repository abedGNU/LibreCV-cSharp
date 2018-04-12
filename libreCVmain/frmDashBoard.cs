using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreCVmain
{
    public partial class frmDashBoard : Form
    {


        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            // make this form hide, don't close. This form have to run always..
            frmProduction frmProduction1 = new frmProduction();
            frmProduction1.Show();
        }

        private void btnCameras_Click(object sender, EventArgs e)
        {
            frmCameras frm = new frmCameras();
            frm.Show();
        }

        private void btnModelCreation_Click(object sender, EventArgs e)
        {
            frmMatchingAssistant frm = new frmMatchingAssistant();
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            frmCalibration frm = new frmCalibration();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOCR frm = new frmOCR();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formtest frm = new Formtest();
            frm.Show();
        }
    }
}
