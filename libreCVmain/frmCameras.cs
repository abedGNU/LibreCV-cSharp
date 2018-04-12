using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

using CoreCV;

namespace libreCVmain
{
    public partial class frmCameras : FormBlack
    {
        ArrayList devicesConnected = new ArrayList();
        ArrayList devicesMemory = new ArrayList();

        #region Initialize
        //
        public frmCameras()
        {
            InitializeComponent();

            initializeComboInterface();

            lvDeviceConnected.View = View.Details;
            lvDeviceConnected.GridLines = true;
            lvDeviceConnected.FullRowSelect = true;

            lvDeviceMemory.View = View.Details;
            lvDeviceMemory.GridLines = true;
            lvDeviceMemory.FullRowSelect = true;
        }

        private void frmCameras_Load(object sender, EventArgs e)
        {
            refreshDeviceMemory();
            refreshDeviceConnected();
        }

        //
        public void initializeComboInterface()
        {
            ArrayList alInter = new ArrayList();
            alInter.Add("GigEVision");
            alInter.Add("DirectShow");
            alInter.Add("File");

            cmbInterface.DataSource = alInter;
        }

        #endregion // Initialize

        // refresh listview device in memory
        private void refreshDeviceMemory()
        {
            // find the list of the devices in memory
            ;

            // hilight devices connected
            ;
        }

        // refresh listview connected devices
        private void refreshDeviceConnected()
        {
            lvDeviceConnected.Items.Clear();
            devicesConnected = CoreCV.DeviceManager.searchConnectedDevices(cmbInterface.SelectedItem.ToString());
            lblNumDevices.Text = "Number of devices: " + devicesConnected.Count.ToString();
            String[] arr = (String[])devicesConnected.ToArray(typeof(string));
            for (int i = 0; i < arr.Length; i++)
            {
                string[] ar = new string[2];
                ar[0] = arr[i];
                ar[1] = cmbInterface.SelectedItem.ToString();
                lvDeviceConnected.Items.Add(new ListViewItem(ar));
            }

            // look if some of the connected devices are in memory. Higligh with a color
            ;

        }


        #region click buttons
        //
        private void btnSearchDevices_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            /*
            lvDeviceConnected.Items.Clear();            
            //add items to ListView 
            arr[0] = "abedCam";
            arr[1] = "GigEVision";
            lvDeviceConnected.Items.Add(new ListViewItem(arr));

            arr[0] = "[0] Logitech HD Pro Webcam C920";
            arr[1] = "DirectShow";
            lvDeviceConnected.Items.Add(new ListViewItem(arr));
            */
            //
            if (cmbInterface.SelectedItem.ToString() == "DirectShow")
            {
                lvDeviceConnected.Items.Clear();
                arr[0] = "[0] Logitech HD Pro Webcam C920";
                arr[1] = "DirectShow";
                lvDeviceConnected.Items.Add(new ListViewItem(arr));
                return;
            }
            lvDeviceConnected.Items.Clear();
            refreshDeviceConnected();
        }


        private void btnGrab_Click(object sender, EventArgs e)
        {
            string device = null;
            string interfac = null;

            if (lvDeviceConnected.SelectedItems.Count == 1)
            {
                device = lvDeviceConnected.SelectedItems[0].SubItems[0].Text;
                interfac = lvDeviceConnected.SelectedItems[0].SubItems[1].Text;

                // create a camera without creating its folder data
                Camera cam = new Camera(interfac, device, false);
                hWndView1.dispObject(cam.GrabImage());
                cam.Dispose();

                hWndView1.listBoxResults.Items.Clear();
                hWndView1.listBoxResults.Items.Add(device);
            }

        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            string device = null;
            string cameraName = null;
            string interfac = cmbInterface.SelectedItem.ToString();
            if (lvDeviceConnected.SelectedItems.Count == 1)
            {

                device = lvDeviceConnected.SelectedItems[0].SubItems[0].Text;
                interfac = lvDeviceConnected.SelectedItems[0].SubItems[1].Text;

                // Refresh the listview of the device in memory
                ;

                // Inputbox to get the name of the camera
                InputBoxItem[] items = new InputBoxItem[] { new InputBoxItem("Camera name", device) };
                InputBox input = InputBox.Show("Enter camera name", items, InputBoxButtons.OKCancel);
                if (input.Result == InputBoxResult.OK)
                {
                    cameraName = input.Items["Camera name"];
                }
                else
                {
                    // if pressed cancel exit, don't create folder
                    return;
                }
                // Look if the camera exist in memory
                // if don't exist create camera and its default paramters
                CoreCV.DeviceManager.createCameraData(device, cameraName, interfac);

                // Refresh the listview of the device in memory again
                ;
                //lvDeviceConnected.Items[lvDeviceConnected.SelectedItems[0].Index].BackColor = Color.LightGray;
                lvDeviceConnected.Items[lvDeviceConnected.FindItemWithText(device).Index].BackColor = Color.LightGray;
            }
        }


        #endregion // click  buttons

        private void cmbInterface_SelectedValueChanged(object sender, EventArgs e)
        {
            lvDeviceConnected.Items.Clear();
        }





    }
}
