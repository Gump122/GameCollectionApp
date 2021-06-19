using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HeroGame;


namespace GameCollectionApp.sw
{
    public partial class SwForm : Form
    {
        private Form parent;
        Hero hero1 = new Hero();        
        Hero hero2 = new Hero();
        public bool splayer1 = false;
        public bool splayer2 = false;

        public SwForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public void changeturn()
        {
            if (splayer1)
            {
                turn.Text = $"{hero1.Name}的回合";
                int x = (int)(0.5 * (this.Width - turn.Width));
                int y = turn.Location.Y;
                turn.Location = new System.Drawing.Point(x, y);
                attack2.Enabled = false;
                skillattack2.Enabled = false;
                skill2.Enabled = false;
                equipment2.Enabled = false;
                lost2.Enabled = false;
                check2.Enabled = false;
                attack1.Enabled = false;
                skillattack1.Enabled = false;
                skill1.Enabled = true;
                equipment1.Enabled = false;
                lost1.Enabled = false;
                check1.Enabled = true;
                foreach (var item in hero1.Skills)
                {
                    if (item.CdCount != item.Cd)
                    {
                        item.CdCount++;
                    }
                }
            }
            else
            {
                turn.Text = $"{hero2.Name}的回合";
                int x = (int)(0.5 * (this.Width - turn.Width));
                int y = turn.Location.Y;
                turn.Location = new System.Drawing.Point(x, y);
                attack1.Enabled = false;
                skillattack1.Enabled = false;
                skill1.Enabled = false;
                equipment1.Enabled = false;
                lost1.Enabled = false;
                check1.Enabled = false;
                attack2.Enabled = false;
                skillattack2.Enabled = false;
                skill2.Enabled = true;
                equipment2.Enabled = false;
                lost2.Enabled = false;
                check2.Enabled = true;
                foreach (var item in hero2.Skills)
                {
                    if (item.CdCount != item.Cd)
                    {
                        item.CdCount++;
                    }
                }
            }
        }
        public void closeall()
        {
            attack1.Enabled = false;
            skillattack1.Enabled = false;
            skill1.Enabled = false;
            equipment1.Enabled = false;
            lost1.Enabled = false;
            attack2.Enabled = false;
            skillattack2.Enabled = false;
            skill2.Enabled = false;
            equipment2.Enabled = false;
            lost2.Enabled = false;
            turn.Text = "XX的回合";
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
            //新建盲僧技能
            Skill zhangangshan = new Skill("回音击", State.Dizziness, false, 100, 3);
            Skill taqianzhan = new Skill("金钟罩", State.Normal, false, 100, 1);
            Skill beishang = new Skill("悲伤的失恋", State.Silence, false, 100, 2);
            Skill touqian = new Skill("偷钱", State.Normal, false, 100, 1);

            //新建提莫技能
            Skill shufuji = new Skill("隐形的翅膀", State.Dizziness, false, 100, 3);
            Skill qiangliji = new Skill("致盲吹箭", State.Normal, false, 100, 1);
            Skill jifengbu = new Skill("毒性射击", State.Silence, false, 100, 2);
            Skill jizhonghuli = new Skill("种蘑菇", State.Normal, false, 100, 1);

            //将盲僧的技能放入一个集合
            List<Skill> mangsengskills = new List<Skill>();
            mangsengskills.Add(zhangangshan);
            mangsengskills.Add(taqianzhan);
            mangsengskills.Add(beishang);
            mangsengskills.Add(touqian);

            //将提莫的技能放入一个集合
            List<Skill> timoskills = new List<Skill>();
            timoskills.Add(shufuji);
            timoskills.Add(qiangliji);
            timoskills.Add(jifengbu);
            timoskills.Add(jizhonghuli);

            //新建装备
            Equipment sanxiangzhili = new Equipment("三相之力", 40, 10, 20, 10, 1, 1750, EquipmentType.Normal, 0);
            Equipment wujinzhiren = new Equipment("无尽之刃", 100, 0, 0, 0, 0, 1750, EquipmentType.Normal, 0);
            Equipment feizhaikuaileshui = new Equipment("肥宅快乐水", 40, 10, 20, 10, 0, 1750, EquipmentType.Consumables, 500);
            Equipment wu = new Equipment("无", 0, 0, 0, 0, 0, 0, EquipmentType.Normal, 0);
            //将新建的装备放入商店
            Store.store.Add(sanxiangzhili);
            Store.store.Add(wujinzhiren);
            Store.store.Add(feizhaikuaileshui);

            //新建英雄盲僧
            hero1 = new Hero("版本之子盲僧", 800, 50, 0, 10, 10, mangsengskills);

            //新建英雄提莫
            hero2 = new Hero("万年的子提莫", 800, 50, 0, 10, 10, timoskills);

            for (int i = 0; i < 5; i++)
            {
                hero1.Equipments.Add(wu);
                hero2.Equipments.Add(wu);
            }

            Console.WriteLine("游戏开始！");
            update();
            splayer1 = true;
            changeturn();            
            begin.Enabled = false;

        }

