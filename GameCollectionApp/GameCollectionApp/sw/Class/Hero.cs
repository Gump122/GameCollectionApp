using System;
using System.Collections.Generic;

namespace HeroGame
{
    /// <summary>
    /// 英雄类
    /// </summary>
    class Hero
    {
        /// <summary>
        /// 英雄名称
        /// </summary>
        public string name;

        /// <summary>
        /// 英雄血量
        /// </summary>
        public int hp;

        /// <summary>
        /// 英雄拥有金钱
        /// </summary>
        public int money;

        /// <summary>
        /// 英雄基础攻击力
        /// </summary>
        public int ad;

        /// <summary>
        /// 英雄基础法强
        /// </summary>
        public int ap;

        /// <summary>
        /// 英雄基础护甲
        /// </summary>
        public int armor;

        /// <summary>
        /// 英雄基础魔抗
        /// </summary>
        public int magicResistance;

        /// <summary>
        /// 装备加成魔抗
        /// </summary>
        public int magicResistanceUp;

        /// <summary>
        /// 装备护甲加成
        /// </summary>
        public int armorUp;

        /// <summary>
        /// 装备加成法强
        /// </summary>
        public int apUp;

        /// <summary>
        /// 装备加成攻击力
        /// </summary>
        public int adUp;

        /// <summary>
        /// 英雄所有技能
        /// </summary>
        public List<Skill> skills;

        /// <summary>
        /// 英雄装备栏
        /// </summary>
        public List<Equipment> equipments;

        /// <summary>
        /// 英雄状态
        /// </summary>
        public State state;

        /// <summary>
        /// 学习技能
        /// </summary>
        /// <param name="num"></param>
        public bool StudySkill(int num)
        {
            //调用技能学习方法
            return skills[num].StudySkill();
        }

        /// <summary>
        /// 升级技能
        /// </summary>
        /// <param name="num"></param>
        public bool UpgradeSkill(int num)
        {
            //调用技能升级方法
            return skills[num].LevelUp();
        }

        /// <summary>
        /// 英雄普通攻击方法
        /// </summary>
        public bool Attack(Hero hero)
        {
            //被攻击的英雄掉血
            hero.hp -= (ad + adUp);

            Console.WriteLine($"{name}对{hero.name}使用了普通攻击");
            Console.WriteLine($"对{hero.name}造成了{ad + adUp}点伤害");
            Console.WriteLine($"{hero.name}剩余血量：{hero.hp}");
            Console.WriteLine($"{name}获得了{(ad + adUp) * 10}的金钱");

            //攻击获得金钱
            money += (ad + adUp) * 10;

            Console.WriteLine($"{name}当前拥有的金钱数量是{money}");

            //判断被攻击者是否死亡
            if (hero.hp <= 0)
            {
                Console.WriteLine($"{hero.name}已经死亡！");
                return true;
            }

            return false;
        }

        /// <summary>
        /// 英雄技能攻击方法
        /// </summary>
        /// <param name="hero">被攻击的英雄</param>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool AttackBySkill(Hero hero, Skill skill)
        {
            skill.cdCount = 0;

            //被攻击的英雄掉血
            hero.hp -= skill.dmg * skill.level;

            hero.state = skill.state;

            Console.WriteLine($"{name}对{hero.name}使用了{skill.name}");
            Console.WriteLine($"对{hero.name}造成了{skill.dmg * skill.level}点伤害");
            Console.WriteLine($"{hero.name}被{name}{skill.state}了");
            Console.WriteLine($"{hero.name}剩余血量：{hero.hp}");
            Console.WriteLine($"{name}获得了{skill.dmg * skill.level * 10}的金钱");

            //攻击所得金钱
            money += skill.dmg * skill.level * 10;

            Console.WriteLine($"{name}当前拥有的金钱数量是{money}");

            //判断被攻击者是否死亡
            if (hero.hp <= 0)
            {
                Console.WriteLine($"{hero.name}被击杀了");
                return true;
            }

            return false;
        }

        /// <summary>
        /// 购买装备方法
        /// </summary>
        public bool BuyEquipment(Equipment equipment)
        {
            //限制购买数量
            if (equipments.Count > 6)
            {
                Console.WriteLine($"{name}不能再购买更多的装备了！");
                return true;
            }

            if (equipment == null)
            {
                Console.WriteLine("请输入正确的指令！");
                return false;
            }

            //判断所有金钱是否足够购买
            if (money < equipment.buyPrice)
            {
                Console.WriteLine($"【{name}当前没有足够的金钱】");
                return false;
            }
            else if (equipment.type == EquipmentType.Consumables)
            {
                hp += equipment.hp;

                money -= equipment.buyPrice;

                Console.WriteLine($"【购买{equipment.name}成功！】");
                Console.WriteLine($"【{name}恢复了{equipment.hp}点生命】");
                Console.WriteLine($"【{name}当前的血量是{hp}】");

                return true;

            }
            else
            {
                equipments.Add(equipment);
                Console.WriteLine($"{name}购买了{equipment.name}，{name}变强了！");

                //扣除金钱
                money -= equipment.buyPrice;

                //计算装备加成
                adUp += equipment.adUp;
                apUp += equipment.apUP;
                armorUp += equipment.armorUp;
                magicResistanceUp += equipment.magicResistanceUp;

                return true;
            }
        }

