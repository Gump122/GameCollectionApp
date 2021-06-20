using System.Windows.Forms;
using HeroGame;

namespace GameCollectionApp.sw
{
    public partial class skillForm : Form
    {
        Hero hero1 = new Hero();
        Hero hero2 = new Hero();
        SwForm parent;
        int stage;
        public skillForm(Hero hero1,Hero hero2,int stage,SwForm parent)
        {
            InitializeComponent();
            this.hero1 = hero1;
            this.hero2 = hero2;
            this.stage = stage;
            this.parent = parent;
            hero1.clearbeforeupdate();
            hero1.updateherostate();
            hero2.clearbeforeupdate();
            hero2.updateherostate();
            for (int i=0;i<4;i++)
            {               
                hero1.Skills[i].updateskillstate();
                hero2.Skills[i].updateskillstate();
            }
            if(stage==1)
            { 
                useskill1.Enabled = false;
                useskill2.Enabled = false;
                useskill3.Enabled = false;
                useskill4.Enabled = false;
                cancel.Enabled = false;
            }
            else if(stage==2)
            {
                study1.Enabled = false;
                study2.Enabled = false;
                study3.Enabled = false;
                study4.Enabled = false;
                skillup1.Enabled = false;
                skillup2.Enabled = false;
                skillup3.Enabled = false;
                skillup4.Enabled = false;
                skip.Enabled = false;
            }
            bindskills();
        }

        //数据传递绑定
        public void bindskills()
        {
            skillintroduce1.DataBindings.Add("Text", hero1.Skills[0], "Skillintroduce");
            skillintroduce2.DataBindings.Add("Text", hero1.Skills[1], "Skillintroduce");
            skillintroduce3.DataBindings.Add("Text", hero1.Skills[2], "Skillintroduce");
            skillintroduce4.DataBindings.Add("Text", hero1.Skills[3], "Skillintroduce");            
        }

