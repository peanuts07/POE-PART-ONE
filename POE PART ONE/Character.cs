using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    abstract class Character : Tile 
    {
        public Character(char x, char y) : base(x, y)  //a constructor that recieves x and y positions
        {
            //NEEDS SYMBOL
        }
    }
}
