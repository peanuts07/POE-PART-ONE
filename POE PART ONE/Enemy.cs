using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    abstract class Enemy : Character
    {
        public Random rnd = new Random();
        public int num;

        public Enemy(char x, char y) : base(x, y)
        {

        }

        public Enemy(int damage, int startingHP, int maxHP, char x, char y) : base(x, y)  //x and y positions)
        {

        }
    }
}
