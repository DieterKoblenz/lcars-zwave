namespace LCARSHome.UserControls
{
    partial class EngineeringScreen
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
            this.elbo3 = new Streambolics.Lcars.Elbo();
            this.btnDiagnostic = new Streambolics.Lcars.Button();
            this.btnAllLightsOff = new Streambolics.Lcars.Button();
            this.btnAllLightsOn = new Streambolics.Lcars.Button();
            this.btnSubSystem = new Streambolics.Lcars.Button();
            this.btnLifeSupport = new Streambolics.Lcars.Button();
            this.button28 = new Streambolics.Lcars.Button();
            this.elbo2 = new Streambolics.Lcars.Elbo();
            this.elbo4 = new Streambolics.Lcars.Elbo();
            this.label5 = new Streambolics.Lcars.Label();
            this.button27 = new Streambolics.Lcars.Button();
            this.label4 = new Streambolics.Lcars.Label();
            this.button26 = new Streambolics.Lcars.Button();
            this.label3 = new Streambolics.Lcars.Label();
            this.button25 = new Streambolics.Lcars.Button();
            this.label2 = new Streambolics.Lcars.Label();
            this.button8 = new Streambolics.Lcars.Button();
            this.label1 = new Streambolics.Lcars.Label();
            this.btnProximity = new Streambolics.Lcars.Button();
            this.btnDeck2Breach = new Streambolics.Lcars.Button();
            this.btnDeck2Motion = new Streambolics.Lcars.Button();
            this.btnDeck1Breach = new Streambolics.Lcars.Button();
            this.btnDeck1Motion = new Streambolics.Lcars.Button();
            this.button24 = new Streambolics.Lcars.Button();
            this.btnRetrans = new Streambolics.Lcars.Button();
            this.btnAutoLockout = new Streambolics.Lcars.Button();
            this.btnInterface = new Streambolics.Lcars.Button();
            this.btnZWave = new Streambolics.Lcars.Button();
            this.btnVoice = new Streambolics.Lcars.Button();
            this.button7 = new Streambolics.Lcars.Button();
            this.button6 = new Streambolics.Lcars.Button();
            this.button5 = new Streambolics.Lcars.Button();
            this.button4 = new Streambolics.Lcars.Button();
            this.button3 = new Streambolics.Lcars.Button();
            this.button2 = new Streambolics.Lcars.Button();
            this.button1 = new Streambolics.Lcars.Button();
            this.elbo1 = new Streambolics.Lcars.Elbo();
            this.sound1 = new Streambolics.Lcars.Sound();
            this.subSystemControls1 = new LCARSHome.UserControls.SubSystemControls();
            this.SuspendLayout();
            // 
            // elbo3
            // 
            this.elbo3.ArcExternal = 100;
            this.elbo3.ArcInternal = 50;
            this.elbo3.BackColor = System.Drawing.Color.Black;
            this.elbo3.ColWidth = 104;
            this.elbo3.ElboOrientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo3.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo3.ForeColor = System.Drawing.Color.White;
            this.elbo3.Function = Streambolics.Lcars.Function.Secondary;
            this.elbo3.InAlert = false;
            this.elbo3.Location = new System.Drawing.Point(110, 732);
            this.elbo3.Name = "elbo3";
            this.elbo3.Online = true;
            this.elbo3.Orientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo3.RowHeight = 47;
            this.elbo3.Size = new System.Drawing.Size(911, 33);
            this.elbo3.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo3.TabIndex = 55;
            this.elbo3.Text = "elbo3";
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.BackColor = System.Drawing.Color.Black;
            this.btnDiagnostic.Blink = false;
            this.btnDiagnostic.BlinkInterval = 500;
            this.btnDiagnostic.BlinkState = false;
            this.btnDiagnostic.ChangeOnHover = false;
            this.btnDiagnostic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiagnostic.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnDiagnostic.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnDiagnostic.ForeColor = System.Drawing.Color.White;
            this.btnDiagnostic.Function = Streambolics.Lcars.Function.Secondary;
            this.btnDiagnostic.InAlert = false;
            this.btnDiagnostic.LeftSegments = 0;
            this.btnDiagnostic.Location = new System.Drawing.Point(740, 313);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.NodeID = ((byte)(0));
            this.btnDiagnostic.Online = true;
            this.btnDiagnostic.RightSegments = 1;
            this.btnDiagnostic.RoundedLeft = true;
            this.btnDiagnostic.RoundedRight = false;
            this.btnDiagnostic.Size = new System.Drawing.Size(219, 42);
            this.btnDiagnostic.SoundFile = "Resources\\Calibration.wav";
            this.btnDiagnostic.SoundRepeatTimes = 1;
            this.btnDiagnostic.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnDiagnostic.TabIndex = 54;
            this.btnDiagnostic.Text = "DIAGNOSTIC";
            this.btnDiagnostic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDiagnostic.Click += new System.EventHandler(this.button38_Click);
            // 
            // btnAllLightsOff
            // 
            this.btnAllLightsOff.BackColor = System.Drawing.Color.Black;
            this.btnAllLightsOff.Blink = false;
            this.btnAllLightsOff.BlinkInterval = 500;
            this.btnAllLightsOff.BlinkState = false;
            this.btnAllLightsOff.ChangeOnHover = false;
            this.btnAllLightsOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllLightsOff.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnAllLightsOff.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnAllLightsOff.ForeColor = System.Drawing.Color.White;
            this.btnAllLightsOff.Function = Streambolics.Lcars.Function.Secondary;
            this.btnAllLightsOff.InAlert = false;
            this.btnAllLightsOff.LeftSegments = 0;
            this.btnAllLightsOff.Location = new System.Drawing.Point(740, 265);
            this.btnAllLightsOff.Name = "btnAllLightsOff";
            this.btnAllLightsOff.NodeID = ((byte)(0));
            this.btnAllLightsOff.Online = true;
            this.btnAllLightsOff.RightSegments = 1;
            this.btnAllLightsOff.RoundedLeft = true;
            this.btnAllLightsOff.RoundedRight = false;
            this.btnAllLightsOff.Size = new System.Drawing.Size(219, 42);
            this.btnAllLightsOff.SoundFile = "Resources/Beep.wav";
            this.btnAllLightsOff.SoundRepeatTimes = 1;
            this.btnAllLightsOff.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnAllLightsOff.TabIndex = 53;
            this.btnAllLightsOff.Text = "ALL LIGHTS OFF";
            this.btnAllLightsOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAllLightsOn
            // 
            this.btnAllLightsOn.BackColor = System.Drawing.Color.Black;
            this.btnAllLightsOn.Blink = false;
            this.btnAllLightsOn.BlinkInterval = 500;
            this.btnAllLightsOn.BlinkState = false;
            this.btnAllLightsOn.ChangeOnHover = false;
            this.btnAllLightsOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllLightsOn.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnAllLightsOn.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnAllLightsOn.ForeColor = System.Drawing.Color.White;
            this.btnAllLightsOn.Function = Streambolics.Lcars.Function.Secondary;
            this.btnAllLightsOn.InAlert = false;
            this.btnAllLightsOn.LeftSegments = 0;
            this.btnAllLightsOn.Location = new System.Drawing.Point(740, 217);
            this.btnAllLightsOn.Name = "btnAllLightsOn";
            this.btnAllLightsOn.NodeID = ((byte)(0));
            this.btnAllLightsOn.Online = true;
            this.btnAllLightsOn.RightSegments = 1;
            this.btnAllLightsOn.RoundedLeft = true;
            this.btnAllLightsOn.RoundedRight = false;
            this.btnAllLightsOn.Size = new System.Drawing.Size(219, 42);
            this.btnAllLightsOn.SoundFile = "Resources/Beep.wav";
            this.btnAllLightsOn.SoundRepeatTimes = 1;
            this.btnAllLightsOn.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnAllLightsOn.TabIndex = 52;
            this.btnAllLightsOn.Text = "ALL LIGHTS ON";
            this.btnAllLightsOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubSystem
            // 
            this.btnSubSystem.BackColor = System.Drawing.Color.Black;
            this.btnSubSystem.Blink = false;
            this.btnSubSystem.BlinkInterval = 500;
            this.btnSubSystem.BlinkState = false;
            this.btnSubSystem.ChangeOnHover = false;
            this.btnSubSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubSystem.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubSystem.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnSubSystem.ForeColor = System.Drawing.Color.White;
            this.btnSubSystem.Function = Streambolics.Lcars.Function.Secondary;
            this.btnSubSystem.InAlert = false;
            this.btnSubSystem.LeftSegments = 0;
            this.btnSubSystem.Location = new System.Drawing.Point(740, 169);
            this.btnSubSystem.Name = "btnSubSystem";
            this.btnSubSystem.NodeID = ((byte)(0));
            this.btnSubSystem.Online = true;
            this.btnSubSystem.RightSegments = 1;
            this.btnSubSystem.RoundedLeft = true;
            this.btnSubSystem.RoundedRight = false;
            this.btnSubSystem.Size = new System.Drawing.Size(219, 42);
            this.btnSubSystem.SoundFile = "Resources/Beep.wav";
            this.btnSubSystem.SoundRepeatTimes = 1;
            this.btnSubSystem.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnSubSystem.TabIndex = 51;
            this.btnSubSystem.Text = "SUBSYSTEM CONTROL";
            this.btnSubSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubSystem.Click += new System.EventHandler(this.button35_Click);
            // 
            // btnLifeSupport
            // 
            this.btnLifeSupport.BackColor = System.Drawing.Color.Black;
            this.btnLifeSupport.Blink = false;
            this.btnLifeSupport.BlinkInterval = 500;
            this.btnLifeSupport.BlinkState = false;
            this.btnLifeSupport.ChangeOnHover = false;
            this.btnLifeSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLifeSupport.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnLifeSupport.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnLifeSupport.ForeColor = System.Drawing.Color.White;
            this.btnLifeSupport.Function = Streambolics.Lcars.Function.Secondary;
            this.btnLifeSupport.InAlert = false;
            this.btnLifeSupport.LeftSegments = 0;
            this.btnLifeSupport.Location = new System.Drawing.Point(740, 121);
            this.btnLifeSupport.Name = "btnLifeSupport";
            this.btnLifeSupport.NodeID = ((byte)(0));
            this.btnLifeSupport.Online = true;
            this.btnLifeSupport.RightSegments = 1;
            this.btnLifeSupport.RoundedLeft = true;
            this.btnLifeSupport.RoundedRight = false;
            this.btnLifeSupport.Size = new System.Drawing.Size(219, 42);
            this.btnLifeSupport.SoundFile = "Resources/Beep.wav";
            this.btnLifeSupport.SoundRepeatTimes = 1;
            this.btnLifeSupport.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnLifeSupport.TabIndex = 50;
            this.btnLifeSupport.Text = "LIFE SUPPORT";
            this.btnLifeSupport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLifeSupport.Click += new System.EventHandler(this.button34_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Black;
            this.button28.Blink = false;
            this.button28.BlinkInterval = 500;
            this.button28.BlinkState = false;
            this.button28.ChangeOnHover = false;
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button28.Font = new System.Drawing.Font("LCARS", 14F);
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Function = Streambolics.Lcars.Function.Secondary;
            this.button28.InAlert = false;
            this.button28.LeftSegments = 0;
            this.button28.Location = new System.Drawing.Point(0, 732);
            this.button28.Name = "button28";
            this.button28.NodeID = ((byte)(0));
            this.button28.Online = true;
            this.button28.RightSegments = 0;
            this.button28.RoundedLeft = false;
            this.button28.RoundedRight = false;
            this.button28.Size = new System.Drawing.Size(104, 33);
            this.button28.SoundFile = "Resources/Beep.wav";
            this.button28.SoundRepeatTimes = 1;
            this.button28.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button28.TabIndex = 49;
            this.button28.Text = "LCARS";
            this.button28.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // elbo2
            // 
            this.elbo2.ArcExternal = 100;
            this.elbo2.ArcInternal = 50;
            this.elbo2.BackColor = System.Drawing.Color.Black;
            this.elbo2.ColWidth = 20;
            this.elbo2.ElboOrientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo2.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo2.ForeColor = System.Drawing.Color.White;
            this.elbo2.Function = Streambolics.Lcars.Function.Secondary;
            this.elbo2.InAlert = false;
            this.elbo2.Location = new System.Drawing.Point(917, 284);
            this.elbo2.Name = "elbo2";
            this.elbo2.Online = true;
            this.elbo2.Orientation = System.Drawing.ContentAlignment.BottomRight;
            this.elbo2.RowHeight = 47;
            this.elbo2.Size = new System.Drawing.Size(104, 124);
            this.elbo2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo2.TabIndex = 48;
            this.elbo2.Text = "elbo2";
            // 
            // elbo4
            // 
            this.elbo4.ArcExternal = 100;
            this.elbo4.ArcInternal = 50;
            this.elbo4.BackColor = System.Drawing.Color.Black;
            this.elbo4.ColWidth = 104;
            this.elbo4.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo4.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo4.ForeColor = System.Drawing.Color.White;
            this.elbo4.Function = Streambolics.Lcars.Function.Secondary;
            this.elbo4.InAlert = false;
            this.elbo4.Location = new System.Drawing.Point(0, 361);
            this.elbo4.Name = "elbo4";
            this.elbo4.Online = true;
            this.elbo4.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo4.RowHeight = 47;
            this.elbo4.Size = new System.Drawing.Size(918, 365);
            this.elbo4.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo4.TabIndex = 47;
            this.elbo4.Text = "elbo4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Font = new System.Drawing.Font("LCARS", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Function = Streambolics.Lcars.Function.Ancillary;
            this.label5.InAlert = false;
            this.label5.LeftSegments = 0;
            this.label5.Location = new System.Drawing.Point(390, 313);
            this.label5.Name = "label5";
            this.label5.Online = true;
            this.label5.RightSegments = 0;
            this.label5.RoundedLeft = false;
            this.label5.RoundedRight = false;
            this.label5.Size = new System.Drawing.Size(41, 42);
            this.label5.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.label5.TabIndex = 45;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Black;
            this.button27.Blink = false;
            this.button27.BlinkInterval = 500;
            this.button27.BlinkState = false;
            this.button27.ChangeOnHover = false;
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button27.Font = new System.Drawing.Font("LCARS", 14F);
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Function = Streambolics.Lcars.Function.Ancillary;
            this.button27.InAlert = false;
            this.button27.LeftSegments = 0;
            this.button27.Location = new System.Drawing.Point(437, 313);
            this.button27.Name = "button27";
            this.button27.NodeID = ((byte)(0));
            this.button27.Online = true;
            this.button27.RightSegments = 0;
            this.button27.RoundedLeft = false;
            this.button27.RoundedRight = true;
            this.button27.Size = new System.Drawing.Size(187, 42);
            this.button27.SoundFile = "Resources/Beep.wav";
            this.button27.SoundRepeatTimes = 1;
            this.button27.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.button27.TabIndex = 44;
            this.button27.Text = "AUDIO";
            this.button27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Font = new System.Drawing.Font("LCARS", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Function = Streambolics.Lcars.Function.Ancillary;
            this.label4.InAlert = false;
            this.label4.LeftSegments = 0;
            this.label4.Location = new System.Drawing.Point(390, 265);
            this.label4.Name = "label4";
            this.label4.Online = true;
            this.label4.RightSegments = 0;
            this.label4.RoundedLeft = false;
            this.label4.RoundedRight = false;
            this.label4.Size = new System.Drawing.Size(41, 42);
            this.label4.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.label4.TabIndex = 43;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Black;
            this.button26.Blink = false;
            this.button26.BlinkInterval = 500;
            this.button26.BlinkState = false;
            this.button26.ChangeOnHover = false;
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button26.Font = new System.Drawing.Font("LCARS", 14F);
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Function = Streambolics.Lcars.Function.Ancillary;
            this.button26.InAlert = false;
            this.button26.LeftSegments = 0;
            this.button26.Location = new System.Drawing.Point(437, 265);
            this.button26.Name = "button26";
            this.button26.NodeID = ((byte)(0));
            this.button26.Online = true;
            this.button26.RightSegments = 0;
            this.button26.RoundedLeft = false;
            this.button26.RoundedRight = true;
            this.button26.Size = new System.Drawing.Size(187, 42);
            this.button26.SoundFile = "Resources/Beep.wav";
            this.button26.SoundRepeatTimes = 1;
            this.button26.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.button26.TabIndex = 42;
            this.button26.Text = "NETWORK";
            this.button26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Font = new System.Drawing.Font("LCARS", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Function = Streambolics.Lcars.Function.Ancillary;
            this.label3.InAlert = false;
            this.label3.LeftSegments = 0;
            this.label3.Location = new System.Drawing.Point(390, 217);
            this.label3.Name = "label3";
            this.label3.Online = true;
            this.label3.RightSegments = 0;
            this.label3.RoundedLeft = false;
            this.label3.RoundedRight = false;
            this.label3.Size = new System.Drawing.Size(41, 42);
            this.label3.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.label3.TabIndex = 41;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Black;
            this.button25.Blink = false;
            this.button25.BlinkInterval = 500;
            this.button25.BlinkState = false;
            this.button25.ChangeOnHover = false;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button25.Font = new System.Drawing.Font("LCARS", 14F);
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Function = Streambolics.Lcars.Function.Ancillary;
            this.button25.InAlert = false;
            this.button25.LeftSegments = 0;
            this.button25.Location = new System.Drawing.Point(437, 217);
            this.button25.Name = "button25";
            this.button25.NodeID = ((byte)(0));
            this.button25.Online = true;
            this.button25.RightSegments = 0;
            this.button25.RoundedLeft = false;
            this.button25.RoundedRight = true;
            this.button25.Size = new System.Drawing.Size(187, 42);
            this.button25.SoundFile = "Resources/Beep.wav";
            this.button25.SoundRepeatTimes = 1;
            this.button25.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.button25.TabIndex = 40;
            this.button25.Text = "STORAGE";
            this.button25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Font = new System.Drawing.Font("LCARS", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Function = Streambolics.Lcars.Function.Ancillary;
            this.label2.InAlert = false;
            this.label2.LeftSegments = 0;
            this.label2.Location = new System.Drawing.Point(390, 169);
            this.label2.Name = "label2";
            this.label2.Online = true;
            this.label2.RightSegments = 0;
            this.label2.RoundedLeft = false;
            this.label2.RoundedRight = false;
            this.label2.Size = new System.Drawing.Size(41, 42);
            this.label2.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.label2.TabIndex = 39;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button8.Font = new System.Drawing.Font("LCARS", 14F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Function = Streambolics.Lcars.Function.Ancillary;
            this.button8.InAlert = false;
            this.button8.LeftSegments = 0;
            this.button8.Location = new System.Drawing.Point(437, 169);
            this.button8.Name = "button8";
            this.button8.NodeID = ((byte)(0));
            this.button8.Online = true;
            this.button8.RightSegments = 0;
            this.button8.RoundedLeft = false;
            this.button8.RoundedRight = true;
            this.button8.Size = new System.Drawing.Size(187, 42);
            this.button8.SoundFile = "Resources/Beep.wav";
            this.button8.SoundRepeatTimes = 1;
            this.button8.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.button8.TabIndex = 38;
            this.button8.Text = "MEMORY";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Font = new System.Drawing.Font("LCARS", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Function = Streambolics.Lcars.Function.Ancillary;
            this.label1.InAlert = false;
            this.label1.LeftSegments = 0;
            this.label1.Location = new System.Drawing.Point(390, 121);
            this.label1.Name = "label1";
            this.label1.Online = true;
            this.label1.RightSegments = 0;
            this.label1.RoundedLeft = false;
            this.label1.RoundedRight = false;
            this.label1.Size = new System.Drawing.Size(41, 42);
            this.label1.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.label1.TabIndex = 37;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProximity
            // 
            this.btnProximity.BackColor = System.Drawing.Color.Black;
            this.btnProximity.Blink = true;
            this.btnProximity.BlinkInterval = 500;
            this.btnProximity.BlinkState = false;
            this.btnProximity.ChangeOnHover = false;
            this.btnProximity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximity.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnProximity.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnProximity.ForeColor = System.Drawing.Color.White;
            this.btnProximity.Function = Streambolics.Lcars.Function.Secondary;
            this.btnProximity.InAlert = false;
            this.btnProximity.LeftSegments = 0;
            this.btnProximity.Location = new System.Drawing.Point(630, 313);
            this.btnProximity.Name = "btnProximity";
            this.btnProximity.NodeID = ((byte)(255));
            this.btnProximity.Online = true;
            this.btnProximity.RightSegments = 0;
            this.btnProximity.RoundedLeft = true;
            this.btnProximity.RoundedRight = true;
            this.btnProximity.Size = new System.Drawing.Size(104, 42);
            this.btnProximity.SoundFile = "Resources/Beep.wav";
            this.btnProximity.SoundRepeatTimes = 1;
            this.btnProximity.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnProximity.TabIndex = 36;
            this.btnProximity.Text = "PROXIMITY";
            this.btnProximity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeck2Breach
            // 
            this.btnDeck2Breach.BackColor = System.Drawing.Color.Black;
            this.btnDeck2Breach.Blink = true;
            this.btnDeck2Breach.BlinkInterval = 500;
            this.btnDeck2Breach.BlinkState = false;
            this.btnDeck2Breach.ChangeOnHover = false;
            this.btnDeck2Breach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeck2Breach.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeck2Breach.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnDeck2Breach.ForeColor = System.Drawing.Color.White;
            this.btnDeck2Breach.Function = Streambolics.Lcars.Function.Secondary;
            this.btnDeck2Breach.InAlert = false;
            this.btnDeck2Breach.LeftSegments = 0;
            this.btnDeck2Breach.Location = new System.Drawing.Point(630, 265);
            this.btnDeck2Breach.Name = "btnDeck2Breach";
            this.btnDeck2Breach.NodeID = ((byte)(21));
            this.btnDeck2Breach.Online = true;
            this.btnDeck2Breach.RightSegments = 0;
            this.btnDeck2Breach.RoundedLeft = true;
            this.btnDeck2Breach.RoundedRight = true;
            this.btnDeck2Breach.Size = new System.Drawing.Size(104, 42);
            this.btnDeck2Breach.SoundFile = "Resources/Beep.wav";
            this.btnDeck2Breach.SoundRepeatTimes = 1;
            this.btnDeck2Breach.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnDeck2Breach.TabIndex = 35;
            this.btnDeck2Breach.Text = "DECK 2 BREACH";
            this.btnDeck2Breach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeck2Breach.Click += new System.EventHandler(this.btnDeck2Breach_Click);
            // 
            // btnDeck2Motion
            // 
            this.btnDeck2Motion.BackColor = System.Drawing.Color.Black;
            this.btnDeck2Motion.Blink = true;
            this.btnDeck2Motion.BlinkInterval = 500;
            this.btnDeck2Motion.BlinkState = false;
            this.btnDeck2Motion.ChangeOnHover = false;
            this.btnDeck2Motion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeck2Motion.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeck2Motion.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnDeck2Motion.ForeColor = System.Drawing.Color.White;
            this.btnDeck2Motion.Function = Streambolics.Lcars.Function.Secondary;
            this.btnDeck2Motion.InAlert = false;
            this.btnDeck2Motion.LeftSegments = 0;
            this.btnDeck2Motion.Location = new System.Drawing.Point(630, 217);
            this.btnDeck2Motion.Name = "btnDeck2Motion";
            this.btnDeck2Motion.NodeID = ((byte)(14));
            this.btnDeck2Motion.Online = true;
            this.btnDeck2Motion.RightSegments = 0;
            this.btnDeck2Motion.RoundedLeft = true;
            this.btnDeck2Motion.RoundedRight = true;
            this.btnDeck2Motion.Size = new System.Drawing.Size(104, 42);
            this.btnDeck2Motion.SoundFile = "Resources/Beep.wav";
            this.btnDeck2Motion.SoundRepeatTimes = 1;
            this.btnDeck2Motion.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnDeck2Motion.TabIndex = 34;
            this.btnDeck2Motion.Text = "DECK 2 MOTION";
            this.btnDeck2Motion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeck2Motion.Click += new System.EventHandler(this.btnDeck2Motion_Click);
            // 
            // btnDeck1Breach
            // 
            this.btnDeck1Breach.BackColor = System.Drawing.Color.Black;
            this.btnDeck1Breach.Blink = true;
            this.btnDeck1Breach.BlinkInterval = 500;
            this.btnDeck1Breach.BlinkState = false;
            this.btnDeck1Breach.ChangeOnHover = false;
            this.btnDeck1Breach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeck1Breach.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeck1Breach.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnDeck1Breach.ForeColor = System.Drawing.Color.White;
            this.btnDeck1Breach.Function = Streambolics.Lcars.Function.Secondary;
            this.btnDeck1Breach.InAlert = false;
            this.btnDeck1Breach.LeftSegments = 0;
            this.btnDeck1Breach.Location = new System.Drawing.Point(630, 169);
            this.btnDeck1Breach.Name = "btnDeck1Breach";
            this.btnDeck1Breach.NodeID = ((byte)(22));
            this.btnDeck1Breach.Online = true;
            this.btnDeck1Breach.RightSegments = 0;
            this.btnDeck1Breach.RoundedLeft = true;
            this.btnDeck1Breach.RoundedRight = true;
            this.btnDeck1Breach.Size = new System.Drawing.Size(104, 42);
            this.btnDeck1Breach.SoundFile = "Resources/Beep.wav";
            this.btnDeck1Breach.SoundRepeatTimes = 1;
            this.btnDeck1Breach.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnDeck1Breach.TabIndex = 33;
            this.btnDeck1Breach.Text = "DECK 1 BREACH";
            this.btnDeck1Breach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeck1Breach.Click += new System.EventHandler(this.btnDeck1Breach_Click);
            // 
            // btnDeck1Motion
            // 
            this.btnDeck1Motion.BackColor = System.Drawing.Color.Black;
            this.btnDeck1Motion.Blink = true;
            this.btnDeck1Motion.BlinkInterval = 500;
            this.btnDeck1Motion.BlinkState = false;
            this.btnDeck1Motion.ChangeOnHover = false;
            this.btnDeck1Motion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeck1Motion.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeck1Motion.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnDeck1Motion.ForeColor = System.Drawing.Color.White;
            this.btnDeck1Motion.Function = Streambolics.Lcars.Function.Secondary;
            this.btnDeck1Motion.InAlert = false;
            this.btnDeck1Motion.LeftSegments = 0;
            this.btnDeck1Motion.Location = new System.Drawing.Point(630, 121);
            this.btnDeck1Motion.Name = "btnDeck1Motion";
            this.btnDeck1Motion.NodeID = ((byte)(20));
            this.btnDeck1Motion.Online = true;
            this.btnDeck1Motion.RightSegments = 0;
            this.btnDeck1Motion.RoundedLeft = true;
            this.btnDeck1Motion.RoundedRight = true;
            this.btnDeck1Motion.Size = new System.Drawing.Size(104, 42);
            this.btnDeck1Motion.SoundFile = "Resources/Beep.wav";
            this.btnDeck1Motion.SoundRepeatTimes = 1;
            this.btnDeck1Motion.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnDeck1Motion.TabIndex = 32;
            this.btnDeck1Motion.Text = "DECK 1 MOTION";
            this.btnDeck1Motion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Black;
            this.button24.Blink = false;
            this.button24.BlinkInterval = 500;
            this.button24.BlinkState = false;
            this.button24.ChangeOnHover = false;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.button24.Font = new System.Drawing.Font("LCARS", 14F);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Function = Streambolics.Lcars.Function.Ancillary;
            this.button24.InAlert = false;
            this.button24.LeftSegments = 0;
            this.button24.Location = new System.Drawing.Point(437, 121);
            this.button24.Name = "button24";
            this.button24.NodeID = ((byte)(0));
            this.button24.Online = true;
            this.button24.RightSegments = 0;
            this.button24.RoundedLeft = false;
            this.button24.RoundedRight = true;
            this.button24.Size = new System.Drawing.Size(187, 42);
            this.button24.SoundFile = "Resources/Beep.wav";
            this.button24.SoundRepeatTimes = 1;
            this.button24.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.button24.TabIndex = 27;
            this.button24.Text = "PROCESSOR";
            this.button24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRetrans
            // 
            this.btnRetrans.BackColor = System.Drawing.Color.Black;
            this.btnRetrans.Blink = false;
            this.btnRetrans.BlinkInterval = 500;
            this.btnRetrans.BlinkState = false;
            this.btnRetrans.ChangeOnHover = false;
            this.btnRetrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetrans.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnRetrans.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnRetrans.ForeColor = System.Drawing.Color.White;
            this.btnRetrans.Function = Streambolics.Lcars.Function.Secondary;
            this.btnRetrans.InAlert = false;
            this.btnRetrans.LeftSegments = 0;
            this.btnRetrans.Location = new System.Drawing.Point(158, 313);
            this.btnRetrans.Name = "btnRetrans";
            this.btnRetrans.NodeID = ((byte)(0));
            this.btnRetrans.Online = true;
            this.btnRetrans.RightSegments = 0;
            this.btnRetrans.RoundedLeft = true;
            this.btnRetrans.RoundedRight = true;
            this.btnRetrans.Size = new System.Drawing.Size(226, 42);
            this.btnRetrans.SoundFile = "Resources/Beep.wav";
            this.btnRetrans.SoundRepeatTimes = 1;
            this.btnRetrans.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnRetrans.TabIndex = 22;
            this.btnRetrans.Text = "RETRANS";
            this.btnRetrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoLockout
            // 
            this.btnAutoLockout.BackColor = System.Drawing.Color.Black;
            this.btnAutoLockout.Blink = false;
            this.btnAutoLockout.BlinkInterval = 500;
            this.btnAutoLockout.BlinkState = false;
            this.btnAutoLockout.ChangeOnHover = false;
            this.btnAutoLockout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoLockout.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnAutoLockout.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnAutoLockout.ForeColor = System.Drawing.Color.White;
            this.btnAutoLockout.Function = Streambolics.Lcars.Function.Secondary;
            this.btnAutoLockout.InAlert = false;
            this.btnAutoLockout.LeftSegments = 0;
            this.btnAutoLockout.Location = new System.Drawing.Point(158, 265);
            this.btnAutoLockout.Name = "btnAutoLockout";
            this.btnAutoLockout.NodeID = ((byte)(0));
            this.btnAutoLockout.Online = true;
            this.btnAutoLockout.RightSegments = 0;
            this.btnAutoLockout.RoundedLeft = true;
            this.btnAutoLockout.RoundedRight = true;
            this.btnAutoLockout.Size = new System.Drawing.Size(226, 42);
            this.btnAutoLockout.SoundFile = "Resources/Beep.wav";
            this.btnAutoLockout.SoundRepeatTimes = 1;
            this.btnAutoLockout.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnAutoLockout.TabIndex = 19;
            this.btnAutoLockout.Text = "AUTO LOCKOUT";
            this.btnAutoLockout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutoLockout.Click += new System.EventHandler(this.btnAutoLockout_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.BackColor = System.Drawing.Color.Black;
            this.btnInterface.Blink = false;
            this.btnInterface.BlinkInterval = 500;
            this.btnInterface.BlinkState = false;
            this.btnInterface.ChangeOnHover = false;
            this.btnInterface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterface.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnInterface.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnInterface.ForeColor = System.Drawing.Color.White;
            this.btnInterface.Function = Streambolics.Lcars.Function.Secondary;
            this.btnInterface.InAlert = false;
            this.btnInterface.LeftSegments = 0;
            this.btnInterface.Location = new System.Drawing.Point(158, 217);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.NodeID = ((byte)(0));
            this.btnInterface.Online = true;
            this.btnInterface.RightSegments = 0;
            this.btnInterface.RoundedLeft = true;
            this.btnInterface.RoundedRight = true;
            this.btnInterface.Size = new System.Drawing.Size(226, 42);
            this.btnInterface.SoundFile = "Resources/Beep.wav";
            this.btnInterface.SoundRepeatTimes = 1;
            this.btnInterface.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnInterface.TabIndex = 16;
            this.btnInterface.Text = "INTERFACE";
            this.btnInterface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZWave
            // 
            this.btnZWave.BackColor = System.Drawing.Color.Black;
            this.btnZWave.Blink = true;
            this.btnZWave.BlinkInterval = 500;
            this.btnZWave.BlinkState = false;
            this.btnZWave.ChangeOnHover = false;
            this.btnZWave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZWave.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnZWave.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnZWave.ForeColor = System.Drawing.Color.White;
            this.btnZWave.Function = Streambolics.Lcars.Function.Secondary;
            this.btnZWave.InAlert = false;
            this.btnZWave.LeftSegments = 0;
            this.btnZWave.Location = new System.Drawing.Point(158, 169);
            this.btnZWave.Name = "btnZWave";
            this.btnZWave.NodeID = ((byte)(0));
            this.btnZWave.Online = true;
            this.btnZWave.RightSegments = 0;
            this.btnZWave.RoundedLeft = true;
            this.btnZWave.RoundedRight = true;
            this.btnZWave.Size = new System.Drawing.Size(226, 42);
            this.btnZWave.SoundFile = "Resources/Beep.wav";
            this.btnZWave.SoundRepeatTimes = 1;
            this.btnZWave.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnZWave.TabIndex = 13;
            this.btnZWave.Text = "Z WAVE";
            this.btnZWave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZWave.Click += new System.EventHandler(this.btnZWave_Click);
            // 
            // btnVoice
            // 
            this.btnVoice.BackColor = System.Drawing.Color.Black;
            this.btnVoice.Blink = false;
            this.btnVoice.BlinkInterval = 500;
            this.btnVoice.BlinkState = false;
            this.btnVoice.ChangeOnHover = false;
            this.btnVoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoice.ElboOrientation = System.Drawing.ContentAlignment.TopLeft;
            this.btnVoice.Font = new System.Drawing.Font("LCARS", 14F);
            this.btnVoice.ForeColor = System.Drawing.Color.White;
            this.btnVoice.Function = Streambolics.Lcars.Function.Secondary;
            this.btnVoice.InAlert = false;
            this.btnVoice.LeftSegments = 0;
            this.btnVoice.Location = new System.Drawing.Point(158, 121);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.NodeID = ((byte)(0));
            this.btnVoice.Online = true;
            this.btnVoice.RightSegments = 0;
            this.btnVoice.RoundedLeft = true;
            this.btnVoice.RoundedRight = true;
            this.btnVoice.Size = new System.Drawing.Size(226, 42);
            this.btnVoice.SoundFile = "Resources/Beep.wav";
            this.btnVoice.SoundRepeatTimes = 1;
            this.btnVoice.SubFunction = Streambolics.Lcars.SubFunction.Primary;
            this.btnVoice.TabIndex = 10;
            this.btnVoice.Text = "VOICE INPUT";
            this.btnVoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
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
            this.button7.Font = new System.Drawing.Font("LCARS", 14F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Function = Streambolics.Lcars.Function.Secondary;
            this.button7.InAlert = false;
            this.button7.LeftSegments = 0;
            this.button7.Location = new System.Drawing.Point(3, 169);
            this.button7.Name = "button7";
            this.button7.NodeID = ((byte)(0));
            this.button7.Online = true;
            this.button7.RightSegments = 0;
            this.button7.RoundedLeft = false;
            this.button7.RoundedRight = false;
            this.button7.Size = new System.Drawing.Size(149, 186);
            this.button7.SoundFile = "Resources/Beep.wav";
            this.button7.SoundRepeatTimes = 1;
            this.button7.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button7.TabIndex = 8;
            this.button7.Text = "MODE SELECT";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.button6.Font = new System.Drawing.Font("LCARS", 14F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Function = Streambolics.Lcars.Function.Database;
            this.button6.InAlert = false;
            this.button6.LeftSegments = 0;
            this.button6.Location = new System.Drawing.Point(3, 121);
            this.button6.Name = "button6";
            this.button6.NodeID = ((byte)(0));
            this.button6.Online = true;
            this.button6.RightSegments = 0;
            this.button6.RoundedLeft = false;
            this.button6.RoundedRight = false;
            this.button6.Size = new System.Drawing.Size(149, 42);
            this.button6.SoundFile = "Resources/Beep.wav";
            this.button6.SoundRepeatTimes = 1;
            this.button6.SubFunction = Streambolics.Lcars.SubFunction.Color1;
            this.button6.TabIndex = 7;
            this.button6.Text = "RED ALERT";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.button5.Font = new System.Drawing.Font("LCARS", 14F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Function = Streambolics.Lcars.Function.Secondary;
            this.button5.InAlert = false;
            this.button5.LeftSegments = 0;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.NodeID = ((byte)(0));
            this.button5.Online = true;
            this.button5.RightSegments = 0;
            this.button5.RoundedLeft = true;
            this.button5.RoundedRight = false;
            this.button5.Size = new System.Drawing.Size(149, 100);
            this.button5.SoundFile = "Resources/Beep.wav";
            this.button5.SoundRepeatTimes = 1;
            this.button5.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button5.TabIndex = 6;
            this.button5.Text = "ENGINEERING";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.button4.Font = new System.Drawing.Font("LCARS", 14F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Function = Streambolics.Lcars.Function.Secondary;
            this.button4.InAlert = false;
            this.button4.LeftSegments = 0;
            this.button4.Location = new System.Drawing.Point(158, 3);
            this.button4.Name = "button4";
            this.button4.NodeID = ((byte)(0));
            this.button4.Online = true;
            this.button4.RightSegments = 0;
            this.button4.RoundedLeft = false;
            this.button4.RoundedRight = false;
            this.button4.Size = new System.Drawing.Size(226, 100);
            this.button4.SoundFile = "Resources/Beep.wav";
            this.button4.SoundRepeatTimes = 1;
            this.button4.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button4.TabIndex = 5;
            this.button4.Text = "INTERNAL";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.button3.Font = new System.Drawing.Font("LCARS", 14F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Function = Streambolics.Lcars.Function.Secondary;
            this.button3.InAlert = false;
            this.button3.LeftSegments = 0;
            this.button3.Location = new System.Drawing.Point(390, 3);
            this.button3.Name = "button3";
            this.button3.NodeID = ((byte)(0));
            this.button3.Online = true;
            this.button3.RightSegments = 0;
            this.button3.RoundedLeft = false;
            this.button3.RoundedRight = false;
            this.button3.Size = new System.Drawing.Size(234, 100);
            this.button3.SoundFile = "Resources/Beep.wav";
            this.button3.SoundRepeatTimes = 1;
            this.button3.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button3.TabIndex = 4;
            this.button3.Text = "MAIN COMPUTER";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.button2.Font = new System.Drawing.Font("LCARS", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Function = Streambolics.Lcars.Function.Secondary;
            this.button2.InAlert = false;
            this.button2.LeftSegments = 0;
            this.button2.Location = new System.Drawing.Point(630, 3);
            this.button2.Name = "button2";
            this.button2.NodeID = ((byte)(0));
            this.button2.Online = true;
            this.button2.RightSegments = 0;
            this.button2.RoundedLeft = false;
            this.button2.RoundedRight = false;
            this.button2.Size = new System.Drawing.Size(104, 100);
            this.button2.SoundFile = "Resources/Beep.wav";
            this.button2.SoundRepeatTimes = 1;
            this.button2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button2.TabIndex = 3;
            this.button2.Text = "SENSORS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.button1.Function = Streambolics.Lcars.Function.Secondary;
            this.button1.InAlert = false;
            this.button1.LeftSegments = 0;
            this.button1.Location = new System.Drawing.Point(740, 3);
            this.button1.Name = "button1";
            this.button1.NodeID = ((byte)(0));
            this.button1.Online = true;
            this.button1.RightSegments = 0;
            this.button1.RoundedLeft = false;
            this.button1.RoundedRight = false;
            this.button1.Size = new System.Drawing.Size(219, 100);
            this.button1.SoundFile = "Resources/Beep.wav";
            this.button1.SoundRepeatTimes = 1;
            this.button1.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button1.TabIndex = 2;
            this.button1.Text = "EPS GRID";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // elbo1
            // 
            this.elbo1.ArcExternal = 100;
            this.elbo1.ArcInternal = 50;
            this.elbo1.BackColor = System.Drawing.Color.Black;
            this.elbo1.ColWidth = 20;
            this.elbo1.ElboOrientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo1.Font = new System.Drawing.Font("LCARS", 14F);
            this.elbo1.ForeColor = System.Drawing.Color.White;
            this.elbo1.Function = Streambolics.Lcars.Function.Secondary;
            this.elbo1.InAlert = false;
            this.elbo1.Location = new System.Drawing.Point(962, 3);
            this.elbo1.Name = "elbo1";
            this.elbo1.Online = true;
            this.elbo1.Orientation = System.Drawing.ContentAlignment.TopRight;
            this.elbo1.RowHeight = 100;
            this.elbo1.Size = new System.Drawing.Size(59, 359);
            this.elbo1.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo1.TabIndex = 0;
            this.elbo1.Text = "elbo1";
            // 
            // subSystemControls1
            // 
            this.subSystemControls1.BackColor = System.Drawing.Color.Black;
            this.subSystemControls1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subSystemControls1.Location = new System.Drawing.Point(110, 414);
            this.subSystemControls1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subSystemControls1.Name = "subSystemControls1";
            this.subSystemControls1.Size = new System.Drawing.Size(900, 300);
            this.subSystemControls1.TabIndex = 56;
            this.subSystemControls1.Visible = false;
            // 
            // EngineeringScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.subSystemControls1);
            this.Controls.Add(this.elbo3);
            this.Controls.Add(this.btnDiagnostic);
            this.Controls.Add(this.btnAllLightsOff);
            this.Controls.Add(this.btnAllLightsOn);
            this.Controls.Add(this.btnSubSystem);
            this.Controls.Add(this.btnLifeSupport);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.elbo2);
            this.Controls.Add(this.elbo4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximity);
            this.Controls.Add(this.btnDeck2Breach);
            this.Controls.Add(this.btnDeck2Motion);
            this.Controls.Add(this.btnDeck1Breach);
            this.Controls.Add(this.btnDeck1Motion);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.btnRetrans);
            this.Controls.Add(this.btnAutoLockout);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.btnZWave);
            this.Controls.Add(this.btnVoice);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elbo1);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EngineeringScreen";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.EngineeringScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Streambolics.Lcars.Sound sound1;
        private Streambolics.Lcars.Elbo elbo1;
        private Streambolics.Lcars.Button button1;
        private Streambolics.Lcars.Button button2;
        private Streambolics.Lcars.Button button3;
        private Streambolics.Lcars.Button button4;
        private Streambolics.Lcars.Button button5;
        private Streambolics.Lcars.Button button6;
        private Streambolics.Lcars.Button button7;
        private Streambolics.Lcars.Button btnVoice;
        private Streambolics.Lcars.Button btnZWave;
        private Streambolics.Lcars.Button btnInterface;
        private Streambolics.Lcars.Button btnAutoLockout;
        private Streambolics.Lcars.Button btnRetrans;
        private Streambolics.Lcars.Button button24;
        private Streambolics.Lcars.Button btnDeck1Motion;
        private Streambolics.Lcars.Button btnDeck1Breach;
        private Streambolics.Lcars.Button btnDeck2Motion;
        private Streambolics.Lcars.Button btnDeck2Breach;
        private Streambolics.Lcars.Button btnProximity;
        private Streambolics.Lcars.Label label1;
        private Streambolics.Lcars.Label label2;
        private Streambolics.Lcars.Button button8;
        private Streambolics.Lcars.Label label3;
        private Streambolics.Lcars.Button button25;
        private Streambolics.Lcars.Label label4;
        private Streambolics.Lcars.Button button26;
        private Streambolics.Lcars.Label label5;
        private Streambolics.Lcars.Button button27;
        private Streambolics.Lcars.Elbo elbo4;
        private Streambolics.Lcars.Elbo elbo2;
        private Streambolics.Lcars.Button button28;
        private Streambolics.Lcars.Button btnLifeSupport;
        private Streambolics.Lcars.Button btnSubSystem;
        private Streambolics.Lcars.Button btnAllLightsOn;
        private Streambolics.Lcars.Button btnAllLightsOff;
        private Streambolics.Lcars.Button btnDiagnostic;
        private Streambolics.Lcars.Elbo elbo3;
        internal SubSystemControls subSystemControls1;
    }
}
