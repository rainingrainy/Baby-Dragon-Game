using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Baby_Dragon_Game
{
    class BottomObstacle
    {
        public int x, y, width, height, obstacleSpeed;
        public Rectangle BobstacleRect;
        Image BobstacleImg;
        public BottomObstacle(int gap, int obs) //Constructor to initialize the properties
        {
            x = gap;
            width = 150;
            height = obs - 250;
            y = 725 - height;
            obstacleSpeed = 10;
            BobstacleRect = new Rectangle(x, y, width, height);
            BobstacleImg = Properties.Resources.BottomObstacle;
        }

        public void drawBobstacle(Graphics g) //Method that draws the class and gives an image
        {
            g.DrawImage(BobstacleImg, BobstacleRect);
        }

        public void moveBobstacle() //Method that allows the player to input and move the class
        {
            x -= obstacleSpeed;
            BobstacleRect.Location = new Point(x, y);
        }
    }
}
