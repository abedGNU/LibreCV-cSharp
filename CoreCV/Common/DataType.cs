using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCV
{
    public static class DataType
    {
        public enum eCameraType
        {
            eAreaScanDiv,
            eAreaScanPol,
        }

        public enum eErrors
        {
            Exeption,
            Debug,
        }

        public struct stcameraParameter
        {
            public eCameraType CameraType;
            public decimal Sx;
            public decimal Sy;
            public decimal focalLength;
            public decimal kappa;
            public decimal Cx;
            public decimal Cy;
            public int imgWidth;
            public int imgHeight;
        }
    }
}
