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
    public partial class GameForm : Form
    {
        Form parent;
        public GameForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
