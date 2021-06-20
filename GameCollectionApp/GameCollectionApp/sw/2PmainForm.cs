using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HeroGame;


namespace GameCollectionApp.sw
{

    /// <summary>
    /// 2PGame主界面
    /// </summary>
    public partial class SwForm : Form
    {
        private Form parent;
        Hero hero1 = new Hero();        
        Hero hero2 = new Hero();
        public bool splayer1 = false;
        public bool splayer2 = false;

        //初始化英雄数据
        private int initmoney=200;
        private int inithp=1500;
        private int initad=50;
        private int initap=0;
        private int initarmor=10;
        private int initmagicResistance=10;
        public int Initmoney { get => initmoney; set => initmoney = value; }
        public int Inithp { get => inithp; set => inithp = value; }
        public int Initad { get => initad; set => initad = value; }
        public int Initap { get => initap; set => initap = value; }
        public int Initarmor { get => initarmor; set => initarmor = value; }
        public int InitmagicResistance { get => initmagicResistance; set => initmagicResistance = value; }
        

        public SwForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// 回合更替
        /// </summary>
        public void changeturn()
        {
            if (splayer1)
            {
                turn.Text = $"{hero1.Name}的回合";
                hero1.Money += 700;
                int x = (int)(0.5 * (this.Width - turn.Width));
                int y = turn.Location.Y;
                turn.Location = new System.Drawing.Point(x, y);
                hero2.State = State.Normal;
                attack2.Enabled = false;
                skillattack2.Enabled = false;
                skill2.Enabled = false;
                equipment2.Enabled = false;
                lost2.Enabled = false;
                check2.Enabled = false;
                skipturn2.Enabled = false;
                attack1.Enabled = false;
                skillattack1.Enabled = false;
                skill1.Enabled = true;
                equipment1.Enabled = false;
                lost1.Enabled = false;
                check1.Enabled = true;
                skipturn1.Enabled = true;
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
                hero2.Money += 700;
                int x = (int)(0.5 * (this.Width - turn.Width));
                int y = turn.Location.Y;
                turn.Location = new System.Drawing.Point(x, y);
                hero1.State = State.Normal;
                attack1.Enabled = false;
                skillattack1.Enabled = false;
                skill1.Enabled = false;
                equipment1.Enabled = false;
                lost1.Enabled = false;
                check1.Enabled = false;
                skipturn1.Enabled = false;
                attack2.Enabled = false;
                skillattack2.Enabled = false;
                skill2.Enabled = true;
                equipment2.Enabled = false;
                lost2.Enabled = false;
                check2.Enabled = true;
                skipturn2.Enabled = true;
                foreach (var item in hero2.Skills)
                {
                    if (item.CdCount != item.Cd)
                    {
                        item.CdCount++;
                    }
                }
            }
        }

        /// <summary>
        /// 游戏结束
        /// </summary>
        public void closeall()
        {
            attack1.Enabled = false;
            skillattack1.Enabled = false;
            skill1.Enabled = false;
            equipment1.Enabled = false;
            lost1.Enabled = false;
            check1.Enabled = false;
            skipturn1.Enabled = false;
            attack2.Enabled = false;
            skillattack2.Enabled = false;
            skill2.Enabled = false;
            equipment2.Enabled = false;
            lost2.Enabled = false;
            check2.Enabled = false;
            skipturn2.Enabled = false;
            restart.Enabled = false;
            setting.Enabled = true;
            begin.Enabled = true;
            hero1 = new Hero();
            hero2 = new Hero();
            int x = (int)(0.5 * (this.Width - turn.Width));
            int y = turn.Location.Y;
            turn.Location = new System.Drawing.Point(x, y);
            turn.Text = "XX的回合";
            hp1.Text = "HP";
            hp2.Text = "HP";
            player1.Text = "玩家";
            player2.Text = "玩家";
        }

        /// <summary>
        /// 更新窗体数据
        /// </summary>
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

        //退出，返回游戏合集主界面
        private void exit_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }


        //开始游戏，创建游戏对象
        public void begin_Click(object sender, EventArgs e)
        {
            //新建盲僧技能
            Skill huiyinji = new Skill("回音击", State.Dizziness, false, 100, 4);
            Skill jinzhongzhao = new Skill("金钟罩", State.Silence, false, 65, 2);
            Skill beishang = new Skill("悲伤的失恋", State.Silence, false, 130, 4);
            Skill touqian = new Skill("偷钱", State.Normal, false, 180, 2);

            //新建提莫技能
            Skill yingxingdechibang = new Skill("隐形的翅膀", State.Dizziness, false, 110, 4);
            Skill zhimangchuijian = new Skill("致盲吹箭", State.Normal, false, 100, 2);
            Skill duxingsheji = new Skill("毒性射击", State.Silence, false, 130, 3);
            Skill zhongmogu = new Skill("种蘑菇", State.Dizziness, false, 185, 4);

            //将盲僧的技能放入一个集合
            List<Skill> mangsengskills = new List<Skill>();
            mangsengskills.Add(huiyinji);
            mangsengskills.Add(jinzhongzhao);
            mangsengskills.Add(beishang);
            mangsengskills.Add(touqian);

            //将提莫的技能放入一个集合
            List<Skill> timoskills = new List<Skill>();
            timoskills.Add(yingxingdechibang);
            timoskills.Add(zhimangchuijian);
            timoskills.Add(duxingsheji);
            timoskills.Add(zhongmogu);

            //新建装备
            Equipment sanxiangzhili = new Equipment("三相之力", 45, 45, 30, 30, 3000, 1750, EquipmentType.Normal, 0);
            Equipment wujinzhiren = new Equipment("无尽之刃", 100, 0, 0, 0, 2000, 900, EquipmentType.Normal, 0);
            Equipment feizhaikuaileshui = new Equipment("肥宅快乐水", 15, 5, 15, 10, 500, 0, EquipmentType.Consumables, 200);            
            //将新建的装备放入商店
            Store.store.Add(sanxiangzhili);
            Store.store.Add(wujinzhiren);
            Store.store.Add(feizhaikuaileshui);

            //新建英雄盲僧
            hero1 = new Hero("版本之子盲僧", initmoney, inithp, initad, initap, Initarmor, InitmagicResistance, mangsengskills);

            //新建英雄提莫
            hero2 = new Hero("万年的子提莫", initmoney, inithp+1000, initad, initap, Initarmor, InitmagicResistance, timoskills);           
            update();
            splayer1 = true;
            changeturn();            
            begin.Enabled = false;
            restart.Enabled = true;
            setting.Enabled = false;
        }        

