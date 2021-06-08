
using System.Collections.Generic;

namespace HeroGame
{
    /// <summary>
    /// 商店类
    /// </summary>
    class Store
    {
        /// <summary>
        /// 装备仓库
        /// </summary>
        public static List<Equipment> store = new List<Equipment>();

        /// <summary>
        /// 介绍商店所有装备信息
        /// </summary>
        public static void Introduce()
        {
            foreach (var item in store)
            {
                item.Introduce();
            }
        }

    }
}

