using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models
{
    /// <summary>
    /// 初學者的弓
    /// </summary>
    public class BaseBow : IWeapon
    {
        public string Name 
        { 
            get 
            {
                return "初學者之弓";
            }
        }
        public int Atk
        {
            get
            {
                return 100;
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
