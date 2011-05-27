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
    public partial class LockScreen : UserControl
    {
        private Status _CurrentStatus = Status.Green;

        public LockScreen()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Program._MainForm._alarmStatus != Alarm.Home && Program._MainForm._alarmStatus != Alarm.Away)
            {
                Program._MainForm.LoadScreen(Screen.HomeScreen, Screen.LockScreen);
            }
            else
            {
                Program._MainForm.LoadScreen(Screen.SecurityScreen, Screen.LockScreen);
            }
        }

        private void LockScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible==true)
                sound1.PlayOnce("Resources\\CommandFunctionsAreOffline.wav");
        }

    }
}
