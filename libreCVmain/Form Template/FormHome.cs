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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            try
            {
                InitializeComponent();
             }
            catch (Exception ex)
            {
                Utilitiy.write_error(this.GetType().FullName, System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex, DataType.eErrors.Exeption);
            }
        }


        #region Form close, move, minimize

        private bool pnlTitleMouseDown;
        private Point lastMouseLocation;

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlTitleMouseDown = true;
                lastMouseLocation = e.Location;//new Point(e.X, e.Y);
            }
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            pnlTitleMouseDown = false;
        }

        // move form
        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (pnlTitleMouseDown)
            {
                this.Location = new Point( (this.Location.X - lastMouseLocation.X) + e.X, (this.Location.Y - lastMouseLocation.Y) + e.Y); 
               // this.SetDesktopLocation(MousePosition.X - lastMousePosition.X, MousePosition.Y - lastMousePosition.Y);
                /*
                 this.Left += MousePosition.X - lastMousePosition.X;
                 this.Top += MousePosition.Y - lastMousePosition.Y; 
                 */

                /* Point mousePose = Control.MousePosition;
                   mousePose.Offset(lastMousePosition.X, lastMousePosition.Y);
                   Location= mousePose;
                 */
            }
        }

        // close aplication
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // minimize form
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
        }

        //Form close, move, minimize methods
        #endregion




    }
}


