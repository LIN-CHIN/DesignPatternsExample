using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models
{
    /// <summary>
    /// 劍士職業
    /// </summary>
    public class Warrior : IAdventurer
    {
        public string Name
        {
            get
            {
                return "劍士";
            }
        }
        public int Str
        {
            get
            {
                return 8;
            }
        }

        public int Dex
        {
            get
            {
                return 3;
            }
        }

        public int Int
        {
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
