using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HeroGame;


namespace GameCollectionApp.sw
{
    public partial class SwForm : Form
    {
        private Form parent;
        Hero hero1=new Hero();
        Hero hero2=new Hero();
        bool splayer1 = false;
        bool splayer2 = false;
        
        public SwForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;            
        }
        public void changeturn()
        {
            if (splayer1) { 
                turn.Text = $"{hero1.Name}的回合";
                attack2.Enabled = false;
                skill2.Enabled = false;
                equipment2.Enabled = false;
                lost2.Enabled = false;
                attack1.Enabled = true;
                skill1.Enabled = true;
                equipment1.Enabled = true;
                lost1.Enabled = true;
            }
            else { 
                turn.Text = $"{hero2.Name}的回合";                
                attack1.Enabled = false;
                skill1.Enabled = false;
                equipment1.Enabled = false;
                lost1.Enabled = false;
                attack2.Enabled = true;
                skill2.Enabled = true;
                equipment2.Enabled = true;
                lost2.Enabled = true;
            }
        }
        public void update()
        {
            hp1.DataBindings.Clear();
            hp2.DataBindings.Clear();
            player1.DataBindings.Clear();
            player2.DataBindings.Clear();
            hp1.DataBindings.Add("Text", hero1, "Hp");
            hp2.DataBindings.Add("Text", hero2, "Hp");
            player1.DataBindings.Add("Text", hero1, "Name");
            player2.DataBindings.Add("Text", hero2, "Name");
        }
        private void exit_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        public void begin_Click(object sender, EventArgs e)
        {
            //新建亚索技能
            Skill zhangangshan = new Skill("斩钢闪", State.Dizziness, false, 100, 3);
            Skill taqianzhan = new Skill("踏前斩", State.Normal, false, 100, 1);
            Skill beishang = new Skill("悲伤的失恋", State.Silence, false, 100, 2);
            Skill touqian = new Skill("偷钱", State.Normal, false, 100, 1);

            //新建风行者技能
            Skill shufuji = new Skill("束缚击", State.Dizziness, false, 100, 3);
            Skill qiangliji = new Skill("强力击", State.Normal, false, 100, 1);
            Skill jifengbu = new Skill("诅咒遗言", State.Silence, false, 100, 2);
            Skill jizhonghuli = new Skill("集中火力", State.Normal, false, 100, 1);

            //将亚索的技能放入一个集合
            List<Skill> yasuoskills = new List<Skill>();
            yasuoskills.Add(zhangangshan);
            yasuoskills.Add(taqianzhan);
            yasuoskills.Add(beishang);
            yasuoskills.Add(touqian);

            //将风行者的技能放入一个集合
            List<Skill> fengxingskills = new List<Skill>();
            fengxingskills.Add(shufuji);
            fengxingskills.Add(qiangliji);
            fengxingskills.Add(jifengbu);
            fengxingskills.Add(jizhonghuli);

            //新建装备
            Equipment sanxiangzhili = new Equipment("三相之力", 40, 10, 20, 10, 3000, 1750, EquipmentType.Normal, 0);
            Equipment wujinzhiren = new Equipment("无尽之刃", 100, 0, 0, 0, 3500, 1750, EquipmentType.Normal, 0);
            Equipment feizhaikuaileshui = new Equipment("肥宅快乐水", 40, 10, 20, 10, 3500, 1750, EquipmentType.Consumables, 500);

            //将新建的装备放入商店
            Store.store.Add(sanxiangzhili);
            Store.store.Add(wujinzhiren);
            Store.store.Add(feizhaikuaileshui);

            //新建英雄亚索
            hero1 = new Hero("疾风剑豪 亚索", 1500, 50, 0, 10, 10, yasuoskills);

            //新建英雄风行者
            hero2 = new Hero("风行者", 1500, 50, 0, 10, 10, fengxingskills);
            

            Console.WriteLine("游戏开始！");
            update();
            splayer1 = true;
            changeturn();
            begin.Enabled = false;
            


        }

        private void lost1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show("确定要投降吗？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("投降成功！来年再战。");
                hero1 = null;
                hero2 = null;
                begin.Enabled = true;
            }

        }

        private void lost2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show("确定要投降吗？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("投降成功！来年再战。");
                hero1 = null;
                hero2 = null;
                begin.Enabled = true;
            }
        }



        private void attack1_Click(object sender, EventArgs e)
        {
            hero2.Hp -= (hero1.Ad + hero1.AdUp);
            splayer1 = false;
            splayer2 = true;
            changeturn();
            update();
            Console.WriteLine(hero2.Hp);
        }

        private void attack2_Click(object sender, EventArgs e)
        {
            hero1.Hp -= (hero2.Ad + hero2.AdUp);
            splayer2 = false;
            splayer1 = true;
            changeturn();
            update();
        }
    }
}
