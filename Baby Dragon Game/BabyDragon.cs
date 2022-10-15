using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Baby_Dragon_Game
{
    class BabyDragon
    {
        public int x, y, width, height, gravity;
        public Rectangle dragonRect;
        Image dragonImg;
        public BabyDragon() //Constructor to initialize the properties
        {
            x = 50;
            y = 10;
            width = 100;
            height = 100;
            gravity = 10;
            dragonRect = new Rectangle(x, y, width, height);
            dragonImg = Properties.Resources.BabyDragonPlace;
        }

        public void drawDragon(Graphics g) //Method that draws the class and gives an image
        {
            g.DrawImage(dragonImg, dragonRect);
        }

        public void moveDragon() //Method that allows the player to input and move the class
        {
            y -= 50;
            dragonRect.Location = new Point(x, y);
        }
    }
}
