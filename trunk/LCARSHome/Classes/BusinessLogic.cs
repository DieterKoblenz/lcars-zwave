using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using Streambolics.Lcars;

namespace LCARSHome
{
    class BusinessLogic
    {
        internal static BackgroundWorker bw = new BackgroundWorker();
        internal static BackgroundWorker bwArm = new BackgroundWorker();
        private static Alarm _PendingAlarmStatus;

        public static List<LcarsControl> GetAllAlertables(IList ctrls)
        {
            List<LcarsControl> RetCtrls = new List<LcarsControl>();
            foreach (Control ctl in ctrls)
            {
                if (ctl.GetType().Namespace=="Streambolics.Lcars")
                    try
                    {
                        RetCtrls.Add((LcarsControl)ctl);
                    }
                    catch { }
                List<LcarsControl> SubCtrls = GetAllAlertables(ctl.Controls);
                RetCtrls.AddRange(SubCtrls);
            }
            return RetCtrls;
        }

        public static List<LcarsControl> GetAllButtons(IList ctrls)
        {
            List<LcarsControl> RetCtrls = new List<LcarsControl>();
            foreach (Control ctl in ctrls)
            {
                if (ctl.GetType().FullName == "Streambolics.Lcars.Button")
                    try
                    {
                        RetCtrls.Add((LcarsControl)ctl);
                    }
                    catch { }
                List<LcarsControl> SubCtrls = GetAllAlertables(ctl.Controls);
                RetCtrls.AddRange(SubCtrls);
            }
            return RetCtrls;
        }

        internal static void Exit()
        {
            Program._MainForm.sound1.PlayOnce("Resources\\AutoShutdown.wav");
            Thread.Sleep(3000);
            Application.Exit();
        }

        internal static void SetStatus(Status status)
        {
            Program._MainForm.SetStatus(status);
            Program._MainForm.securityScreen1.SetStatus(status);
            Program._MainForm.communicationScreen1.SetStatus(status);
            Program._MainForm.commandCodesScreen1.SetStatus(status);
            Program._MainForm.homeScreen1.SetStatus(status);
            Program._MainForm.lockScreen1.SetStatus(status);
            #region Status
            switch (status)
            {
                case Status.Red:
                    {
                        if (!Program._MainForm.securityScreen1.Visible)
                            Program._MainForm.LoadScreen(Screen.SecurityScreen, Screen.NotAScreen);
                        if (Program._MainForm._alarmStatus != Alarm.Sounding)
                        {
                            SetAlarm(Alarm.Sounding);
                        }
                        List<LcarsControl> alertables = GetAllAlertables(Program._MainForm.Controls);
                        foreach (LcarsControl ctl in alertables)
                        {
                            ctl.InAlert = true;
                            ctl.Invalidate();
                        }

                        Program._MainForm.lockScreen1.label1.Text = "RED ALERT - SYSTEM LOCKED";
                        break;
                    }
                case Status.Blue:
                    {
                        if (!bw.IsBusy)
                        {
                            try
                            {
                                bw.RunWorkerCompleted -= bw_RunWorkerCompleted;
                                bw.DoWork -= bw_DoWork;
                                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                                bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                                bw.WorkerSupportsCancellation = true;
                                bw.WorkerReportsProgress = true;
                                bw.RunWorkerAsync();
                            }
                            catch { }
                            if (!Program._MainForm.securityScreen1.Visible)
                                Program._MainForm.LoadScreen(Screen.SecurityScreen, Screen.NotAScreen);
                        }
                        break;
                    }
                case Status.Yellow:
                    {
                        if (!Program._MainForm.securityScreen1.Visible)
                            Program._MainForm.LoadScreen(Screen.SecurityScreen, Screen.NotAScreen);
                        break;
                    }
                case Status.Green:
                    {
                        if (bw.IsBusy)
                               bw.CancelAsync();

                        Program._MainForm.sound1.Stop();
                        Program._MainForm.lockScreen1.label1.Text = "COMMAND FUNCTIONS OFFLINE";
                        List<LcarsControl> alertables = GetAllAlertables(Program._MainForm.Controls);
                        foreach (LcarsControl ctl in alertables)
                        {
                            ctl.InAlert = false;
                            ctl.Invalidate();
                        }
                        break;
                    }
            }
            #endregion
        }

        static void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Program._MainForm.securityScreen1.AlarmCountDown(e.ProgressPercentage, true,Alarm.Sounding);
        }

