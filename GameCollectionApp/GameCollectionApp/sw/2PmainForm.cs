using System;
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
        /// 英雄属性初始化
        /// </summary>
        /// <param name="hero"></param>
        public void heroadd(Hero hero)
        {
            hero.Money += initmoney;
            hero.Hp += inithp;
            hero.Ad += initad;
            hero.Ap += initap;
            hero.Armor += initarmor;
            hero.MagicResistance += initmagicResistance;
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
            //新建商店
            Store s = new Store();           

            hero1 = deepcopy.CloneJson(Hero.heroinit(1));
            heroadd(hero1);
            hero2 = deepcopy.CloneJson(Hero.heroinit(2));
            heroadd(hero2);


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

        private void SwForm_Load(object sender, EventArgs e)
        {

        }

        private void SwForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
