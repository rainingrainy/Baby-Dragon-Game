using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Baby_Dragon_Game
{
    class Spacing
    {
        public int x, y, width, height, obstacleSpeed;
        public Rectangle spacingRect;
        Image spacingImg;
        public Spacing(int gap) //Constructor to initialize the properties
        {
            x = 50 + gap;
            y = 500;
            width = 50;
            height = 50;
            obstacleSpeed = 10;
            spacingRect = new Rectangle(x, y, width, height);
            spacingImg = Properties.Resources.SpacingPlace;
        }

        public void drawSpacing(Graphics g) //Method that draws the class and gives an image
        {
            g.DrawImage(spacingImg, spacingRect);
        }

        public void moveSpacing() //Method that allows the player to input and move the class
        {

        }
    }
}
