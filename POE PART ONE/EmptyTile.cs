using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    abstract class EmptyTile : Tile
    {
        public EmptyTile(char x, char y) : base(x, y) //Constructor calls base class constructor with x, y parameters
        {
            //Denote an empty tile
        }
    }
}
