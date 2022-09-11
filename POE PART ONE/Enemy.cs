using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    protected Random rnd = new Random();
    protected int num = 1;
    // why are the protected members not being inherited ????????
    abstract class Enemy : Character
    {
        public Random rnd = new Random();
        public int num;

        public Enemy(char x, char y) : base(x, y)
        {

        }

        public Enemy(int damage, int startingHP, int maxHP, char x, char y) : base(x, y)  //x and y positions)
        {
            this.maxHP = 0;
            this.damage = 0;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            damage.ToString();
            x.ToString();
            y.ToString();
            //This is defined in the Character subclasses and overrides the traditional Object ToString() method.
            return " Enemy at: " + x + y + damage;
        }
    }
}
