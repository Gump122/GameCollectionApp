using System;

namespace HeroGame
{
    /// <summary>
    /// 装备类
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// 装备名称
        /// </summary>
        private string name;

        /// <summary>
        /// 攻击加成
        /// </summary>
        private int adUp;

        /// <summary>
        /// 法强加成
        /// </summary>
        private int apUP;

        /// <summary>
        /// 护甲加成
        /// </summary>
        private int armorUp;

        /// <summary>
        /// 魔抗加成
        /// </summary>
        private int magicResistanceUp;

        /// <summary>
        /// 购买价格
        /// </summary>
        private int buyPrice;

        /// <summary>
        /// 出售价格
        /// </summary>
        private int sellPrice;

        /// <summary>
        /// 装备类型
        /// </summary>
        private EquipmentType type;

        /// <summary>
        /// 回复血量
        /// </summary>
        private int hp;

        /// <summary>
        /// 装备介绍
        /// </summary>
        private string equipmentintroduce;

        
        public string Name { get => name; set => name = value; }
        public int AdUp { get => adUp; set => adUp = value; }
        public int ApUP { get => apUP; set => apUP = value; }
        public int ArmorUp { get => armorUp; set => armorUp = value; }
        public int MagicResistanceUp { get => magicResistanceUp; set => magicResistanceUp = value; }
        public int BuyPrice { get => buyPrice; set => buyPrice = value; }
        public int SellPrice { get => sellPrice; set => sellPrice = value; }
        public EquipmentType Type { get => type; set => type = value; }
        public int Hp { get => hp; set => hp = value; }
        public string Equipmentintroduce { get => equipmentintroduce; set => equipmentintroduce = value; }

        public Equipment(string name, int adUp, int apUP, int armorUp, int magicResistanceUp, int buyPrice, int sellPrice, EquipmentType type, int hp)
        {
            this.Name = name;
            this.AdUp = adUp;
            this.ApUP = apUP;
            this.ArmorUp = armorUp;
            this.MagicResistanceUp = magicResistanceUp;
            this.BuyPrice = buyPrice;
            this.SellPrice = sellPrice;
            this.Type = type;
            this.Hp = hp;

            if(type==EquipmentType.Normal)
            {
                this.equipmentintroduce = $"【装备名称】：{name}"
                  + Environment.NewLine + $"【装备花费】：{buyPrice}"
                  + Environment.NewLine + $"【出售价格】：{sellPrice}"
                  + Environment.NewLine + $"【装备类型】：普通类型"
                  + Environment.NewLine + $"【攻击加成】：{adUp}"
                  + Environment.NewLine + $"【法术加成】：{apUP}"
                  + Environment.NewLine + $"【护甲加成】：{armorUp}"
                  + Environment.NewLine + $"【魔抗加成】：{magicResistanceUp}";
            }
            else
            {
                this.equipmentintroduce = $"【装备名称】：{name}"
                  + Environment.NewLine + $"【装备花费】：{buyPrice}"
                  + Environment.NewLine + $"【出售价格】：{sellPrice}"
                  + Environment.NewLine + $"【装备类型】：消耗品"
                  + Environment.NewLine + $"【装备回复生命值】：{hp}"
                  + Environment.NewLine + $"【攻击加成】：{adUp}"
                  + Environment.NewLine + $"【法术加成】：{apUP}"
                  + Environment.NewLine + $"【护甲加成】：{armorUp}"
                  + Environment.NewLine + $"【魔抗加成】：{magicResistanceUp}";
            }
        }
               
       
    }
}

