using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_ONE
{
    internal class Map
    {
        // declare objects in other classes ? 
        public string heroTile = "H";
        public string enemyTile = "E";
        public string emptyTile = ".";
        public string[] enemies; // need to make 2d possibly for the diff postions
        private int minSizeWidth = 8;
        private int maxSizeWidth = 17;
        private int minSizeHeight = 14;
        private int maxSizeHeight = 29;
        public static Random newInt = new Random();
        public static int sizeW;
        public int sizeH;
        private int number = 10;
        public static int positionXE;
        public static int positionYE;
        public static int positionXH;
        public static int positionYH;
        public static string mapChar = "?";// Hero.TileType             look into this one 
        Tile Tile { get; set; } // we need to figure that one out when the power is back 

        public static string[,] map; // random size of  map 

        public Map()
        {
            sizeH = newInt.Next(minSizeHeight, maxSizeHeight);
            sizeW = newInt.Next(minSizeWidth, maxSizeWidth);
            map = new string[sizeW, sizeH];

            FillMap();
            //Create(); 
            //create(int numb)    

            // that thing that gets the remainder to set how many enemies % 

        }
        public void mapSize()
        {

        }
        private static void Create() // for heero
        {
            positionXH = newInt.Next(2, 9);
            positionYH = newInt.Next(2, 9);
            //  mapBuild[positionXH, positionYH] = type; // fix it to be char


        }
        private static void Create(int number) // for enemy
        {
            // int newNum = number % sizeW; // to get number of enemies
            positionXE = 4;
            positionXE = 4;
            //  enemies = new string[newNum];
            // change

        }

        public static void UpdateVison() // probably will be something like the crossword game passing the tile array... nvm
        {
            // must somehow collect data from the view north south east west 

        }
        // how to border the map , loop ? for evry miSin and max value put an x 

        public static void FillMap()
        {

            Create();
            Create(1);
            // For all rows
            for (int row = 0; row < 10; row++)
            {


                // For all columns
                for (int col = 0; col < 10; col++)
                {
                    if (row == 0)
                    {
                        map[row, col] = "X";

                    }
                    else if (col == 0)
                    {
                        map[row, col] = "X";
                    }
                    else if (row == 9)
                    {
                        map[row, col] = "X";
                    }
                    else if (col == 9)
                    {
                        map[row, col] = "X";
                    }
                    else if (row == positionXE && col == positionYE) // this doesnt work to randomly set the enemy.. why
                    {

                        map[row, col] = "E";

                    }
                    else if (row == positionXH && col == positionYH)
                    {
                        map[row, col] = "H";
                    }

                    else
                    {
                        map[row, col] = ".";
                    }
                }
                // where to check  reroll 
            }
        }
    }
}

