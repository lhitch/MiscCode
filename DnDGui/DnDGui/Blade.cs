using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGui
{
    class Blade : Weapon
    {
        public Blade (string s)
        {
            Name = s;
        }

        public override void GetAttackString(string n)
        {
            switch(n)
            {
                case "Longsword":
                    Roll = 1;
                    Damage = 8;
                    break;
                case "Dagger":
                    Roll = 2;
                    Damage = 4;
                    break;
                default:
                    break;
            }
        }
    }
}
