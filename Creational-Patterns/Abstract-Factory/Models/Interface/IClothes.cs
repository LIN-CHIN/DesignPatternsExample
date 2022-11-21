using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models.Interface
{
    public interface IClothes
    {
        public int Defense { get; }
        public string Name { get; }
        public int GetDefense();
        public string GetName();
    }
}
