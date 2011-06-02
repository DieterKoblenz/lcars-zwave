using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LCARSHome.UserControls
{
    public partial class SubSystemControls : UserControl
    {
        BackgroundWorker bw = new BackgroundWorker();
        public SubSystemControls()
        {
            InitializeComponent();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
        }


        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetButtonStatuses();
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }

        internal void SetButtonStatuses()
        {
            if(Zwave.PoweredOn(9))
                button27.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            else
                button27.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            
            if (Zwave.PoweredOn(2))
                button25.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            else
                button25.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;

            if (Zwave.PoweredOn(7))
                button4.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            else
                button4.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;

            button27.Invalidate();
            button25.Invalidate();
            button4.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            byte NodeID = 9;
            if (Zwave.PoweredOn(NodeID))
                Zwave.PowerOff(NodeID);
            else
                Zwave.PowerOn(NodeID);

            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            byte NodeID = 2;
            if (Zwave.PoweredOn(NodeID))
                Zwave.PowerOff(NodeID);
            else
                Zwave.PowerOn(NodeID);

            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte NodeID = 7;
            if (Zwave.PoweredOn(NodeID))
                Zwave.PowerOff(NodeID);
            else
                Zwave.PowerOn(NodeID);
            
            if(!bw.IsBusy)
                bw.RunWorkerAsync();
        }
    }
}
