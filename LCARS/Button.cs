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
using System.Drawing.Design;
using System.Windows.Forms;

namespace Streambolics.Lcars
{
    // TODO: Make the button derive from the label, so the drawing of the text is done
    //       the same way.

    [ToolboxBitmap (@"C:\Inetpub\wwwroot\LCARS\LCARS_Toolbox\icon\st1_16.ico")]
    public class Button : Label
    {
        // Fields
        private bool _Blink = true;
        private bool _BlinkState = false;
        private int _BlinkInterval = 500;
        private int _SoundRepeat = 1;

        private string _SoundFile = "Resources/Beep.wav";
        private bool _IsDown = false;
        private bool _ChangeOnHover = false;

        // TODO: Try to remove this.
        private IContainer components;

        private Sound lCARS_Sound1;
        private Timer timer2;
        private int timer2tickcount=0;

        // TODO: Each button uses its own timer, and thus blinks independantly of all
        //       the others. Do we really want that, or do we want all blinking to
        //       be synchronized?

        private Timer timer1;

        // Methods
        public Button ()
        {
            this.InitializeComponent ();
            base.SetStyle (ControlStyles.DoubleBuffer, true);
            base.SetStyle (ControlStyles.AllPaintingInWmPaint, true);
        }

        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lCARS_Sound1 = new Streambolics.Lcars.Sound();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new EventHandler(timer2_Tick);
            // 
            // Button
            // 
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LCARS_Button";
            this.Size = new System.Drawing.Size(104, 32);
            this.ResumeLayout(false);

        }

        void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2tickcount < _SoundRepeat)
            {
                this.lCARS_Sound1.PlayOnce(this._SoundFile);
                timer2tickcount++;
            }
            else
            {
                timer2tickcount = 0;
                timer2.Stop();
            }
        }

        protected override void OnMouseHover (EventArgs e)
        {
            base.OnMouseHover (e);
            _IsDown = true;
            Invalidate ();
        }

        protected override void OnMouseLeave (EventArgs e)
        {
            base.OnMouseLeave (e);
            _IsDown = false;
            Invalidate ();
        }

        protected override void OnMouseDown (MouseEventArgs e)
        {
            base.OnMouseDown (e);
            if (this._SoundFile.Trim () != "")
            {
                if (_SoundRepeat <1)
                {
                }
                else if (_SoundRepeat == 1)
                {
                    this.lCARS_Sound1.PlayOnce(this._SoundFile);
                }
                else
                {
                    this.lCARS_Sound1.PlayOnce(this._SoundFile);
                    timer2tickcount = 1;
                    timer2.Start();
                }
            }
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            UseAlternateColor = (_IsDown && _ChangeOnHover) || (_Blink && _BlinkState);
            base.OnPaint (e);
        }

        private void Timer1Tick (object sender, EventArgs e)
        {
            if (this.InAlert || !this.Online)
            {
                _BlinkState = !_BlinkState;
                Invalidate();
            }
        }

        // Properties

        // BUG: The term "blink" is a verb. Use Blinking instead.
        // TODO: Move blinking support to the Panel itself.
        // TODO: In category "behavior" ?

        [Category ("LCARS"), Description ("Blink button")]
        public bool Blink
        {
            get
            {
                return this._Blink;
            }
            set
            {
                this._Blink = value;
                this.timer1.Enabled = this._Blink;
            }
        }

        [Category("LCARS"), Description("Blink state")]
        public bool BlinkState
        {
            get
            {
                return this._BlinkState;
            }
            set
            {
                this._BlinkState = value;
            }
        }

        [Category("LCARS"), Description("Change to Alternate Color on Hover")]
        public bool ChangeOnHover
        {
            get
            {
                return this._ChangeOnHover;
            }
            set
            {
                this._ChangeOnHover = value;
            }
        }
        [Category("LCARS"), Description("Blink interval")]
        public int BlinkInterval
        {
            get
            {
                return this._BlinkInterval;
            }
            set
            {
                this._BlinkInterval = value;
                this.timer1.Interval = this._BlinkInterval;
            }
        }

        [Category("LCARS"), Description("Number of times to repeat sound")]
        public int SoundRepeatTimes
        {
            get
            {
                return this._SoundRepeat;
            }
            set
            {
                this._SoundRepeat = value;
            }
        }

        [Description ("Sound file"), Category ("LCARS")]
        public string SoundFile
        {
            get
            {
                return this._SoundFile;
            }
            set
            {
                this._SoundFile = value;
                base.Invalidate ();
            }
        }

    }
}