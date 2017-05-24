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

            }

        }

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

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
    }
}