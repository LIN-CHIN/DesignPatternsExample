using Abstract_Factory.Models;
using Abstract_Factory.Models.Factory;
using Abstract_Factory.Models.Factory.Interface;
using System;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User 輸入的職業
            string job = "Warrior"; 

            //裝備工廠
            IEquipmentFactory equipmentFactory = null ;
            IAdventurer adventurer = null;

            //之後用 DI 取代 
            if (job == "Archer")
            {
                equipmentFactory = new ArcherEquipmentFactory();
                adventurer = new Archer();
            }
            else if (job == "Warrior")
            {
                equipmentFactory = new WarriorEquipmentFactory();
                adventurer = new Warrior();
            }

            Console.WriteLine("職業:" + adventurer.GetName());
            Console.WriteLine("Str:" + adventurer.GetStr());
            Console.WriteLine("Dex:" + adventurer.GetDex());
            Console.WriteLine("Int:" + adventurer.GetInt());
            Console.WriteLine("Luk:" + adventurer.GetLuk());

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("武器名稱:" + equipmentFactory.CreateWeaponFacotry().GetName());
            Console.WriteLine("武器攻擊力:" + equipmentFactory.CreateWeaponFacotry().GetAtk());
            Console.WriteLine("防具名稱:" + equipmentFactory.CreateClothesFacotry().GetName());
            Console.WriteLine("防具防禦力:" + equipmentFactory.CreateClothesFacotry().GetDefense());
        }
    }
}
