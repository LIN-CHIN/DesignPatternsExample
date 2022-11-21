using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    /// <summary>
    /// 冒險家介面
    /// </summary>
    public interface IAdventurer
    {
        public string Name { get; }
        public int Str { get; }
        public int Dex { get; }
        public int Int { get; }
        public int Luk { get; }

        public string GetName();
        public int GetStr();
        public int GetDex();
        public int GetInt();
        public int GetLuk();
    }
}
