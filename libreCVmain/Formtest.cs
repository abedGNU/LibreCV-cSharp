using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreCV;

namespace libreCVmain
{
    public partial class Formtest : Form
    {

        public aFile file;
        public Formtest()
        {
            InitializeComponent();
            file = new aFile(@"dataRep\Vision\Models\OCR\", "11seg", "bmp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (file.FileExist)
            // {
            MessageBox.Show(file.FullName + " exist=" + file.FileExist.ToString());
            //}

        }
    }
}
