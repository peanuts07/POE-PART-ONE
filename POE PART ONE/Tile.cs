using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    public abstract class Tile
    {
        //variables
        protected char x; //FIGURE OUT HOW TO DO BOTH PROTECTED AND PUBLIC
        protected char y;
        public enum TileType
        {
            Hero, // 0
            Enemy, // 1
            Gold, // 2
            Weapon // 3
        }
        public Tile()
        {

        }
        public Tile(int X, int Y) //Constructor that recieves initial values for these variables
        {
            this.x = x; // only in this class 
            this.y = y;
        }
    }
}
