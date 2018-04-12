using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using HalconDotNet;


namespace ViewROI
{
    public partial class HWndView : UserControl
    {
        private HWndCtrl hWndControl;
        private HImage image;

        public HWndView()
        {
            InitializeComponent();
        }

        private void HWndView_Load(object sender, EventArgs e)
        {
            hWndControl = new HWndCtrl(viewPort);
            hWndControl.NotifyIconObserver = new IconicDelegate(UpdateHWnd);
            Init();
        }

        private void Init()
        {
           // String fileName = "particle";
           
            try
            {
                 //set the step of the scrollbars
                hWndControl.setGUICompRangeX(new int[] { scrollBarX.Minimum, scrollBarX.Maximum }, scrollBarX.Value);
                hWndControl.setGUICompRangeY(new int[] { scrollBarY.Minimum, scrollBarY.Maximum }, scrollBarY.Maximum - scrollBarY.Value);
            }
            catch (Exception ex)
            {; }
        }
        /**************************************************************************/
        /**************************************************************************/

        #region methods
        //

        /// <summary>
        /// Update method invoked by the window controller for errors 
        /// that may occur during loading or processing
        /// </summary>
        public void UpdateHWnd(int mode)
        {
            switch (mode)
            {
                case HWndCtrl.ERR_READING_IMG:
                    MessageBox.Show("Problem occured while reading file! \n" +
                        hWndControl.exceptionText,
                        "GraphicsStack",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case HWndCtrl.ERR_DEFINING_GC:
                    MessageBox.Show("Problem occured while setting up graphical context! \n " +
                        hWndControl.exceptionText,
                        "GraphicsStack",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
            }
        }
        //

        public void dispObject(HObject obj)
        {
            hWndControl.addIconicVar(obj);
            hWndControl.repaint();
        }
        #endregion
        //
        #region events

        /*************************************************************************
         * Eventhandles to reset the window to the initial view dimensions, as well  
         * as clearing the graphics stack from all iconic objects added - display 
         * will be black then. 
        /**************************************************************************/
        private void ResetButton_Click(object sender, EventArgs e)
        {
            scrollBarY.Value = 50;
            scrollBarX.Value = 50;
            ZoomUpDown.Value = 100;
            //
            hWndControl.resetGUIInitValues(scrollBarX.Value, scrollBarY.Value);
            hWndControl.resetWindow();
            hWndControl.repaint();

        }
        //
        private void ClearWindButton_Click(object sender, EventArgs e)
        {
            hWndControl.resetWindow();
            hWndControl.clearList();
            hWndControl.repaint();

        }
        //
        /*************************************************************************
         * Eventhandles for the GUI components mapping the view functions, like
         * move, zoom and the neutral state.
        /**************************************************************************/
        private void MoveButton_CheckedChanged(object sender, System.EventArgs e)
        {
            hWndControl.setViewState(HWndCtrl.MODE_VIEW_MOVE);
        }

        private void ZoomButton_CheckedChanged(object sender, System.EventArgs e)
        {
            hWndControl.setViewState(HWndCtrl.MODE_VIEW_ZOOM);
        }

        private void NoneButton_CheckedChanged(object sender, System.EventArgs e)
        {
            hWndControl.setViewState(HWndCtrl.MODE_VIEW_NONE);
        }

        /**************************************************************************/
        /* Adjust the view using GUI components for moving along the x and y 
         * direction and for changing the zoom of the image displayed
         * *************************************************************************/
        private void scrollBarY_Scroll(object sender, ScrollEventArgs e)
        {
            hWndControl.moveYByGUIHandle(scrollBarY.Maximum - scrollBarY.Value);
        }

        private void scrollBarX_Scroll(object sender, ScrollEventArgs e)
        {

            hWndControl.moveXByGUIHandle(scrollBarX.Value);
        }

        private void ZoomUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            hWndControl.zoomByGUIHandle((int)ZoomUpDown.Value);
        }

        public void addIconicVar(HObject obj)
        {
            hWndControl.addIconicVar(obj);
        }

        #endregion

    }
}
