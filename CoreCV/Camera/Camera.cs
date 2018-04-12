using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using HalconDotNet;

namespace CoreCV
{
    public class Camera : HFramegrabber
    {

        #region fields
        private string cameraName;
        private string device;
        //private HFramegrabber frameGrabber;
        private string interfaceName = "GigEVision"; // default interface
        //private HTuple hFrameGrabber = null;
        private HCalibData calibraionData;
        private string dirPath = "dataRep";
        private string locationDir = "";
        //
        static HTuple CameraParameter;
        //
        private DirectoryInfo diCurrent; // current directory
        private DirectoryInfo diCamera; // camera folder

        private int expTime; // actual exptime
        private int prevExpTime; // previous exp time

        private string expParamName = "ExposureTimeAbs"; // "ExposureTime"

        #endregion

        #region properies

        public string CameraName
        {
            get
            {
                return cameraName;
            }
            // set { cameraName = value; }
        }

        public int ExpTime
        {
            get
            {
                return expTime;
            }
            set
            {
                try
                {
                    if (expTime != value)
                    {
                        prevExpTime = expTime;
                        expTime = value;
                        this.SetFramegrabberParam(new HTuple(expParamName), new HTuple(expTime));
                    }
                }
                catch (HOperatorException ex)
                {
                    Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
                }

            }
        }

        public string Device
        {
            get
            {
                return device;
            }
            // set { device = value; }
        }
        #endregion

        #region constructors
        // contructor take only the camera name, the interface is the default interface
        public Camera(string device)
        {
            try
            {
                this.OpenFramegrabber(interfaceName, 0, 0, 0, 0, 0, 0, "default", -1,
                                       "default", -1, "false", "default", device, 0, -1);
                this.device = device;
                readParamater();

            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }
        // contructor take interface name,camera name
        public Camera(string interfac, string device)
        {
            try
            {
                this.OpenFramegrabber(interfac, 0, 0, 0, 0, 0, 0, "default", -1,
                 "default", -1, "false", "default", device, 0, -1);
                this.device = device;
                this.interfaceName = interfac;
                //readParamater();

            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }
        //
        // contructor take interface name,camera name
        public Camera(string interfac, string device, string cameraName, string cameraType)
        {
            try
            {
                this.OpenFramegrabber(interfac, 0, 0, 0, 0, 0, 0, "default", -1,
                 "default", -1, "false", cameraType, device, 0, -1);
                this.cameraName = cameraName;
                this.cameraName = device;
                this.interfaceName = interfac;
                //readParamater();

            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }
        // contructor take interface name,camera name
        public Camera(string interfac, string device, bool initParam)
        {
            try
            {
                this.OpenFramegrabber(interfac, 0, 0, 0, 0, 0, 0, "default", -1,
                 "default", -1, "false", "default", device, 0, -1);
                this.device = device;
                this.interfaceName = interfac;
                if (initParam)
                {
                    readParamater();
                }
            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }
        // Constructor, have same parameter as OpenFramegrabber(.....)
        public Camera(string name, int horizontalResolution, int verticalResolution, int imageWidth, int imageHeight,
            int startRow, int startColumn, string field, int bitsPerChannel, string colorSpace, double generic,
            string externalTrigger, string cameraType,
            string device, int port, int lineIn)
        {
            try
            {
                this.OpenFramegrabber(name, horizontalResolution, verticalResolution, imageWidth, imageHeight, startRow, startColumn, field, bitsPerChannel, colorSpace, generic, externalTrigger, cameraType, device, port, lineIn);
            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }
        //
        public Camera()
        {
            // readParamater();
        }
        /*
        ~Camera()
        {
            // readParamater();
        }
        */
        #endregion // Constructors

        #region methods

        public void readParamater()
        {
            diCurrent = new DirectoryInfo(".\\"); // current directory
            diCamera = new DirectoryInfo(dirPath + @"\Cameras\" + cameraName); // camera directory
            //
            try
            {
                if (!diCamera.Exists)
                {
                    // if camera folder doesn't exist, I create it
                    diCurrent.CreateSubdirectory(dirPath + @"\Cameras\" + cameraName);
                }
                else
                {
                    // if exist, I read the data from the folder if they exist: calibration paramter, ....
                    readCamParam();
                }
            }
            catch (Exception ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }


        public void readCamParam()
        {

            try
            {
                FileInfo fi = new FileInfo(dirPath + @"\Cameras\" + cameraName + @"\camera_parameters.dat");
                if (fi.Exists)
                {
                    CameraParameter = HMisc.ReadCamPar(fi.FullName);
                }
            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
            catch (Exception ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }

        /*
        private void setExpTime(int expTime)
        {
            try
            {
                if (expTime != this.expTime)
                {
                    this.lastExpTime = this.expTime;
                    this.SetFramegrabberParam(new HTuple("ExposureTimeAbs"), new HTuple(expTime));
                    this.expTime = expTime;
                }
            }
            catch (HOperatorException ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }*/
        #endregion

    }
}
