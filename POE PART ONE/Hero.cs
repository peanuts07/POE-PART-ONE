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
            this.HP = 10;
            this.maxHP = maxHP;
            this.damage = 2;
            this.x = x;
            this.y = y;
        }

        public override int ReturnMove(int num)
        {

            // a loop to check the vision array againt the move given .. how would we check valid movement ? 
            // so if the . = . then movemnt is vaild 
            // if the . = sth else then its no movement , the value retuened from enum is 0 
            // a number from the enum must then be used in main code to move the char in the dicrection

            //if(num == 0) // 
            //{
            //    if (this.damage > 0)
            //    {

            //    }
            //}
            //else if ()
            //{

            //}

            return num;
            //randomizes a direction
        }
        public override String ToString()
        {
            damage.ToString();
            x.ToString();
            y.ToString();
            //This is defined in the Character subclasses and overrides the traditional Object ToString() method.
            return " Hero at: " + x + y + damage;
        }
    }
}
