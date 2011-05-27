#region Original Work By Marcelo Chavez
//---------------------------------------------------------------------------------------------------
//
//  This library is based on original work by Marcelo Chavez.
//  Please see http://www.codeproject.com/KB/miscctrl/lcars_net_controls.aspx
//  for more information.
//
//---------------------------------------------------------------------------------------------------
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Streambolics.Lcars
{
    [ToolboxBitmap (@"C:\Inetpub\wwwroot\LCARS\LCARS_Toolbox\icon\st1_16.ico")]
    public class DateLabel : Panel
    {
        // Fields
        private string _Format = "yyyy-MM-dd HH:mm:ss";
        private DateStyle _Style = DateStyle.StarDate;
        private IContainer components;
        private Timer timer1;

        // Methods
        public DateLabel ()
        {
            this.InitializeComponent ();
        }

        private string FormatDate ()
        {
            try
            {
                if (this._Style == DateStyle.Normal)
                {
                    return ((this._Format.Trim () == "") ? DateTime.Now.ToString () : DateTime.Now.ToString (this._Format));
                }
                DateTime now = DateTime.Now;
                double month = now.Month;
                double day = now.Day;
                double year = now.Year;
                double hour = now.Hour;
                double minute = now.Minute;
                double second = now.Second;
                double num7 = ((second + (60.0 * minute)) + (3600.0 * hour)) + (86400.0 * (day - 1.0));
                if (month > 10.0)
                {
                    num7 += 28857600.0;
                }
                else if (month > 9.0)
                {
                    num7 += 26265600.0;
                }
                else if (month > 8.0)
                {
                    num7 += 23587200.0;
                }
                else if (month > 7.0)
                {
                    num7 += 20995200.0;
                }
                else if (month > 6.0)
                {
                    num7 += 18316800.0;
                }
                else if (month > 5.0)
                {
                    num7 += 15638400.0;
                }
                else if (month > 4.0)
                {
                    num7 += 13046400.0;
                }
                else if (month > 3.0)
                {
                    num7 += 10368000.0;
                }
                else if (month > 2.0)
                {
                    num7 += 7776000.0;
                }
                else if (month > 1.0)
                {
                    num7 += 5097600.0;
                }
                else if (month > 0.0)
                {
                    num7 += 2678400.0;
                }
                if (year > 2100.0)
                {
                    year -= 1900.0;
                }
                double num8 = Math.Round ((double)(num7 / 315.36)) / 100.0;
                double num9 = Math.Round ((double)(year / 400.0));
                double num10 = year / 400.0;
                if ((num9 == num10) && (month > 2.0))
                {
                    num7 += 86400.0;
                }
                double num11 = Math.Round ((double)(((year - 2323.0) / 100.0) - 0.5));
                double num12 = (year - (2323.0 + (num11 * 100.0))) * 1000.0;
                double num13 = num8 + num12;
                string str = "";
                string str2 = "";
                if (minute < 10.0)
                {
                    str = "0";
                }
                else
                {
                    str = "";
                }
                if (second < 10.0)
                {
                    str2 = "0";
                }
                else
                {
                    str2 = "";
                }
                return string.Concat (new object[] { "[", num11, "] ", num13, " ", hour, ":", str, minute, ':', str2, second });
            }
            catch
            {
                return "Invalid date";
            }
        }

        private void InitializeComponent ()
        {
            this.components = new Container ();
            this.timer1 = new Timer (this.components);
            this.timer1.Enabled = true;
            this.timer1.Interval = 0x3e8;
            this.timer1.Tick += new EventHandler (this.Timer1Tick);
            base.Name = "LCARS_Date";
            base.Size = new Size (0x68, 0x20);
        }

        private void Timer1Tick (object sender, EventArgs e)
        {
            Text = FormatDate ();
        }

        // Properties

        [Description ("Date format using .NET expressions\r\n"), Category ("LCARS")]
        public string Format
        {
            get
            {
                return this._Format;
            }
            set
            {
                this._Format = value;
                base.Invalidate ();
            }
        }

        [Description ("Date style"), Category ("LCARS")]
        public DateStyle Style
        {
            get
            {
                return this._Style;
            }
            set
            {
                this._Style = value;
                base.Invalidate ();
            }
        }
    }
}
