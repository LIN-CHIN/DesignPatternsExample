using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models.Factory.Interface
{
    public interface IEquipmentFactory
    {
        public IClothes CreateClothesFacotry();

        public IWeapon CreateWeaponFacotry();
    }
}
