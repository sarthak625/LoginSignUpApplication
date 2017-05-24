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
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.EMailLabel = new MetroFramework.Controls.MetroLabel();
            this.EMailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
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
            this.bunifuElipse1.TargetControl = this.bunifuGradientPanel1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.LoginButton);
            this.bunifuGradientPanel1.Controls.Add(this.PasswordTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.PasswordLabel);
            this.bunifuGradientPanel1.Controls.Add(this.EMailTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.EMailLabel);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(140, 53);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 100;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(206, 187);
            this.bunifuGradientPanel1.TabIndex = 3;
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
            // EMailTextBox
            // 
            this.EMailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.EMailTextBox.CustomBackground = true;
            this.EMailTextBox.CustomForeColor = true;
            this.EMailTextBox.Location = new System.Drawing.Point(19, 37);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(153, 23);
            this.EMailTextBox.TabIndex = 1;
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
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.PasswordTextBox.CustomBackground = true;
            this.PasswordTextBox.CustomForeColor = true;
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Location = new System.Drawing.Point(19, 96);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(98)))));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(79, 134);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(93, 29);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.LoginButton;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(601, 363);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel loginLabel;
        private MetroFramework.Controls.MetroLabel signUpLabel;
        private System.Windows.Forms.Panel sliderPanel;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private MetroFramework.Controls.MetroLabel EMailLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox EMailTextBox;
        private System.Windows.Forms.Button LoginButton;
        private ns1.BunifuElipse bunifuElipse2;
    }
}