        static void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            int max = Properties.Settings.Default.EntryDelay;
            for (int i = 1; i <= max; i++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    bw.ReportProgress(max-i);
                }
            }
        }

        static void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Program._MainForm.securityScreen1.AlarmCountDown(0, false,Alarm.Sounding);
            if (!e.Cancelled)
                BusinessLogic.SetAlarm(Alarm.Sounding);
             //BusinessLogic.SetStatus(Status.Red);
        }


        internal static void SetAlarm(Alarm alarm)
        {
            switch (alarm)
            {
                case Alarm.Sounding:
                    {
                        if (Program._MainForm._CurrentStatus != Status.Red)
                        {
                            BusinessLogic.SetStatus(Status.Red);
                        }
                        break;
                    }
                case Alarm.Home:
                    {
                        Program._MainForm.SetAlarm(Alarm.Arming);
                        _PendingAlarmStatus = alarm;
                        if (!bwArm.IsBusy)
                        {
                            try
                            {
                                bwArm.RunWorkerCompleted -= bwArm_RunWorkerCompleted;
                                bwArm.DoWork -= bwArm_DoWork;
                                bwArm.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwArm_RunWorkerCompleted);
                                bwArm.DoWork += new DoWorkEventHandler(bwArm_DoWork);
                                bwArm.ProgressChanged += new ProgressChangedEventHandler(bwArm_ProgressChanged);
                                bwArm.WorkerSupportsCancellation = true;
                                bwArm.WorkerReportsProgress = true;
                                bwArm.RunWorkerAsync();
                            }
                            catch { }
                        }
                        break;
                    }

                case Alarm.Away:
                    {
                        Program._MainForm.SetAlarm(Alarm.Arming);
                        _PendingAlarmStatus = alarm;
                        if (!bwArm.IsBusy)
                        {
                            try
                            {
                                bwArm.RunWorkerCompleted -= bwArm_RunWorkerCompleted;
                                bwArm.DoWork -= bwArm_DoWork;
                                bwArm.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwArm_RunWorkerCompleted);
                                bwArm.DoWork += new DoWorkEventHandler(bwArm_DoWork);
                                bwArm.ProgressChanged += new ProgressChangedEventHandler(bwArm_ProgressChanged);
                                bwArm.WorkerSupportsCancellation = true;
                                bwArm.WorkerReportsProgress = true;
                                bwArm.RunWorkerAsync();
                            }
                            catch { }
                        }
                        break;
                    }
                case Alarm.Disarmed:
                    {
                        Program._MainForm.SetAlarm(Alarm.Disarmed);
                        if (Program._MainForm._CurrentStatus != Status.Green)
                        {
                            BusinessLogic.SetStatus(Status.Green);
                        }
                        break;
                    }
            }
        }

        static void bwArm_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Program._MainForm.securityScreen1.AlarmCountDown(e.ProgressPercentage, true, Alarm.Arming);
        }

        static void bwArm_DoWork(object sender, DoWorkEventArgs e)
        {
            int max=0;
            switch (_PendingAlarmStatus)
            {
                case Alarm.Away:
                    {
                        max = Properties.Settings.Default.ExitDelay;
                        break;
                    }
                case Alarm.Home:
                    {
                        max=Properties.Settings.Default.ArmDelayHome;
                        break;
                    }
            }
            for (int i = 1; i <= max; i++)
            {
                if (bwArm.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    bwArm.ReportProgress(max - i);
                }
            }
        }

        static void bwArm_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                Program._MainForm.SetAlarm(_PendingAlarmStatus);
                SetStatus(Status.Yellow);
                Program._MainForm.lockScreen1.label1.Text="ARMED IN " + _PendingAlarmStatus.ToString().ToUpper() + " MODE";
            }
        }

        internal static void SensorStatusChange(byte NodeID, byte Status)
        {
            switch (Program._MainForm._alarmStatus)
            {
                case Alarm.Away:
                    {
                        switch (NodeID)
                        {
                            case 14:
                            case 20:
                                {
                                    switch (Status)
                                    {
                                        case 255:
                                            {
                                                SetStatus(LCARSHome.Status.Red);
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 21:
                            case 22:
                                {
                                    switch (Status)
                                    {
                                        case 255:
                                            {
                                                SetStatus(LCARSHome.Status.Blue);
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case Alarm.Home:
                    {
                        switch (NodeID)
                        {
                            case 21:
                            case 22:
                                {
                                    switch (Status)
                                    {
                                        case 255:
                                            {
                                                SetStatus(LCARSHome.Status.Red);
                                                break;
                                            }

                                    }
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}
