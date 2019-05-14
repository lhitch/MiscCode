using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGui
{
    static class Random
    {
        private static readonly System.Random variable = new System.Random();

        public static int RandomNumberGenerator(int min, int max)
        {
            return variable.Next(min, max + 1);
        }
    }
}
