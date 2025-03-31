using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "1234")
            {
                ManualAditionForm maf = new ManualAditionForm(this);
                Hide();
                maf.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                tbUsername.Clear();
                tbPassword.Clear();
                tbUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool privacyFlag = true;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(privacyFlag == true)
            {
                pictureBox4.Image = Image.FromFile(@"../images/password_privacyOFF.png");
                privacyFlag = false;
            }
            else
            {
                pictureBox4.Image = Image.FromFile(@"../images/password_privacyON.png");
                privacyFlag = true;
            }
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
        }
    }
}
