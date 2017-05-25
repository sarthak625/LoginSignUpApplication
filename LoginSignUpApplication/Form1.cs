using System;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using Finisar.SQLite;
using Firebase.Database;

namespace LoginSignUpApplication
{
    public partial class Form1 : Form
    {
        //Instance variables to keep track which state is active
        bool loginLabelActive = false;
        bool signUpLabelActive = false;

        //Instance variables for DB Connectivity
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCmd;
        private SQLiteDataAdapter DBAdapter;
       
       
        public Form1()
        {
            InitializeComponent();
                 
            loginLabelActive = true;
            signUpPanel.Visible = false;
            panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void loginLabel_Click(object sender, EventArgs e)
        {
            //Empty any previous entries
            EMailTextBox.Text = "";
            PasswordTextBox.Text = "";
            
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
                    panel2.Location = new Point(panel2.Location.X + 1, panel2.Location.Y - 1);
                }

                //Set the signUpLabel color to inactive color
                signUpLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a1b4b4");

                //Change the location of slider panel to bring it below loginLabel
                sliderPanel.Location = new Point(369,31);

                panel1.Location = new Point(212, 83);
                panel1.Visible = true;
                panel2.Visible = false;

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
            //Empty any previous entries
            EMailTextBox2.Text = "";
            PasswordTextBox2.Text = "";
            ConfPassBox.Text = "";
           
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
                    panel1.Location = new Point(panel1.Location.X - 1, panel1.Location.Y + 1);
                }

                //Set the logInLabel color to inactive color
                loginLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#a1b4b4");
                panel1.Visible = false;
                panel2.Visible = true;

                //Change the location of slider panel to bring it below signUpLabel
                sliderPanel.Location = new Point(185, 31);

                panel2.Location = new Point(225, 62);

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
            //Check if fields are not empty
            if (EMailTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("One or more fields are empty!");
                return;
            }
            //Check if the user details are valid

            String email = EMailTextBox.Text;
            if (!IsValidEmail(email))
                MessageBox.Show("Invalid Email");
            else
            {
                //Look up the record in the database
                int result = 0;
                try
                {
                    SetConnection();
                    sqlCon.Open();

                    sqlCmd = sqlCon.CreateCommand();
                    sqlCmd.CommandText = "SELECT * FROM TABLE WHERE emailId='" + EMailTextBox.Text + "' AND password='" + PasswordTextBox.Text + "'";

                    
                    using (SQLiteDataReader reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = reader.GetInt32(0);
                        }
                    }
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
          
                //Show message accordingly
                if (result>0)
                    MessageBox.Show("Welcome!");
                else
                    MessageBox.Show("Wrong email or password!");

            }  


        }
        #endregion

        #region passwordTextBoxClicks
        //Function to enter password characters as * 
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        } 

        #endregion

        #region continueButton
        //Checks if a string is a number or not
        private bool isNumber(String text)
        {
            bool result = false;
            try
            {
                long a = Int64.Parse(text);
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if ((PasswordTextBox2.Text == "") || (ConfPassBox.Text == "") || (EMailTextBox2.Text == "") || (NameTextBox.Text == ""))
                MessageBox.Show("One or more fields are empty.");
            else if (!IsValidEmail(EMailTextBox2.Text))
                MessageBox.Show("Invalid Email"); 
            else if (!PasswordTextBox2.Text.Equals(ConfPassBox.Text))
                MessageBox.Show("Mobile Numbers do not match");
            else if (PasswordTextBox2.Text.Length != 10 && !isNumber(PasswordTextBox2.Text))
                MessageBox.Show("Invalid Mobile Number");
            else
            {
                Console.WriteLine("Valid");

                Boolean succSubmitted = true;

                //Connect to database and store user data
                try
                {
                    int result = 0;
                    string txtSQLQuery = "insert into  userInfo (emailId,password) values ('" + EMailTextBox2.Text + "' , '" + PasswordTextBox2.Text + "')";

                    SetConnection();
                    sqlCon.Open();
                    sqlCmd = sqlCon.CreateCommand();

                    //Check if the email id is already registered
                    sqlCmd.CommandText = "SELECT * FROM TABLE WHERE emailId='" + EMailTextBox.Text + "'";
                    using (SQLiteDataReader reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = reader.GetInt32(0);
                        }
                    }

                    //If it is not registered then proceed with adding the user, else show an error message
                    if (result <= 0)
                        ExecuteQuery(txtSQLQuery);
                    else
                    {
                        MessageBox.Show("The email id is already registered!");
                        succSubmitted = false;
                    }
                }
                catch (Exception ex)
                {
                    succSubmitted = false;
                    MessageBox.Show(ex.ToString());
                }

                //If submitted successfully generate successfully submitted message
                if (succSubmitted)
                {
                    MessageBox.Show("You have successfully signed up!");
                }
                else
                {
                    MessageBox.Show("There was some problem signing you up. Please try again.");
                }

                //Sync the data to Google Firebase
                var firebase = new FirebaseClient("");

               

            }
        }
        #endregion

        //Database Connectivity Functions
        private void SetConnection()
        {
            sqlCon = new SQLiteConnection("Data Source=C:\\userInfo.db;Version=3;New=True;");
        }

        //Function to execute a query
        private void ExecuteQuery(string txtQuery)
        {
            //SetConnection();
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = txtQuery;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}