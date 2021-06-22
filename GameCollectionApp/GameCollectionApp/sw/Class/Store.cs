using System.Collections.Generic;

namespace HeroGame
{
    /// <summary>
    /// 商店类
    /// </summary>
    public class Store
    {
        /// <summary>
        /// 装备仓库,英雄购买装备时英雄装备引用指向仓库已有装备对象而不再创建新对象
        /// </summary>
        public static List<Equipment> store = new List<Equipment>();

        public Store()
        {
            //新建装备
            Equipment sanxiangzhili = new Equipment("三相之力", 45, 45, 30, 30, 3000, 1500, EquipmentType.Normal, 0);
            Equipment wujinzhiren = new Equipment("无尽之刃", 100, 0, 0, 0, 2000, 1000, EquipmentType.Normal, 0);
            Equipment ludengdehuixiang = new Equipment("卢登的回响", 0, 100, 20, 20, 3550, 1700, EquipmentType.Normal, 0);
            Equipment qiang = new Equipment("海克斯科技枪(回复HP300点)", 0, 35, 10, 10, 3000, 1200, EquipmentType.Normal, 300);
            Equipment jian = new Equipment("饮血剑（回复HP300点）", 70, 0, 10, 10, 3000, 1200, EquipmentType.Normal, 300);
            Equipment tiebushan = new Equipment("铁布衫", 5, 5, 45, 45, 1800, 900, EquipmentType.Normal, 0);
            Equipment riyandoupeng = new Equipment("日炎斗篷", 0, 20, 30, 55, 2500, 1250, EquipmentType.Normal, 0);            
            Equipment fujizhizhua = new Equipment("伏击之爪", 10, 10, 20, 70, 3800, 900, EquipmentType.Normal, 500);
            Equipment feizhaikuaileshui = new Equipment("肥宅快乐水", 15, 5, 15, 10, 1000, 0, EquipmentType.Consumables, 500);
            Equipment jiushu = new Equipment("救赎", 0, 0, 30, 30, 4500, 0, EquipmentType.Consumables, 1500);

            //将新建的装备放入商店
            store.Add(sanxiangzhili);
            store.Add(wujinzhiren);
            store.Add(ludengdehuixiang);
            store.Add(qiang);
            store.Add(jian);
            store.Add(tiebushan);
            store.Add(riyandoupeng);
            store.Add(fujizhizhua);
            store.Add(feizhaikuaileshui);
            store.Add(jiushu);

        }
        
    }
}

