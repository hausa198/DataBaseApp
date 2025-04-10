using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class LogInForm : Form
    {
        // Constructor for the LogInForm
        public LogInForm()
        {
            InitializeComponent();
        }

        // Event which checks if the inputted username and password are correct and then if so,
        // opens the ProcessingForm
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "1234")
            {
                ProcessingForm pf = new ProcessingForm(this);
                Hide();
                pf.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                tbUsername.Clear();
                tbPassword.Clear();
                tbUsername.Focus();
            }
        }

        // Event which clears the fields and sets the focus to the username field
        private void label2_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbUsername.Focus();
        }

        // Event which closes the application
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Flag to check if the password is visible or not
        private bool privacyFlag = true;

        // Event which changes the visibility of the password
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(privacyFlag == true)
            {
                pictureBox4.Image = Image.FromFile(@"../Debug/images/password_privateOFF.png");
                privacyFlag = false;
            }
            else
            {
                pictureBox4.Image = Image.FromFile(@"../Debug/images/password_privateON.png");
                privacyFlag = true;
            }
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
        }

        // Event that clears the fields and sets the focus to the username field when the form is activated
        private void LogInForm_Activated(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbUsername.Focus();
        }
    }
}
