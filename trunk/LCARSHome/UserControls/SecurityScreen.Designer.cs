namespace LCARSHome.UserControls
{
    partial class SecurityScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new Streambolics.Lcars.Label();
            this.elbo9 = new Streambolics.Lcars.Elbo();
            this.elbo8 = new Streambolics.Lcars.Elbo();
            this.button9 = new Streambolics.Lcars.Button();
            this.button8 = new Streambolics.Lcars.Button();
            this.button7 = new Streambolics.Lcars.Button();
            this.elbo7 = new Streambolics.Lcars.Elbo();
            this.elbo6 = new Streambolics.Lcars.Elbo();
            this.elbo10 = new Streambolics.Lcars.Elbo();
            this.elbo4 = new Streambolics.Lcars.Elbo();
            this.button15 = new Streambolics.Lcars.Button();
            this.btnRedAlert = new Streambolics.Lcars.Button();
            this.btnGreenAlert = new Streambolics.Lcars.Button();
            this.btnBlueAlert = new Streambolics.Lcars.Button();
            this.btnYellowAlert = new Streambolics.Lcars.Button();
            this.button10 = new Streambolics.Lcars.Button();
            this.elbo5 = new Streambolics.Lcars.Elbo();
            this.button6 = new Streambolics.Lcars.Button();
            this.button5 = new Streambolics.Lcars.Button();
            this.button4 = new Streambolics.Lcars.Button();
            this.button3 = new Streambolics.Lcars.Button();
            this.button1 = new Streambolics.Lcars.Button();
            this.elbo2 = new Streambolics.Lcars.Elbo();
            this.button2 = new Streambolics.Lcars.Button();
            this.sound1 = new Streambolics.Lcars.Sound();
            this.lblAlarmWarning = new Streambolics.Lcars.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.CausesValidation = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(603, 398);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(10, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(240, 222);
            this.webBrowser1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Font = new System.Drawing.Font("LCARS", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Function = Streambolics.Lcars.Function.Ancillary;
            this.label1.LeftSegments = 0;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label1.Name = "label1";
            this.label1.Online = true;
            this.label1.RightSegments = 0;
            this.label1.RoundedLeft = false;
            this.label1.RoundedRight = false;
            this.label1.Size = new System.Drawing.Size(192, 84);
            this.label1.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.label1.TabIndex = 29;
            this.label1.Text = "SECURITY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // elbo9
            // 
            this.elbo9.ArcExternal = 50;
            this.elbo9.ArcInternal = 10;
            this.elbo9.BackColor = System.Drawing.Color.Black;
            this.elbo9.ColWidth = 32;
            this.elbo9.ElboOrientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo9.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo9.ForeColor = System.Drawing.Color.White;
            this.elbo9.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo9.Location = new System.Drawing.Point(211, 259);
            this.elbo9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo9.Name = "elbo9";
            this.elbo9.Online = true;
            this.elbo9.Orientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo9.RowHeight = 32;
            this.elbo9.Size = new System.Drawing.Size(45, 48);
            this.elbo9.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo9.TabIndex = 79;
            this.elbo9.Text = "elbo9";
            // 
            // elbo8
            // 
            this.elbo8.ArcExternal = 50;
            this.elbo8.ArcInternal = 10;
            this.elbo8.BackColor = System.Drawing.Color.Black;
            this.elbo8.ColWidth = 32;
            this.elbo8.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo8.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo8.ForeColor = System.Drawing.Color.White;
            this.elbo8.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo8.Location = new System.Drawing.Point(211, 161);
            this.elbo8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo8.Name = "elbo8";
            this.elbo8.Online = true;
            this.elbo8.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo8.RowHeight = 32;
            this.elbo8.Size = new System.Drawing.Size(45, 48);
            this.elbo8.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo8.TabIndex = 78;
            this.elbo8.Text = "12";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Blink = false;
            this.button9.BlinkInterval = 1000;
            this.button9.BlinkState = false;
            this.button9.ChangeOnHover = false;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Font = new System.Drawing.Font("LCARS", 14F);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Function = Streambolics.Lcars.Function.Ancillary;
            this.button9.LeftSegments = 0;
            this.button9.Location = new System.Drawing.Point(211, 215);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button9.Name = "button9";
            this.button9.Online = true;
            this.button9.RightSegments = 0;
            this.button9.RoundedLeft = false;
            this.button9.RoundedRight = false;
            this.button9.Size = new System.Drawing.Size(33, 38);
            this.button9.SoundFile = "";
            this.button9.SoundRepeatTimes = 1;
            this.button9.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button9.TabIndex = 77;
            this.button9.Text = ">";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Blink = false;
            this.button8.BlinkInterval = 1000;
            this.button8.BlinkState = false;
            this.button8.ChangeOnHover = false;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button8.Font = new System.Drawing.Font("LCARS", 14F);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Function = Streambolics.Lcars.Function.Ancillary;
            this.button8.LeftSegments = 0;
            this.button8.Location = new System.Drawing.Point(159, 215);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Online = true;
            this.button8.RightSegments = 0;
            this.button8.RoundedLeft = false;
            this.button8.RoundedRight = false;
            this.button8.Size = new System.Drawing.Size(48, 38);
            this.button8.SoundFile = "";
            this.button8.SoundRepeatTimes = 1;
            this.button8.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button8.TabIndex = 76;
            this.button8.Text = "16-953";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Blink = false;
            this.button7.BlinkInterval = 1000;
            this.button7.BlinkState = false;
            this.button7.ChangeOnHover = false;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Font = new System.Drawing.Font("LCARS", 14F);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Function = Streambolics.Lcars.Function.Ancillary;
            this.button7.LeftSegments = 0;
            this.button7.Location = new System.Drawing.Point(122, 215);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button7.Name = "button7";
            this.button7.Online = true;
            this.button7.RightSegments = 0;
            this.button7.RoundedLeft = false;
            this.button7.RoundedRight = false;
            this.button7.Size = new System.Drawing.Size(33, 38);
            this.button7.SoundFile = "";
            this.button7.SoundRepeatTimes = 1;
            this.button7.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button7.TabIndex = 75;
            this.button7.Text = "<";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elbo7
            // 
            this.elbo7.ArcExternal = 50;
            this.elbo7.ArcInternal = 10;
            this.elbo7.BackColor = System.Drawing.Color.Black;
            this.elbo7.ColWidth = 32;
            this.elbo7.ElboOrientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo7.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo7.ForeColor = System.Drawing.Color.White;
            this.elbo7.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo7.Location = new System.Drawing.Point(111, 161);
            this.elbo7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo7.Name = "elbo7";
            this.elbo7.Online = true;
            this.elbo7.Orientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo7.RowHeight = 32;
            this.elbo7.Size = new System.Drawing.Size(45, 48);
            this.elbo7.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo7.TabIndex = 74;
            this.elbo7.Text = "elbo7";
            // 
            // elbo6
            // 
            this.elbo6.ArcExternal = 50;
            this.elbo6.ArcInternal = 10;
            this.elbo6.BackColor = System.Drawing.Color.Black;
            this.elbo6.ColWidth = 32;
            this.elbo6.ElboOrientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo6.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo6.ForeColor = System.Drawing.Color.White;
            this.elbo6.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo6.Location = new System.Drawing.Point(111, 259);
            this.elbo6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo6.Name = "elbo6";
            this.elbo6.Online = true;
            this.elbo6.Orientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo6.RowHeight = 32;
            this.elbo6.Size = new System.Drawing.Size(45, 48);
            this.elbo6.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo6.TabIndex = 73;
            this.elbo6.Text = "elbo6";
            // 
            // elbo10
            // 
            this.elbo10.ArcExternal = 100;
            this.elbo10.ArcInternal = 100;
            this.elbo10.BackColor = System.Drawing.Color.Black;
            this.elbo10.ColWidth = 300;
            this.elbo10.ElboOrientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo10.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo10.ForeColor = System.Drawing.Color.White;
            this.elbo10.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo10.Location = new System.Drawing.Point(458, 662);
            this.elbo10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo10.Name = "elbo10";
            this.elbo10.Online = true;
            this.elbo10.Orientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo10.RowHeight = 40;
            this.elbo10.Size = new System.Drawing.Size(563, 84);
            this.elbo10.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo10.TabIndex = 72;
            this.elbo10.Text = "elbo10";
            // 
            // elbo4
            // 
            this.elbo4.ArcExternal = 100;
            this.elbo4.ArcInternal = 100;
            this.elbo4.BackColor = System.Drawing.Color.Black;
            this.elbo4.ColWidth = 300;
            this.elbo4.ElboOrientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo4.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo4.ForeColor = System.Drawing.Color.White;
            this.elbo4.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo4.Location = new System.Drawing.Point(2, 626);
            this.elbo4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo4.Name = "elbo4";
            this.elbo4.Online = true;
            this.elbo4.Orientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo4.RowHeight = 40;
            this.elbo4.Size = new System.Drawing.Size(481, 76);
            this.elbo4.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo4.TabIndex = 71;
            this.elbo4.Text = "elbo4";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.Blink = false;
            this.button15.BlinkInterval = 1500;
            this.button15.BlinkState = false;
            this.button15.ChangeOnHover = false;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button15.Font = new System.Drawing.Font("LCARS", 14F);
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Function = Streambolics.Lcars.Function.Ancillary;
            this.button15.LeftSegments = 1;
            this.button15.Location = new System.Drawing.Point(2, 588);
            this.button15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button15.Name = "button15";
            this.button15.Online = true;
            this.button15.RightSegments = 0;
            this.button15.RoundedLeft = false;
            this.button15.RoundedRight = true;
            this.button15.Size = new System.Drawing.Size(304, 32);
            this.button15.SoundFile = "";
            this.button15.SoundRepeatTimes = 0;
            this.button15.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button15.TabIndex = 70;
            this.button15.Tag = "";
            this.button15.Text = "FORCEFIELDS";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnRedAlert
            // 
            this.btnRedAlert.BackColor = System.Drawing.Color.Black;
            this.btnRedAlert.Blink = true;
            this.btnRedAlert.BlinkInterval = 1500;
            this.btnRedAlert.BlinkState = false;
            this.btnRedAlert.ChangeOnHover = false;
            this.btnRedAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedAlert.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnRedAlert.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnRedAlert.ForeColor = System.Drawing.Color.Black;
            this.btnRedAlert.Function = Streambolics.Lcars.Function.Ancillary;
            this.btnRedAlert.LeftSegments = 1;
            this.btnRedAlert.Location = new System.Drawing.Point(2, 398);
            this.btnRedAlert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRedAlert.Name = "btnRedAlert";
            this.btnRedAlert.Online = true;
            this.btnRedAlert.RightSegments = 0;
            this.btnRedAlert.RoundedLeft = false;
            this.btnRedAlert.RoundedRight = true;
            this.btnRedAlert.Size = new System.Drawing.Size(304, 32);
            this.btnRedAlert.SoundFile = "";
            this.btnRedAlert.SoundRepeatTimes = 0;
            this.btnRedAlert.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnRedAlert.TabIndex = 69;
            this.btnRedAlert.Tag = "";
            this.btnRedAlert.Text = "RED ALERT";
            this.btnRedAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRedAlert.Click += new System.EventHandler(this.button14_Click);
            this.btnRedAlert.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRedAlert_Paint);
            // 
            // btnGreenAlert
            // 
            this.btnGreenAlert.BackColor = System.Drawing.Color.Black;
            this.btnGreenAlert.Blink = false;
            this.btnGreenAlert.BlinkInterval = 1500;
            this.btnGreenAlert.BlinkState = false;
            this.btnGreenAlert.ChangeOnHover = false;
            this.btnGreenAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreenAlert.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnGreenAlert.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnGreenAlert.ForeColor = System.Drawing.Color.Black;
            this.btnGreenAlert.Function = Streambolics.Lcars.Function.Ancillary;
            this.btnGreenAlert.LeftSegments = 1;
            this.btnGreenAlert.Location = new System.Drawing.Point(2, 512);
            this.btnGreenAlert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGreenAlert.Name = "btnGreenAlert";
            this.btnGreenAlert.Online = true;
            this.btnGreenAlert.RightSegments = 0;
            this.btnGreenAlert.RoundedLeft = false;
            this.btnGreenAlert.RoundedRight = true;
            this.btnGreenAlert.Size = new System.Drawing.Size(304, 32);
            this.btnGreenAlert.SoundFile = "";
            this.btnGreenAlert.SoundRepeatTimes = 0;
            this.btnGreenAlert.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.btnGreenAlert.TabIndex = 68;
            this.btnGreenAlert.Tag = "Resources\\Error.wav";
            this.btnGreenAlert.Text = "STAND DOWN ALERT STATUS";
            this.btnGreenAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGreenAlert.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnBlueAlert
            // 
            this.btnBlueAlert.BackColor = System.Drawing.Color.Black;
            this.btnBlueAlert.Blink = false;
            this.btnBlueAlert.BlinkInterval = 1500;
            this.btnBlueAlert.BlinkState = false;
            this.btnBlueAlert.ChangeOnHover = false;
            this.btnBlueAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlueAlert.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnBlueAlert.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnBlueAlert.ForeColor = System.Drawing.Color.Black;
            this.btnBlueAlert.Function = Streambolics.Lcars.Function.Ancillary;
            this.btnBlueAlert.LeftSegments = 1;
            this.btnBlueAlert.Location = new System.Drawing.Point(2, 474);
            this.btnBlueAlert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBlueAlert.Name = "btnBlueAlert";
            this.btnBlueAlert.Online = true;
            this.btnBlueAlert.RightSegments = 0;
            this.btnBlueAlert.RoundedLeft = false;
            this.btnBlueAlert.RoundedRight = true;
            this.btnBlueAlert.Size = new System.Drawing.Size(304, 32);
            this.btnBlueAlert.SoundFile = "";
            this.btnBlueAlert.SoundRepeatTimes = 0;
            this.btnBlueAlert.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnBlueAlert.TabIndex = 67;
            this.btnBlueAlert.Tag = "";
            this.btnBlueAlert.Text = "INTRUDER ALERT";
            this.btnBlueAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBlueAlert.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnYellowAlert
            // 
            this.btnYellowAlert.BackColor = System.Drawing.Color.Black;
            this.btnYellowAlert.Blink = false;
            this.btnYellowAlert.BlinkInterval = 1500;
            this.btnYellowAlert.BlinkState = false;
            this.btnYellowAlert.ChangeOnHover = false;
            this.btnYellowAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYellowAlert.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnYellowAlert.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnYellowAlert.ForeColor = System.Drawing.Color.Black;
            this.btnYellowAlert.Function = Streambolics.Lcars.Function.Ancillary;
            this.btnYellowAlert.LeftSegments = 1;
            this.btnYellowAlert.Location = new System.Drawing.Point(2, 436);
            this.btnYellowAlert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnYellowAlert.Name = "btnYellowAlert";
            this.btnYellowAlert.Online = true;
            this.btnYellowAlert.RightSegments = 0;
            this.btnYellowAlert.RoundedLeft = false;
            this.btnYellowAlert.RoundedRight = true;
            this.btnYellowAlert.Size = new System.Drawing.Size(304, 32);
            this.btnYellowAlert.SoundFile = "Resources\\UnableToComply.wav";
            this.btnYellowAlert.SoundRepeatTimes = 1;
            this.btnYellowAlert.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnYellowAlert.TabIndex = 66;
            this.btnYellowAlert.Tag = "";
            this.btnYellowAlert.Text = "YELLOW ALERT";
            this.btnYellowAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYellowAlert.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Blink = false;
            this.button10.BlinkInterval = 1500;
            this.button10.BlinkState = false;
            this.button10.ChangeOnHover = false;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Font = new System.Drawing.Font("LCARS", 14F);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Function = Streambolics.Lcars.Function.Ancillary;
            this.button10.LeftSegments = 1;
            this.button10.Location = new System.Drawing.Point(2, 550);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button10.Name = "button10";
            this.button10.Online = true;
            this.button10.RightSegments = 0;
            this.button10.RoundedLeft = false;
            this.button10.RoundedRight = true;
            this.button10.Size = new System.Drawing.Size(304, 32);
            this.button10.SoundFile = "";
            this.button10.SoundRepeatTimes = 0;
            this.button10.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button10.TabIndex = 65;
            this.button10.Tag = "";
            this.button10.Text = "SHIELDS";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // elbo5
            // 
            this.elbo5.ArcExternal = 100;
            this.elbo5.ArcInternal = 100;
            this.elbo5.BackColor = System.Drawing.Color.Black;
            this.elbo5.ColWidth = 300;
            this.elbo5.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo5.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo5.ForeColor = System.Drawing.Color.White;
            this.elbo5.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo5.Location = new System.Drawing.Point(2, 316);
            this.elbo5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo5.Name = "elbo5";
            this.elbo5.Online = true;
            this.elbo5.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo5.RowHeight = 40;
            this.elbo5.Size = new System.Drawing.Size(1019, 76);
            this.elbo5.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo5.TabIndex = 57;
            this.elbo5.Text = "elbo5";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Blink = false;
            this.button6.BlinkInterval = 1000;
            this.button6.BlinkState = false;
            this.button6.ChangeOnHover = false;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Font = new System.Drawing.Font("LCARS", 14F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Function = Streambolics.Lcars.Function.Ancillary;
            this.button6.LeftSegments = 2;
            this.button6.Location = new System.Drawing.Point(320, 275);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Online = true;
            this.button6.RightSegments = 1;
            this.button6.RoundedLeft = true;
            this.button6.RoundedRight = true;
            this.button6.Size = new System.Drawing.Size(701, 32);
            this.button6.SoundFile = "Resources\\VariousBeeps.wav";
            this.button6.SoundRepeatTimes = 1;
            this.button6.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button6.TabIndex = 56;
            this.button6.Tag = "http://blog.tempworks.com/feed/";
            this.button6.Text = "INTRUSION DETECTION AND RESPONSE SYSTEM";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Blink = false;
            this.button5.BlinkInterval = 1000;
            this.button5.BlinkState = false;
            this.button5.ChangeOnHover = false;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Font = new System.Drawing.Font("LCARS", 14F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Function = Streambolics.Lcars.Function.Ancillary;
            this.button5.LeftSegments = 2;
            this.button5.Location = new System.Drawing.Point(320, 237);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Online = true;
            this.button5.RightSegments = 1;
            this.button5.RoundedLeft = true;
            this.button5.RoundedRight = true;
            this.button5.Size = new System.Drawing.Size(701, 32);
            this.button5.SoundFile = "Resources\\VariousBeeps.wav";
            this.button5.SoundRepeatTimes = 1;
            this.button5.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button5.TabIndex = 55;
            this.button5.Tag = "http://feeds.feedburner.com/blogspot/MKuf?format=rss";
            this.button5.Text = "SECURITY OVERRIDE";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Blink = false;
            this.button4.BlinkInterval = 1000;
            this.button4.BlinkState = false;
            this.button4.ChangeOnHover = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Font = new System.Drawing.Font("LCARS", 14F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Function = Streambolics.Lcars.Function.Ancillary;
            this.button4.LeftSegments = 2;
            this.button4.Location = new System.Drawing.Point(320, 199);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Online = true;
            this.button4.RightSegments = 1;
            this.button4.RoundedLeft = true;
            this.button4.RoundedRight = true;
            this.button4.Size = new System.Drawing.Size(701, 32);
            this.button4.SoundFile = "Resources\\VariousBeeps.wav";
            this.button4.SoundRepeatTimes = 1;
            this.button4.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button4.TabIndex = 54;
            this.button4.Tag = "http://rss.weather.com/weather/rss/local/55122?cm_ven=LWO&cm_cat=rss&par=LWO_rss";
            this.button4.Text = "INTERNAL SENSORS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Blink = false;
            this.button3.BlinkInterval = 1000;
            this.button3.BlinkState = false;
            this.button3.ChangeOnHover = false;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Font = new System.Drawing.Font("LCARS", 14F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Function = Streambolics.Lcars.Function.Ancillary;
            this.button3.LeftSegments = 2;
            this.button3.Location = new System.Drawing.Point(320, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Online = true;
            this.button3.RightSegments = 1;
            this.button3.RoundedLeft = true;
            this.button3.RoundedRight = true;
            this.button3.Size = new System.Drawing.Size(701, 32);
            this.button3.SoundFile = "Resources\\VariousBeeps.wav";
            this.button3.SoundRepeatTimes = 1;
            this.button3.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button3.TabIndex = 53;
            this.button3.Tag = "http://news.feedzilla.com/en_us/headlines/top-news/usa.rss";
            this.button3.Text = "SYSTEM DIAGNOSTIC";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Blink = true;
            this.button1.BlinkInterval = 1000;
            this.button1.BlinkState = true;
            this.button1.ChangeOnHover = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Font = new System.Drawing.Font("LCARS", 14F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Function = Streambolics.Lcars.Function.Ancillary;
            this.button1.LeftSegments = 0;
            this.button1.Location = new System.Drawing.Point(917, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Online = true;
            this.button1.RightSegments = 0;
            this.button1.RoundedLeft = false;
            this.button1.RoundedRight = false;
            this.button1.Size = new System.Drawing.Size(104, 66);
            this.button1.SoundFile = "";
            this.button1.SoundRepeatTimes = 1;
            this.button1.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button1.TabIndex = 52;
            this.button1.Text = "MODE SELECT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elbo2
            // 
            this.elbo2.ArcExternal = 1;
            this.elbo2.ArcInternal = 50;
            this.elbo2.BackColor = System.Drawing.Color.Black;
            this.elbo2.ColWidth = 104;
            this.elbo2.ElboOrientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo2.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo2.ForeColor = System.Drawing.Color.White;
            this.elbo2.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo2.Location = new System.Drawing.Point(190, 75);
            this.elbo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo2.Name = "elbo2";
            this.elbo2.Online = true;
            this.elbo2.Orientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo2.RowHeight = 50;
            this.elbo2.Size = new System.Drawing.Size(831, 68);
            this.elbo2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo2.TabIndex = 51;
            this.elbo2.Text = "elbo2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Blink = false;
            this.button2.BlinkInterval = 1000;
            this.button2.BlinkState = false;
            this.button2.ChangeOnHover = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Font = new System.Drawing.Font("LCARS", 14F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Function = Streambolics.Lcars.Function.Ancillary;
            this.button2.LeftSegments = 0;
            this.button2.Location = new System.Drawing.Point(2, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Online = true;
            this.button2.RightSegments = 0;
            this.button2.RoundedLeft = true;
            this.button2.RoundedRight = false;
            this.button2.Size = new System.Drawing.Size(192, 50);
            this.button2.SoundFile = "";
            this.button2.SoundRepeatTimes = 1;
            this.button2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button2.TabIndex = 28;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAlarmWarning
            // 
            this.lblAlarmWarning.BackColor = System.Drawing.Color.Black;
            this.lblAlarmWarning.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.lblAlarmWarning.Font = new System.Drawing.Font("LCARS", 50F);
            this.lblAlarmWarning.ForeColor = System.Drawing.Color.White;
            this.lblAlarmWarning.Function = Streambolics.Lcars.Function.RedAlert;
            this.lblAlarmWarning.LeftSegments = 0;
            this.lblAlarmWarning.Location = new System.Drawing.Point(232, 3);
            this.lblAlarmWarning.Name = "lblAlarmWarning";
            this.lblAlarmWarning.Online = true;
            this.lblAlarmWarning.RightSegments = 0;
            this.lblAlarmWarning.RoundedLeft = false;
            this.lblAlarmWarning.RoundedRight = false;
            this.lblAlarmWarning.Size = new System.Drawing.Size(640, 84);
            this.lblAlarmWarning.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.lblAlarmWarning.TabIndex = 81;
            this.lblAlarmWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarmWarning.Visible = false;
            // 
            // SecurityScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblAlarmWarning);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elbo9);
            this.Controls.Add(this.elbo8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.elbo7);
            this.Controls.Add(this.elbo6);
            this.Controls.Add(this.elbo10);
            this.Controls.Add(this.elbo4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnRedAlert);
            this.Controls.Add(this.btnGreenAlert);
            this.Controls.Add(this.btnBlueAlert);
            this.Controls.Add(this.btnYellowAlert);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.elbo5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elbo2);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SecurityScreen";
            this.Size = new System.Drawing.Size(1024, 768);
            this.VisibleChanged += new System.EventHandler(this.SecurityScreen_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Streambolics.Lcars.Label label1;
        private Streambolics.Lcars.Button button2;
        private Streambolics.Lcars.Elbo elbo10;
        private Streambolics.Lcars.Elbo elbo4;
        private Streambolics.Lcars.Button button15;
        private Streambolics.Lcars.Button btnRedAlert;
        private Streambolics.Lcars.Button btnGreenAlert;
        private Streambolics.Lcars.Button btnBlueAlert;
        private Streambolics.Lcars.Button btnYellowAlert;
        private Streambolics.Lcars.Button button10;
        private Streambolics.Lcars.Elbo elbo5;
        private Streambolics.Lcars.Button button6;
        private Streambolics.Lcars.Button button5;
        private Streambolics.Lcars.Button button4;
        private Streambolics.Lcars.Button button3;
        private Streambolics.Lcars.Button button1;
        private Streambolics.Lcars.Elbo elbo2;
        private Streambolics.Lcars.Elbo elbo9;
        private Streambolics.Lcars.Elbo elbo8;
        private Streambolics.Lcars.Button button9;
        private Streambolics.Lcars.Button button8;
        private Streambolics.Lcars.Button button7;
        private Streambolics.Lcars.Elbo elbo7;
        private Streambolics.Lcars.Elbo elbo6;
        private Streambolics.Lcars.Sound sound1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Streambolics.Lcars.Label lblAlarmWarning;


    }
}
