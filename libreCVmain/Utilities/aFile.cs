using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CoreCV.Utilities
{
    class aFile
    {
        public string Dir = ""; // directory, file location
        public string fName=""; // File name
        public string Extension="";

        public string FullName="";

        private bool fileExist = false;
        public bool FileExist
        {
            get
            {
                fileInfo.Refresh();
                return fileExist;
            }

        }

        private bool dirExist = false;
        public bool DirExist
        {
            get
            {
                locationInfo.Refresh();
                return dirExist;
            }

        }

        private DirectoryInfo locationInfo;
        private DirectoryInfo currentDirInfo;
        private FileInfo fileInfo;

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
            FullName = dir + fileName + extension;

            init();
        }

        private void init()
        {
            currentDirInfo = new DirectoryInfo(".\\");
            locationInfo = new DirectoryInfo(Dir);
            fileInfo = new FileInfo(FullName);


            dirExist = locationInfo.Exists;
            fileExist = fileInfo.Exists;
        }

        public bool CreateDirectory()
        {
            currentDirInfo.CreateSubdirectory(Dir);
            dirExist = locationInfo.Exists;
            return dirExist;
        }

    }
}
