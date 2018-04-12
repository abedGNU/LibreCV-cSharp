using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HalconDotNet;
using MatchingModule;
using ViewROI;
using CoreCV;

namespace libreCVmain
{
    public partial class frmProduction : FormFlat
    {
        private Camera cam;


        public frmProduction()
        {
            try
            {
                InitializeComponent();
                //cam = new Camera("abedCam");
                 cam = new Camera("DirectShow", "[0] Logitech HD Pro Webcam C920");
                // [0] Lenovo EasyCamera
                // cam = new Camera();

                //Window = hWindowControl1.HalconWindow;
            }
            catch (Exception ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }

        private void btnGrabImage_Click(object sender, EventArgs e)
        {
            try
            {
                //cam.GrabImage().DispObj(Window);
                hWndView1.dispObject(cam.GrabImage());
                /*
                String fileName = "particle";
                HImage image = new HImage(fileName);
                hWndView1.dispObject(image);
                */
            }
            catch (Exception ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }
    }
}


