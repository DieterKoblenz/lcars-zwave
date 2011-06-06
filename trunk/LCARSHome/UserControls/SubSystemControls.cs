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
            #region Enabled & Ready
            if (Properties.Settings.Default.ZWaveEnabled && Zwave.m_ready)
            {
                foreach (Streambolics.Lcars.Button b in this.Controls)
                {
                    b.BlinkState = false;
                    ZWaveStatus s = Zwave.Status(b.NodeID);
                    if (s == ZWaveStatus.PartiallyOn)
                    {
                        b.SubFunction = Streambolics.Lcars.SubFunction.Primary;
                        b.Online = true;
                    }
                    else if (s == ZWaveStatus.On)
                    {
                        b.SubFunction = Streambolics.Lcars.SubFunction.Color1;
                        b.Online = true;
                    }
                    else if (s == ZWaveStatus.Off)
                    {
                        b.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
                        b.Online = true;
                    }
                    else if (b.NodeID == 0)
                    {
                    }
                    else
                    {
                        b.Online = false;
                    }
                    b.Invalidate();
                }
            }
            #endregion
            #region Else
            else
            {
                foreach (Streambolics.Lcars.Button b in this.Controls)
                {
                    b.Online = false;
                    b.Invalidate();
                }
            }
            #endregion
            Program._MainForm.engineeringScreen1.SetButtonStatuses();
        }


        private void button27_Click(object sender, EventArgs e)
        {
            byte NodeID = 9;
            if (Properties.Settings.Default.ZWaveEnabled)
            {
                if (Zwave.PoweredOn(NodeID))
                    Zwave.PowerOff(NodeID);
                else
                    Zwave.PowerOn(NodeID);
            }
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ZWaveEnabled)
            {
                byte NodeID = 2;
                if (Zwave.PoweredOn(NodeID))
                    Zwave.PowerOff(NodeID);
                else
                    Zwave.PowerOn(NodeID);
            }
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte NodeID = 7;
            if (Properties.Settings.Default.ZWaveEnabled)
            {
                if (Zwave.PoweredOn(NodeID))
                    Zwave.PowerOff(NodeID);
                else
                    Zwave.PowerOn(NodeID);
            }
            if(!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void btnStairway_Click(object sender, EventArgs e)
        {
            byte NodeID = 18;
            if (Properties.Settings.Default.ZWaveEnabled)
            {
                if (Zwave.PoweredOn(NodeID))
                    Zwave.PowerOff(NodeID);
                else
                    Zwave.PowerOn(NodeID);
            }
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void btnLilly_Click(object sender, EventArgs e)
        {
            byte NodeID = 17;
            if (Properties.Settings.Default.ZWaveEnabled)
            {
                if (Zwave.PoweredOn(NodeID))
                    Zwave.PowerOff(NodeID);
                else
                    Zwave.PowerOn(NodeID);
            }
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }
    }
}
