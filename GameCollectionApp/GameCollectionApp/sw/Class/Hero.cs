using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HeroGame
{
    /// <summary>
    /// 英雄类
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// 英雄名称
        /// </summary>
        private string name;

        /// <summary>
        /// 英雄血量
        /// </summary>
        private int hp;

        /// <summary>
        /// 英雄最大血量
        /// </summary>
        private int maxhp;

        /// <summary>
        /// 英雄拥有金钱
        /// </summary>
        private int money;

        /// <summary>
        /// 英雄基础攻击力
        /// </summary>
        private int ad;

        /// <summary>
        /// 英雄基础法强
        /// </summary>
        private int ap;

        /// <summary>
        /// 英雄基础护甲
        /// </summary>
        private int armor;

        /// <summary>
        /// 英雄基础魔抗
        /// </summary>
        private int magicResistance;

        /// <summary>
        /// 装备加成魔抗
        /// </summary>
        private int magicResistanceUp;

        /// <summary>
        /// 装备护甲加成
        /// </summary>
        private int armorUp;

        /// <summary>
        /// 装备加成法强
        /// </summary>
        private int apUp;

        /// <summary>
        /// 装备加成攻击力
        /// </summary>
        private int adUp;

        /// <summary>
        /// 英雄所有技能
        /// </summary>
        private List<Skill> skills;

        /// <summary>
        /// 英雄装备栏
        /// </summary>
        private List<Equipment> equipments;

        /// <summary>
        /// 英雄状态
        /// </summary>
        private State state;

        /// <summary>
        /// 英雄属性介绍
        /// </summary>
        private string herointroduce;

        /// <summary>
        /// 没有装备时都指向该英雄的“无”装备对象
        /// </summary>
        public Equipment wu = new Equipment("无", 0, 0, 0, 0, 0, 0, EquipmentType.Normal, 0);
        
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Money { get => money; set => money = value; }
        public int Ad { get => ad; set => ad = value; }
        public int Ap { get => ap; set => ap = value; }
        public int Armor { get => armor; set => armor = value; }
        public int MagicResistance { get => magicResistance; set => magicResistance = value; }
        public int MagicResistanceUp { get => magicResistanceUp; set => magicResistanceUp = value; }
        public int ArmorUp { get => armorUp; set => armorUp = value; }
        public int ApUp { get => apUp; set => apUp = value; }
        public int AdUp { get => adUp; set => adUp = value; }
        internal List<Skill> Skills { get => skills; set => skills = value; }
        internal List<Equipment> Equipments { get => equipments; set => equipments = value; }
        internal State State { get => state; set => state = value; }
        public string Herointroduce { get => herointroduce; set => herointroduce = value; }
        public int Maxhp { get => maxhp; set => maxhp = value; }

        public Hero() 
        {
            Name = "初始状态";
            Hp = 0;
            Money = 0;
            Ad = 0;
            Armor = 0;
            MagicResistance = 0;
            MagicResistanceUp = 0;
            ArmorUp = 0;
            ApUp = 0;
            AdUp = 0;
            Skill a = new Skill("a", State.Dizziness, false, 100, 3);
            Skill b = new Skill("b", State.Normal, false, 100, 1);
            Skill c = new Skill("c", State.Silence, false, 100, 2);
            Skill d = new Skill("d", State.Normal, false, 100, 1);

            Skills = new List<Skill>();
            Skills.Add(a);
            Skills.Add(b);
            Skills.Add(c);
            Skills.Add(d);

            Equipments = new List<Equipment>();
            for (int i = 0; i < 6; i++)
            {
                Equipments.Add(wu);
            }

            State = State.Normal;

            herointroduce = $"【英雄名称】：{Name}"
                + Environment.NewLine + $"【英雄血量】：{Hp}/{Maxhp}"
                + Environment.NewLine + $"【现有金钱】：{Money}"
                + Environment.NewLine + $"【英雄基础攻击力】：{Ad}"
                + Environment.NewLine + $"【英雄基础法强】：{Ap}"
                + Environment.NewLine + $"【英雄基础护甲】：{Armor}"
                + Environment.NewLine + $"【英雄基础魔抗】：{Armor}"
                + Environment.NewLine + $"【装备加成攻击力】：{AdUp}"
                + Environment.NewLine + $"【装备加成法强】：{ApUp}"
                + Environment.NewLine + $"【装备加成护甲】：{ArmorUp}"
                + Environment.NewLine + $"【装备加成魔抗】：{MagicResistanceUp}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "-----技能栏-----"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能一】" + Environment.NewLine + $"{Skills[0].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能二】" + Environment.NewLine + $"{Skills[1].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能三】" + Environment.NewLine + $"{Skills[2].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能四】" + Environment.NewLine + $"{Skills[3].Skillintroduce}";
        }              
               
        public Hero(string name, int money, int hp, int ad, int ap, int armor, int magicResistance, List<Skill> skills)
        {
            Name = name;
            Hp = hp;
            Maxhp = hp;
            Money = money;
            Ad = ad;
            Ap = ap;
            Armor = armor;
            MagicResistance = magicResistance;
            MagicResistanceUp = 0;
            ArmorUp = 0;
            ApUp = 0;
            AdUp = 0;
            Skills = skills;

            Equipments = new List<Equipment>(); 
            for(int i=0;i<6;i++)
            {
                Equipments.Add(wu);
            }

            State = State.Normal;

            herointroduce = $"【英雄名称】：{Name}"
                + Environment.NewLine + $"【英雄血量】：{Hp}/{Maxhp}"
                + Environment.NewLine + $"【现有金钱】：{Money}"
                + Environment.NewLine + $"【英雄基础攻击力】：{Ad}"
                + Environment.NewLine + $"【英雄基础法强】：{Ap}"
                + Environment.NewLine + $"【英雄基础护甲】：{Armor}"
                + Environment.NewLine + $"【英雄基础魔抗】：{Armor}"
                + Environment.NewLine + $"【装备加成攻击力】：{AdUp}"
                + Environment.NewLine + $"【装备加成法强】：{ApUp}"
                + Environment.NewLine + $"【装备加成护甲】：{ArmorUp}"
                + Environment.NewLine + $"【装备加成魔抗】：{MagicResistanceUp}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "-----技能栏-----"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能一】" + Environment.NewLine + $"{Skills[0].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能二】" + Environment.NewLine + $"{Skills[1].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能三】" + Environment.NewLine + $"{Skills[2].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能四】" + Environment.NewLine + $"{Skills[3].Skillintroduce}";
        }

        /// <summary>
        /// 更新英雄状态
        /// </summary>
        public void updateherostate()
        {
            for(int i=0;i<6;i++)
            {
                AdUp += Equipments[i].AdUp;
                ApUp += Equipments[i].ApUP;
                ArmorUp += Equipments[i].ArmorUp;
                MagicResistanceUp += Equipments[i].MagicResistanceUp;                
            }
            for(int i=0;i<4;i++)
            {
                Skills[i].Dmg += (AdUp + ApUp * 2);
                Skills[i].updateskillstate();
            }

            herointroduce = $"【英雄名称】：{Name}"
                + Environment.NewLine + $"【英雄血量】：{Hp}/{Maxhp}"
                + Environment.NewLine + $"【现有金钱】：{Money}"
                + Environment.NewLine + $"【英雄基础攻击力】：{Ad}"
                + Environment.NewLine + $"【英雄基础法强】：{Ap}"
                + Environment.NewLine + $"【英雄基础护甲】：{Armor}"
                + Environment.NewLine + $"【英雄基础魔抗】：{Armor}"
                + Environment.NewLine + $"【装备加成攻击力】：{AdUp}"
                + Environment.NewLine + $"【装备加成法强】：{ApUp}"
                + Environment.NewLine + $"【装备加成护甲】：{ArmorUp}"
                + Environment.NewLine + $"【装备加成魔抗】：{MagicResistanceUp}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "-----技能栏-----"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能一】" + Environment.NewLine + $"{Skills[0].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能二】" + Environment.NewLine + $"{Skills[1].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能三】" + Environment.NewLine + $"{Skills[2].Skillintroduce}"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "----------------"
                + Environment.NewLine + "【技能四】" + Environment.NewLine + $"{Skills[3].Skillintroduce}";
        }
        public void clearbeforeupdate()
        {
            for (int i = 0; i < 4; i++)
            {
                Skills[i].Dmg -= (AdUp + ApUp * 2);
            }
            for (int i = 0; i < 6; i++)
            {
                AdUp -= Equipments[i].AdUp;
                ApUp -= Equipments[i].ApUP;
                ArmorUp -= Equipments[i].ArmorUp;
                MagicResistanceUp -= Equipments[i].MagicResistanceUp;
            }            
        }

        /// <summary>
        /// 出售装备
        /// </summary>
        public bool sellEquipment(Equipment e)
        {
            if(e.Name=="无")
            {
                MessageBox.Show("没有装备！");
                return false;
            }
            else
            {
                MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show($"确定要出售装备{e.Name}？", "提示", mess);
                if (d == DialogResult.OK)
                {
                    AdUp -= e.AdUp;
                    ApUp -= e.ApUP;
                    ArmorUp -= e.ArmorUp;
                    MagicResistanceUp -= e.MagicResistanceUp;
                    Money += e.SellPrice;
                    MessageBox.Show($"出售成功！获得金钱{e.SellPrice}，但英雄属性下降了。");                    
                }
            }
            return true;

        }

    }
}

