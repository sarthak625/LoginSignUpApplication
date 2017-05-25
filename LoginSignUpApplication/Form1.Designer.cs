namespace LoginSignUpApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginLabel = new MetroFramework.Controls.MetroLabel();
            this.signUpLabel = new MetroFramework.Controls.MetroLabel();
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.loginPanel = new ns1.BunifuGradientPanel();
            this.LoginButton = new ns1.BunifuThinButton2();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.EMailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EMailLabel = new MetroFramework.Controls.MetroLabel();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.ContinueButton = new ns1.BunifuThinButton2();
            this.ConfPassBox = new MetroFramework.Controls.MetroTextBox();
            this.ConfPassLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel2 = new MetroFramework.Controls.MetroLabel();
            this.EMailTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.EMailLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.loginPanel.SuspendLayout();
            this.signUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.CustomBackground = true;
            this.loginLabel.CustomForeColor = true;
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.loginLabel.Location = new System.Drawing.Point(194, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 19);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            this.loginLabel.UseStyleColors = true;
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.CustomBackground = true;
            this.signUpLabel.CustomForeColor = true;
            this.signUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.signUpLabel.Location = new System.Drawing.Point(375, 9);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(55, 19);
            this.signUpLabel.TabIndex = 1;
            this.signUpLabel.Text = "Sign Up";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.sliderPanel.Location = new System.Drawing.Point(185, 31);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(60, 3);
            this.sliderPanel.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.loginPanel;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPanel.BackgroundImage")));
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.LoginButton);
            this.loginPanel.Controls.Add(this.PasswordTextBox);
            this.loginPanel.Controls.Add(this.PasswordLabel);
            this.loginPanel.Controls.Add(this.EMailTextBox);
            this.loginPanel.Controls.Add(this.EMailLabel);
            this.loginPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.loginPanel.GradientBottomRight = System.Drawing.Color.White;
            this.loginPanel.GradientTopLeft = System.Drawing.Color.White;
            this.loginPanel.GradientTopRight = System.Drawing.Color.White;
            this.loginPanel.Location = new System.Drawing.Point(116, 63);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Quality = 100;
            this.loginPanel.Size = new System.Drawing.Size(206, 187);
            this.loginPanel.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.LoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.LoginButton.IdleForecolor = System.Drawing.Color.White;
            this.LoginButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.LoginButton.Location = new System.Drawing.Point(92, 127);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 42);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.PasswordTextBox.CustomBackground = true;
            this.PasswordTextBox.CustomForeColor = true;
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Location = new System.Drawing.Point(19, 96);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.CustomForeColor = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.PasswordLabel.Location = new System.Drawing.Point(19, 74);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 19);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.UseStyleColors = true;
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.EMailTextBox.CustomBackground = true;
            this.EMailTextBox.CustomForeColor = true;
            this.EMailTextBox.Location = new System.Drawing.Point(19, 37);
            this.EMailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 3, 3);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(153, 23);
            this.EMailTextBox.TabIndex = 1;
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.CustomForeColor = true;
            this.EMailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EMailLabel.Location = new System.Drawing.Point(19, 15);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(47, 19);
            this.EMailLabel.TabIndex = 0;
            this.EMailLabel.Text = "E-Mail";
            this.EMailLabel.UseStyleColors = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.Color.White;
            this.signUpPanel.Controls.Add(this.metroLabel1);
            this.signUpPanel.Controls.Add(this.NameTextBox);
            this.signUpPanel.Controls.Add(this.ContinueButton);
            this.signUpPanel.Controls.Add(this.ConfPassBox);
            this.signUpPanel.Controls.Add(this.ConfPassLabel);
            this.signUpPanel.Controls.Add(this.PasswordTextBox2);
            this.signUpPanel.Controls.Add(this.PasswordLabel2);
            this.signUpPanel.Controls.Add(this.EMailTextBox2);
            this.signUpPanel.Controls.Add(this.EMailLabel2);
            this.signUpPanel.Location = new System.Drawing.Point(295, 45);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(222, 289);
            this.signUpPanel.TabIndex = 4;
            // 
            // ContinueButton
            // 
            this.ContinueButton.ActiveBorderThickness = 1;
            this.ContinueButton.ActiveCornerRadius = 20;
            this.ContinueButton.ActiveFillColor = System.Drawing.Color.White;
            this.ContinueButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.ContinueButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.ContinueButton.BackColor = System.Drawing.Color.White;
            this.ContinueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContinueButton.BackgroundImage")));
            this.ContinueButton.ButtonText = "Continue";
            this.ContinueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ContinueButton.IdleBorderThickness = 2;
            this.ContinueButton.IdleCornerRadius = 20;
            this.ContinueButton.IdleFillColor = System.Drawing.Color.White;
            this.ContinueButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.ContinueButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.ContinueButton.Location = new System.Drawing.Point(80, 234);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(121, 37);
            this.ContinueButton.TabIndex = 7;
            this.ContinueButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ConfPassBox
            // 
            this.ConfPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ConfPassBox.CustomBackground = true;
            this.ConfPassBox.CustomForeColor = true;
            this.ConfPassBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConfPassBox.Location = new System.Drawing.Point(16, 200);
            this.ConfPassBox.Name = "ConfPassBox";
            this.ConfPassBox.Size = new System.Drawing.Size(167, 23);
            this.ConfPassBox.TabIndex = 6;
            // 
            // ConfPassLabel
            // 
            this.ConfPassLabel.AutoSize = true;
            this.ConfPassLabel.CustomForeColor = true;
            this.ConfPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ConfPassLabel.Location = new System.Drawing.Point(16, 178);
            this.ConfPassLabel.Name = "ConfPassLabel";
            this.ConfPassLabel.Size = new System.Drawing.Size(151, 19);
            this.ConfPassLabel.TabIndex = 5;
            this.ConfPassLabel.Text = "Confirm Phone Number";
            this.ConfPassLabel.UseStyleColors = true;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.PasswordTextBox2.CustomBackground = true;
            this.PasswordTextBox2.CustomForeColor = true;
            this.PasswordTextBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox2.Location = new System.Drawing.Point(16, 142);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.Size = new System.Drawing.Size(167, 23);
            this.PasswordTextBox2.TabIndex = 4;
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.CustomForeColor = true;
            this.PasswordLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.PasswordLabel2.Location = new System.Drawing.Point(16, 120);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(99, 19);
            this.PasswordLabel2.TabIndex = 3;
            this.PasswordLabel2.Text = "Phone Number";
            this.PasswordLabel2.UseStyleColors = true;
            // 
            // EMailTextBox2
            // 
            this.EMailTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.EMailTextBox2.CustomBackground = true;
            this.EMailTextBox2.CustomForeColor = true;
            this.EMailTextBox2.Location = new System.Drawing.Point(16, 88);
            this.EMailTextBox2.Name = "EMailTextBox2";
            this.EMailTextBox2.Size = new System.Drawing.Size(167, 23);
            this.EMailTextBox2.TabIndex = 2;
            // 
            // EMailLabel2
            // 
            this.EMailLabel2.AutoSize = true;
            this.EMailLabel2.CustomForeColor = true;
            this.EMailLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EMailLabel2.Location = new System.Drawing.Point(16, 66);
            this.EMailLabel2.Name = "EMailLabel2";
            this.EMailLabel2.Size = new System.Drawing.Size(47, 19);
            this.EMailLabel2.TabIndex = 1;
            this.EMailLabel2.Text = "E-Mail";
            this.EMailLabel2.UseStyleColors = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.signUpPanel;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(212, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 195);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.panel2.Location = new System.Drawing.Point(225, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 209);
            this.panel2.TabIndex = 9;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.NameTextBox.CustomBackground = true;
            this.NameTextBox.CustomForeColor = true;
            this.NameTextBox.Location = new System.Drawing.Point(16, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(167, 23);
            this.NameTextBox.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.metroLabel1.Location = new System.Drawing.Point(16, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(601, 363);
            this.Controls.Add(this.signUpPanel);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel loginLabel;
        private MetroFramework.Controls.MetroLabel signUpLabel;
        private System.Windows.Forms.Panel sliderPanel;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuGradientPanel loginPanel;
        private MetroFramework.Controls.MetroLabel EMailLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox EMailTextBox;
        private ns1.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel signUpPanel;
        private ns1.BunifuElipse bunifuElipse3;
        private ns1.BunifuThinButton2 LoginButton;
        private ns1.BunifuThinButton2 ContinueButton;
        private MetroFramework.Controls.MetroTextBox ConfPassBox;
        private MetroFramework.Controls.MetroLabel ConfPassLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox2;
        private MetroFramework.Controls.MetroLabel PasswordLabel2;
        private MetroFramework.Controls.MetroTextBox EMailTextBox2;
        private MetroFramework.Controls.MetroLabel EMailLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
    }
}

