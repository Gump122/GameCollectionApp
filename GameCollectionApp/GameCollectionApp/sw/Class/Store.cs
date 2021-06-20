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

    }
}