        //技能准备之后改变行动状态
        public void skillchangebuttonenable(bool splayer1)
        {
            if (splayer1 == true)
            {
                skill1.Enabled = false;
                attack1.Enabled = true;
                skillattack1.Enabled = true;
                equipment1.Enabled = true;
                lost1.Enabled = true;
                check1.Enabled = true;
                skipturn1.Enabled = true;
            }
            else
            {
                skill2.Enabled = false;
                attack2.Enabled = true;
                skillattack2.Enabled = true;
                equipment2.Enabled = true;
                lost2.Enabled = true;
                check2.Enabled = true;
                skipturn2.Enabled = true;
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
            if (hero1.State == State.Dizziness) { MessageBox.Show("眩晕状态！一回合内无法攻击！"); }
            else
            {
                hero2.Hp -= (hero1.Ad + hero1.AdUp - hero2.Armor - hero2.ArmorUp);
                hero1.Money += (hero1.Ad + hero1.AdUp - hero2.Armor - hero2.ArmorUp) * 5;
                if (hero2.Hp < 0)
                {
                    MessageBox.Show($"{hero1.Name}死亡，{hero2.Name}胜利！");
                    closeall();
                }
                else
                {
                    splayer1 = false;
                    splayer2 = true;
                    changeturn();
                    update();
                }
            }           
        }
        private void attack2_Click(object sender, EventArgs e)
        {
            if (hero2.State == State.Dizziness) { MessageBox.Show("眩晕状态！一回合内无法普通攻击或使用技能！"); }
            else
            {
                hero1.Hp -= (hero2.Ad + hero2.AdUp - hero1.Armor - hero1.ArmorUp);
                hero2.Money += (hero2.Ad + hero2.AdUp - hero1.Armor - hero1.ArmorUp) * 5;
                if (hero1.Hp < 0)
                {
                    MessageBox.Show($"{hero1.Name}死亡，{hero2.Name}胜利！");
                    closeall();
                }
                else
                {
                    splayer2 = false;
                    splayer1 = true;
                    changeturn();
                    update();
                }                
            }           
        }

        //技能攻击
        private void skillattack1_Click(object sender, EventArgs e)
        {
            if (hero1.State == State.Dizziness) { MessageBox.Show("眩晕状态！一回合内无法普通攻击或使用技能！"); }
            else if(hero1.State == State.Silence) { MessageBox.Show("沉默状态！一回合内无法使用技能！"); }
            else { new skillForm(hero1, hero2, 2, this).Show(); }            
        }
        private void skillattack2_Click(object sender, EventArgs e)
        {
            if (hero2.State == State.Dizziness) { MessageBox.Show("眩晕状态！一回合内无法普通攻击或使用技能！"); }
            else if (hero2.State == State.Silence) { MessageBox.Show("沉默状态！一回合内无法使用技能！"); }
            else { new skillForm(hero2, hero1, 2, this).Show(); }           
        }

        //购买装备
        private void equipment1_Click(object sender, EventArgs e)
        {
            if(hero1.Equipments[0].Name!="无"&& hero1.Equipments[1].Name != "无"
                && hero1.Equipments[2].Name != "无" && hero1.Equipments[3].Name != "无"
                && hero1.Equipments[4].Name != "无" && hero1.Equipments[5].Name != "无")
            {
                MessageBox.Show("英雄装备栏已满！");
                equipment1.Enabled = false;
            }
            else { new storeForm(hero1, this).Show();}
            
        }
        private void equipment2_Click(object sender, EventArgs e)
        {
            if (hero2.Equipments[0].Name != "无" && hero2.Equipments[1].Name != "无"
                && hero2.Equipments[2].Name != "无" && hero2.Equipments[3].Name != "无"
                && hero2.Equipments[4].Name != "无" && hero2.Equipments[5].Name != "无")
            {
                MessageBox.Show("英雄装备栏已满！");
                equipment2.Enabled = false;
            }
            else { new storeForm(hero2, this).Show(); }
        }

        //投降
        private void lost1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show("确定要投降吗？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("投降成功！来年再战...");
                closeall();
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
                closeall();
                hp1.Text = "Hp";
                hp2.Text = "Hp";
            }
        }

        //查看状态
        private void check1_Click(object sender, EventArgs e)
        {
            new stateForm(hero1).Show();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            new stateForm(hero2).Show();
        }

        //跳过回合
        private void skipturn1_Click(object sender, EventArgs e)
        {
            splayer1 = false;
            splayer2 = true;
            changeturn();
        }
        private void skipturn2_Click(object sender, EventArgs e)
        {
            splayer2 = false;
            splayer1 = true;
            changeturn();
        }

        //设置按钮
        private void setting_Click(object sender, EventArgs e)
        {
            new settingForm(this).Show();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            closeall();
        }

        private void SwForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
