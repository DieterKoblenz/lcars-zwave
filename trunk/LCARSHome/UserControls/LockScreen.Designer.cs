namespace LCARSHome.UserControls
{
    partial class LockScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new Streambolics.Lcars.Label();
            this.button1 = new Streambolics.Lcars.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.elbo2.Function = Streambolics.Lcars.Function.Secondary;
            this.elbo2.InAlert = false;
            this.elbo2.Location = new System.Drawing.Point(2, 3);
            this.elbo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.elbo2.Name = "elbo2";
            this.elbo2.Online = true;
            this.elbo2.Orientation = System.Drawing.ContentAlignment.TopLeft;
            this.elbo2.RowHeight = 32;
            this.elbo2.Size = new System.Drawing.Size(963, 762);
            this.elbo2.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.elbo2.TabIndex = 4;
            this.elbo2.Text = "elbo2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LCARSHome.Properties.Resources.ufp;
            this.pictureBox1.Location = new System.Drawing.Point(146, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.label1.Location = new System.Drawing.Point(287, 656);
            this.label1.Name = "label1";
            this.label1.Online = true;
            this.label1.RightSegments = 0;
            this.label1.RoundedLeft = false;
            this.label1.RoundedRight = false;
            this.label1.Size = new System.Drawing.Size(558, 72);
            this.label1.SubFunction = Streambolics.Lcars.SubFunction.Color2;
            this.label1.TabIndex = 22;
            this.label1.Text = "COMMAND FUNCTIONS OFFLINE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button1.Location = new System.Drawing.Point(956, 3);
            this.button1.Name = "button1";
            this.button1.Online = true;
            this.button1.RightSegments = 0;
            this.button1.RoundedLeft = false;
            this.button1.RoundedRight = true;
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.SoundFile = "";
            this.button1.SoundRepeatTimes = 1;
            this.button1.SubFunction = Streambolics.Lcars.SubFunction.Elbo;
            this.button1.TabIndex = 23;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.elbo2);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LockScreen";
            this.Size = new System.Drawing.Size(1024, 768);
            this.VisibleChanged += new System.EventHandler(this.LockScreen_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Streambolics.Lcars.Elbo elbo2;
        private Streambolics.Lcars.Sound sound1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Streambolics.Lcars.Button button1;
        public Streambolics.Lcars.Label label1;
    }
}
