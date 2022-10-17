using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Baby_Dragon_Game
{
    public partial class FormGame : Form
    {
        BabyDragon dragon = new BabyDragon();
        TopObstacle[] tobstacle = new TopObstacle[3];
        BottomObstacle[] bobstacle = new BottomObstacle[3];
        Spacing[] spacing = new Spacing[3];
        Graphics g;
        bool isjumping, spacebar, gameover, scoring, collision, entername, changeT, changeB, changeS;
        int i, arraycount, gap, score, gapnum, obs;
        string playername;

        Random r = new Random();

        private void NameText_KeyPress(object sender, KeyPressEventArgs e) //Method for pressing keys only when NameText is focused
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar)) //NameText validation
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Return) //Validates user input for pressing enter
            {
                NameText.ReadOnly = true;
                entername = true;
            }
        }

        private void MenuRestart_Click(object sender, EventArgs e) //Method for when restart is clicked
        {
            Application.Restart();
        }

        private void MenuStart_Click(object sender, EventArgs e) //Method for when start is clicked
        {
            if (entername && gameover == false)
            {
                timerDragon.Start();
                timerObstacles.Start();
                playername = NameText.Text;
                if (playername == "")
                {
                    playername = "Unknown";
                }
            }
        }

        private void MenuStop_Click(object sender, EventArgs e) ////Method for when stop is clicked
        {
            timerDragon.Stop();
            timerObstacles.Stop();
        }

        public FormGame() //Constructor to initialize the properties 
        {
            InitializeComponent();
            arraycount = 3;
            for (i = 0; i < arraycount; i++) //instantiation of every index
            {
                gapnum = 400;
                obs = r.Next(50, 425);
                gap = MainPanel.Right + (gapnum * i);
                tobstacle[i] = new TopObstacle(gap, obs);
                obs = 725 - tobstacle[i].height;
                bobstacle[i] = new BottomObstacle(gap, obs);
                obs = tobstacle[i].height;
                spacing[i] = new Spacing(gap, obs);
            }
        }

        private void FormGame_Load(object sender, EventArgs e) //Method for executing events that happen when the form loads
        {
            score = 0;
            entername = false;
            spacebar = true;
            timerDragon.Stop();
            timerObstacles.Stop();
            GameOverLabel.Visible = false;
            GameOverLabel2.Visible = false;
            MessageBox.Show("Welcome to Baby Dragon!  To play the game, use your spacebar to avoid the oncoming obstacles.  " +
                "Every succesful dodge will increase your score but make sure not to touch the obstacles or it's game over!  " +
                "Enter your name first before starting, and when you lose, click restart to reset.");
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e) //Method for painting on the MainPanel
        {
            g = e.Graphics;
            dragon.drawDragon(g); //Drawing Dragon
            for (i = 0; i < arraycount; i++) //Drawing every instance of every array
            {
                tobstacle[i].drawTobstacle(g);
                bobstacle[i].drawBobstacle(g);
                spacing[i].drawSpacing(g);
            }
        }

        private void timerObstacles_Tick(object sender, EventArgs e) //Timer for the all the obstacle classes
        {
            MainPanel.BackgroundImage = Properties.Resources.Background;
            MainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            for (i = 0; i < arraycount; i++)
            {
                //Obstacle movement
                tobstacle[i].moveTobstacle();
                if (tobstacle[i].TobstacleRect.Right < MainPanel.Left)
                {
                    obs = r.Next(50, 425);
                    tobstacle[i] = new TopObstacle(gap, obs);
                    changeT = true;
                }
                bobstacle[i].moveBobstacle();
                if (bobstacle[i].BobstacleRect.Right < MainPanel.Left)
                {
                    obs = 725 - tobstacle[i].height;
                    bobstacle[i] = new BottomObstacle(gap, obs);
                    changeB = true;
                }
                spacing[i].moveSpacing();
                if (spacing[i].spacingRect.Right < MainPanel.Left)
                {
                    obs = tobstacle[i].height;
                    spacing[i] = new Spacing(gap, obs);
                    changeS = true;
                }

                //Obstacle difficulty
                if (score >= 5)
                {
                    tobstacle[i].obstacleSpeed = 12;
                    bobstacle[i].obstacleSpeed = 12;
                    spacing[i].obstacleSpeed = 12;
                }
                if (score >= 10)
                {
                    tobstacle[i].obstacleSpeed = 14;
                    bobstacle[i].obstacleSpeed = 14;
                    spacing[i].obstacleSpeed = 14;
                }
                if (score >= 15)
                {
                    tobstacle[i].obstacleSpeed = 16;
                    bobstacle[i].obstacleSpeed = 16;
                    spacing[i].obstacleSpeed = 16;
                }
                if (score >= 20)
                {
                    tobstacle[i].obstacleSpeed = 18;
                    bobstacle[i].obstacleSpeed = 18;
                    spacing[i].obstacleSpeed = 18;
                }
                if (score >= 25)
                {
                    tobstacle[i].obstacleSpeed = 20;
                    bobstacle[i].obstacleSpeed = 20;
                    spacing[i].obstacleSpeed = 20;
                }
                if (score >= 30)
                {
                    tobstacle[i].obstacleSpeed = 22;
                    bobstacle[i].obstacleSpeed = 22;
                    spacing[i].obstacleSpeed = 22;
                }

                //Sending obstacles back to the front
                if (changeT)
                {
                    tobstacle[i].x = MainPanel.Right + (gapnum - tobstacle[i].width);
                    tobstacle[i].TobstacleRect.Location = new Point(tobstacle[i].x, tobstacle[i].y);
                    changeT = false;
                }
                if (changeB)
                {
                    bobstacle[i].x = MainPanel.Right + (gapnum - bobstacle[i].width);
                    bobstacle[i].BobstacleRect.Location = new Point(bobstacle[i].x, bobstacle[i].y);
                    changeB = false;
                }
                if (changeS)
                {
                    spacing[i].x = MainPanel.Right + (gapnum - spacing[i].width);
                    spacing[i].spacingRect.Location = new Point(spacing[i].x, spacing[i].y);
                    changeS = false;
                }
            }
            //Collisions
            gameover = false;
            scoring = false;
            foreach (TopObstacle obstacleT in tobstacle)
            {
                if (dragon.dragonRect.IntersectsWith(obstacleT.TobstacleRect))
                {
                    gameover = true;
                }
            }
            foreach (BottomObstacle obstacleB in bobstacle)
            {
                if (dragon.dragonRect.IntersectsWith(obstacleB.BobstacleRect))
                {
                    gameover = true;
                }
            }
            foreach (Spacing spaces in spacing)
            {
                if (dragon.dragonRect.IntersectsWith(spaces.spacingRect))
                {
                    scoring = true;
                }
            }

            if (gameover) //Game over system
            {
                timerDragon.Stop();
                timerObstacles.Stop();
                GameOverLabel2.Text = playername + ", your score was " + score;
                GameOverLabel2.Visible = true;
                GameOverLabel.Visible = true;
            }
            else if (scoring) //Scoring system
            {
                if (collision)
                { 
                    score++;
                    ScoreLabel.Text = score.ToString();
                    collision = false;
                }
            }
            else
            {
                collision = true;
            }
            MainPanel.Invalidate(); //Allows MainPanel to be redrawn
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

            //Dragon MainPanel boundaries
            if (dragon.y < 0)
            {
                dragon.y = 10;
                dragon.dragonRect.Location = new Point(dragon.x, dragon.y);
            }
            if (dragon.y > 725 - dragon.height)
            {
                dragon.y = (725 - dragon.height) - 10;
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
