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
    public partial class HomeScreen : UserControl
    {
        private Status _CurrentStatus = Status.Green;

        public HomeScreen()
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
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program._MainForm.LoadScreen(Screen.LockScreen,Screen.HomeScreen);
        }

        private void HomeScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                sound1.PlayOnce("Resources\\LogonComplete.wav");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Thread.Sleep(300);
            Program._MainForm.LoadScreen(Screen.CommunicationScreen, Screen.HomeScreen);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Thread.Sleep(300);
            Program._MainForm.LoadScreen(Screen.SecurityScreen, Screen.HomeScreen);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

    }
}
