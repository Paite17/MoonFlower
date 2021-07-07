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
    public partial class Form3 : Form
    {
        private Bitmap imageDisplayed;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            randomImageDecide();
        }

        private void randomImageDecide()
        {
            Random randomGen = new Random();
            int funnyNumber = randomGen.Next(1, 10);
            /*
             * once again, hard-coding the images, though i wanted the program to grab them from a website i'd set up
             * unfortunately, i ain't smart enough for that shit (or anything website related really)
             */
            switch (funnyNumber)
            {
                case 1:
                    imageDisplayed = new Bitmap("image1.jpeg");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 2:
                    imageDisplayed = new Bitmap("image2.png");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 3:
                    imageDisplayed = new Bitmap("image3.png");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 4:
                    imageDisplayed = new Bitmap("image4.png");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 5:
                    imageDisplayed = new Bitmap("image5.png");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 6:
                    imageDisplayed = new Bitmap("image6.jpg");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 7:
                    imageDisplayed = new Bitmap("image7.png");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 8:
                    imageDisplayed = new Bitmap("image8.PNG");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 9:
                    imageDisplayed = new Bitmap("image9.jpg");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
                case 10:
                    imageDisplayed = new Bitmap("image10.png");
                    mainPicture.Image = (Image)imageDisplayed;
                    break;
            }
            // mmm yes filetype consistency
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
