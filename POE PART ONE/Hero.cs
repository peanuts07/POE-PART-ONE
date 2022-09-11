using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    class Hero : Character
    {
        public Hero(char x, char y, int HP) : base(x, y)
        {
            //set the hp and max hp of hero based on parameter
            //hero's damage is always 2
        }
    }
}
