using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE112_POE_PART_1
{
    public abstract class Tile //Base class
    {
        //variables
        protected int x; //FIGURE OUT HOW TO DO BOTH PROTECTED AND PUBLIC
        protected int  y;
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

        //public Tile is the constructor and the brackets are the parameters
        public Tile(int x, int y) //Constructor that recieves initial values for these variables
        {
            this.x = x; // only in this class 
            this.y = y;
        }
      

    }
}
