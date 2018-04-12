using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CoreCV;
using HalconDotNet;

namespace libreCVmain
{
    public partial class frmMatchingAssistant : FormBlack
    {
        public frmMatchingAssistant()
        {
            InitializeComponent();
        }

        private void btnGrabImage_Click(object sender, EventArgs e)
        {
            try
            {
                //CoreCV.DeviceManager.cam = new Camera("DirectShow", "[0] Logitech HD Pro Webcam C920");
                string path = Directory.GetCurrentDirectory();
                CoreCV.DeviceManager.cam = new Camera("File","Default","test", path+@"\dataRep\Vision\Cameras\default\test");
                //CoreCV.DeviceManager.cam = new Camera("CASS2");
                hWndView1.dispObject(CoreCV.DeviceManager.cam.GrabImage());
                hWndView1.listBoxDiagnostic.Items.Add(CoreCV.DeviceManager.cam.CameraName);
                CoreCV.DeviceManager.cam.Dispose();
                CoreCV.DeviceManager.cam = null;
            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
                hWndView1.listBoxDiagnostic.Items.Add(ex.ToString());
            }
        }


        private void btnOperations_Click(object sender, EventArgs e)
        {

            stripMenuOperations.Show(this, new Point(btnOperations.Location.X + btnOperations.Width, btnOperations.Location.Y+btnOperations.Height));
            //stripMenuOperations.Show(this, new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            stripMenuCamera.Show(this, new Point(btnCamera.Location.X + btnCamera.Width, btnCamera.Location.Y + btnCamera.Height));
        }
    }
}
