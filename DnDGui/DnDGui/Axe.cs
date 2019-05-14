using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGui
{
    class Axe : Weapon
    {
        public Axe (string s)
        {
            Name = s;
        }

        public override void GetAttackString(string n)
        {
            switch (n)
            {
                case "Greataxe":
                    Roll = 1;
                    Damage = 12;
                    break;
                default:
                    break;
            }
        }
    }
}
