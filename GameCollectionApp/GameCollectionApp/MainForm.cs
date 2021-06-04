using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }

        private void dkButton_Click(object sender, EventArgs e)
        {
            new dk.DkForm(this).Show();
            Hide();
        }

        private void ljwButton_Click(object sender, EventArgs e)
        {
            new ljw.LjwForm(this).Show();
            Hide();
        }

        private void xcButton_Click(object sender, EventArgs e)
        {
            new xc.XcForm(this).Show();
            Hide();
        }

        private void swButton_Click(object sender, EventArgs e)
        {
            new sw.SwForm(this).Show();
            Hide();
        }
    }
}
