using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LCARSHome
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int _timer1tickcount = 1;
        private int _SoundRepeat = 0;
        private string _SoundFile = "";
        internal Status _CurrentStatus=Status.Green;
        internal Alarm _alarmStatus = Alarm.Disarmed;

        public void LoadScreen(Screen ToScreen, Screen FromScreen)
        {
            LoadScreen(ToScreen,FromScreen,Status.NotAStatus);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadScreen(Screen.LockScreen,Screen.NotAScreen);
            this.timer1.Interval = 2000;
            this.timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        internal void SetStatus(Status status)
        {
            this._CurrentStatus = status;
            switch (status)
            {
                case Status.Green:
                    {
                        _SoundRepeat = 0;
                        //TODO: Add Events
                        break;
                    }
                case Status.Yellow:
                    {
                        _SoundFile = "Resources\\AutomaticDefenseProcedures.wav";
                        Program._MainForm.sound1.PlayOnce(this._SoundFile);
                        //_SoundRepeat = 4;
                        //_timer1tickcount = 1;
                        //TODO: Add Events
                        break;
                    }
                case Status.Red:
                    {
                        _SoundFile = "Resources\\RedAlertWarning.wav";
                        Program._MainForm.sound1.PlayOnce(this._SoundFile);
                        _SoundRepeat=15;
                        _timer1tickcount = 1;
                        //TODO: Add Events
                        break;
                    }
                case Status.Blue:
                    {
                        _SoundFile = "Resources\\alert1.wav";
                        Program._MainForm.sound1.PlayOnce(this._SoundFile);
                        _SoundRepeat = 8;
                        _timer1tickcount = 1;
                        //TODO: Add Events
                        break;
                    }
            }
        }
        
        private void securityScreen1_Load(object sender, EventArgs e)
        {

        }

        void timer1_Tick(object sender, EventArgs e)
        {
           if (_timer1tickcount < _SoundRepeat)
            {
                Program._MainForm.sound1.PlayOnce(this._SoundFile);
                _timer1tickcount++;
            }
            else
            {
                _SoundRepeat = 0;
            }

           if (!backgroundWorker1.IsBusy)
           {
               try
               {
                   backgroundWorker1.RunWorkerAsync();
               }
               catch { }
           }
        }

        internal void SetAlarm(Alarm alarm)
        {
            this._alarmStatus = alarm;
            Program._MainForm.securityScreen1.AlarmCountDown(0, false, Alarm.Arming);
            switch (alarm)
            {
                case Alarm.Arming:
                    {
                        _SoundFile = "Resources\\ForcefieldAlarm.wav";
                        Program._MainForm.sound1.PlayOnce(this._SoundFile);
                        _SoundRepeat = 10;
                        _timer1tickcount = 1;
                        //TODO: Add Events
                        break;
                    }
                default:
                    {
                        _SoundRepeat = 0;
                        //TODO: Add Events
                        break;
                    }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BusinessLogic.SetStatus(Status.Green);
        }

        internal void LoadScreen(Screen ToScreen, Screen FromScreen, Status setStatus)
        {
            this.commandCodesScreen1.Visible = false;
            this.communicationScreen1.Visible = false;
            this.lockScreen1.Visible = false;
            this.homeScreen1.Visible = false;
            this.securityScreen1.Visible = false;

            this.commandCodesScreen1.FromScreen = FromScreen;
            this.commandCodesScreen1.ToScreen = ToScreen;

            switch (FromScreen)
            {
                case Screen.LockScreen:
                    {
                        //from a lock screen.
                        switch (ToScreen)
                        {
                            case Screen.LockScreen:
                                {
                                    this.lockScreen1.Visible = true;
                                    break;
                                }

                            case Screen.SecurityScreen:
                                {
                                    this.securityScreen1.Visible = true;
                                    break;
                                }

                            default:
                                {
                                    this.commandCodesScreen1.Visible = true;
                                    break;
                                }
                        }
                        break;
                    }
                case Screen.CommandCodesScreen:
                    {
                        //from a command code screen. I am authorized.
                        switch (ToScreen)
                        {
                            case Screen.HomeScreen:
                                {
                                    this.homeScreen1.Visible = true;
                                    break;
                                }
                            case Screen.LockScreen:
                                {
                                    this.lockScreen1.Visible = true;
                                    break;
                                }
                            case Screen.SecurityScreen:
                                {
                                    if (setStatus != Status.NotAStatus)
                                    {
                                        BusinessLogic.SetStatus(setStatus);
                                        BusinessLogic.SetAlarm(Alarm.Disarmed);
                                        commandCodesScreen1.PendingStatus = Status.NotAStatus;
                                    }
                                    this.securityScreen1.Visible = true;
                                    break;
                                }
                        }
                        break;
                    }
                case Screen.SecurityScreen:
                    {
                        //from Security Screen
                        switch (ToScreen)
                        {
                            case Screen.CommandCodesScreen:
                                {
                                    this.commandCodesScreen1.ToScreen = Screen.SecurityScreen;
                                    this.commandCodesScreen1.PendingStatus = setStatus;
                                    this.commandCodesScreen1.Visible = true;
                                    break;
                                }
                        }
                        goto default;
                    }
                default:
                    {
                        //Not from a lock screen, not authorized.
                        switch (ToScreen)
                        {
                            case Screen.LockScreen:
                                {
                                    this.lockScreen1.Visible = true;
                                    break;
                                }
                            case Screen.HomeScreen:
                                {
                                    this.homeScreen1.Visible = true;
                                    break;
                                }
                            case Screen.CommunicationScreen:
                                {
                                    this.communicationScreen1.Visible = true;
                                    break;
                                }
                            case Screen.SecurityScreen:
                                {
                                    this.securityScreen1.Visible = true;
                                    break;
                                }
                        }
                        break;
                    }
            }           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
 
                while (Win32.GetIdleTime()/1000 < Properties.Settings.Default.IdleTimeoutInSeconds)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine((Win32.GetIdleTime()/1000).ToString());
                }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!Program._MainForm.lockScreen1.Visible)
                Program._MainForm.LoadScreen(Screen.LockScreen, Screen.NotAScreen);
        }
    }
}
