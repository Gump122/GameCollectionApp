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
            moneyview.DataBindings.Add("Text", hero, "Money");
        }


        //购买装备
        private void buy1_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[0].Name}？", "提示", mess);
            if (d == DialogResult.OK&& Store.store[0].Type==EquipmentType.Normal&&hero.Money>= Store.store[0].BuyPrice)
            {
                if (hero.Equipments[0].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[0] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if(hero.Equipments[1].Name=="无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[1] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if(hero.Equipments[2].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[2] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if (hero.Equipments[3].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[3] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if (hero.Equipments[4].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[4] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }
                else if (hero.Equipments[5].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[5] = Store.store[0];
                    MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                }                

                hero.Money -= Store.store[0].BuyPrice;
                hero.updateherostate();
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[0].Type == EquipmentType.Consumables && hero.Money >= Store.store[0].BuyPrice)
            {
                hero.Hp += Store.store[0].Hp;
                MessageBox.Show("购买成功！变强了！");
                hero.updateherostate();
                hero.Money -= Store.store[0].BuyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if(d == DialogResult.Cancel) { }
            else if (d == DialogResult.OK&&hero.Money < Store.store[0].BuyPrice)
            {
                MessageBox.Show("剩余金钱不足！");                
            }

        }
        private void buy2_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[1].Name}？", "提示", mess);
            if (d == DialogResult.OK && Store.store[1].Type == EquipmentType.Normal && hero.Money >= Store.store[1].BuyPrice)
            {
                MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                if (hero.Equipments[0].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[0] = Store.store[1];
                }
                else if (hero.Equipments[1].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[1] = Store.store[1];
                }
                else if (hero.Equipments[2].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[2] = Store.store[1];
                }
                else if (hero.Equipments[3].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[3] = Store.store[1];
                }
                else if (hero.Equipments[4].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[4] = Store.store[1];
                }
                else if (hero.Equipments[5].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[5] = Store.store[1];
                }

                hero.Money -= Store.store[1].BuyPrice;
                hero.updateherostate();
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[1].Type == EquipmentType.Consumables && hero.Money >= Store.store[1].BuyPrice)
            {
                hero.Hp += Store.store[1].Hp;
                MessageBox.Show("购买成功！变强了！");
                hero.Money -= Store.store[1].BuyPrice;
                hero.updateherostate();
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (d == DialogResult.Cancel) { }
            else if (d == DialogResult.OK && hero.Money < Store.store[1].BuyPrice)
            {
                MessageBox.Show("剩余金钱不足！");
            }
        }
        private void buy3_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要购买{Store.store[2].Name}？", "提示", mess);
            if (d == DialogResult.OK && Store.store[2].Type == EquipmentType.Normal && hero.Money >= Store.store[2].BuyPrice)
            {
                MessageBox.Show("购买成功！可在英雄状态栏查看装备情况。");
                if (hero.Equipments[0].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[0] = Store.store[2];
                }
                else if (hero.Equipments[1].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[1] = Store.store[2];
                }
                else if (hero.Equipments[2].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[2] = Store.store[2];
                }
                else if (hero.Equipments[3].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[3] = Store.store[2];
                }
                else if (hero.Equipments[4].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[4] = Store.store[2];
                }
                else if (hero.Equipments[5].Name == "无")
                {
                    hero.clearbeforeupdate();
                    hero.Equipments[5] = Store.store[2];
                }                
                hero.Money -= Store.store[2].BuyPrice;
                hero.updateherostate();
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (Store.store[2].Type == EquipmentType.Consumables && hero.Money >= Store.store[2].BuyPrice)
            {
                hero.Hp += Store.store[2].Hp;
                MessageBox.Show("购买成功！变强了！");
                hero.updateherostate();
                hero.Money -= Store.store[2].BuyPrice;
                this.Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else if (d == DialogResult.Cancel) { }
            else if(d == DialogResult.OK && hero.Money < Store.store[2].BuyPrice)
            { 
                MessageBox.Show("剩余金钱不足！");
            }
        }


    }
}
