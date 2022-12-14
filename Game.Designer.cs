
namespace Game
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.GameRunning = new System.Windows.Forms.Timer(this.components);
            this.lblOver = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.PictureBox();
            this.blast = new System.Windows.Forms.PictureBox();
            this.enemyRed = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoad = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRunning
            // 
            this.GameRunning.Enabled = true;
            this.GameRunning.Interval = 10;
            this.GameRunning.Tick += new System.EventHandler(this.GameRunning_Tick);
            // 
            // lblOver
            // 
            this.lblOver.AutoSize = true;
            this.lblOver.BackColor = System.Drawing.Color.Crimson;
            this.lblOver.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOver.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblOver.Location = new System.Drawing.Point(164, 182);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(212, 39);
            this.lblOver.TabIndex = 13;
            this.lblOver.Text = "GAME OVER";
            this.lblOver.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Teal;
            this.btnPlayAgain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(193, 289);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(151, 34);
            this.btnPlayAgain.TabIndex = 14;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.reset_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.FloralWhite;
            this.lblscore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Black;
            this.lblscore.Location = new System.Drawing.Point(29, 20);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(88, 23);
            this.lblscore.TabIndex = 16;
            this.lblscore.Text = "Score: 0";
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.FloralWhite;
            this.lblGameScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.ForeColor = System.Drawing.Color.Black;
            this.lblGameScore.Location = new System.Drawing.Point(191, 243);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(153, 23);
            this.lblGameScore.TabIndex = 21;
            this.lblGameScore.Text = "GAME SCORE: ";
            this.lblGameScore.Visible = false;
            // 
            // Car
            // 
            this.Car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Car.Image = global::Game.Properties.Resources.carGreen;
            this.Car.Location = new System.Drawing.Point(263, 382);
            this.Car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(49, 82);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 7;
            this.Car.TabStop = false;
            // 
            // blast
            // 
            this.blast.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.blast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blast.Image = global::Game.Properties.Resources.explosion;
            this.blast.Location = new System.Drawing.Point(137, 462);
            this.blast.Margin = new System.Windows.Forms.Padding(0);
            this.blast.Name = "blast";
            this.blast.Size = new System.Drawing.Size(42, 30);
            this.blast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blast.TabIndex = 18;
            this.blast.TabStop = false;
            this.blast.Visible = false;
            // 
            // enemyRed
            // 
            this.enemyRed.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.enemyRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyRed.Image = global::Game.Properties.Resources.carPink1;
            this.enemyRed.Location = new System.Drawing.Point(110, 53);
            this.enemyRed.Margin = new System.Windows.Forms.Padding(0);
            this.enemyRed.Name = "enemyRed";
            this.enemyRed.Size = new System.Drawing.Size(42, 84);
            this.enemyRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyRed.TabIndex = 9;
            this.enemyRed.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(548, 1);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(7, 522);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(1, 1);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(7, 582);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBoxRoad
            // 
            this.pictureBoxRoad.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBoxRoad.ErrorImage = null;
            this.pictureBoxRoad.Image = global::Game.Properties.Resources.trackAnimated;
            this.pictureBoxRoad.InitialImage = null;
            this.pictureBoxRoad.Location = new System.Drawing.Point(1, -2);
            this.pictureBoxRoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRoad.Name = "pictureBoxRoad";
            this.pictureBoxRoad.Size = new System.Drawing.Size(557, 508);
            this.pictureBoxRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoad.TabIndex = 19;
            this.pictureBoxRoad.TabStop = false;
            this.pictureBoxRoad.Click += new System.EventHandler(this.road_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(237, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(552, 514);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGameScore);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.lblOver);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.blast);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.enemyRed);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBoxRoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer GameRunning;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox enemyRed;
        private System.Windows.Forms.Label lblOver;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox blast;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.PictureBox pictureBoxRoad;
        private System.Windows.Forms.Button btnClose;
    }
}

