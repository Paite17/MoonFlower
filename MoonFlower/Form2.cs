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

namespace MoonFlower
{
    public partial class Form2 : Form
    {
        // make this false if you don't wanna die
        bool loop = true;
        bool hasBeenPaused = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            destroyThisPC();
        }

        private void destroyThisPC()
        {
            while (loop == true)
            {
                Process.Start("awesome.txt");
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (hasBeenPaused == false)
            {
                loop = false;
                pauseButton.Text = "Start again";
            }
            else
            {
                loop = true;
                pauseButton.Text = "Make it stop!";
            }
            
        }
    }
}
