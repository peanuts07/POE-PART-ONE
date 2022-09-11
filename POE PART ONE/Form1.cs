namespace POE_PART_ONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string value = " ";
        public int number = 10;
        Map obj = new Map();

        private void Form1_Load(object sender, EventArgs e)
        {
            AddItems();
            Map.FillMap();
            PrintMap();
            SwampCreature swampCreature = new SwampCreature(1, 1, 1, 'x', 'y');

            lblEnemyStats.Text = swampCreature.ToString();
            Hero hero = new Hero('x', 'y');

            lblHeroStats.Text = hero.ToString();

            lblEnemyStats.Text = swampCreature.ToString();
            //code to fill the map

            //get the enmy stats to go here ... override of to string isnt working

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}