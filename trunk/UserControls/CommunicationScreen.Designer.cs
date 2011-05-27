namespace LCARSHome.UserControls
{
    partial class CommunicationScreen
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
            this.richTextBoxItemPrefix = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elbo10 = new Streambolics.Lcars.Elbo();
            this.elbo4 = new Streambolics.Lcars.Elbo();
            this.button15 = new Streambolics.Lcars.Button();
            this.button14 = new Streambolics.Lcars.Button();
            this.button13 = new Streambolics.Lcars.Button();
            this.button12 = new Streambolics.Lcars.Button();
            this.button11 = new Streambolics.Lcars.Button();
            this.button10 = new Streambolics.Lcars.Button();
            this.elbo9 = new Streambolics.Lcars.Elbo();
            this.elbo8 = new Streambolics.Lcars.Elbo();
            this.button9 = new Streambolics.Lcars.Button();
            this.button8 = new Streambolics.Lcars.Button();
            this.button7 = new Streambolics.Lcars.Button();
            this.elbo7 = new Streambolics.Lcars.Elbo();
            this.elbo6 = new Streambolics.Lcars.Elbo();
            this.elbo5 = new Streambolics.Lcars.Elbo();
            this.button6 = new Streambolics.Lcars.Button();
            this.button5 = new Streambolics.Lcars.Button();
            this.button4 = new Streambolics.Lcars.Button();
            this.button3 = new Streambolics.Lcars.Button();
            this.elbo3 = new Streambolics.Lcars.Elbo();
            this.label1 = new Streambolics.Lcars.Label();
            this.button2 = new Streambolics.Lcars.Button();
            this.button1 = new Streambolics.Lcars.Button();
            this.elbo2 = new Streambolics.Lcars.Elbo();
            this.elbo1 = new Streambolics.Lcars.Elbo();
            this.sound1 = new Streambolics.Lcars.Sound();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxItemPrefix
            // 
            this.richTextBoxItemPrefix.Location = new System.Drawing.Point(833, 321);
            this.richTextBoxItemPrefix.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxItemPrefix.Name = "richTextBoxItemPrefix";
            this.richTextBoxItemPrefix.Size = new System.Drawing.Size(151, 96);
            this.richTextBoxItemPrefix.TabIndex = 30;
            this.richTextBoxItemPrefix.Text = "\t\t<tr>\n\t\t\t<td class=\"itemTitle\"><a href=\"%Link%\" target=\"_blank\" class=\"itemTitle" +
    "\">%Title%</a></td>\n\t\t</tr>\n\t\t<tr>\n\t\t\t<td class=\"itemDescription\">%Description%</" +
    "td>\n\t\t</tr>";
            this.richTextBoxItemPrefix.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // webBrowser1
            // 
            this.webBrowser1.CausesValidation = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(708, 154);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(10, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(314, 564);
            this.webBrowser1.TabIndex = 31;
            this.webBrowser1.VisibleChanged += new System.EventHandler(this.webBrowser1_VisibleChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCARSHome.Properties.Resources.starfleet_command_emblem;
            this.pictureBox1.Location = new System.Drawing.Point(63, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // elbo10
            // 
            this.elbo10.ArcExternal = 100;
            this.elbo10.ArcInternal = 100;
            this.elbo10.BackColor = System.Drawing.Color.Black;
            this.elbo10.ColWidth = 300;
            this.elbo10.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo10.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo10.ForeColor = System.Drawing.Color.White;
            this.elbo10.Function = Streambolics.Lcars.Function.Primary;
            this.elbo10.Location = new System.Drawing.Point(2, 667);
            this.elbo10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo10.Name = "elbo10";
            this.elbo10.Online = true;
            this.elbo10.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo10.RowHeight = 40;
            this.elbo10.Size = new System.Drawing.Size(422, 84);
            this.elbo10.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo10.TabIndex = 26;
            this.elbo10.Text = "elbo10";
            // 
            // elbo4
            // 
            this.elbo4.ArcExternal = 100;
            this.elbo4.ArcInternal = 100;
            this.elbo4.BackColor = System.Drawing.Color.Black;
            this.elbo4.ColWidth = 300;
            this.elbo4.ElboOrientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo4.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo4.ForeColor = System.Drawing.Color.White;
            this.elbo4.Function = Streambolics.Lcars.Function.Primary;
            this.elbo4.Location = new System.Drawing.Point(312, 631);
            this.elbo4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo4.Name = "elbo4";
            this.elbo4.Online = true;
            this.elbo4.Orientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo4.RowHeight = 40;
            this.elbo4.Size = new System.Drawing.Size(356, 76);
            this.elbo4.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo4.TabIndex = 25;
            this.elbo4.Text = "elbo4";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.Blink = false;
            this.button15.BlinkInterval = 1000;
            this.button15.BlinkState = false;
            this.button15.ChangeOnHover = false;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button15.Font = new System.Drawing.Font("LCARS", 14F);
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Function = Streambolics.Lcars.Function.Primary;
            this.button15.LeftSegments = 0;
            this.button15.Location = new System.Drawing.Point(366, 593);
            this.button15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button15.Name = "button15";
            this.button15.Online = true;
            this.button15.RightSegments = 1;
            this.button15.RoundedLeft = true;
            this.button15.RoundedRight = false;
            this.button15.Size = new System.Drawing.Size(302, 32);
            this.button15.SoundFile = "";
            this.button15.SoundRepeatTimes = 1;
            this.button15.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button15.TabIndex = 24;
            this.button15.Tag = "Resources\\Error.wav";
            this.button15.Text = "DIAGNOSTICS";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.Blink = false;
            this.button14.BlinkInterval = 1000;
            this.button14.BlinkState = false;
            this.button14.ChangeOnHover = false;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button14.Font = new System.Drawing.Font("LCARS", 14F);
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Function = Streambolics.Lcars.Function.Primary;
            this.button14.LeftSegments = 0;
            this.button14.Location = new System.Drawing.Point(366, 403);
            this.button14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button14.Name = "button14";
            this.button14.Online = true;
            this.button14.RightSegments = 1;
            this.button14.RoundedLeft = true;
            this.button14.RoundedRight = false;
            this.button14.Size = new System.Drawing.Size(302, 32);
            this.button14.SoundFile = "";
            this.button14.SoundRepeatTimes = 1;
            this.button14.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button14.TabIndex = 23;
            this.button14.Tag = "Resources\\Error.wav";
            this.button14.Text = "OPEN HAILING FREQUENCY";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button13.Function = Streambolics.Lcars.Function.Primary;
            this.button13.LeftSegments = 0;
            this.button13.Location = new System.Drawing.Point(366, 517);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button13.Name = "button13";
            this.button13.Online = true;
            this.button13.RightSegments = 1;
            this.button13.RoundedLeft = true;
            this.button13.RoundedRight = false;
            this.button13.Size = new System.Drawing.Size(302, 32);
            this.button13.SoundFile = "";
            this.button13.SoundRepeatTimes = 1;
            this.button13.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button13.TabIndex = 22;
            this.button13.Tag = "Resources\\Error.wav";
            this.button13.Text = "LOCAL COMMUNICATION";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button12.Function = Streambolics.Lcars.Function.Primary;
            this.button12.LeftSegments = 0;
            this.button12.Location = new System.Drawing.Point(366, 479);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button12.Name = "button12";
            this.button12.Online = true;
            this.button12.RightSegments = 1;
            this.button12.RoundedLeft = true;
            this.button12.RoundedRight = false;
            this.button12.Size = new System.Drawing.Size(302, 32);
            this.button12.SoundFile = "";
            this.button12.SoundRepeatTimes = 1;
            this.button12.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button12.TabIndex = 21;
            this.button12.Tag = "Resources\\Error.wav";
            this.button12.Text = "SHIPWIDE COMMUNICATION";
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
            this.button11.Function = Streambolics.Lcars.Function.Primary;
            this.button11.LeftSegments = 0;
            this.button11.Location = new System.Drawing.Point(366, 441);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button11.Name = "button11";
            this.button11.Online = true;
            this.button11.RightSegments = 1;
            this.button11.RoundedLeft = true;
            this.button11.RoundedRight = false;
            this.button11.Size = new System.Drawing.Size(302, 32);
            this.button11.SoundFile = "";
            this.button11.SoundRepeatTimes = 1;
            this.button11.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button11.TabIndex = 20;
            this.button11.Tag = "Resources\\Error.wav";
            this.button11.Text = "SUBSPACE MESSAGING";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button10.Function = Streambolics.Lcars.Function.Primary;
            this.button10.LeftSegments = 0;
            this.button10.Location = new System.Drawing.Point(366, 555);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button10.Name = "button10";
            this.button10.Online = true;
            this.button10.RightSegments = 1;
            this.button10.RoundedLeft = true;
            this.button10.RoundedRight = false;
            this.button10.Size = new System.Drawing.Size(302, 32);
            this.button10.SoundFile = "";
            this.button10.SoundRepeatTimes = 1;
            this.button10.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button10.TabIndex = 19;
            this.button10.Tag = "Resources\\Error.wav";
            this.button10.Text = "LOG ENTRY";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button10.Click += new System.EventHandler(this.button10_Click);
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
            this.elbo9.Function = Streambolics.Lcars.Function.Primary;
            this.elbo9.Location = new System.Drawing.Point(590, 265);
            this.elbo9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo9.Name = "elbo9";
            this.elbo9.Online = true;
            this.elbo9.Orientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo9.RowHeight = 32;
            this.elbo9.Size = new System.Drawing.Size(44, 48);
            this.elbo9.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo9.TabIndex = 18;
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
            this.elbo8.Function = Streambolics.Lcars.Function.Primary;
            this.elbo8.Location = new System.Drawing.Point(590, 167);
            this.elbo8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo8.Name = "elbo8";
            this.elbo8.Online = true;
            this.elbo8.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo8.RowHeight = 32;
            this.elbo8.Size = new System.Drawing.Size(44, 48);
            this.elbo8.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo8.TabIndex = 17;
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
            this.button9.Function = Streambolics.Lcars.Function.Primary;
            this.button9.LeftSegments = 0;
            this.button9.Location = new System.Drawing.Point(590, 221);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button9.Name = "button9";
            this.button9.Online = true;
            this.button9.RightSegments = 0;
            this.button9.RoundedLeft = false;
            this.button9.RoundedRight = false;
            this.button9.Size = new System.Drawing.Size(32, 38);
            this.button9.SoundFile = "";
            this.button9.SoundRepeatTimes = 1;
            this.button9.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button9.TabIndex = 16;
            this.button9.Text = "+";
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
            this.button8.Function = Streambolics.Lcars.Function.Primary;
            this.button8.LeftSegments = 0;
            this.button8.Location = new System.Drawing.Point(536, 221);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Online = true;
            this.button8.RightSegments = 0;
            this.button8.RoundedLeft = false;
            this.button8.RoundedRight = false;
            this.button8.Size = new System.Drawing.Size(47, 38);
            this.button8.SoundFile = "";
            this.button8.SoundRepeatTimes = 1;
            this.button8.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button8.TabIndex = 15;
            this.button8.Text = "32.5";
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
            this.button7.Function = Streambolics.Lcars.Function.Primary;
            this.button7.LeftSegments = 0;
            this.button7.Location = new System.Drawing.Point(500, 221);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button7.Name = "button7";
            this.button7.Online = true;
            this.button7.RightSegments = 0;
            this.button7.RoundedLeft = false;
            this.button7.RoundedRight = false;
            this.button7.Size = new System.Drawing.Size(32, 38);
            this.button7.SoundFile = "";
            this.button7.SoundRepeatTimes = 1;
            this.button7.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.button7.TabIndex = 14;
            this.button7.Text = "-";
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
            this.elbo7.Function = Streambolics.Lcars.Function.Primary;
            this.elbo7.Location = new System.Drawing.Point(488, 167);
            this.elbo7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo7.Name = "elbo7";
            this.elbo7.Online = true;
            this.elbo7.Orientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo7.RowHeight = 32;
            this.elbo7.Size = new System.Drawing.Size(44, 48);
            this.elbo7.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo7.TabIndex = 13;
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
            this.elbo6.Function = Streambolics.Lcars.Function.Primary;
            this.elbo6.Location = new System.Drawing.Point(488, 265);
            this.elbo6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo6.Name = "elbo6";
            this.elbo6.Online = true;
            this.elbo6.Orientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo6.RowHeight = 32;
            this.elbo6.Size = new System.Drawing.Size(44, 48);
            this.elbo6.SubFunction = Streambolics.Lcars.SubFunction.Unavailable;
            this.elbo6.TabIndex = 12;
            this.elbo6.Text = "elbo6";
            // 
            // elbo5
            // 
            this.elbo5.ArcExternal = 100;
            this.elbo5.ArcInternal = 100;
            this.elbo5.BackColor = System.Drawing.Color.Black;
            this.elbo5.ColWidth = 300;
            this.elbo5.ElboOrientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo5.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo5.ForeColor = System.Drawing.Color.White;
            this.elbo5.Function = Streambolics.Lcars.Function.Primary;
            this.elbo5.Location = new System.Drawing.Point(2, 321);
            this.elbo5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo5.Name = "elbo5";
            this.elbo5.Online = true;
            this.elbo5.Orientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo5.RowHeight = 40;
            this.elbo5.Size = new System.Drawing.Size(666, 76);
            this.elbo5.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo5.TabIndex = 11;
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
            this.button6.Function = Streambolics.Lcars.Function.Primary;
            this.button6.LeftSegments = 2;
            this.button6.Location = new System.Drawing.Point(2, 283);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Online = true;
            this.button6.RightSegments = 1;
            this.button6.RoundedLeft = true;
            this.button6.RoundedRight = true;
            this.button6.Size = new System.Drawing.Size(403, 32);
            this.button6.SoundFile = "Resources\\VariousBeeps.wav";
            this.button6.SoundRepeatTimes = 1;
            this.button6.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button6.TabIndex = 9;
            this.button6.Tag = "http://blog.tempworks.com/feed/";
            this.button6.Text = "TEMPWORKS NEWS";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Blink = true;
            this.button5.BlinkInterval = 1000;
            this.button5.BlinkState = true;
            this.button5.ChangeOnHover = false;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Font = new System.Drawing.Font("LCARS", 14F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Function = Streambolics.Lcars.Function.Primary;
            this.button5.LeftSegments = 2;
            this.button5.Location = new System.Drawing.Point(2, 245);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Online = true;
            this.button5.RightSegments = 1;
            this.button5.RoundedLeft = true;
            this.button5.RoundedRight = true;
            this.button5.Size = new System.Drawing.Size(403, 32);
            this.button5.SoundFile = "Resources\\VariousBeeps.wav";
            this.button5.SoundRepeatTimes = 1;
            this.button5.SubFunction = Streambolics.Lcars.SubFunction.Offline;
            this.button5.TabIndex = 8;
            this.button5.Tag = "http://feeds.feedburner.com/blogspot/MKuf?format=rss";
            this.button5.Text = "GOOGLE NEWS";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.button4.Function = Streambolics.Lcars.Function.Primary;
            this.button4.LeftSegments = 2;
            this.button4.Location = new System.Drawing.Point(2, 207);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Online = true;
            this.button4.RightSegments = 1;
            this.button4.RoundedLeft = true;
            this.button4.RoundedRight = true;
            this.button4.Size = new System.Drawing.Size(403, 32);
            this.button4.SoundFile = "Resources\\VariousBeeps.wav";
            this.button4.SoundRepeatTimes = 1;
            this.button4.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button4.TabIndex = 7;
            this.button4.Tag = "http://rss.weather.com/weather/rss/local/55122?cm_ven=LWO&cm_cat=rss&par=LWO_rss";
            this.button4.Text = "LOCAL WEATHER";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button3.Function = Streambolics.Lcars.Function.Primary;
            this.button3.LeftSegments = 2;
            this.button3.Location = new System.Drawing.Point(2, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Online = true;
            this.button3.RightSegments = 1;
            this.button3.RoundedLeft = true;
            this.button3.RoundedRight = true;
            this.button3.Size = new System.Drawing.Size(403, 32);
            this.button3.SoundFile = "Resources\\VariousBeeps.wav";
            this.button3.SoundRepeatTimes = 1;
            this.button3.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.button3.TabIndex = 6;
            this.button3.Tag = "http://news.feedzilla.com/en_us/headlines/top-news/usa.rss";
            this.button3.Text = "USA NEWS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // elbo3
            // 
            this.elbo3.ArcExternal = 50;
            this.elbo3.ArcInternal = 50;
            this.elbo3.BackColor = System.Drawing.Color.Black;
            this.elbo3.ColWidth = 32;
            this.elbo3.ElboOrientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo3.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo3.ForeColor = System.Drawing.Color.White;
            this.elbo3.Function = Streambolics.Lcars.Function.Primary;
            this.elbo3.Location = new System.Drawing.Point(672, 154);
            this.elbo3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo3.Name = "elbo3";
            this.elbo3.Online = true;
            this.elbo3.Orientation = System.Drawing.ContentAlignment.BottomLeft;
            this.elbo3.RowHeight = 10;
            this.elbo3.Size = new System.Drawing.Size(350, 597);
            this.elbo3.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo3.TabIndex = 5;
            this.elbo3.Text = "elbo3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Font = new System.Drawing.Font("LCARS", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Function = Streambolics.Lcars.Function.Primary;
            this.label1.LeftSegments = 0;
            this.label1.Location = new System.Drawing.Point(708, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label1.Name = "label1";
            this.label1.Online = true;
            this.label1.RightSegments = 0;
            this.label1.RoundedLeft = false;
            this.label1.RoundedRight = false;
            this.label1.Size = new System.Drawing.Size(300, 84);
            this.label1.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.label1.TabIndex = 4;
            this.label1.Text = "COMMUNICATIONS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.button2.Function = Streambolics.Lcars.Function.Primary;
            this.button2.LeftSegments = 0;
            this.button2.Location = new System.Drawing.Point(708, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Online = true;
            this.button2.RightSegments = 0;
            this.button2.RoundedLeft = false;
            this.button2.RoundedRight = true;
            this.button2.Size = new System.Drawing.Size(300, 50);
            this.button2.SoundFile = "";
            this.button2.SoundRepeatTimes = 1;
            this.button2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button2.TabIndex = 3;
            this.button2.Text = "INCOMING DATA STREAM";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Blink = true;
            this.button1.BlinkInterval = 1000;
            this.button1.BlinkState = false;
            this.button1.ChangeOnHover = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Font = new System.Drawing.Font("LCARS", 14F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Function = Streambolics.Lcars.Function.Primary;
            this.button1.LeftSegments = 0;
            this.button1.Location = new System.Drawing.Point(600, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Online = true;
            this.button1.RightSegments = 0;
            this.button1.RoundedLeft = false;
            this.button1.RoundedRight = false;
            this.button1.Size = new System.Drawing.Size(104, 66);
            this.button1.SoundFile = "";
            this.button1.SoundRepeatTimes = 1;
            this.button1.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button1.TabIndex = 2;
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
            this.elbo2.Function = Streambolics.Lcars.Function.Primary;
            this.elbo2.Location = new System.Drawing.Point(299, 80);
            this.elbo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo2.Name = "elbo2";
            this.elbo2.Online = true;
            this.elbo2.Orientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo2.RowHeight = 50;
            this.elbo2.Size = new System.Drawing.Size(405, 68);
            this.elbo2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo2.TabIndex = 1;
            this.elbo2.Text = "elbo2";
            // 
            // elbo1
            // 
            this.elbo1.ArcExternal = 100;
            this.elbo1.ArcInternal = 50;
            this.elbo1.BackColor = System.Drawing.Color.Black;
            this.elbo1.ColWidth = 400;
            this.elbo1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo1.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo1.ForeColor = System.Drawing.Color.White;
            this.elbo1.Function = Streambolics.Lcars.Function.Primary;
            this.elbo1.Location = new System.Drawing.Point(2, 98);
            this.elbo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo1.Name = "elbo1";
            this.elbo1.Online = true;
            this.elbo1.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo1.RowHeight = 50;
            this.elbo1.Size = new System.Drawing.Size(581, 65);
            this.elbo1.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo1.TabIndex = 0;
            this.elbo1.Text = "elbo1";
            // 
            // CommunicationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.richTextBoxItemPrefix);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.elbo10);
            this.Controls.Add(this.elbo4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.elbo9);
            this.Controls.Add(this.elbo8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.elbo7);
            this.Controls.Add(this.elbo6);
            this.Controls.Add(this.elbo5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.elbo3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elbo2);
            this.Controls.Add(this.elbo1);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CommunicationScreen";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Streambolics.Lcars.Elbo elbo1;
        private Streambolics.Lcars.Elbo elbo2;
        private Streambolics.Lcars.Button button1;
        private Streambolics.Lcars.Button button2;
        private Streambolics.Lcars.Label label1;
        private Streambolics.Lcars.Elbo elbo3;
        private Streambolics.Lcars.Button button3;
        private Streambolics.Lcars.Button button4;
        private Streambolics.Lcars.Button button5;
        private Streambolics.Lcars.Button button6;
        private Streambolics.Lcars.Elbo elbo5;
        private Streambolics.Lcars.Elbo elbo6;
        private Streambolics.Lcars.Elbo elbo7;
        private Streambolics.Lcars.Button button7;
        private Streambolics.Lcars.Button button8;
        private Streambolics.Lcars.Button button9;
        private Streambolics.Lcars.Elbo elbo8;
        private Streambolics.Lcars.Elbo elbo9;
        private Streambolics.Lcars.Button button10;
        private Streambolics.Lcars.Button button11;
        private Streambolics.Lcars.Button button12;
        private Streambolics.Lcars.Button button13;
        private Streambolics.Lcars.Button button14;
        private Streambolics.Lcars.Button button15;
        private Streambolics.Lcars.Elbo elbo4;
        private Streambolics.Lcars.Elbo elbo10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Streambolics.Lcars.Sound sound1;
        private System.Windows.Forms.RichTextBox richTextBoxItemPrefix;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser webBrowser1;

    }
}
