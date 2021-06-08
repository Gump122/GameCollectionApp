using System;

namespace HeroGame
{
    /// <summary>
    /// 技能类
    /// </summary>
    class Skill
    {
        /// <summary>
        /// 技能名称
        /// </summary>
        public string name;

        /// <summary>
        /// 技能等级
        /// </summary>
        public int level;

        /// <summary>
        /// 技能附加状态
        /// </summary>
        public State state;

        /// <summary>
        /// 是否学习了该技能
        /// </summary>
        public bool isStudy;

        /// <summary>
        /// 技能伤害
        /// </summary>
        public int dmg;

        /// <summary>
        /// 技能CD
        /// </summary>
        public int cd;

        /// <summary>
        /// 记录技能cd情况
        /// </summary>
        public int cdCount;

        /// <summary>
        /// 技能升级
        /// </summary>
        public bool LevelUp()
        {
            if (isStudy == true)
            {
                if (level < 3)
                {
                    level++;
                    Console.WriteLine($"技能{name}升级成功！");
                    return true;
                }
                else
                {
                    Console.WriteLine("技能已满级！");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("该技能尚未学习，无法升级！");
                return false;
            }
        }

        /// <summary>
        /// 学习技能
        /// </summary>
        public bool StudySkill()
        {
            //判断是否学习过
            if (isStudy == false)
            {
                isStudy = true;
                Console.WriteLine($"技能{name}学习成功！");
                return true;
            }
            else
            {
                Console.WriteLine("你已经学习过这个技能了，请选择升级技能");
                return false;
            }
        }

        public Skill(string name, State state, bool isStudy, int dmg, int cd)
        {
            this.name = name;
            level = 1;
            this.state = state;
            this.isStudy = isStudy;
            this.dmg = dmg;
            this.cd = cd;
            cdCount = cd;

        }

        /// <summary>
        /// 技能介绍方法
        /// </summary>
        public void Introduce()
        {
            Console.WriteLine($"-------【技能名称】：{name}-------");
            Console.WriteLine($"【技能等级】：{level}");
            Console.WriteLine($"【技能类型】：让敌方{state}");
            Console.WriteLine($"【技能基础伤害】：{dmg}");
            Console.WriteLine($"【技能等级伤害加成】：{(level - 1) * 100}");
            Console.WriteLine($"【技能冷却时间】：每{cd}回合使用一次");
            Console.WriteLine("---------------------------------------------");
        }
    }
}