        //跳过技能准备
        private void skip_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要跳过技能准备阶段，直接进入战斗？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("跳过技能准备，直接进入战斗阶段!");
                parent.skillchangebuttonenable(parent.splayer1);
                Close();
            }
        }
        private void cancel_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定要取消技能释放？", "提示", mess);
            if (d == DialogResult.OK)
            {
                MessageBox.Show("技能释放已取消");
                Close();
            }
        }


        //技能学习
        private void study1_Click(object sender, System.EventArgs e)
        {
            bool a=hero1.Skills[0].StudySkill();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }

        }
        private void skillup1_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[0].LevelUp();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }      
        private void study2_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[1].StudySkill();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }

        private void skillup2_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[1].LevelUp();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }

        private void study3_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[2].StudySkill();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }

        //技能升级
        private void skillup3_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[2].LevelUp();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }

        private void study4_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[3].StudySkill();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }

        private void skillup4_Click(object sender, System.EventArgs e)
        {
            bool a = hero1.Skills[3].LevelUp();
            if (a) { Close();
                parent.skillchangebuttonenable(parent.splayer1);
            }
        }

        //使用技能
        private void useskill1_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定发动技能{hero1.Skills[0].Name}?", "提示", mess);
            if (d == DialogResult.OK&& hero1.Skills[0].IsStudy==true&& hero1.Skills[0].CdCount== hero1.Skills[0].Cd)
            {
                MessageBox.Show($"技能发动成功，对{hero2.Name}造成伤害{hero1.Skills[0].Dmg * hero1.Skills[0].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2}");
                hero1.Skills[0].CdCount = 0;
                hero2.Hp -= (hero1.Skills[0].Dmg * hero1.Skills[0].Level - hero2.Armor -hero2.ArmorUp - hero2.MagicResistance*2 -hero2.MagicResistanceUp*2);
                hero2.State = hero1.Skills[0].State;
                hero1.Money += (hero1.Skills[0].Dmg * hero1.Skills[0].Level * 10 - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                if (hero2.Hp < 0)
                {
                    MessageBox.Show($"{hero2.Name}死亡，{hero1.Name}胜利！");
                    parent.closeall();
                }
                Close();
                if(parent.splayer1 == true){ parent.splayer1 = false;parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }               
                parent.changeturn();
                parent.update();
            }
            else { 
                if(hero1.Skills[0].IsStudy == false)
                MessageBox.Show("技能尚未学习，发动失败!");
                else
                MessageBox.Show("技能尚未冷却，发动失败!");
            }
        }
        private void useskill2_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定发动技能{hero1.Skills[1].Name}?", "提示", mess);
            if (d == DialogResult.OK && hero1.Skills[1].IsStudy == true && hero1.Skills[1].CdCount == hero1.Skills[1].Cd)
            {
                MessageBox.Show($"技能发动成功，对{hero2.Name}造成伤害{hero1.Skills[1].Dmg * hero1.Skills[1].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2}");
                hero1.Skills[1].CdCount = 0;
                hero2.Hp -= (hero1.Skills[1].Dmg * hero1.Skills[1].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                hero2.State = hero1.Skills[1].State;
                hero1.Money += (hero1.Skills[1].Dmg * hero1.Skills[1].Level * 10 - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                if (hero2.Hp < 0)
                {
                    MessageBox.Show($"{hero2.Name}死亡，{hero1.Name}胜利！");
                    parent.closeall();
                }
                Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else
            {
                if (hero1.Skills[1].IsStudy == false)
                    MessageBox.Show("技能尚未学习，发动失败!");
                else
                    MessageBox.Show("技能尚未冷却，发动失败!");
            }


        }
        private void useskill3_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定发动技能{hero1.Skills[2].Name}?", "提示", mess);
            if (d == DialogResult.OK && hero1.Skills[2].IsStudy == true&&hero1.Skills[2].CdCount == hero1.Skills[2].Cd)
            {
                MessageBox.Show($"技能发动成功，对{hero2.Name}造成伤害{hero1.Skills[2].Dmg * hero1.Skills[2].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2}");
                hero1.Skills[2].CdCount = 0;
                hero2.Hp -= (hero1.Skills[2].Dmg * hero1.Skills[2].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                hero2.State = hero1.Skills[2].State;
                hero1.Money += (hero1.Skills[2].Dmg * hero1.Skills[2].Level * 10 - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                if (hero2.Hp < 0)
                {
                    MessageBox.Show($"{hero2.Name}死亡，{hero1.Name}胜利！");
                    parent.closeall();
                }
                Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else
            {
                if (hero1.Skills[2].IsStudy == false)
                    MessageBox.Show("技能尚未学习，发动失败!");
                else
                    MessageBox.Show("技能尚未冷却，发动失败!");
            }

        }
        private void useskill4_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show($"确定发动技能{hero1.Skills[3].Name}?", "提示", mess);
            if (d == DialogResult.OK && hero1.Skills[3].IsStudy == true && hero1.Skills[3].CdCount == hero1.Skills[3].Cd)
            {
                MessageBox.Show($"技能发动成功，对{hero2.Name}造成伤害{hero1.Skills[3].Dmg * hero1.Skills[3].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2}");
                hero1.Skills[3].CdCount = 0;
                hero2.Hp -= (hero1.Skills[3].Dmg * hero1.Skills[3].Level - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                hero2.State = hero1.Skills[3].State;
                hero1.Money += (hero1.Skills[3].Dmg * hero1.Skills[3].Level * 10 - hero2.Armor - hero2.ArmorUp - hero2.MagicResistance * 2 - hero2.MagicResistanceUp * 2);
                if (hero2.Hp < 0)
                {
                    MessageBox.Show($"{hero2.Name}死亡，{hero1.Name}胜利！");
                    parent.closeall();
                }
                Close();
                if (parent.splayer1 == true) { parent.splayer1 = false; parent.splayer2 = true; }
                else { parent.splayer2 = false; parent.splayer1 = true; }
                parent.changeturn();
                parent.update();
            }
            else
            {
                if (hero1.Skills[3].IsStudy == false)
                    MessageBox.Show("技能尚未学习，发动失败!");
                else
                    MessageBox.Show("技能尚未冷却，发动失败!");
            }
        }


    }
}
