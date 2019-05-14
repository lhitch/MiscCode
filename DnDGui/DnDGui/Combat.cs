using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DnDGui
{
    static class Combat
    {
        public static void Attack(Character attacker, Character defender, Form1 form)
        {
            int repeat = 0;
            while (repeat < attacker.Weapon.Roll)
            {
                if (Random.RandomNumberGenerator(1, 20) > 14)
                {
                    int damage = Random.RandomNumberGenerator(1, attacker.Weapon.Damage);
                    form.Push_Message("Attack hits! " + defender.Name + " takes " + damage + " damage!");
                    defender.HP -= damage;
                    
                }
                    
                else
                {
                    form.Push_Message(attacker.Name + " missed " + defender.Name + "!");
                    //Thread.Sleep(500);
                }
                //Thread.Sleep(500);
                repeat++;
            }
        }
    }
}
