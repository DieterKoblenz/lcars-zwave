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
    public partial class CommandCodesScreen : UserControl
    {
        internal static Screen _ToScreen;
        internal static Screen _FromScreen;
        private Status _pendingStatus=Status.NotAStatus;
        private Status _CurrentStatus = Status.Green;

        public CommandCodesScreen()
        {
            InitializeComponent();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtCommandCode.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ValidateCode(sender,e);
        }

        private void ValidateCode(object sender,EventArgs e)
        {
            if (txtCommandCode.Text=="")
            {
                sound1.PlayOnce("Resources\\CommandCodesVerified.wav");
                Thread.Sleep(2800);
                if (_pendingStatus == Status.NotAStatus)
                {
                    Program._MainForm.LoadScreen(_ToScreen, Screen.CommandCodesScreen);
                }
                else
                {
                    Program._MainForm.LoadScreen(_ToScreen, Screen.CommandCodesScreen,_pendingStatus);
                }
                txtCommandCode.Text = "";
            }
            else
            {
                sound1.PlayOnce("Resources\\AccessDenied.wav");
                button12_Click(sender,e);
                txtCommandCode.Text = "";
            }
        }

        private void button12_VisibleChanged(object sender, EventArgs e)
        {
            sound1.PlayOnce("Resources\\InputCommandCode.wav");
        }

        [Category("Command Code"), Description("Destination Screen")]
        public Screen ToScreen
        {
            get
            {
                return _ToScreen;
            }
            set
            {
                _ToScreen = value;
            }
        }
        [Category("Command Code"), Description("Origin Screen")]
        public Screen FromScreen
        {
            get
            {
                return _FromScreen;
            }
            set
            {
                _FromScreen = value;
            }
        }

        [Category("Command Code"), Description("Pending Status Change")]
        public Status PendingStatus
        {
            get
            {
                return _pendingStatus;
            }
            set
            {
                _pendingStatus = value;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Program._MainForm.LoadScreen(_FromScreen, Screen.NotAScreen);
        }
    }
}
