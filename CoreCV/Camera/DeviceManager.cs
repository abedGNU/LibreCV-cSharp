using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HalconDotNet;
using System.Collections;


namespace CoreCV
{
    public class DeviceManager
    {
        public static Camera cam;
        //public static Dictionary<string, string> CamerasMemory = new Dictionary<string, string>();
        //public static List<Tuple<string, string, string, string>> CamerasMemory = new List<Tuple<string, string, string, string>>();
        public static List<string[]> CamerasMemoryArr = new List<string[]>();

        #region directories   
        private static string root = "dataRep";
        private static string camerasDir = @"dataRep\Vision\cameras\";
        #endregion

        // searchConnectedDevices
        public static ArrayList searchConnectedDevices(string interfac)
        {
            HTuple name = new HTuple(interfac);
            HTuple query = new HTuple("info_boards"); ;
            HTuple information = new HTuple();
            HTuple valueList = new HTuple();
            //
            ArrayList found = new ArrayList();
            string sValue = "device:";
            //
            HOperatorSet.InfoFramegrabber(interfac, query, out information, out valueList);
            for (int i = 0; i < valueList.Length; i++)
            {
                // loop over each item of the Htuple, and save it in a string
                string str = valueList[i].S;
                // look for the last index of sValue, add to it the length of itself
                // like this we get the index of the first char after the string sValue.
                str = str.Substring(str.LastIndexOf(sValue) + sValue.Length);
                found.Add(str);

            }
            return found;
        }

        // searchConnectedDevices
        public static List<Tuple<string, string>> searchConnectedDevices(string interfac, HTuple info)
        {
            HTuple name = new HTuple(interfac);
            HTuple query = new HTuple("info_boards"); ;
            HTuple information = new HTuple();
            HTuple valueList = new HTuple();
            //
            List<Tuple<string, string>> found = new List<Tuple<string, string>>();
            int offset = 7;

            HOperatorSet.InfoFramegrabber(interfac, query, out information, out valueList);

            for (int i = 0; i < valueList.Length; i++)
            {
                string str = valueList[i].S;
                str = str.Substring(str.LastIndexOf("device:") + offset);
                found.Add(new Tuple<string, string>(str, interfac));
            }
            return found;
        }

        //searchConnectedDevices
        public static void getDevicesInMemory()
        {
            ;
        }

        // Create Camera folders
        public static string createCameraData(string device, string cameraName, string interfac)
        {
            HTuple cameraInfo = new HTuple(device, cameraName, interfac);
            string camerafolder = camerasDir + device + @"\" + cameraName;
            DirectoryInfo diCurrent = new DirectoryInfo(".\\"); // current directory
            DirectoryInfo diDevice = new DirectoryInfo(camerasDir); // device directory
            DirectoryInfo diCamera = new DirectoryInfo(camerafolder); // camera directory
            if (!diCamera.Exists)
            {
                // if device folder doesn't exist, I create it, starting from the current(active) directory
                diCurrent.CreateSubdirectory(camerafolder);
                HOperatorSet.WriteTuple(cameraInfo, camerafolder + @"\cameraInfo.tup");
            }
            return camerafolder;
        }
        //
        public static string[] CameraDataExist(string device, string cameraName, string interfac)
        {
            HTuple cameraInfo;
            string camerafolder = camerasDir + device + @"\" + cameraName;
            DirectoryInfo diCurrent = new DirectoryInfo(".\\"); // current directory
            DirectoryInfo diDevice = new DirectoryInfo(camerasDir); // device directory
            DirectoryInfo diCamera = new DirectoryInfo(camerafolder); // camera directory
            if (diCamera.Exists)
            {
                HOperatorSet.ReadTuple(camerafolder + @"\cameraInfo.tup", out cameraInfo);
                if (cameraInfo[0] == device & cameraInfo[1] == cameraName & cameraInfo[2] == interfac)
                {
                    string[] res = { device, cameraName, interfac, camerafolder };
                    return res;
                }
                else
                    return null;
            }
            else
                return null;
        }
        //




    }// end class
}
