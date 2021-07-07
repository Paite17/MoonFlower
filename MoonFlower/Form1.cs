using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonFlower
{
    public partial class Form1 : Form
    {
        public Random yellowRandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // on load make a random number between 0 and 19
            int randRange = yellowRandom.Next(0, 20);
            yellowTextDecide(randRange);
        }
        private void yellowTextDecide(int number)
        {
            // hard-coding the yellow texts because i'm lazy - fix later
            switch (number)
            {
                case 0:
                    yellowText.Text = "A work in progress!";
                    break;
                case 1:
                    yellowText.Text = "Cooler than sunflower!";
                    break;
                case 2:
                    yellowText.Text = "A Lewis-approved product!";
                    break;
                case 3:
                    yellowText.Text = "Subscribe to Paite";
                    break;
                case 4:
                    yellowText.Text = "var pooBackgroundFarts:Int";
                    break;
                case 5:
                    yellowText.Text = "Oh god I have to make 20 of these";
                    break;
                case 6:
                    yellowText.Text = "Funky!";
                    break;
                case 7:
                    yellowText.Text = "Made in C#";
                    break;
                case 8:
                    yellowText.Text = "Imagine using Java";
                    break;
                case 9:
                    yellowText.Text = "C--";
                    break;
                case 10:
                    yellowText.Text = "IT hates it!";
                    break;
                case 11:
                    yellowText.Text = "Shoutouts to Max!";
                    break;
                case 13:
                    yellowText.Text = "Curb your flowers";
                    break;
                case 14:
                    yellowText.Text = "The other side of sunflower";
                    break;
                case 15:
                    yellowText.Text = "Not Minecraft";
                    break;
                case 16:
                    yellowText.Text = "Merry Christmas!";
                    break;
                case 17:
                    yellowText.Text = "Antiviruses hate it!";
                    break;
                case 18:
                    yellowText.Text = "dogney kngo";
                    break;
                case 19:
                    yellowText.Text = "Made by Me!";
                    break;
            }
        }

        private void breakPCButton_Click(object sender, EventArgs e)
        {
            // change to the funny form
            Form Form2 = new Form();
            Form2.Show();
            this.Hide();
        }
    }
}
