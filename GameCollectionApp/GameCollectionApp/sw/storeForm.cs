using HeroGame;
using System.Windows.Forms;

namespace GameCollectionApp.sw
{
    public partial class storeForm : Form
    {
        SwForm parent;
        Hero hero = new Hero();
        Equipment wu = new Equipment("无", 0, 0, 0, 0, 0, 0, EquipmentType.Normal, 0);
        public storeForm(Hero hero1,SwForm parent)
        {
            InitializeComponent();
            this.hero = hero1;
            this.parent = parent;
            bindstoreequipments();            
        }
        public void bindstoreequipments()
        {            
            equipmentintroduce1.DataBindings.Add("Text", Store.store[0], "Equipmentintroduce");
            equipmentintroduce2.DataBindings.Add("Text", Store.store[1], "Equipmentintroduce");
            equipmentintroduce3.DataBindings.Add("Text", Store.store[2], "Equipmentintroduce");
        }

        private void buy1_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[0].name}？", "提示", mess);
            if (d == DialogResult.OK&& Store.store[0].type==EquipmentType.Normal&&hero.Money>= Store.store[0].buyPrice)
            {                
                if(hero.Equipments[1].name=="无")
                {
                    hero.Equipments[1] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if(hero.Equipments[2].name == "无")
                {
                    hero.Equipments[2] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if (hero.Equipments[3].name == "无")
                {
                    hero.Equipments[3] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if (hero.Equipments[4].name == "无")
                {
                    hero.Equipments[4] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if (hero.Equipments[5].name == "无")
                {
                    hero.Equipments[5] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }                

                hero.Money -= Store.store[0].buyPrice;

                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[0].type == EquipmentType.Consumables && hero.Money >= Store.store[0].buyPrice)
            {
                hero.Hp += Store.store[0].hp;
                MessageBox.Show("购买成功！变强了！");
                hero.Money -= Store.store[0].buyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (hero.Money < Store.store[0].buyPrice)
            {
                MessageBox.Show("剩余金钱不足！");                
            }

        }

        private void buy2_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[1].name}？", "提示", mess);
            if (d == DialogResult.OK && Store.store[1].type == EquipmentType.Normal && hero.Money >= Store.store[1].buyPrice)
            {
                MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                if (hero.Equipments[1].name == "无")
                {
                    hero.Equipments[1] = Store.store[1];
                }
                else if (hero.Equipments[2].name == "无")
                {
                    hero.Equipments[2] = Store.store[1];
                }
                else if (hero.Equipments[3].name == "无")
                {
                    hero.Equipments[3] = Store.store[1];
                }
                else if (hero.Equipments[4].name == "无")
                {
                    hero.Equipments[4] = Store.store[1];
                }
                else if (hero.Equipments[5].name == "无")
                {
                    hero.Equipments[5] = Store.store[1];
                }

                hero.Money -= Store.store[1].buyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[1].type == EquipmentType.Consumables && hero.Money >= Store.store[1].buyPrice)
            {
                hero.Hp += Store.store[1].hp;
                MessageBox.Show("购买成功！变强了！");
                hero.Money -= Store.store[1].buyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (hero.Money < Store.store[1].buyPrice)
            {
                MessageBox.Show("剩余金钱不足！");
            }
        }

        private void buy3_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[2].name}？", "提示", mess);
            if (d == DialogResult.OK && Store.store[2].type == EquipmentType.Normal && hero.Money >= Store.store[2].buyPrice)
            {
                MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                if (hero.Equipments[1].name == "无")
                {
                    hero.Equipments[1] = Store.store[2];
                }
                else if (hero.Equipments[2].name == "无")
                {
                    hero.Equipments[2] = Store.store[2];
                }
                else if (hero.Equipments[3].name == "无")
                {
                    hero.Equipments[3] = Store.store[2];
                }
                else if (hero.Equipments[4].name == "无")
                {
                    hero.Equipments[4] = Store.store[2];
                }
                else if (hero.Equipments[5].name == "无")
                {
                    hero.Equipments[5] = Store.store[2];
                }                
                hero.Money -= Store.store[2].buyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[2].type == EquipmentType.Consumables && hero.Money >= Store.store[2].buyPrice)
            {
                hero.Hp += Store.store[2].hp;
                MessageBox.Show("购买成功！变强了！");
                hero.Money -= Store.store[2].buyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if(hero.Money < Store.store[2].buyPrice)
            { 
                MessageBox.Show("剩余金钱不足！");
            }
        }
    }
}
