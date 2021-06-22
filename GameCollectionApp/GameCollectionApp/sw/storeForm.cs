using HeroGame;
using System.Windows.Forms;

namespace GameCollectionApp.sw
{
    public partial class storeForm : Form
    {
        SwForm parent;
        Hero hero = new Hero();
        public storeForm(Hero hero,SwForm parent)
        {
            InitializeComponent();
            this.hero = hero;
            this.parent = parent;
            bindstoreequipments();            
        }

        //数据传递绑定
        public void bindstoreequipments()
        {            
            equipmentintroduce1.DataBindings.Add("Text", Store.store[0], "Equipmentintroduce");
            equipmentintroduce2.DataBindings.Add("Text", Store.store[1], "Equipmentintroduce");
            equipmentintroduce3.DataBindings.Add("Text", Store.store[2], "Equipmentintroduce");
            equipmentintroduce4.DataBindings.Add("Text", Store.store[3], "Equipmentintroduce");
            equipmentintroduce5.DataBindings.Add("Text", Store.store[4], "Equipmentintroduce");
            equipmentintroduce6.DataBindings.Add("Text", Store.store[5], "Equipmentintroduce");
            equipmentintroduce7.DataBindings.Add("Text", Store.store[6], "Equipmentintroduce");
            equipmentintroduce8.DataBindings.Add("Text", Store.store[7], "Equipmentintroduce");
            equipmentintroduce9.DataBindings.Add("Text", Store.store[8], "Equipmentintroduce");
            equipmentintroduce10.DataBindings.Add("Text", Store.store[9], "Equipmentintroduce");
            moneyview.DataBindings.Add("Text", hero, "Money");
        }

        /// <summary>
        /// 购买装备
        /// </summary>
        /// <param name="i">选择的装备项</param>
        public void buyequipment(int i)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[i].Name}？", "提示", mess);
            if (d == DialogResult.OK && Store.store[i].Type == EquipmentType.Normal && hero.Money >= Store.store[i].BuyPrice)
            {
                MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                if (hero.Equipments[0].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[0] = Store.store[i];
                }
                else if (hero.Equipments[1].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[1] = Store.store[i];
                }
                else if (hero.Equipments[2].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[2] = Store.store[i];
                }
                else if (hero.Equipments[3].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[3] = Store.store[i];
                }
                else if (hero.Equipments[4].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[4] = Store.store[i];
                }
                else if (hero.Equipments[5].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[5] = Store.store[i];
                }
                hero.Money -= Store.store[i].BuyPrice;
                hero.updateherostate();
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[i].Type == EquipmentType.Consumables && hero.Money >= Store.store[i].BuyPrice)
            {
                hero.Hp += Store.store[i].Hp;
                hero.AdUp += Store.store[i].AdUp;
                hero.ApUp += Store.store[i].ApUP;
                hero.ArmorUp += Store.store[i].ArmorUp;
                hero.MagicResistanceUp += Store.store[i].MagicResistanceUp;
                MessageBox.Show("购买成功！变强了！");
                hero.updateherostate();
                hero.Money -= Store.store[i].BuyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (d == DialogResult.Cancel) { }
            else if (d == DialogResult.OK && hero.Money < Store.store[i].BuyPrice)
            {
                MessageBox.Show("剩余金钱不足！");
            }
        }

        //购买装备
        private void buy1_Click(object sender, System.EventArgs e)
        {
            buyequipment(0);            
        }
        private void buy2_Click(object sender, System.EventArgs e)
        {
            buyequipment(1);
        }
        private void buy3_Click(object sender, System.EventArgs e)
        {
            buyequipment(2);
        }
        private void buy4_Click(object sender, System.EventArgs e)
        {
            buyequipment(3);
        }
        private void buy5_Click(object sender, System.EventArgs e)
        {
            buyequipment(4);
        }
        private void buy6_Click(object sender, System.EventArgs e)
        {
            buyequipment(5);
        }
        private void buy7_Click(object sender, System.EventArgs e)
        {
            buyequipment(6);
        }
        private void buy8_Click(object sender, System.EventArgs e)
        {
            buyequipment(7);
        }
        private void buy9_Click(object sender, System.EventArgs e)
        {
            buyequipment(8);
        }
        private void buy10_Click(object sender, System.EventArgs e)
        {
            buyequipment(9);
        }

    }
}
