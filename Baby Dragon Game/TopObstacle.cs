using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Baby_Dragon_Game
{
    class TopObstacle
    {
        public int x, y, width, height, obstacleSpeed;
        public Rectangle TobstacleRect;
        Image TobstacleImg;
        public TopObstacle(int gap) //Constructor to initialize the properties
        {
            x = gap;
            y = 0;
            width = 150;
            height = 400;
            obstacleSpeed = 10;
            TobstacleRect = new Rectangle(x, y, width, height);
            TobstacleImg = Properties.Resources.TopObstaclePlace;
        }

        public void drawTobstacle(Graphics g) //Method that draws the class and gives an image
        {
            g.DrawImage(TobstacleImg, TobstacleRect);
        }

        public void moveTobstacle() //Method that allows the player to input and move the class
        {

        }
    }
}
