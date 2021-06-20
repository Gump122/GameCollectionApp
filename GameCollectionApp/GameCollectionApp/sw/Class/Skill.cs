using System;
using System.Windows.Forms;

namespace HeroGame
{
    /// <summary>
    /// 技能类
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// 技能名称
        /// </summary>
        private string name;

        /// <summary>
        /// 技能等级
        /// </summary>
        private int level;

        /// <summary>
        /// 技能附加状态
        /// </summary>
        private State state;

        /// <summary>
        /// 是否学习了该技能
        /// </summary>
        private bool isStudy;

        /// <summary>
        /// 技能伤害
        /// </summary>
        private int dmg;

        /// <summary>
        /// 技能CD
        /// </summary>
        private int cd;

        /// <summary>
        /// 记录技能cd情况
        /// </summary>
        private int cdCount;

        /// <summary>
        /// 技能介绍
        /// </summary>
        private string skillintroduce;


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        internal State State { get => state; set => state = value; }
        public bool IsStudy { get => isStudy; set => isStudy = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public int Cd { get => cd; set => cd = value; }
        public int CdCount { get => cdCount; set => cdCount = value; }
        public string Skillintroduce { get => skillintroduce; set => skillintroduce = value; }

        /// <summary>
        /// 技能升级
        /// </summary>
        public bool LevelUp()
        {
            if (IsStudy == true)
            {
                if (Level < 3)
                {
                    MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                    DialogResult d = MessageBox.Show($"确定要升级技能:{Name}？", "提示", mess);
                    if (d == DialogResult.OK)
                    {                        
                        Level++;
                        MessageBox.Show($"技能:{Name}升级成功（Level:{Level}），进入战斗阶段");
                    }
                    else { return false; }
                    return true;

                }
                else
                {
                    MessageBox.Show($"技能:{Name}已满级！");
                    return false;
                }

            }
            else
            {
                MessageBox.Show($"技能:{Name}尚未学习，无法升级！");
                return false;
            }

        }

        /// <summary>
        /// 学习技能
        /// </summary>
        public bool StudySkill()
        {
            //判断是否学习过
            if (IsStudy == false)
            {
                MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show($"确定要学习技能{Name}？", "提示", mess);
                if (d == DialogResult.OK)
                {
                    IsStudy = true;
                    Level++;
                    MessageBox.Show("技能学习成功，进入战斗阶段");
                    return true;
                }
                else if(d == DialogResult.OK) { return false; }
                
            }            
            else
            {
                MessageBox.Show("你已经学习过这个技能了，请选择升级技能");
                return false;
            }
            return false;
        }

        public Skill(string name, State state, bool isStudy, int dmg, int cd)
        {
            this.Name = name;
            Level = 0;
            this.State = state;
            this.IsStudy = isStudy;
            this.Dmg = dmg;
            this.Cd = cd;
            CdCount = cd;
            this.skillintroduce = $"【技能名称】：{Name}"
                +Environment.NewLine+$"【技能等级】：{Level}"
                +Environment.NewLine+$"【技能类型】：让敌方{State}"
                +Environment.NewLine+$"【技能基础伤害】：{Dmg}" 
                +Environment.NewLine+$"【技能等级伤害加成】：{(Level) * 100}"
                +Environment.NewLine+$"【技能冷却时间】：每{Cd}回合使用一次";
        }
        /// <summary>
        /// 更新技能状态
        /// </summary>
        public void updateskillstate()
        {
            this.skillintroduce = $"【技能名称】：{Name}"
                + Environment.NewLine + $"【技能等级】：{Level}"
                + Environment.NewLine + $"【技能类型】：让敌方{State}"
                + Environment.NewLine + $"【技能基础伤害】：{Dmg}"
                + Environment.NewLine + $"【技能等级伤害加成】：{(Level) * 100}"
                + Environment.NewLine + $"【技能冷却时间】：每{Cd}回合使用一次";
        }       

    }
}

