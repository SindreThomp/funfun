using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testing
{
    class Weapon
    {
        public string WepName { get; set; }
        public string WepID { get; set; }
        public string WeaponType { get; set; }
        public int WepDamage { get; set; }

        public List<Weapon> AllWeapons = new List<Weapon>();

        public Weapon()
        {
            
        }

        //Adds weapons to the weaponslist
        public void AddWeapons()
        {
            AllWeapons.Add(new Weapon() { WepID = "1", WepName = "HK-416", WeaponType = "Auto", WepDamage = 25 });
            AllWeapons.Add(new Weapon() { WepID = "2", WepName = "AWM   ", WeaponType = "Bolt", WepDamage = 10 });

            //Prints out every weapon in the list through a foreach-loop
            foreach (Weapon weapon in AllWeapons)
            {
                Console.WriteLine("WeaponId: " + weapon.WepID + " | Name: " + weapon.WepName + " | WeaponType: "
                    + weapon.WeaponType + " | Weapondamage: " + weapon.WepDamage);
            }
        }

        //Finds the wanted weapon based on weapon id
        public void FindWeapon(string WantedID)
        {
            var item = AllWeapons.FirstOrDefault(i => i.WepID.Equals(WantedID));



            if (item.WepID == WantedID)
            {
                Console.WriteLine("You chose " + WantedID + " " + item.WepName);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Not found");
                Console.WriteLine("You chose an ID that doesnt exist. Choose 1 or 2");
                
            }
        }
    }
}
