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
        public BottomObstacle(int gap) //Constructor to initialize the properties
        {
            x = gap;
            y = 962 - (960 - 400 - 200);
            width = 150;
            height = (960-400-200);
            obstacleSpeed = 10;
            BobstacleRect = new Rectangle(x, y, width, height);
            BobstacleImg = Properties.Resources.TopObstaclePlace;
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
