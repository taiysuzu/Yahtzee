using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Dice
    {
        int value;
        Random randGen = new Random();

        Dice(int _value)
        {
            value = _value;
        }

        void Roll()
        {
            value = randGen.Next(1, 6);
        }
    }
}
