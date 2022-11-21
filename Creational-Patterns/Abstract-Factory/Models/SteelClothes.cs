using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    /// <summary>
    /// 鋼鐵衣
    /// </summary>
    public class SteelClothes : IClothes
    {
        public int Defense
        {
            get
            {
                return 200;
            }
        }
            
        public string Name
        {
            get
            {
                return "鋼鐵衣";
            }
        }

        public int GetDefense()
        {
            return Defense;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
