using System;
using System.Windows.Forms;

namespace GameCollectionApp.sw
{
    public partial class settingForm : Form
    {
        private int initmoney;
        private int inithp;
        private int initad;
        private int initap;
        private int initarmor;
        private int initmagicResistance;
        SwForm parent;
        public settingForm(SwForm parent)
        {
            InitializeComponent();            
            this.parent = parent;
            initmoney = parent.Initmoney;
            inithp = parent.Inithp;
            initad = parent.Initad;
            initap = parent.Initap;
            initarmor = parent.Initarmor;
            initmagicResistance = parent.InitmagicResistance;
            initial();
        }

        //初始化选项的值
        public void initial()
        {
            setmoney.Value = initmoney;
            sethp.Value = inithp;
            setad.Value = initad;
            setap.Value = initap;
            setarmor.Value = initarmor;
            setmagicResistance.Value = initmagicResistance;
        }

        private void setmoney_ValueChanged(object sender, EventArgs e)
        {           
            parent.Initmoney = (int)setmoney.Value;
        }
        private void resetmoney_Click(object sender, EventArgs e)
        {
            parent.Initmoney = initmoney;
            setmoney.Value = initmoney;
        }

        private void sethp_ValueChanged(object sender, EventArgs e)
        {
            parent.Inithp = (int)sethp.Value;
        }

        private void resethp_Click(object sender, EventArgs e)
        {
            parent.Inithp = inithp;
            sethp.Value = inithp;
        }

        private void setad_ValueChanged(object sender, EventArgs e)
        {
            parent.Initad = (int)setad.Value;
        }

        private void resetad_Click(object sender, EventArgs e)
        {
            parent.Initad = initad;
            setad.Value = initad;
        }

        private void setap_ValueChanged(object sender, EventArgs e)
        {
            parent.Initap = (int)setap.Value;
        }

        private void resetap_Click(object sender, EventArgs e)
        {
            parent.Initap = initap;
            setap.Value = initap;
        }

        private void setarmor_ValueChanged(object sender, EventArgs e)
        {
            parent.Initarmor = (int)setarmor.Value;
        }

        private void resetarmor_Click(object sender, EventArgs e)
        {
            parent.Initarmor = initarmor;
            setarmor.Value = initarmor;
        }

        private void setmagicResistance_ValueChanged(object sender, EventArgs e)
        {
            parent.InitmagicResistance = (int)setmagicResistance.Value;
        }

        private void resetmagicResistance_Click(object sender, EventArgs e)
        {
            parent.InitmagicResistance = initmagicResistance;
            setmagicResistance.Value = initmagicResistance;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
