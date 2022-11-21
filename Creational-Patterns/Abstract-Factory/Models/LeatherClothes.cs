using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    /// <summary>
    /// 皮衣
    /// </summary>
    public class LeatherClothes : IClothes
    {
        public int Defense
        {
            get 
            {
                return 10;
            }
        }

        public string Name 
        {
            get 
            {
                return "皮衣";
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