        public Hero(string name, int hp, int ad, int ap, int armor, int magicResistance, List<Skill> skills)
        {
            this.name = name;
            this.hp = hp;
            money = 0;
            this.ad = ad;
            this.ap = ap;
            this.armor = armor;
            this.magicResistance = magicResistance;
            magicResistanceUp = 0;
            armorUp = 0;
            apUp = 0;
            adUp = 0;
            this.skills = skills;
            equipments = new List<Equipment>();
            state = State.Normal;
        }

        /// <summary>
        /// 介绍英雄技能方法
        /// </summary>
        public void IntroduceSkill()
        {
            foreach (var item in skills)
            {
                item.Introduce();
            }
        }

        /// <summary>
        /// 开始PK
        /// </summary>
        public Hero PKWith(Hero hero)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"【{name}的回合】");
            IntroduceSkill();

            //控制学习技能的循环的标记
            bool studyFlag = true;

            //控制购买或攻击的循环的标记
            bool flag = true;

            //如果所有技能都已经满级，不再进入技能相关的循环
            if (skills[0].level == 3 && skills[1].level == 3 && skills[2].level == 3 && skills[3].level == 3)
            {
                Console.WriteLine("您的所有技能都已满级！");
                studyFlag = false;
            }

            //控制技能学习与升级的循环
            while (studyFlag)
            {
                Console.WriteLine("请选择学习技能还是升级技能:0-学习,1-升级");

                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("请输入技能编号：");
                        int num01 = Int32.Parse(Console.ReadLine());

                        //如果学习成功，标记改为false结束循环
                        if (StudySkill(num01))
                        {
                            studyFlag = false;
                        }
                        break;

                    case "1":
                        Console.WriteLine("请输入技能编号：");
                        int num02 = Int32.Parse(Console.ReadLine());

                        //如果升级成功，标记改为false结束循环
                        if (UpgradeSkill(num02))
                        {
                            studyFlag = false;
                        }
                        break;

                    default:
                        Console.WriteLine("您输入的指令不正确！");
                        break;
                }
            }

            //控制每回合行动的循环
            while (flag)
            {
                //首先判断英雄当前所处的状态
                if (state == State.Normal)
                {
                    Console.WriteLine($"{name}当前的状态是：{state}");

                    Console.WriteLine("********************************");

                    Console.WriteLine("请输入指令：0-购买装备,1-普通攻击,2-技能攻击");

                }
                else if (state == State.Silence)
                {
                    Console.WriteLine($"{name}当前的状态是：{state}");

                    Console.WriteLine("********************************");

                    Console.WriteLine("请输入指令：0-购买装备,1-普通攻击");

                }
                else
                {
                    Console.WriteLine($"{name}当前的状态是：{state}");

                    Console.WriteLine("********************************");

                    Console.WriteLine("请输入指令：0-购买装备");
                }

                switch (Console.ReadLine())
                {
                    case "0":

                        Console.WriteLine($"{name}正在购买装备。。。");
                        Store.Introduce();

                        Console.WriteLine("请输入你要购买的装备的编号：（输入666退出）");

                        int num03 = Int32.Parse(Console.ReadLine());

                        //判断指令决定是否退出行动并结束本回合
                        if (num03 == 666)
                        {
                            flag = false;
                            break;
                        }
                        else if (BuyEquipment(Store.store[num03]))
                        {
                            flag = false;
                        }
                        break;

                    case "1":
                        //根据英雄状态决定是否可以执行此操作
                        if (state == State.Dizziness)
                        {
                            Console.WriteLine($"{name}在当前状态下不能执行此操作！");
                            break;
                        }

                        //判断英雄是否死亡已决定是否结束游戏
                        if (Attack(hero))
                        {
                            return this;
                        }
                        flag = false;
                        break;

                    case "2":
                        //根据英雄状态决定是否可以执行此操作
                        if (state != State.Normal)
                        {
                            Console.WriteLine($"{name}在当前状态下不能执行此操作！");
                            break;
                        }

                        Console.WriteLine($"{name}当前可以释放以下技能。。。");

                        //用来保存所有可用的技能
                        List<Skill> usableSkill = new List<Skill>();

                        //查出所有已学且cd好的技能
                        foreach (var item in skills)
                        {
                            if (item.isStudy && item.cd == item.cdCount)
                            {
                                //将符合条件的技能放入可用技能的集合
                                usableSkill.Add(item);
                                item.Introduce();
                            }
                        }

                        Console.WriteLine("请输入技能编号：");

                        int num04 = Int32.Parse(Console.ReadLine());

                        //判断英雄是否死亡已决定是否结束游戏
                        if (AttackBySkill(hero, usableSkill[num04]))
                        {
                            return this;
                        }
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("请输入正确的指令！");
                        break;
                }
            }
            //英雄所有技能刷新cd时间一回合
            foreach (var item in skills)
            {
                if (item.cdCount != item.cd)
                {
                    item.cdCount++;
                }
            }

            state = State.Normal;

            //（这里是用两个英雄来回调用各自的PKWith()函数实现回合制，直到一方死亡）返回获胜英雄
            return hero.PKWith(this);

        }


    }
}

