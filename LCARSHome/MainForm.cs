using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Recognition;
using OpenZWaveDotNet;

namespace LCARSHome
{
    public partial class MainForm : Form
    {
        public static SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
        public static StringBuilder output = new StringBuilder();
        public static int IdleBooster = 0;
        public static bool m_ready = false;

        static private ZWOptions m_options = null;
        static public ZWOptions Options
        {
            get { return m_options; }
        }

        static private ZWManager m_manager = null;
        static public ZWManager Manager
        {
            get { return m_manager; }
        }

        private ZWNotification m_notification = null;

        public MainForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.SpeechRecognitionEnabled)
            {
                engine.LoadGrammar(new DictationGrammar());
                engine.SetInputToDefaultAudioDevice();
                engine.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(engine_RecognizeCompleted);
            }
            if (Properties.Settings.Default.ZWaveEnabled)
            {
                m_options = new ZWOptions();
                m_options.Create(@"C:\Users\Kevin\Documents\Visual Studio 2010\Projects\OpenZWave\config\", @"", @"");
                m_options.Lock();
                m_manager = new ZWManager();
                m_manager.Create();
                m_manager.AddDriver(@"\\.\COM4");
                m_manager.OnNotification += new ManagedNotificationsHandler(NotificationHandler);
            }
        }
        private int _timer1tickcount = 1;
        private int _SoundRepeat = 0;
        private string _SoundFile = "";
        internal Status _CurrentStatus=Status.Green;
        internal Alarm _alarmStatus = Alarm.Disarmed;

        public void NotificationHandler(ZWNotification notification)
        {
            // Handle the notification on a thread that can safely
            // modify the form controls without throwing an exception.
            m_notification = notification;
            Invoke(new MethodInvoker(NotificationHandler));
            m_notification = null;
        }

        private void NotificationHandler()
        {
            Zwave.NotificationHandler(m_notification);
        }

        void engine_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            output.Clear();
            RecognitionResult result = e.Result;
            try
            {
                foreach (RecognizedWordUnit word in result.Words)
                {
                    output.Append(word.Text + " ");
                }
                if (output.ToString().Contains("computer") || output.ToString().Contains("pewter"))
                {
                    IdleBooster = (int)Win32.GetIdleTime() +60;
                    if (output.ToString().Contains("red") || output.ToString().Contains("rattler"))
                    {
                        BusinessLogic.SetStatus(Status.Red);
                    }
                    else if (output.ToString().Contains("intruder"))
                    {
                        BusinessLogic.SetStatus(Status.Blue);
                    }
                    else if (output.ToString().Contains("yellow") || output.ToString().Contains("eller") || output.ToString().Contains("shields"))
                    {
                        //BusinessLogic.SetStatus(Status.Yellow);
                        BusinessLogic.SetAlarm(Alarm.Home);
                    }
                    else if (output.ToString().Contains("stand") || output.ToString().Contains("cancel")||output.ToString().Contains("stand out") || output.ToString().Contains("standout")
                        || output.ToString().Contains("stand then") || output.ToString().Contains("green"))
                    {
                        if (output.ToString().Contains("omega three"))
                        {
                            BusinessLogic.SetStatus(Status.Green);  
                        }
                        else
                        {
                            sound1.PlayOnce("Resources\\AccessDenied.wav");
                        }
                    }
                    else if (output.ToString().Contains("listen"))
                    {
                        this.sound1.PlayOnce("Resources\\Affirmative.wav");
                    }
                    else if (output.ToString().Contains("security"))
                    {
                        Program._MainForm.LoadScreen(Screen.SecurityScreen, Screen.NotAScreen);
                    }
                    else if (output.ToString().Contains("communication"))
                    {
                        Program._MainForm.LoadScreen(Screen.CommunicationScreen, Screen.NotAScreen);
                    }
                    else if (output.ToString().Contains("lock") | output.ToString().Contains("command functions"))
                    {
                        Program._MainForm.LoadScreen(Screen.LockScreen, Screen.NotAScreen);
                    }
                    else if (output.ToString().Contains("home") || output.ToString().Contains("main"))
                    {
                        Program._MainForm.LoadScreen(Screen.HomeScreen, Screen.NotAScreen);
                    }
                    else if (output.ToString().Contains("shut down") || output.ToString().Contains("exit"))
                    {
                        BusinessLogic.Exit();
                    }
                    else if (output.ToString().Contains("engine"))
                    {
                        Program._MainForm.LoadScreen(Screen.EngineeringScreen, Screen.NotAScreen);
                    }
                    else
                    {
                        this.sound1.PlayOnce("Resources\\RestateCommand.wav");
                        Console.WriteLine("Unrecognized Command: " + output.ToString());
                    }

                }
            }
            catch { }
            engine.RecognizeAsync();
        }

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
            if (Properties.Settings.Default.SpeechRecognitionEnabled)
                engine.RecognizeAsync();
        }
        internal void SetStatus(Status status)
        {
            this._CurrentStatus = status;
            switch (status)
            {
                case Status.Green:
                    {
                        IdleBooster = 0;
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
            this.engineeringScreen1.Visible = false;

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
                            case Screen.EngineeringScreen:
                                {
                                    this.engineeringScreen1.Visible = true;
                                    break;
                                }
                        }
                        break;
                    }
            }           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
 
                while (Win32.GetIdleTime()/1000 < IdleBooster + Properties.Settings.Default.IdleTimeoutInSeconds)
                {
                    Thread.Sleep(1000);
                    //Console.WriteLine((Win32.GetIdleTime()/1000).ToString());
                }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Program._MainForm.lockScreen1.Visible && Properties.Settings.Default.IdleTimerEnabled)
                Program._MainForm.LoadScreen(Screen.LockScreen, Screen.NotAScreen);
        }
    }
}
