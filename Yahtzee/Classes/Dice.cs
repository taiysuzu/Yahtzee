using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Dice
    {
        public int value;
        public bool frozen = false;

        public Dice(int _value)
        {
            value = _value;
        }

        public void Roll()
        {
            if (frozen == false)
            {
                value = GameScreen.randGen.Next(1, 7);
            }
            else
            {
            }
        }
    }
}
