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
        Graphics g;
        public FormGame() //Constructor to initialize the properties 
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e) //Method for executing events that happen when the form loads
        {
        
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e) //Method for painting on the MainPanel
        {
            g = e.Graphics;
            dragon.drawDragon(g);
        }






        private void timerDragon_Tick(object sender, EventArgs e) //Timer for the BabyDragon class
        {

        }
    }
}
