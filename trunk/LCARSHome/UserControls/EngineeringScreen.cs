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
    public partial class EngineeringScreen : UserControl
    {
        private Status _CurrentStatus = Status.Green;
        private BackgroundWorker _bw = new BackgroundWorker();
        private string _DiagnosticResult;

        public EngineeringScreen()
        {
            InitializeComponent();
            _bw.WorkerReportsProgress = true;
            _bw.DoWork += new DoWorkEventHandler(_bw_DoWork);
            _bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_bw_RunWorkerCompleted);
            _bw.ProgressChanged += new ProgressChangedEventHandler(_bw_ProgressChanged);
        }

        void _bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sound1.PlayOnce("Resources\\DiagnosticComplete.wav");
            Thread.Sleep(2000);
            MessageBox.Show(_DiagnosticResult.ToString());
        }

        void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < 20; x++)
            {
                byte NodeID = (byte)x;
                sb.Append(Zwave.Diagnostic(NodeID) + Environment.NewLine);
            }
            _DiagnosticResult = sb.ToString();
        }
        internal void SetStatus(Status status)
        {
            this._CurrentStatus = status;
            switch (status)
            {
                case Status.Green:
                    {

                        //TODO: Add Events
                        break;
                    }
                case Status.Yellow:
                    {
                        //TODO: Add Events
                        break;
                    }
                case Status.Red:
                    {
                        //TODO: Add Events
                        break;
                    }
                case Status.Blue:
                    {
                        //TODO: Add Events
                        break;
                    }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            Program._MainForm.LoadScreen(Screen.HomeScreen, Screen.EngineeringScreen);
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            subSystemControls1.Visible = !subSystemControls1.Visible;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //_bw.RunWorkerAsync();
            MainForm.Manager.WriteConfig(Properties.Settings.Default.HomeID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BusinessLogic.SetStatus(Status.Red);
        }

        internal void SetButtonStatuses()
        {
            #region Enabled & Ready
            if (Properties.Settings.Default.ZWaveEnabled && Zwave.m_ready)
            {
                foreach (Streambolics.Lcars.Button b in BusinessLogic.GetAllButtons(this.Controls))
                {
                    b.BlinkState = false;
                    ZWaveStatus s = Zwave.Status(b.NodeID);
                    if (s == ZWaveStatus.PartiallyOn)
                    {
                        b.SubFunction = Streambolics.Lcars.SubFunction.Color1;
                        b.Online = true;
                    }
                    else if (s == ZWaveStatus.On)
                    {
                        b.SubFunction = Streambolics.Lcars.SubFunction.Primary;
                        b.Online = true;
                    }
                    else if (s == ZWaveStatus.Off)
                    {
                        b.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
                        b.Online = true;
                    }
                    else if (b.NodeID == 0)
                    {
                        //b.SubFunction = b.SubFunction;
                        //b.Online = b.Online;
                        //b.Online = true;
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
                foreach (Streambolics.Lcars.Button b in BusinessLogic.GetAllButtons(this.Controls))
                    {
                        if (b.NodeID != 0)
                        {
                            b.BlinkState = false;
                            b.Online = false;
                        }
                        b.Invalidate();
                    }
            }
            #endregion
            this.btnZWave.Online = Zwave.m_ready;
            
            if (Properties.Settings.Default.SpeechRecognitionEnabled)
                btnVoice.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            else
                btnVoice.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            
            if (Properties.Settings.Default.ZWaveEnabled)
                btnZWave.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            else
                btnZWave.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;

            if (Properties.Settings.Default.IdleTimerEnabled)
                btnAutoLockout.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            else
                btnAutoLockout.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpeechRecognitionEnabled = !Properties.Settings.Default.SpeechRecognitionEnabled;
            SetButtonStatuses();
            Properties.Settings.Default.Save();
        }

        private void btnZWave_Click(object sender, EventArgs e)
        {
            if (!btnZWave.Online)
            {
                if (!Properties.Settings.Default.ZWaveEnabled)
                {
                    Properties.Settings.Default.ZWaveEnabled = true;
                    Properties.Settings.Default.Save();
                }
                Console.WriteLine("Manually set ZWave Controller to Ready");
                Zwave.m_ready = true;
                Program._MainForm.engineeringScreen1.SetButtonStatuses();
                Program._MainForm.engineeringScreen1.subSystemControls1.SetButtonStatuses();
                
            }
            else
            {
                Properties.Settings.Default.ZWaveEnabled = !Properties.Settings.Default.ZWaveEnabled;
                Properties.Settings.Default.Save();
                SetButtonStatuses();
            }
        }

        private void btnAutoLockout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IdleTimerEnabled = !Properties.Settings.Default.IdleTimerEnabled;
            Properties.Settings.Default.Save();
            SetButtonStatuses();
        }

        private void btnDeck2Breach_Click(object sender, EventArgs e)
        {
            //byte node = btnDeck2Breach.NodeID;
            //Console.WriteLine("Attempting to Associate Node " + node.ToString() + " with Controller...");
            //MainForm.Manager.AddAssociation(Properties.Settings.Default.HomeID, node, 1, 13);
            //Console.WriteLine("Attempting to Refresh Node " + node.ToString() + " Info...");
            //MainForm.Manager.RefreshNodeInfo(Properties.Settings.Default.HomeID, node);
            //Console.WriteLine("Association Attempt Complete.");
        }

        private void btnDeck1Breach_Click(object sender, EventArgs e)
        {
            //byte node = btnDeck1Breach.NodeID;
            //Console.WriteLine("Attempting to Associate Node " + node.ToString() + " with Controller...");
            //MainForm.Manager.AddAssociation(Properties.Settings.Default.HomeID, node, 1, 13);
            //Console.WriteLine("Attempting to Refresh Node " + node.ToString() + " Info...");
            //MainForm.Manager.RefreshNodeInfo(Properties.Settings.Default.HomeID, node);
            //Console.WriteLine("Association Attempt Complete.");
        }

        private void btnDeck2Motion_Click(object sender, EventArgs e)
        {

        }

        private void EngineeringScreen_Load(object sender, EventArgs e)
        {
            SetButtonStatuses();
        }
    }
}
