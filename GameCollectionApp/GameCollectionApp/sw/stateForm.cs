using HeroGame;
using System;
using System.Windows.Forms;

namespace GameCollectionApp.sw
{
    public partial class stateForm : Form
    {
        Hero hero;
        public stateForm(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
            bindstates();
        }

        //数据传递绑定
        public void bindstates()
        {
            herovalues.DataBindings.Clear();
            heroequipment1.DataBindings.Clear();
            heroequipment2.DataBindings.Clear();
            heroequipment3.DataBindings.Clear();
            heroequipment4.DataBindings.Clear();
            heroequipment5.DataBindings.Clear();
            heroequipment6.DataBindings.Clear();
            herovalues.DataBindings.Add("Text", hero, "Herointroduce");
            heroequipment1.DataBindings.Add("Text", hero.Equipments[0], "Equipmentintroduce");
            heroequipment2.DataBindings.Add("Text", hero.Equipments[1], "Equipmentintroduce");
            heroequipment3.DataBindings.Add("Text", hero.Equipments[2], "Equipmentintroduce");
            heroequipment4.DataBindings.Add("Text", hero.Equipments[3], "Equipmentintroduce");
            heroequipment5.DataBindings.Add("Text", hero.Equipments[4], "Equipmentintroduce");
            heroequipment6.DataBindings.Add("Text", hero.Equipments[5], "Equipmentintroduce");
        }

        //出售装备
        private void sell1_Click(object sender, EventArgs e)
        {
            bool a = hero.sellEquipment(hero.Equipments[0]);
            if (a) { hero.Equipments[0] = hero.wu;  }
        }

        private void sell2_Click(object sender, EventArgs e)
        {
            bool a = hero.sellEquipment(hero.Equipments[1]);
            if (a) { hero.Equipments[1] = hero.wu;  }
        }

        private void sell3_Click(object sender, EventArgs e)
        {
            bool a = hero.sellEquipment(hero.Equipments[2]);
            if (a) { hero.Equipments[2] = hero.wu;  }
        }

        private void sell4_Click(object sender, EventArgs e)
        {
            bool a = hero.sellEquipment(hero.Equipments[3]);
            if (a) { hero.Equipments[3] = hero.wu;  }
        }

        private void sell5_Click(object sender, EventArgs e)
        {
            bool a = hero.sellEquipment(hero.Equipments[4]);
            if (a) { hero.Equipments[4] = hero.wu;  }
        }

        private void sell6_Click(object sender, EventArgs e)
        {
            bool a = hero.sellEquipment(hero.Equipments[5]);
            if (a) { hero.Equipments[5] = hero.wu;  }
        }

        //更新英雄状态
        private void updatestate_Click(object sender, EventArgs e)
        {
            hero.clearbeforeupdate();
            hero.updateherostate();
            bindstates();
        }


    }
}
