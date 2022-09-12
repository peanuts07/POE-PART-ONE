using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_CODE_GADE_SEMESTER_2_PART_1
{
   
    abstract class Enemy : Character
    {
         protected Random rnd = new Random();
         protected int num=1;
        protected static  int EX = Map.positionXE;
        protected static  int EY = Map.positionYE;

        public Enemy(int damage, int startingHP, int maxHP, int x, int y) : base(x, y)  //x and y positions)  /// constructor initializer??
        {
            
            this.maxHP = 0;
            this.damage = 0;
            this.x = EX;
            this.y = EY; 
        }
        public Enemy()
        {

        }
        // is ther a way to access the to string from the character class ??? , maybe it will fix problem in main code 
       

        public override string ToString()
        {
            damage.ToString();
            x.ToString();
            y.ToString();
            //This is defined in the Character subclasses and overrides the traditional Object ToString() method.
            return " Enemy at: " + EX + EY + " " + damage;
        }



    }
}
