using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_CODE_GADE_SEMESTER_2_PART_1
{
     class Hero : Character
    {
        protected static int HX = Map.positionXH;
        protected static int HY = Map.positionYH;

        public Hero(int x , int y ) : base ( x, y) 
        {
            this.HP = 10;
            this.maxHP = maxHP;
            this.damage = 2;
            this.x = x;
            this.y = y; 
            
        }

        // need to figure out how to pass key press events 
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

        public  override String ToString()
        {
            damage.ToString();
            x.ToString();
            y.ToString();
            //This is defined in the Character subclasses and overrides the traditional Object ToString() method.
            return " Hero at: " +HX + HY + " " + damage;
        }
    }
}
