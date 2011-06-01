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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

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
            _bw.RunWorkerAsync();
        }

    }
}
