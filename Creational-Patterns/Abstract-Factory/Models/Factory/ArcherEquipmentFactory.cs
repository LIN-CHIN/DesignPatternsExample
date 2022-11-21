using Abstract_Factory.Models.Factory.Interface;
using Abstract_Factory.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Models.Factory
{
    /// <summary>
    /// 弓箭手裝備工廠
    /// </summary>
    public class ArcherEquipmentFactory : IEquipmentFactory
    {
        public IClothes CreateClothesFacotry()
        {
            return new LeatherClothes();
        }

        public IWeapon CreateWeaponFacotry()
        {
            return new BaseBow();
        }
    }
}
