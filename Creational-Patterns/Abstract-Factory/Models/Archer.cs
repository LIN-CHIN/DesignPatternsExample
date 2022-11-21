using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models
{
    /// <summary>
    /// 弓箭手職業
    /// </summary>
    public class Archer : IAdventurer
    {
        public string Name {
            get 
            {
                return "弓箭手";
            }
        }
        public int Str { 
            get 
            {
                return 3;
            }
        }

        public int Dex {
            get
            {
                return 8;
            }
        }

        public int Int {
            get 
            {
                return 3;
            }
        }

        public int Luk
        {
            get
            {
                return 3;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public int GetStr()
        {
            return Str;
        }

        public int GetDex()
        {
            return Dex;
        }

        public int GetInt()
        {
            return Int;
        }

        public int GetLuk()
        {
            return Luk;
        }

    }
}
