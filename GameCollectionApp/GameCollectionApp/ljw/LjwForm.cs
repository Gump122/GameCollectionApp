using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.ljw
{
    public partial class LjwForm : Form
    {
        private Form parent;
        public LjwForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        private void LjwForm_Load(object sender, EventArgs e)
        {

        }

        private void LjwForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (port1.Text == "")
                return;
            Program program = new Program();
            MessageBox.Show("waiting for connecting...");
            if (program.createGame(Convert.ToInt32(this.port1.Text)))
            {
                new GameForm(parent).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            if (port2.Text == "" || ip2.Text == "") 
                return;
            Program program = new Program();
            MessageBox.Show("connecting...");
            if (program.joinGame(ip2.Text, Convert.ToInt32(port2.Text)))
            {
                new GameForm(parent).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }
    }
}
