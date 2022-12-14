using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Game
{
        public partial class Game : Form
        {
        static int score = 0;
        public static int currunt_score = 0;
        Random r = new Random();
        int position;
             
        public Game()
        {            
            InitializeComponent();   
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Removebackground();
            GameReset();
        }

        private void GameRunning_Tick(object sender, EventArgs e)
        {          
            EnemyMove();
            GameOverCheck();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 90)
                    Car.Left -= 25;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right < 310)
                    Car.Left += 25;
            }
           
        }

        private void reset_Click(object sender, EventArgs e)
        {
            GameReset();
        }

        void EnemyMove()
        {
            position = r.Next(100, 250);
            int a  = r.Next(150, 200);

            if (enemyRed.Bottom >= 450)
            {
                this.lblscore.Text = "SCORE: " + score++;
                currunt_score = score;
                enemyRed.Location = new Point(position, 0);
                SelectCar();
            }
            else
                enemyRed.Top += 5;

        }

        void GameOverCheck()
        {
            if (Car.Bounds.IntersectsWith(enemyRed.Bounds))
            {               
                GameOver(enemyRed);
                this.lblGameScore.Text = "SCORE: "+score.ToString();
                this.lblGameScore.Visible = true;
                this.lblscore.Visible = false;

                HighScore();
            }
          
        }


        void GameOver(PictureBox p)
        {this.blast.Location = p.Location;
            this.blast.Top = p.Top+44;
            //
            this.blast.Visible = true;           
            this.lblOver.Visible = true;
            this.btnPlayAgain.Visible = true;
            this.lblGameScore.Visible = true;
            this.btnClose.Visible = true;
            this.pictureBoxRoad.Enabled = false;
            //
            GameRunning.Enabled = false;

            if (score > int.Parse(File.ReadAllText("score.txt")))
            {
                using (StreamWriter writer = new StreamWriter("score.txt"))
                {
                    writer.WriteLine(score - 1);
                }
            }
        }
        void GameReset()
        {
            score = 0;
            this.lblscore.Text = "SCORE: "+score;
            this.lblscore.Visible = true;
            this.pictureBoxRoad.Enabled = true;
            //
            this.blast.Visible = false;
            this.lblOver.Visible = false;
            this.btnPlayAgain.Visible = false;
            this.lblGameScore.Visible = false;
            this.btnClose.Visible = false;
            //
            enemyRed.Location = new Point(70, 0);
            GameRunning.Start();
            //road.Image = Properties.Resources.Road_Running;
        }
       
        void Removebackground()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Car.BackColor = Color.Transparent;           
            this.enemyRed.BackColor = Color.Transparent;
            this.blast.BackColor = Color.Transparent;
            this.lblscore.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void SelectCar()
        {
            int c = r.Next(1, 4);
            if (c % 3 == 0)
            {
                enemyRed.Image = Properties.Resources.ambulance1;
            }
            else
            {

                switch (c)
                {
                    case 1:
                        enemyRed.Image = Properties.Resources.carYellow1;
                        break;
                    case 2:
                        enemyRed.Image = Properties.Resources.carPink1;
                        break;
                    case 3:
                        enemyRed.Image = Properties.Resources.CarRed1;
                        break;
                }
            }
        }

        void HighScore()
        {
            
            if (score > int.Parse(File.ReadAllText("score.txt")))
            {
                using (StreamWriter writer = new StreamWriter("score.txt"))
                {
                    writer.WriteLine((score - 1));
                }
            }

        }

        private void road_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Game.ActiveForm.Dispose();
        }
    }
}
