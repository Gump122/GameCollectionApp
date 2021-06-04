﻿using System;
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
    }
}