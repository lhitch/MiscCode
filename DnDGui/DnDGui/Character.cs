using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGui
{
    class Character
    {
        //private
        private string name;
        private int str;
        private int dex;
        private int con;
        private int health;
        private Weapon weapon;

        //properties
        public string Name
        {
            get { return name; }
            set {name = value; }
        }
        public int STR
        {
            get { return str; }
            set { str = value; }
        }
        public int DEX
        {
            get { return dex; }
            set { dex = value; }
        }
        public int CON
        {
            get { return con; }
            set { con = value; }
        }
        public int HP
        {
            get { return health; }
            set { health = value; }
        }
        public Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        //methods
        public void SetStats()
        {
            STR = Random.RandomNumberGenerator(10,18);
            DEX = Random.RandomNumberGenerator(10, 18);
            CON = Random.RandomNumberGenerator(10, 18);
            //using normal DnD HP calc based off CON stats. HD + CON modifier
            HP = Random.RandomNumberGenerator(10, 20) + ((CON - 10) / 2);
        }

        public void SetWeapon(int choice)
        {
            if (choice == 1)
            {
                Weapon = (Weapon)new Blade("Longsword");
                Weapon.GetAttackString(Weapon.Name);
            }
            else if (choice == 2)
            {
                Weapon = (Weapon)new Axe("Greataxe");
                Weapon.GetAttackString(Weapon.Name);
            }
            else
            {
                Weapon = (Weapon)new Blade("Dagger");
                Weapon.GetAttackString(Weapon.Name);
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nStrength: {1}\nDexterity: {2}\nConstitution: {3}\nHealth: {4}\n", Name, STR, DEX, CON, HP);
        }

        public Character()
        {

        }

        public Character(string n)
        {
            Name = n;
        }

    }
}
