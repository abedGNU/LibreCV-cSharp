using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CoreCV
{
    public class aFile
    {

        #region Fields
        //
        public string Dir = ""; // directory, file location
        public string fName = ""; // File name
        public string Extension = "";

        private DirectoryInfo locationInfo;
        private DirectoryInfo currentDirInfo;
        private FileInfo fileInfo;
        //
        #endregion //Fields

        #region Properties
        public string FullName
        {
            get
            {
                return Dir + fName + "." + Extension;
            }

        }
        //private bool fileExist = false;
        public bool FileExist
        {
            get
            {
                fileInfo.Refresh();
                //return fileExist = fileInfo.Exists;
                return fileInfo.Exists;
            }

        }

        //private bool dirExist = false;
        public bool DirExist
        {
            get
            {
                locationInfo.Refresh();
                //return dirExist = locationInfo.Exists;
                return locationInfo.Exists;
            }

        }

        #endregion //Properties


        #region Constructors
        //
        public aFile()
        {

        }

        public aFile(string dir)
        {
            Dir = dir;
            init();
        }

        public aFile(string dir, string fileName, string extension)
        {
            Dir = dir;
            fName = fileName;
            Extension = extension;
            //FullName();
            init();
        }
        //
        #endregion // Constructors

        #region Methods
        /*
        public string FullName()
        {
            //fullName = Dir + fName + "." + Extension;
            return fullName;
        }*/

        private void init()
        {
            currentDirInfo = new DirectoryInfo(".\\");
            locationInfo = new DirectoryInfo(Dir);
            fileInfo = new FileInfo(FullName);


            //dirExist = locationInfo.Exists;
            //fileExist = fileInfo.Exists;
        }

        public bool CreateDirectory()
        {
            currentDirInfo.CreateSubdirectory(Dir);
            //dirExist = locationInfo.Exists;
            return DirExist;
        }

        #endregion //Methods




    }// class
}//namespace
