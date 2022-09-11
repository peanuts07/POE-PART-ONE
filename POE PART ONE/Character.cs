using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    abstract class Character : Tile 
    {
        //Protected variables and public where necessary WHICH ONES NEED PUBLIC?
        protected int HP { get; set; }
        protected int maxHP { get; set; }
        protected int damage { get; set; }
        protected object[] arr = new object[6]; // array ??

        //Tile array for character vision                                                                                                      possubly use the objects array
        public enum Movement
        {
            noMovement,
            up,
            down,
            left,
            right
        }
        //a constructor that recieves x and y positions
        public Character(char x, char y) : base(x, y) //Constructor calls base class constructor with x, y parameters
        {

        }
        public Character()
        {

        }
        public virtual void Attack(Character target)
        {
            // attacks a target and decreases its health by attacking characters damage
        }

        public bool IsDead()
        {
            bool isDead = false;
            //checks if character is dead
            return isDead;
        }

        private int DistanceTo(Character target)
        {
            return Math.Abs(target.x - x) + Math.Abs(target.y - y); // code given as a hint ,i  dont understand it
        }
        public virtual bool CheckRange(Character target)
        {
            return DistanceTo(target) <= 3;
        }

        //public virtual void CheckRange(Character target)
        //{
        //    //checks if a target is is in range of character
        //    //Determines distance via the DistanceTo() method and returns true or false
        //}

        //private int DistanceTo(Character target)
        //{

        //    int value = Convert.ToInt32(target); // iddkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
        //                                         // used by checkRange()
        //    return value;
        //}

        public void Move(Movement move) /// no such thing as MovementEnum 
        {
            //Edits a unit’s X and Y values to move it up/down/left/right based on the identifier from the enum
        }

        public virtual int ReturnMove(int num)
        {
            int newMove = 0;
            return newMove;
            //The method returns a direction of movement based on how the character should move, based on the validity of that move against a Character’s vision array
        }

        public override string ToString()
        {
            //string stringValue= "";

            damage.ToString();
            x.ToString();
            y.ToString();
            //This is defined in the Character subclasses and overrides the traditional Object ToString() method.
            return " char at: " + x + y + damage;
        }
    }
}
