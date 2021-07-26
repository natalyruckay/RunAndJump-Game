using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAndJump_Game
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 25;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            runner.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (runner.Top > 416 && jumping == false)
            {
                force = 25;
                runner.Top = 417;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle1")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (runner.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        runner.Image = Properties.Resources.ghost;
                        txtScore.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "obstacle2")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(700, 1000) + (x.Width * 15);
                        score++;
                    }

                    if (runner.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        runner.Image = Properties.Resources.ghost;
                        txtScore.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 25;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            runner.Image = Properties.Resources.runner_new;
            isGameOver = false;
            runner.Top = 417;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "obstacle1")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }

                if (x is PictureBox && (string)x.Tag == "obstacle2")
                {
                    position = this.ClientSize.Width + rand.Next(1000, 1300) + (x.Width * 10);

                    x.Left = position;
                }
            }

            gameTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

