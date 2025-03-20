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
            ManualAditionForm maf = new ManualAditionForm(this);
            Hide();
            maf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManualDeletionForm mad = new ManualDeletionForm(this);
            Hide();
            mad.Show();
        }
    }
}