        //投降
        private void lost1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show("确定要投降吗？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("投降成功！来年再战...");
                hero1 = null;
                hero2 = null;
                closeall();
                begin.Enabled = true;
                hp1.Text = "Hp";
                hp2.Text = "Hp";
            }

        }
        private void lost2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show("确定要投降吗？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("投降成功！来年再战...");
                hero1 = null;
                hero2 = null;
                closeall();
                begin.Enabled = true;
                hp1.Text = "Hp";
                hp2.Text = "Hp";
            }
        }

        public void skillchangebuttonenable(bool splayer1)
        {
            if (splayer1 == true)
            {
                skill1.Enabled = false;
                attack1.Enabled = true;
                skillattack1.Enabled = true;
                equipment1.Enabled = true;
                lost1.Enabled = true;
            }
            else
            {
                skill2.Enabled = false;
                attack2.Enabled = true;
                skillattack2.Enabled = true;
                equipment2.Enabled = true;
                lost2.Enabled = true;
            }

        }

        //技能准备
        private void skill1_Click(object sender, EventArgs e)
        {
            new skillForm(hero1, hero2, 1, this).Show();
        }
        private void skill2_Click(object sender, EventArgs e)
        {
            new skillForm(hero2, hero1, 1, this).Show();
        }

        //普通攻击
        private void attack1_Click(object sender, EventArgs e)
        {
            hero2.Hp -= (hero1.Ad + hero1.AdUp);
            hero1.Money += (hero1.Ad + hero1.AdUp) * 10;
            if (hero1.Hp <= 0)
            {
                MessageBox.Show($"{hero1.Name}死亡，{hero2.Name}胜利！");
            }
            splayer1 = false;
            splayer2 = true;
            changeturn();
            update();
        }
        private void attack2_Click(object sender, EventArgs e)
        {
            hero1.Hp -= (hero2.Ad + hero2.AdUp);
            hero2.Money += (hero2.Ad + hero2.AdUp) * 10;
            if (hero1.Hp <= 0)
            {
                MessageBox.Show($"{hero1.Name}死亡，{hero2.Name}胜利！");
            }
            splayer2 = false;
            splayer1 = true;
            changeturn();
            update();
        }

        private void skillattack1_Click(object sender, EventArgs e)
        {
            new skillForm(hero1, hero2, 2, this).Show();
        }

        private void skillattack2_Click(object sender, EventArgs e)
        {
            new skillForm(hero2, hero1, 2, this).Show();
        }

        private void equipment1_Click(object sender, EventArgs e)
        {
            if(hero1.Equipments[0].name!="无"&& hero1.Equipments[1].name != "无"
                && hero1.Equipments[2].name != "无" && hero1.Equipments[3].name != "无"
                && hero1.Equipments[4].name != "无" && hero1.Equipments[5].name != "无")
            {
                MessageBox.Show("英雄装备栏已满！");
                equipment1.Enabled = false;
            }
            else { new storeForm(hero1, this).Show();}
            
        }

        private void equipment2_Click(object sender, EventArgs e)
        {
            if (hero2.Equipments[0].name != "无" && hero2.Equipments[1].name != "无"
                && hero2.Equipments[2].name != "无" && hero2.Equipments[3].name != "无"
                && hero2.Equipments[4].name != "无" && hero2.Equipments[5].name != "无")
            {
                MessageBox.Show("英雄装备栏已满！");
                equipment2.Enabled = false;
            }
            else { new storeForm(hero2, this).Show(); }
        }

        private void check1_Click(object sender, EventArgs e)
        {
            new stateForm(hero1).Show();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            new stateForm(hero2).Show();
        }
    }
}
