using System;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;

namespace LoginSignUpApplication
{
    public partial class Form1 : Form
    {
       
       
        //Instance variables to keep track which state is active
        bool loginLabelActive = false;
        bool signUpLabelActive = false;
       
        public Form1()
        {
            InitializeComponent();
                 
            loginLabelActive = true;
            signUpPanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void loginLabel_Click(object sender, EventArgs e)
        {
            if (!loginLabelActive)          //if login is not already active
            {
                //Move the signUp label a little bit to the right
                while (!(signUpLabel.Location.X == 375))
                {
                    signUpLabel.Location = new Point(signUpLabel.Location.X + 1, 9);
                    //Refresh();
                }

                //Bring the loginLabel back to the original position
                
                while (!(loginLabel.Location.X == 194))
                {
                    loginLabel.Location = new Point(loginLabel.Location.X + 1, 9);
                    //Refresh();
                }

                //Set the signUpLabel color to inactive color
                signUpLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a1b4b4");

                //Change the location of slider panel to bring it below loginLabel
                sliderPanel.Location = new Point(369,31);

                while (!(sliderPanel.Location.X==185))
                {
                    sliderPanel.Location = new Point(sliderPanel.Location.X - 1, 31);
                    //Refresh();
                }

                //Change the state variables
                signUpLabelActive = false;
                loginLabelActive = true;

                //Set the loginLabel color to active color
                loginLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#c8dfed");

                //Set the loginPanel to visible and signUp panel to Invisible
                loginPanel.Visible = true;
                signUpPanel.Visible = false;
            }
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            if (!signUpLabelActive)
            {
                //Move the logIn label a little bit to the left
                while (!(loginLabel.Location.X == 188))
                {
                    loginLabel.Location = new Point(loginLabel.Location.X - 1, 9);
                    //Refresh();
                }

                //Bring the signUpLabel back to the current position
                while (!(signUpLabel.Location.X == 369))
                {
                    signUpLabel.Location = new Point(signUpLabel.Location.X - 1, 9);
                    //Refresh();
                }

                //Set the logInLabel color to inactive color
                loginLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a1b4b4");

                //Change the location of slider panel to bring it below signUpLabel
                sliderPanel.Location = new Point(185, 31);

                while (!(sliderPanel.Location.X == 369))
                {
                    sliderPanel.Location = new Point(sliderPanel.Location.X + 1, 31);
                    //Refresh();
                }

                //Change the state variables
                signUpLabelActive = true;
                loginLabelActive = false;

                //Set the signUpLabel color to active color
                signUpLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#c8dfed");

                //Set the loginPanel to Invisible and signUp panel to visible
                loginPanel.Visible = false;
                signUpPanel.Visible = true;

            }

        }

        //Function to check if the email format is valid or not
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        #region LogIn Button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Check if the user details are valid

            String email = EMailTextBox.Text;
            if (!IsValidEmail(email))
                MessageBox.Show("Invalid Email");  


        }
        #endregion

        #region passwordTextBoxClicks
        //Functions to enter password characters as * and alert if the Caps Lock is on 
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void PasswordTextBox2_Click(object sender, EventArgs e)
        {
            PasswordTextBox2.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void ConfPassBox_Click(object sender, EventArgs e)
        {
            ConfPassBox.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        #endregion

        #region continueButton
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(EMailTextBox2.Text))
                MessageBox.Show("Invalid Email");
            else if (!PasswordTextBox2.Text.Equals(ConfPassBox.Text))
                MessageBox.Show("Password do not match");
            else
            {
                Console.WriteLine("Valid");
            }
        }
        #endregion
    }
}