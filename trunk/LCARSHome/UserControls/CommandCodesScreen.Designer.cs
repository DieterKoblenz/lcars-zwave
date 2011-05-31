namespace LCARSHome.UserControls
{
    partial class CommandCodesScreen
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
            this.elbo2 = new Streambolics.Lcars.Elbo();
            this.sound1 = new Streambolics.Lcars.Sound();
            this.label1 = new Streambolics.Lcars.Label();
            this.button1 = new Streambolics.Lcars.Button();
            this.button2 = new Streambolics.Lcars.Button();
            this.button3 = new Streambolics.Lcars.Button();
            this.button4 = new Streambolics.Lcars.Button();
            this.button5 = new Streambolics.Lcars.Button();
            this.button6 = new Streambolics.Lcars.Button();
            this.button7 = new Streambolics.Lcars.Button();
            this.button8 = new Streambolics.Lcars.Button();
            this.button9 = new Streambolics.Lcars.Button();
            this.button10 = new Streambolics.Lcars.Button();
            this.button11 = new Streambolics.Lcars.Button();
            this.button12 = new Streambolics.Lcars.Button();
            this.button13 = new Streambolics.Lcars.Button();
            this.txtCommandCode = new System.Windows.Forms.TextBox();
            this.button14 = new Streambolics.Lcars.Button();
            this.SuspendLayout();
            // 
            // elbo2
            // 
            this.elbo2.ArcExternal = 100;
            this.elbo2.ArcInternal = 50;
            this.elbo2.BackColor = System.Drawing.Color.Black;
            this.elbo2.ColWidth = 104;
            this.elbo2.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elbo2.ForeColor = System.Drawing.Color.White;
            this.elbo2.Function = Streambolics.Lcars.Function.Ancillary;
            this.elbo2.InAlert = false;
            this.elbo2.Location = new System.Drawing.Point(2, 3);
            this.elbo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo2.Name = "elbo2";
            this.elbo2.Online = true;
            this.elbo2.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo2.RowHeight = 32;
            this.elbo2.Size = new System.Drawing.Size(963, 762);
            this.elbo2.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo2.TabIndex = 4;
            this.elbo2.Text = "elbo2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Font = new System.Drawing.Font("LCARS", 48F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Function = Streambolics.Lcars.Function.Database;
            this.label1.InAlert = false;
            this.label1.LeftSegments = 0;
            this.label1.Location = new System.Drawing.Point(276, 53);
            this.label1.Name = "label1";
            this.label1.Online = true;
            this.label1.RightSegments = 0;
            this.label1.RoundedLeft = false;
            this.label1.RoundedRight = false;
            this.label1.Size = new System.Drawing.Size(558, 72);
            this.label1.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.label1.TabIndex = 22;
            this.label1.Text = "PLEASE ENTER COMMAND CODES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Blink = false;
            this.button1.BlinkInterval = 500;
            this.button1.BlinkState = false;
            this.button1.ChangeOnHover = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Font = new System.Drawing.Font("LCARS", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Function = Streambolics.Lcars.Function.Ancillary;
            this.button1.InAlert = false;
            this.button1.LeftSegments = 0;
            this.button1.Location = new System.Drawing.Point(501, 3);
            this.button1.Name = "button1";
            this.button1.Online = true;
            this.button1.RightSegments = 0;
            this.button1.RoundedLeft = false;
            this.button1.RoundedRight = true;
            this.button1.Size = new System.Drawing.Size(512, 32);
            this.button1.SoundFile = "";
            this.button1.SoundRepeatTimes = 1;
            this.button1.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button1.TabIndex = 23;
            this.button1.Text = "SECURITY CLEARANCE REQUIRED";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Blink = false;
            this.button2.BlinkInterval = 500;
            this.button2.BlinkState = false;
            this.button2.ChangeOnHover = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Font = new System.Drawing.Font("LCARS", 28F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Function = Streambolics.Lcars.Function.Ancillary;
            this.button2.InAlert = false;
            this.button2.LeftSegments = 0;
            this.button2.Location = new System.Drawing.Point(331, 293);
            this.button2.Name = "button2";
            this.button2.Online = true;
            this.button2.RightSegments = 0;
            this.button2.RoundedLeft = true;
            this.button2.RoundedRight = true;
            this.button2.Size = new System.Drawing.Size(140, 82);
            this.button2.SoundFile = "/Resources/Beep.wav";
            this.button2.SoundRepeatTimes = 1;
            this.button2.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button2.TabIndex = 24;
            this.button2.Text = "1";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Blink = false;
            this.button3.BlinkInterval = 500;
            this.button3.BlinkState = false;
            this.button3.ChangeOnHover = false;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Font = new System.Drawing.Font("LCARS", 28F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Function = Streambolics.Lcars.Function.Ancillary;
            this.button3.InAlert = false;
            this.button3.LeftSegments = 0;
            this.button3.Location = new System.Drawing.Point(477, 292);
            this.button3.Name = "button3";
            this.button3.Online = true;
            this.button3.RightSegments = 0;
            this.button3.RoundedLeft = true;
            this.button3.RoundedRight = true;
            this.button3.Size = new System.Drawing.Size(140, 82);
            this.button3.SoundFile = "/Resources/Beep.wav";
            this.button3.SoundRepeatTimes = 1;
            this.button3.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button3.TabIndex = 25;
            this.button3.Text = "2";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Blink = false;
            this.button4.BlinkInterval = 500;
            this.button4.BlinkState = false;
            this.button4.ChangeOnHover = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Font = new System.Drawing.Font("LCARS", 28F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Function = Streambolics.Lcars.Function.Ancillary;
            this.button4.InAlert = false;
            this.button4.LeftSegments = 0;
            this.button4.Location = new System.Drawing.Point(623, 293);
            this.button4.Name = "button4";
            this.button4.Online = true;
            this.button4.RightSegments = 0;
            this.button4.RoundedLeft = true;
            this.button4.RoundedRight = true;
            this.button4.Size = new System.Drawing.Size(140, 82);
            this.button4.SoundFile = "/Resources/Beep.wav";
            this.button4.SoundRepeatTimes = 1;
            this.button4.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button4.TabIndex = 26;
            this.button4.Text = "3";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Blink = false;
            this.button5.BlinkInterval = 500;
            this.button5.BlinkState = false;
            this.button5.ChangeOnHover = false;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Font = new System.Drawing.Font("LCARS", 28F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Function = Streambolics.Lcars.Function.Ancillary;
            this.button5.InAlert = false;
            this.button5.LeftSegments = 0;
            this.button5.Location = new System.Drawing.Point(477, 380);
            this.button5.Name = "button5";
            this.button5.Online = true;
            this.button5.RightSegments = 0;
            this.button5.RoundedLeft = true;
            this.button5.RoundedRight = true;
            this.button5.Size = new System.Drawing.Size(140, 82);
            this.button5.SoundFile = "/Resources/Beep.wav";
            this.button5.SoundRepeatTimes = 1;
            this.button5.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button5.TabIndex = 27;
            this.button5.Text = "5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Blink = false;
            this.button6.BlinkInterval = 500;
            this.button6.BlinkState = false;
            this.button6.ChangeOnHover = false;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Font = new System.Drawing.Font("LCARS", 28F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Function = Streambolics.Lcars.Function.Ancillary;
            this.button6.InAlert = false;
            this.button6.LeftSegments = 0;
            this.button6.Location = new System.Drawing.Point(331, 381);
            this.button6.Name = "button6";
            this.button6.Online = true;
            this.button6.RightSegments = 0;
            this.button6.RoundedLeft = true;
            this.button6.RoundedRight = true;
            this.button6.Size = new System.Drawing.Size(140, 82);
            this.button6.SoundFile = "/Resources/Beep.wav";
            this.button6.SoundRepeatTimes = 1;
            this.button6.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button6.TabIndex = 28;
            this.button6.Text = "4";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Blink = false;
            this.button7.BlinkInterval = 500;
            this.button7.BlinkState = false;
            this.button7.ChangeOnHover = false;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Font = new System.Drawing.Font("LCARS", 28F);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Function = Streambolics.Lcars.Function.Ancillary;
            this.button7.InAlert = false;
            this.button7.LeftSegments = 0;
            this.button7.Location = new System.Drawing.Point(623, 380);
            this.button7.Name = "button7";
            this.button7.Online = true;
            this.button7.RightSegments = 0;
            this.button7.RoundedLeft = true;
            this.button7.RoundedRight = true;
            this.button7.Size = new System.Drawing.Size(140, 82);
            this.button7.SoundFile = "/Resources/Beep.wav";
            this.button7.SoundRepeatTimes = 1;
            this.button7.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button7.TabIndex = 29;
            this.button7.Text = "6";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Blink = false;
            this.button8.BlinkInterval = 500;
            this.button8.BlinkState = false;
            this.button8.ChangeOnHover = false;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button8.Font = new System.Drawing.Font("LCARS", 28F);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Function = Streambolics.Lcars.Function.Ancillary;
            this.button8.InAlert = false;
            this.button8.LeftSegments = 0;
            this.button8.Location = new System.Drawing.Point(331, 468);
            this.button8.Name = "button8";
            this.button8.Online = true;
            this.button8.RightSegments = 0;
            this.button8.RoundedLeft = true;
            this.button8.RoundedRight = true;
            this.button8.Size = new System.Drawing.Size(140, 82);
            this.button8.SoundFile = "/Resources/Beep.wav";
            this.button8.SoundRepeatTimes = 1;
            this.button8.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button8.TabIndex = 30;
            this.button8.Text = "7";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Blink = false;
            this.button9.BlinkInterval = 500;
            this.button9.BlinkState = false;
            this.button9.ChangeOnHover = false;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Font = new System.Drawing.Font("LCARS", 28F);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Function = Streambolics.Lcars.Function.Ancillary;
            this.button9.InAlert = false;
            this.button9.LeftSegments = 0;
            this.button9.Location = new System.Drawing.Point(477, 468);
            this.button9.Name = "button9";
            this.button9.Online = true;
            this.button9.RightSegments = 0;
            this.button9.RoundedLeft = true;
            this.button9.RoundedRight = true;
            this.button9.Size = new System.Drawing.Size(140, 82);
            this.button9.SoundFile = "/Resources/Beep.wav";
            this.button9.SoundRepeatTimes = 1;
            this.button9.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button9.TabIndex = 31;
            this.button9.Text = "8";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Blink = false;
            this.button10.BlinkInterval = 500;
            this.button10.BlinkState = false;
            this.button10.ChangeOnHover = false;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Font = new System.Drawing.Font("LCARS", 28F);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Function = Streambolics.Lcars.Function.Ancillary;
            this.button10.InAlert = false;
            this.button10.LeftSegments = 0;
            this.button10.Location = new System.Drawing.Point(623, 468);
            this.button10.Name = "button10";
            this.button10.Online = true;
            this.button10.RightSegments = 0;
            this.button10.RoundedLeft = true;
            this.button10.RoundedRight = true;
            this.button10.Size = new System.Drawing.Size(140, 82);
            this.button10.SoundFile = "/Resources/Beep.wav";
            this.button10.SoundRepeatTimes = 1;
            this.button10.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button10.TabIndex = 32;
            this.button10.Text = "9";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Blink = false;
            this.button11.BlinkInterval = 500;
            this.button11.BlinkState = false;
            this.button11.ChangeOnHover = false;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Font = new System.Drawing.Font("LCARS", 28F);
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Function = Streambolics.Lcars.Function.Ancillary;
            this.button11.InAlert = false;
            this.button11.LeftSegments = 0;
            this.button11.Location = new System.Drawing.Point(477, 556);
            this.button11.Name = "button11";
            this.button11.Online = true;
            this.button11.RightSegments = 0;
            this.button11.RoundedLeft = true;
            this.button11.RoundedRight = true;
            this.button11.Size = new System.Drawing.Size(140, 82);
            this.button11.SoundFile = "/Resources/Beep.wav";
            this.button11.SoundRepeatTimes = 1;
            this.button11.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button11.TabIndex = 33;
            this.button11.Text = "0";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Blink = false;
            this.button12.BlinkInterval = 500;
            this.button12.BlinkState = false;
            this.button12.ChangeOnHover = false;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button12.Font = new System.Drawing.Font("LCARS", 28F);
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Function = Streambolics.Lcars.Function.Ancillary;
            this.button12.InAlert = false;
            this.button12.LeftSegments = 0;
            this.button12.Location = new System.Drawing.Point(477, 644);
            this.button12.Name = "button12";
            this.button12.Online = true;
            this.button12.RightSegments = 0;
            this.button12.RoundedLeft = true;
            this.button12.RoundedRight = true;
            this.button12.Size = new System.Drawing.Size(140, 82);
            this.button12.SoundFile = "/Resources/Beep.wav";
            this.button12.SoundRepeatTimes = 1;
            this.button12.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button12.TabIndex = 34;
            this.button12.Text = "CLEAR";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button12.VisibleChanged += new System.EventHandler(this.button12_VisibleChanged);
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Blink = false;
            this.button13.BlinkInterval = 500;
            this.button13.BlinkState = false;
            this.button13.ChangeOnHover = false;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button13.Font = new System.Drawing.Font("LCARS", 28F);
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Function = Streambolics.Lcars.Function.Ancillary;
            this.button13.InAlert = false;
            this.button13.LeftSegments = 0;
            this.button13.Location = new System.Drawing.Point(623, 644);
            this.button13.Name = "button13";
            this.button13.Online = true;
            this.button13.RightSegments = 0;
            this.button13.RoundedLeft = true;
            this.button13.RoundedRight = true;
            this.button13.Size = new System.Drawing.Size(140, 82);
            this.button13.SoundFile = "/Resources/Beep.wav";
            this.button13.SoundRepeatTimes = 1;
            this.button13.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.button13.TabIndex = 35;
            this.button13.Text = "ACCEPT";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // txtCommandCode
            // 
            this.txtCommandCode.Font = new System.Drawing.Font("LCARS", 125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandCode.Location = new System.Drawing.Point(331, 185);
            this.txtCommandCode.Multiline = true;
            this.txtCommandCode.Name = "txtCommandCode";
            this.txtCommandCode.PasswordChar = '*';
            this.txtCommandCode.Size = new System.Drawing.Size(432, 80);
            this.txtCommandCode.TabIndex = 36;
            this.txtCommandCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.Blink = false;
            this.button14.BlinkInterval = 500;
            this.button14.BlinkState = false;
            this.button14.ChangeOnHover = false;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button14.Font = new System.Drawing.Font("LCARS", 28F);
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Function = Streambolics.Lcars.Function.Ancillary;
            this.button14.InAlert = false;
            this.button14.LeftSegments = 0;
            this.button14.Location = new System.Drawing.Point(331, 644);
            this.button14.Name = "button14";
            this.button14.Online = true;
            this.button14.RightSegments = 0;
            this.button14.RoundedLeft = true;
            this.button14.RoundedRight = true;
            this.button14.Size = new System.Drawing.Size(140, 82);
            this.button14.SoundFile = "/Resources/Beep.wav";
            this.button14.SoundRepeatTimes = 1;
            this.button14.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button14.TabIndex = 37;
            this.button14.Text = "CANCEL";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // CommandCodesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button14);
            this.Controls.Add(this.txtCommandCode);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elbo2);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CommandCodesScreen";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Streambolics.Lcars.Elbo elbo2;
        private Streambolics.Lcars.Sound sound1;
        private Streambolics.Lcars.Label label1;
        private Streambolics.Lcars.Button button1;
        private Streambolics.Lcars.Button button2;
        private Streambolics.Lcars.Button button3;
        private Streambolics.Lcars.Button button4;
        private Streambolics.Lcars.Button button5;
        private Streambolics.Lcars.Button button6;
        private Streambolics.Lcars.Button button7;
        private Streambolics.Lcars.Button button8;
        private Streambolics.Lcars.Button button9;
        private Streambolics.Lcars.Button button10;
        private Streambolics.Lcars.Button button11;
        private Streambolics.Lcars.Button button12;
        private Streambolics.Lcars.Button button13;
        private System.Windows.Forms.TextBox txtCommandCode;
        private Streambolics.Lcars.Button button14;
    }
}
