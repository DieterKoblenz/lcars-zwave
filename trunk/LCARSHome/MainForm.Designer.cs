namespace LCARSHome
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sound1 = new Streambolics.Lcars.Sound();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.securityScreen1 = new LCARSHome.UserControls.SecurityScreen();
            this.communicationScreen1 = new LCARSHome.UserControls.CommunicationScreen();
            this.commandCodesScreen1 = new LCARSHome.UserControls.CommandCodesScreen();
            this.homeScreen1 = new LCARSHome.UserControls.HomeScreen();
            this.lockScreen1 = new LCARSHome.UserControls.LockScreen();
            this.engineeringScreen1 = new LCARSHome.UserControls.EngineeringScreen();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // securityScreen1
            // 
            this.securityScreen1.BackColor = System.Drawing.Color.Black;
            this.securityScreen1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityScreen1.Location = new System.Drawing.Point(0, 2);
            this.securityScreen1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.securityScreen1.Name = "securityScreen1";
            this.securityScreen1.Size = new System.Drawing.Size(1025, 768);
            this.securityScreen1.TabIndex = 4;
            this.securityScreen1.Visible = false;
            this.securityScreen1.Load += new System.EventHandler(this.securityScreen1_Load);
            // 
            // communicationScreen1
            // 
            this.communicationScreen1.BackColor = System.Drawing.Color.Black;
            this.communicationScreen1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.communicationScreen1.Location = new System.Drawing.Point(0, 2);
            this.communicationScreen1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.communicationScreen1.Name = "communicationScreen1";
            this.communicationScreen1.Size = new System.Drawing.Size(1024, 768);
            this.communicationScreen1.TabIndex = 3;
            this.communicationScreen1.Visible = false;
            // 
            // commandCodesScreen1
            // 
            this.commandCodesScreen1.BackColor = System.Drawing.Color.Black;
            this.commandCodesScreen1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCodesScreen1.FromScreen = LCARSHome.Screen.HomeScreen;
            this.commandCodesScreen1.Location = new System.Drawing.Point(0, 2);
            this.commandCodesScreen1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.commandCodesScreen1.Name = "commandCodesScreen1";
            this.commandCodesScreen1.PendingStatus = LCARSHome.Status.NotAStatus;
            this.commandCodesScreen1.Size = new System.Drawing.Size(1025, 768);
            this.commandCodesScreen1.TabIndex = 2;
            this.commandCodesScreen1.ToScreen = LCARSHome.Screen.HomeScreen;
            this.commandCodesScreen1.Visible = false;
            // 
            // homeScreen1
            // 
            this.homeScreen1.BackColor = System.Drawing.Color.Black;
            this.homeScreen1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScreen1.Location = new System.Drawing.Point(0, 2);
            this.homeScreen1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(1025, 768);
            this.homeScreen1.TabIndex = 1;
            this.homeScreen1.Visible = false;
            // 
            // lockScreen1
            // 
            this.lockScreen1.BackColor = System.Drawing.Color.Black;
            this.lockScreen1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockScreen1.Location = new System.Drawing.Point(6, 2);
            this.lockScreen1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lockScreen1.Name = "lockScreen1";
            this.lockScreen1.Size = new System.Drawing.Size(1026, 768);
            this.lockScreen1.TabIndex = 0;
            this.lockScreen1.Visible = false;
            // 
            // engineeringScreen1
            // 
            this.engineeringScreen1.BackColor = System.Drawing.Color.Black;
            this.engineeringScreen1.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineeringScreen1.Location = new System.Drawing.Point(0, 2);
            this.engineeringScreen1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.engineeringScreen1.Name = "engineeringScreen1";
            this.engineeringScreen1.Size = new System.Drawing.Size(1024, 768);
            this.engineeringScreen1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.engineeringScreen1);
            this.Controls.Add(this.securityScreen1);
            this.Controls.Add(this.communicationScreen1);
            this.Controls.Add(this.commandCodesScreen1);
            this.Controls.Add(this.homeScreen1);
            this.Controls.Add(this.lockScreen1);
            this.Font = new System.Drawing.Font("LCARS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "LCARS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        internal UserControls.HomeScreen homeScreen1;
        internal UserControls.LockScreen lockScreen1;
        internal UserControls.CommandCodesScreen commandCodesScreen1;
        internal UserControls.CommunicationScreen communicationScreen1;
        internal UserControls.SecurityScreen securityScreen1;
        internal Streambolics.Lcars.Sound sound1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControls.EngineeringScreen engineeringScreen1;




    }
}

