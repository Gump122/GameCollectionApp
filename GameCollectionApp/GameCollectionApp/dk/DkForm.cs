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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        public void fresh()
        {

        }
    }
}
