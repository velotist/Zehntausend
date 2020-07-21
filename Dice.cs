using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zehntausend
{
    class Dice
    {
        public int Eyes { get; }

        private int DiceEye(int numberOfEyes)
        {
            Random random = new Random();
            int eye = random.Next(1, numberOfEyes);

            return eye;
        }
    }
}
