using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_CODE_GADE_SEMESTER_2_PART_1
{
    class SwampCreature : Enemy
    {
        private string name = "kes";
        public string Name
        {
            get { return name; } // get method 
            set { name = value; }
        }
        public SwampCreature(int damage, int startingHP, int maxHP, int x, int y) : base(damage, startingHP, maxHP, x, y)  //x and y positions)  /// constructor initializer??
        {
           
            this.maxHP = 10;
            this.damage = 1;
            this.x = x; // delagting back to the other class??
            this.y = y;
        }
        //public SwampCreature()
        //{

        //}
   
        

        //delegate its variable settings
        //////////////////////HOW TO DELEGATE MOSTLY TO ENEMY CLASS///////////////////////////////////////

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
