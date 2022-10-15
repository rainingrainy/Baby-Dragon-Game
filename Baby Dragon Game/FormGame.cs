using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baby_Dragon_Game
{
    public partial class FormGame : Form
    {
        BabyDragon dragon = new BabyDragon();
        TopObstacle[] tobstacle = new TopObstacle[3];
        BottomObstacle[] bobstacle = new BottomObstacle[3];
        Spacing[] spacing = new Spacing[3];
        Graphics g;
        bool isjumping, spacebar;
        int i, arraycount, gap;
        public FormGame() //Constructor to initialize the properties 
        {
            InitializeComponent();
            arraycount = 3;
            for (i = 0; i < arraycount; i++) //instantiation of every index
            {
                gap = (985 - 150) + (450 * -i);
                tobstacle[i] = new TopObstacle(gap);
                bobstacle[i] = new BottomObstacle(gap);
                spacing[i] = new Spacing(gap);
            }
        }

        private void FormGame_Load(object sender, EventArgs e) //Method for executing events that happen when the form loads
        {
        
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e) //Method for painting on the MainPanel
        {
            g = e.Graphics;
            dragon.drawDragon(g);
            for (i = 0; i < 3; i++) //Drawing every instance of every array
            {
                tobstacle[i].drawTobstacle(g);
                bobstacle[i].drawBobstacle(g);
                spacing[i].drawSpacing(g);
            }
        }

        private void timerDragon_Tick(object sender, EventArgs e) //Timer for the BabyDragon class
        {
            //Dragon movement
            if (isjumping)
            {
                dragon.moveDragon();
                isjumping = false;
            }
            else
            {
                dragon.y += dragon.gravity;
                dragon.dragonRect.Location = new Point(dragon.x, dragon.y);
            }
            MainPanel.Invalidate(); //Allows MainPanel to be redrawn
        }

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e) //Method for pressing keys
        {
            if (e.KeyChar == Convert.ToChar(" ") && spacebar) //Validates user input for pressing spacebar
            {
                isjumping = true;
                spacebar = false;
            }
        }

        private void FormGame_KeyUp(object sender, KeyEventArgs e) //Validates user input for checking the spacebar is up
        {
            if (e.KeyData == Keys.Space)
            {
                spacebar = true;
            }
        }
    }
    public class MainPanel : System.Windows.Forms.Panel //Class for helping in removing the flickering
    {
        public MainPanel() //Constructor to initialize the properties 
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}
