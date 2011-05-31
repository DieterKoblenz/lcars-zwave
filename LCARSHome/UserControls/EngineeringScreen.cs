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

        public EngineeringScreen()
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

    }
}
