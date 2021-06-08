using System;

namespace HeroGame
{
    /// <summary>
    /// 装备类
    /// </summary>
    class Equipment
    {
        /// <summary>
        /// 装备名称
        /// </summary>
        public string name;

        /// <summary>
        /// 攻击加成
        /// </summary>
        public int adUp;

        /// <summary>
        /// 法强加成
        /// </summary>
        public int apUP;

        /// <summary>
        /// 护甲加成
        /// </summary>
        public int armorUp;

        /// <summary>
        /// 魔抗加成
        /// </summary>
        public int magicResistanceUp;

        /// <summary>
        /// 购买价格
        /// </summary>
        public int buyPrice;

        /// <summary>
        /// 出售价格
        /// </summary>
        public int sellPrice;

        /// <summary>
        /// 装备类型
        /// </summary>
        public EquipmentType type;

        /// <summary>
        /// 回复血量
        /// </summary>
        public int hp;

        public Equipment(string name, int adUp, int apUP, int armorUp, int magicResistanceUp, int buyPrice, int sellPrice, EquipmentType type, int hp)
        {
            this.name = name;
            this.adUp = adUp;
            this.apUP = apUP;
            this.armorUp = armorUp;
            this.magicResistanceUp = magicResistanceUp;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.type = type;
            this.hp = hp;
        }

        /// <summary>
        /// 装备详情介绍方法
        /// </summary>
        public void Introduce()
        {
            if (type == EquipmentType.Normal)
            {
                Console.WriteLine($"-------【装备名称】：{name}-------");
                Console.WriteLine($"【装备花费：{buyPrice}】");
                Console.WriteLine($"【装备类型：普通类型】");
                Console.WriteLine($"【攻击加成：{adUp}】");
                Console.WriteLine($"【法术加成：{apUP}】");
                Console.WriteLine($"【护甲加成：{armorUp}】");
                Console.WriteLine($"【魔抗加成：{magicResistanceUp}】");
                Console.WriteLine("---------------------------------------------");
            }
            else
            {
                Console.WriteLine($"-------【装备名称】：{name}-------");
                Console.WriteLine($"【装备花费：{buyPrice}】");
                Console.WriteLine($"【装备类型：消耗品】");
                Console.WriteLine($"【装备回复生命值：{hp}】");
                Console.WriteLine("---------------------------------------------");
            }

        }

    }
}

