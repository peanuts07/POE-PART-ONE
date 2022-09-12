using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE112_POE_PART_1
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            
        }
        public string value="";
        public int number = 10;
        Map obj = new Map();

        private void Form1_Load(object sender, EventArgs e) 
        {
           AddItems();
            Map.FillMap();
            PrintMap();
            SwampCreature swampCreature = new SwampCreature(1, 1, 1,'x','y');

             lblEnemyStats.Text = swampCreature.ToString();
            Hero hero = new Hero('x','y');

            lblHeroStats.Text = hero.ToString();    

            lblEnemyStats.Text = swampCreature.ToString();
            // code to fill the map 

            // get the enemy stats to go here... override of to string isnt workinnggg idk why 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddItems()
        {
            //cmbAttack.Items.Add("e1");  need to add a list of enemies ...how will the thng know which one to attackidk 
            //cmbAttack.Items.Add("e2");
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }



        public void PrintMap()
        {
            for (int row = 0; row < 10; row++)
            {
                // For all columns
                for (int col = 0; col < 10; col++)
                {
                    lblNewMap.Text +=Map.map[row, col];
                    // Make that position the same as the tile passed in
                    
                }
                 lblNewMap.Text += Environment.NewLine;
            }

        }
    }
    


    // what needs to be done next ???? we need to find out how to set the diff vars
    // need to figure out how get the different chars

}
// NOTES : things in not understanding are the abstract modifiers , and some ofthe return values 