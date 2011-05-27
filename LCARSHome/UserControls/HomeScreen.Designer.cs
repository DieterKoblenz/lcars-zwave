namespace LCARSHome.UserControls
{
    partial class HomeScreen
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
            this.dateLabel1 = new Streambolics.Lcars.DateLabel();
            this.elbo3 = new Streambolics.Lcars.Elbo();
            this.button14 = new Streambolics.Lcars.Button();
            this.button13 = new Streambolics.Lcars.Button();
            this.button12 = new Streambolics.Lcars.Button();
            this.button11 = new Streambolics.Lcars.Button();
            this.button10 = new Streambolics.Lcars.Button();
            this.button8 = new Streambolics.Lcars.Button();
            this.button7 = new Streambolics.Lcars.Button();
            this.label1 = new Streambolics.Lcars.Label();
            this.button2 = new Streambolics.Lcars.Button();
            this.button4 = new Streambolics.Lcars.Button();
            this.button1 = new Streambolics.Lcars.Button();
            this.elbo2 = new Streambolics.Lcars.Elbo();
            this.button3 = new Streambolics.Lcars.Button();
            this.elbo1 = new Streambolics.Lcars.Elbo();
            this.sound1 = new Streambolics.Lcars.Sound();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new Streambolics.Lcars.Button();
            this.button6 = new Streambolics.Lcars.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel1
            // 
            this.dateLabel1.BackColor = System.Drawing.Color.Black;
            this.dateLabel1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.dateLabel1.Font = new System.Drawing.Font("LCARS", 14F);
            this.dateLabel1.ForeColor = System.Drawing.Color.Black;
            this.dateLabel1.Format = "yyyy-MM-dd HH:mm:ss";
            this.dateLabel1.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.dateLabel1.LeftSegments = 0;
            this.dateLabel1.Location = new System.Drawing.Point(688, 108);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Online = true;
            this.dateLabel1.RightSegments = 0;
            this.dateLabel1.RoundedLeft = false;
            this.dateLabel1.RoundedRight = false;
            this.dateLabel1.Size = new System.Drawing.Size(323, 32);
            this.dateLabel1.Style = Streambolics.Lcars.DateStyle.StarDate;
            this.dateLabel1.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.dateLabel1.TabIndex = 22;
            this.dateLabel1.Text = "[-4] 88482.34 1:16:34";
            // 
            // elbo3
            // 
            this.elbo3.ArcExternal = 1;
            this.elbo3.ArcInternal = 1;
            this.elbo3.BackColor = System.Drawing.Color.Black;
            this.elbo3.ColWidth = 104;
            this.elbo3.ElboOrientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elbo3.ForeColor = System.Drawing.Color.White;
            this.elbo3.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.elbo3.Location = new System.Drawing.Point(2, 658);
            this.elbo3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo3.Name = "elbo3";
            this.elbo3.Online = true;
            this.elbo3.Orientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo3.RowHeight = 32;
            this.elbo3.Size = new System.Drawing.Size(102, 107);
            this.elbo3.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.elbo3.TabIndex = 20;
            this.elbo3.Text = "elbo3";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.Blink = true;
            this.button14.BlinkInterval = 1200;
            this.button14.BlinkState = true;
            this.button14.ChangeOnHover = false;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button14.Font = new System.Drawing.Font("LCARS", 14F);
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button14.LeftSegments = 0;
            this.button14.Location = new System.Drawing.Point(0, 620);
            this.button14.Name = "button14";
            this.button14.Online = true;
            this.button14.RightSegments = 0;
            this.button14.RoundedLeft = false;
            this.button14.RoundedRight = false;
            this.button14.Size = new System.Drawing.Size(104, 32);
            this.button14.SoundFile = "Resources\\AutoShutdown.wav";
            this.button14.SoundRepeatTimes = 1;
            this.button14.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button14.TabIndex = 19;
            this.button14.Text = "EXIT";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Blink = false;
            this.button13.BlinkInterval = 1000;
            this.button13.BlinkState = false;
            this.button13.ChangeOnHover = false;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button13.Font = new System.Drawing.Font("LCARS", 14F);
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button13.LeftSegments = 0;
            this.button13.Location = new System.Drawing.Point(0, 496);
            this.button13.Name = "button13";
            this.button13.Online = true;
            this.button13.RightSegments = 0;
            this.button13.RoundedLeft = false;
            this.button13.RoundedRight = false;
            this.button13.Size = new System.Drawing.Size(104, 32);
            this.button13.SoundFile = "Resources\\DoubleBeep.wav";
            this.button13.SoundRepeatTimes = 1;
            this.button13.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button13.TabIndex = 18;
            this.button13.Text = "COMMUNICATIONS";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Blink = false;
            this.button12.BlinkInterval = 1000;
            this.button12.BlinkState = false;
            this.button12.ChangeOnHover = false;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button12.Font = new System.Drawing.Font("LCARS", 14F);
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button12.LeftSegments = 0;
            this.button12.Location = new System.Drawing.Point(0, 534);
            this.button12.Name = "button12";
            this.button12.Online = true;
            this.button12.RightSegments = 0;
            this.button12.RoundedLeft = false;
            this.button12.RoundedRight = false;
            this.button12.Size = new System.Drawing.Size(104, 80);
            this.button12.SoundFile = "Resources\\Error.wav";
            this.button12.SoundRepeatTimes = 1;
            this.button12.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button12.TabIndex = 17;
            this.button12.Text = "ENVIRONMENTAL";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Blink = false;
            this.button11.BlinkInterval = 1000;
            this.button11.BlinkState = false;
            this.button11.ChangeOnHover = false;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Font = new System.Drawing.Font("LCARS", 14F);
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button11.LeftSegments = 0;
            this.button11.Location = new System.Drawing.Point(0, 362);
            this.button11.Name = "button11";
            this.button11.Online = true;
            this.button11.RightSegments = 0;
            this.button11.RoundedLeft = false;
            this.button11.RoundedRight = false;
            this.button11.Size = new System.Drawing.Size(104, 128);
            this.button11.SoundFile = "Resources\\DoubleBeep.wav";
            this.button11.SoundRepeatTimes = 1;
            this.button11.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button11.TabIndex = 16;
            this.button11.Text = "SECURITY";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Blink = false;
            this.button10.BlinkInterval = 1000;
            this.button10.BlinkState = false;
            this.button10.ChangeOnHover = false;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Font = new System.Drawing.Font("LCARS", 14F);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button10.LeftSegments = 0;
            this.button10.Location = new System.Drawing.Point(0, 324);
            this.button10.Name = "button10";
            this.button10.Online = true;
            this.button10.RightSegments = 0;
            this.button10.RoundedLeft = false;
            this.button10.RoundedRight = false;
            this.button10.Size = new System.Drawing.Size(104, 32);
            this.button10.SoundFile = "Resources\\Error.wav";
            this.button10.SoundRepeatTimes = 1;
            this.button10.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button10.TabIndex = 15;
            this.button10.Text = "ENGINEERING";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button8.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button8.LeftSegments = 0;
            this.button8.Location = new System.Drawing.Point(0, 286);
            this.button8.Name = "button8";
            this.button8.Online = true;
            this.button8.RightSegments = 0;
            this.button8.RoundedLeft = false;
            this.button8.RoundedRight = false;
            this.button8.Size = new System.Drawing.Size(104, 32);
            this.button8.SoundFile = "Resources\\Error.wav";
            this.button8.SoundRepeatTimes = 1;
            this.button8.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button8.TabIndex = 13;
            this.button8.Text = "DATA";
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
            this.button7.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button7.LeftSegments = 0;
            this.button7.Location = new System.Drawing.Point(0, 248);
            this.button7.Name = "button7";
            this.button7.Online = true;
            this.button7.RightSegments = 0;
            this.button7.RoundedLeft = false;
            this.button7.RoundedRight = false;
            this.button7.Size = new System.Drawing.Size(104, 32);
            this.button7.SoundFile = "Resources\\Error.wav";
            this.button7.SoundRepeatTimes = 1;
            this.button7.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button7.TabIndex = 12;
            this.button7.Text = "SENSORS";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Font = new System.Drawing.Font("LCARS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Function = Streambolics.Lcars.Function.Database;
            this.label1.LeftSegments = 0;
            this.label1.Location = new System.Drawing.Point(585, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label1.Name = "label1";
            this.label1.Online = true;
            this.label1.RightSegments = 0;
            this.label1.RoundedLeft = false;
            this.label1.RoundedRight = false;
            this.label1.Size = new System.Drawing.Size(435, 64);
            this.label1.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.label1.TabIndex = 10;
            this.label1.Text = "LCARS DATABASE 3218X7";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Blink = true;
            this.button2.BlinkInterval = 1000;
            this.button2.BlinkState = false;
            this.button2.ChangeOnHover = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button2.LeftSegments = 0;
            this.button2.Location = new System.Drawing.Point(458, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Online = true;
            this.button2.RightSegments = 0;
            this.button2.RoundedLeft = false;
            this.button2.RoundedRight = false;
            this.button2.Size = new System.Drawing.Size(226, 15);
            this.button2.SoundFile = "";
            this.button2.SoundRepeatTimes = 1;
            this.button2.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button2.TabIndex = 9;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Blink = false;
            this.button4.BlinkInterval = 1000;
            this.button4.BlinkState = false;
            this.button4.ChangeOnHover = false;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ElboOrientation = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button4.LeftSegments = 0;
            this.button4.Location = new System.Drawing.Point(688, 70);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Online = true;
            this.button4.RightSegments = 0;
            this.button4.RoundedLeft = false;
            this.button4.RoundedRight = false;
            this.button4.Size = new System.Drawing.Size(154, 32);
            this.button4.SoundFile = "";
            this.button4.SoundRepeatTimes = 1;
            this.button4.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button4.TabIndex = 7;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Blink = false;
            this.button1.BlinkInterval = 1000;
            this.button1.BlinkState = false;
            this.button1.ChangeOnHover = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button1.LeftSegments = 0;
            this.button1.Location = new System.Drawing.Point(434, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Online = true;
            this.button1.RightSegments = 0;
            this.button1.RoundedLeft = false;
            this.button1.RoundedRight = false;
            this.button1.Size = new System.Drawing.Size(20, 32);
            this.button1.SoundFile = "";
            this.button1.SoundRepeatTimes = 1;
            this.button1.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.elbo2.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.elbo2.Location = new System.Drawing.Point(0, 108);
            this.elbo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo2.Name = "elbo2";
            this.elbo2.Online = true;
            this.elbo2.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo2.RowHeight = 32;
            this.elbo2.Size = new System.Drawing.Size(430, 134);
            this.elbo2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo2.TabIndex = 4;
            this.elbo2.Text = "elbo2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Blink = true;
            this.button3.BlinkInterval = 500;
            this.button3.BlinkState = true;
            this.button3.ChangeOnHover = false;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ElboOrientation = System.Drawing.ContentAlignment.BottomRight;
            this.button3.Font = new System.Drawing.Font("LCARS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button3.LeftSegments = 1;
            this.button3.Location = new System.Drawing.Point(846, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Online = true;
            this.button3.RightSegments = 0;
            this.button3.RoundedLeft = false;
            this.button3.RoundedRight = true;
            this.button3.Size = new System.Drawing.Size(165, 32);
            this.button3.SoundFile = "";
            this.button3.SoundRepeatTimes = 1;
            this.button3.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button3.TabIndex = 3;
            this.button3.Text = "SYSTEM LOCK";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // elbo1
            // 
            this.elbo1.ArcExternal = 100;
            this.elbo1.ArcInternal = 50;
            this.elbo1.BackColor = System.Drawing.Color.Black;
            this.elbo1.ColWidth = 104;
            this.elbo1.ElboOrientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elbo1.ForeColor = System.Drawing.Color.White;
            this.elbo1.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.elbo1.Location = new System.Drawing.Point(0, 0);
            this.elbo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo1.Name = "elbo1";
            this.elbo1.Online = true;
            this.elbo1.Orientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo1.RowHeight = 32;
            this.elbo1.Size = new System.Drawing.Size(430, 102);
            this.elbo1.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo1.TabIndex = 0;
            this.elbo1.Text = "elbo1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCARSHome.Properties.Resources.ufp;
            this.pictureBox1.Location = new System.Drawing.Point(160, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button5.LeftSegments = 0;
            this.button5.Location = new System.Drawing.Point(434, 108);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Online = true;
            this.button5.RightSegments = 0;
            this.button5.RoundedLeft = false;
            this.button5.RoundedRight = false;
            this.button5.Size = new System.Drawing.Size(20, 32);
            this.button5.SoundFile = "";
            this.button5.SoundRepeatTimes = 1;
            this.button5.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button5.TabIndex = 23;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Blink = true;
            this.button6.BlinkInterval = 1000;
            this.button6.BlinkState = false;
            this.button6.ChangeOnHover = false;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Function = Streambolics.Lcars.Function.MultiDisplay;
            this.button6.LeftSegments = 0;
            this.button6.Location = new System.Drawing.Point(458, 87);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Online = true;
            this.button6.RightSegments = 0;
            this.button6.RoundedLeft = false;
            this.button6.RoundedRight = false;
            this.button6.Size = new System.Drawing.Size(226, 15);
            this.button6.SoundFile = "";
            this.button6.SoundRepeatTimes = 1;
            this.button6.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button6.TabIndex = 24;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.elbo3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elbo2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.elbo1);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1024, 768);
            this.VisibleChanged += new System.EventHandler(this.HomeScreen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Streambolics.Lcars.Elbo elbo1;
        private Streambolics.Lcars.Button button3;
        private Streambolics.Lcars.Elbo elbo2;
        private Streambolics.Lcars.Button button1;
        private Streambolics.Lcars.Button button4;
        private Streambolics.Lcars.Button button2;
        private Streambolics.Lcars.Label label1;
        private Streambolics.Lcars.Button button7;
        private Streambolics.Lcars.Button button8;
        private Streambolics.Lcars.Button button10;
        private Streambolics.Lcars.Button button11;
        private Streambolics.Lcars.Button button12;
        private Streambolics.Lcars.Button button13;
        private Streambolics.Lcars.Button button14;
        private Streambolics.Lcars.Elbo elbo3;
        private Streambolics.Lcars.Sound sound1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Streambolics.Lcars.DateLabel dateLabel1;
        private Streambolics.Lcars.Button button5;
        private Streambolics.Lcars.Button button6;
    }
}
