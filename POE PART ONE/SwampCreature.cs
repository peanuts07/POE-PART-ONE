using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    class SwampCreature : Enemy
    {
        private string name = "kes";
        public string Name
        {
            get { return name; } // get method 
            set { name = value; }
        }
        public SwampCreature(int damage, int startingHP, int maxHP, char x, char y) : base(damage, startingHP, maxHP, x, y)  //x and y positions)  /// constructor initializer??
        {
            this.maxHP = 10;
            this.damage = 1;
            this.x = x; // delagting back to the other class??
            this.y = y;
        }

        public override int ReturnMove(int num)
        {
            num = rnd.Next();
            if (num == 0)
            {
                // if position of enemy is not = obsticle 
            }
            else
            { // reroll
                num = rnd.Next();

            }
            return num;
            //randomizes a direction
        }

    }
}
