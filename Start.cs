using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Start : Form
    {

        HighScore scoreBoard;
        About_Us aboutUs;
        public Start()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void highestScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void scoreBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scoreBoard.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            aboutUs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {
            scoreBoard = new HighScore();
            aboutUs = new About_Us();
            
        }
    }
}
