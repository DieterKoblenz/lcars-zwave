using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LCARSHome.UserControls
{
    public partial class SecurityScreen : UserControl
    {
        private Status _CurrentStatus = Status.Green;

        public SecurityScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_CurrentStatus!=Status.Red && _CurrentStatus!=Status.Blue)
                Program._MainForm.LoadScreen(Screen.HomeScreen, Screen.SecurityScreen);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program._MainForm.LoadScreen(Screen.CommandCodesScreen, Screen.SecurityScreen,Status.Green);
        }

        private void SecurityScreen_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible == true && _CurrentStatus != Program._MainForm._CurrentStatus)
                {
                        SetStatus(Program._MainForm._CurrentStatus);
                }
            }
            catch { }
        }
        internal void SetStatus(Status status)
        {
            btnGreenAlert.Blink = false;
            btnRedAlert.Blink = false;
            btnYellowAlert.Blink = false;
            btnBlueAlert.Blink = false;
            button10.Blink = false;
            button15.Blink = false;
            this._CurrentStatus = status;
            switch (status)
            {
                case Status.Green:
                    {
                        btnGreenAlert.Blink = true;
                        webBrowser1.Navigate("about:<HtmlDocument><body scroll='no' bgcolor='black'><img src='" + Directory.GetCurrentDirectory() + "\\Resources\\Green-alert.gif' height='202' width='250'> </img></body></html>");  
                        break;
                    }
                case Status.Yellow:
                    {
                        btnYellowAlert.Blink = true;
                        webBrowser1.Navigate("about:<HtmlDocument><body scroll='no' bgcolor='black'><img src='" + Directory.GetCurrentDirectory() + "\\Resources\\Yellow-alert.gif' height='202' width='250'> </img></body></html>");
                        break;
                    }
                case Status.Red:
                    {
                        btnRedAlert.Blink = true;
                        webBrowser1.Navigate("about:<HtmlDocument><body scroll='no' bgcolor='black'><img src='" + Directory.GetCurrentDirectory() + "\\Resources\\red-alert.gif' height='202' width='250'> </img></body></html>");
                        break;
                    }
                case Status.Blue:
                    {
                        btnBlueAlert.Blink = true;
                        webBrowser1.Navigate("about:<HtmlDocument><body scroll='no' bgcolor='black'><img src='" + Directory.GetCurrentDirectory() + "\\Resources\\ST_Bluealert.gif' height='202' width='250'> </img></body></html>");
                        break;
                    }
            }
            btnGreenAlert.Invalidate();
            btnRedAlert.Invalidate();
            btnYellowAlert.Invalidate();
            btnBlueAlert.Invalidate();
            button10.Invalidate();
            button15.Invalidate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //RedAlert();
            BusinessLogic.SetStatus(Status.Red);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //never set yellow manually, alarm is armed in yellow. use an arming mechanism.
            //if (_CurrentStatus!=Status.Red && _CurrentStatus!=Status.Blue)
            //    BusinessLogic.SetStatus(Status.Yellow);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_CurrentStatus != Status.Red && _CurrentStatus != Status.Blue)
                BusinessLogic.SetStatus(Status.Blue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_CurrentStatus.ToString());
            //MessageBox.Show(btnRedAlert.Blink.ToString());
            ZWave zw = new ZWave();
        }

        private void btnRedAlert_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(btnRedAlert.BlinkState);
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (_CurrentStatus == Status.Green && !lblAlarmWarning.Visible)
            {
                BusinessLogic.SetAlarm(Alarm.Home);
                button10.Blink = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (_CurrentStatus == Status.Green && !lblAlarmWarning.Visible)
            {
                BusinessLogic.SetAlarm(Alarm.Away);
                button15.Blink = true;
            }
        }

        internal void AlarmCountDown(int Seconds, bool visible, Alarm pendingAction)
        {
            switch (pendingAction)
            {
                case Alarm.Sounding:
                    {
                        this.lblAlarmWarning.Text = "ALARM WILL SOUND IN " + Seconds.ToString() + " SECONDS";
                        this.lblAlarmWarning.Visible = visible;
                        break;
                    }
                case Alarm.Arming:
                    {
                        this.lblAlarmWarning.Text = "ARMING SYSTEM IN " + Seconds.ToString() + " SECONDS";
                        this.lblAlarmWarning.Visible = visible;
                        break;
                    }
            }
        }
    }
}
