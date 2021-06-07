using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionApp.dk
{
    public partial class DkForm : Form
    {
        private Form parent;
        public DkForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void DkForm_Load(object sender, EventArgs e)
        {
            Program program = new Program();
            program.init(this.fresh);
            program.start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        public void fresh()
        {

        }

        private void card13_Click(object sender, EventArgs e)
        {

        }

        private void card12_Click(object sender, EventArgs e)
        {

        }

        private void card10_Click(object sender, EventArgs e)
        {

        }

        private void card9_Click(object sender, EventArgs e)
        {

        }

        private void card11_Click(object sender, EventArgs e)
        {

        }

        private void card8_Click(object sender, EventArgs e)
        {

        }

        private void card7_Click(object sender, EventArgs e)
        {

        }

        private void card6_Click(object sender, EventArgs e)
        {

        }

        private void card5_Click(object sender, EventArgs e)
        {

        }

        private void card4_Click(object sender, EventArgs e)
        {

        }

        private void card3_Click(object sender, EventArgs e)
        {

        }

        private void card2_Click(object sender, EventArgs e)
        {

        }

        private void card1_Click(object sender, EventArgs e)
        {

        }
    }
}
