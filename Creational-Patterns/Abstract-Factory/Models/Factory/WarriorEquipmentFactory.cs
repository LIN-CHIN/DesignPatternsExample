using Abstract_Factory.Models.Factory.Interface;
using Abstract_Factory.Models.Interface;

namespace Abstract_Factory.Models.Factory
{
    /// <summary>
    /// 劍士裝備工廠
    /// </summary>
    public class WarriorEquipmentFactory : IEquipmentFactory
    {
        public IClothes CreateClothesFacotry()
        {
            return new SteelClothes();
        }

        public IWeapon CreateWeaponFacotry()
        {
            return new BaseSword();
        }
    }
}