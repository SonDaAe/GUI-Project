using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int speed = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            action(speed);
            score();
            gameclear();
            gameover();
        }

        Random r = new Random();
        int x;
        void action(int speed)
        {
            //액션가면
            if (pictureBox_action.Top >= 570)
            {
                x = r.Next(0, 550);
                pictureBox_action.Location = new Point(x, 0);
            }
            else
                pictureBox_action.Top += speed;

            //초코비
            if (pictureBox_choco.Top >= 570)
            {
                x = r.Next(0, 550);
                pictureBox_choco.Location = new Point(x, 0);
            }
            else
                pictureBox_choco.Top += speed;

            //흰둥이 밥
            if (pictureBox_dog.Top >= 570)
            {
                x = r.Next(0, 550);
                pictureBox_dog.Location = new Point(x, 0);
            }
            else
                pictureBox_dog.Top += speed;

            //피망
            if (pictureBox_pm.Top >= 570)
            {
                x = r.Next(0, 550);
                pictureBox_pm.Location = new Point(x, 0);
            }
            else
                pictureBox_pm.Top += speed;
        }

        int Score = 0;
        void score()
        {
            //액션가면
            if (pictureBox1.Bounds.IntersectsWith(pictureBox_action.Bounds))
            {
                Score += 300;
                if (Score > 2500)
                {
                    progressBar1.Value = 2500;
                    gameclear();
                }
                else
                    progressBar1.Value += 300;

                pictureBox_action.Visible = false;
                label2_score.Text = Score.ToString();
                pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width + 10, pictureBox1.Size.Height + 10);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y - 10);

                x = r.Next(0, 500);
                pictureBox_action.Location = new Point(x, 0);
                pictureBox_action.Visible = true;
            }
            //초코비
            else if (pictureBox1.Bounds.IntersectsWith(pictureBox_choco.Bounds))
            {
                Score += 150;
                if (Score > 2500)
                {
                    progressBar1.Value = 2500;
                    gameclear();
                }
                else
                    progressBar1.Value += 150;

                pictureBox_choco.Visible = false;
                label2_score.Text = Score.ToString();

                x = r.Next(0, 500);
                pictureBox_choco.Location = new Point(x, 0);
                pictureBox_choco.Visible = true;
            }
            //흰둥이 밥
            else if (pictureBox1.Bounds.IntersectsWith(pictureBox_dog.Bounds))
            {
                Score -= 200;
                if (Score < 0)
                {
                    progressBar1.Value = 0;
                }
                else
                    progressBar1.Value -= 200;

                pictureBox_dog.Visible = false;
                label2_score.Text = Score.ToString();
                pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width - 20, pictureBox1.Size.Height - 20);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y + 20);

                if (pictureBox2_heart.Visible == true && pictureBox3_heart.Visible == true && pictureBox4_heart.Visible == true)
                    pictureBox4_heart.Visible = false;
                else if (pictureBox2_heart.Visible == true && pictureBox3_heart.Visible == true && pictureBox4_heart.Visible == false)
                    pictureBox3_heart.Visible = false;
                else if (pictureBox2_heart.Visible == true && pictureBox3_heart.Visible == false && pictureBox4_heart.Visible == false)
                {
                    pictureBox2_heart.Visible = false;
                    gameover();
                }

                x = r.Next(0, 500);
                pictureBox_dog.Location = new Point(x, 0);
                pictureBox_dog.Visible = true;
            }
            //피망
            else if (pictureBox1.Bounds.IntersectsWith(pictureBox_pm.Bounds))
            {
                Score -= 100;
                if (Score < 0)
                {
                    progressBar1.Value = 0;
                }
                else
                    progressBar1.Value -= 100;

                pictureBox_pm.Visible = false;
                label2_score.Text = Score.ToString();

                if (pictureBox2_heart.Visible == true && pictureBox3_heart.Visible == true && pictureBox4_heart.Visible == true)
                    pictureBox4_heart.Visible = false;
                else if (pictureBox2_heart.Visible == true && pictureBox3_heart.Visible == true && pictureBox4_heart.Visible == false)
                    pictureBox3_heart.Visible = false;
                else if (pictureBox2_heart.Visible == true && pictureBox3_heart.Visible == false && pictureBox4_heart.Visible == false)
                {
                    pictureBox2_heart.Visible = false;
                    gameover();
                }

                x = r.Next(0, 500);
                pictureBox_pm.Location = new Point(x, 0);
                pictureBox_pm.Visible = true;
            }
        }

        void gameover()
        {
            if (pictureBox2_heart.Visible == false && pictureBox3_heart.Visible == false && pictureBox4_heart.Visible == false)
            {
                timer1.Enabled = false;
                label1_gameover.Visible = true;
            }
        }

        void gameclear()
        {
            if (progressBar1.Value > progressBar1.Maximum || progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                label1_gameclear.Visible = true;
            }
        }

        SoundPlayer player = new SoundPlayer(@"C:\Users\USER\source\시작2.wav");
        private void Form4_Load(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Close();

            timer1_Tick(sender, e);
            timer1.Start();
            player.Play();
            progressBar1.Value = 0;
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox1.Left > 0)
                    pictureBox1.Left -= 8;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (pictureBox1.Right < 600 - pictureBox1.Width / 2)
                    pictureBox1.Left += 8;
            }
            this.Update();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("게임을 종료합니다.", "알림");
        }
    }
}
