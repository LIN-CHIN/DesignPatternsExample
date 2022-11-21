using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models.Interface
{
    public interface IWeapon
    {
        public string Name { get; }
        public int Atk { get; }
        public string GetName();

        public int GetAtk();
    }
}
