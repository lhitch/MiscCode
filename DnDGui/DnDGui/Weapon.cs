using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGui
{
    abstract class Weapon
    {
        private string name;
        private int roll;
        private int damage;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        //abstract method
        public abstract void GetAttackString(string n);
    }
}
