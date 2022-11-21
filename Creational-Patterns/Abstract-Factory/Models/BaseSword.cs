using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models
{
    /// <summary>
    /// 初學者的劍
    /// </summary>
    public class BaseSword : IWeapon
    {
        public string Name 
        { 
            get 
            {
                return "初學者之劍";
            }
        }
        public int Atk 
        {
            get
            {
                return 200;
            }
        }

        public int GetAtk()
        {
            return Atk;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
