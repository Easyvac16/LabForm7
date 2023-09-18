using System;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LabForm7
{
    public partial class Form1 : Form
    {
        private int player1Score;
        private int player2Score;
        private int ballSpeedX;
        private int ballSpeedY;
        private int step = 8;
        private const int TimerInterval = 10;
        private int botMoveDelay = 0;
        private List<int> botMoveDelays = new List<int> { 10, 8, 6 };
        private SoundPlayer soundPlayer;
        private Random random = new Random();
        private int currentDifficulty;


        private void InitializeBallSpeed()
        {

            ballSpeedX = random.Next(-3, 4);
            ballSpeedY = random.Next(-3, 4);

            while (ballSpeedX == 0 || ballSpeedY == 0)
            {
                ballSpeedX = random.Next(-3, 4);
                ballSpeedY = random.Next(-3, 4);
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeBallSpeed();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            timer1.Interval = TimerInterval;
            timer1.Tick += timer1_Tick;
            

            soundPlayer = new SoundPlayer(@"F:\dimaaaa.wav");

            soundPlayer.PlayLooping();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (pictureBox_X.Top - step >= 0)
                        MovePicture(pictureBox_X, 0, -step);
                    break;

                case Keys.S:
                    if (pictureBox_X.Bottom + step <= ClientSize.Height)
                        MovePicture(pictureBox_X, 0, step);
                    break;

                case Keys.Up:
                    if (pictureBox_O.Top - step >= 0)
                        MovePicture(pictureBox_O, 0, -step);
                    break;

                case Keys.Down:
                    if (pictureBox_O.Bottom + step <= ClientSize.Height)
                        MovePicture(pictureBox_O, 0, step);
                    break;

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += ballSpeedX;
            pictureBox1.Top += ballSpeedY;

            BallCheck();
            MoveBot();
            Score();
            EndGame();

        }


        private void MovePicture(PictureBox pictureBox, int x, int y)
        {
            pictureBox.Location = new Point(pictureBox.Location.X + x, pictureBox.Location.Y + y);
        }


        private void MoveBot()
        {
            botMoveDelay++;

            int botSpeed = GetBotSpeed(currentDifficulty);

            if (botMoveDelay >= botMoveDelays[botSpeed])
            {
                if (pictureBox_O.Top + pictureBox_O.Height / 2 < pictureBox1.Top + pictureBox1.Height / 2)
                {
                    if (pictureBox_O.Bottom + step <= ClientSize.Height)
                        MovePicture(pictureBox_O, 0, step);
                }
                else if (pictureBox_O.Bottom - pictureBox_O.Height / 2 > pictureBox1.Bottom - pictureBox1.Height / 2)
                {
                    if (pictureBox_O.Top - step >= 0)
                        MovePicture(pictureBox_O, 0, -step);
                }
                botMoveDelay = 0;
            }
        }

        private int GetBotSpeed(int difficulty)
        {
            
            switch (difficulty)
            {
                case 0: 
                    return 0;
                case 1: 
                    return 1;
                case 2: 
                    return 2;
                default: 
                    return 0;
            }
        }


        private void Score()
        {
            if (pictureBox1.Left < 0 || pictureBox1.Right > ClientSize.Width)
            {
                if (pictureBox1.Left < 0)
                {

                    player2Score++;
                    label2.Text = player2Score.ToString();
                    pictureBox1.Location = new Point(ClientSize.Width / 2 - pictureBox1.Width / 2, ClientSize.Height / 2 - pictureBox1.Height / 2);
                }
                else
                {

                    player1Score++;
                    label1.Text = player1Score.ToString();
                    pictureBox1.Location = new Point(ClientSize.Width / 2 - pictureBox1.Width / 2, ClientSize.Height / 2 - pictureBox1.Height / 2);
                }


            }
        }


        private void BallCheck()
        {
            if (pictureBox1.Top < 0 || pictureBox1.Bottom > ClientSize.Height)
            {
                ballSpeedY = -ballSpeedY;
            }


            if (pictureBox1.Bounds.IntersectsWith(pictureBox_X.Bounds) || (pictureBox1.Bounds.IntersectsWith(pictureBox_O.Bounds)))
            {
                ballSpeedX = -ballSpeedX;

            }
        }

        private void EndGame()
        {
            if (player1Score == 3 || player2Score == 3)
            {
                timer1.Stop();
                MessageBox.Show($"Игра окончена!\nСчет:\nИгрок 1: {player1Score}\nИгрок 2: {player2Score}");
                button1.Show();
                comboBox1.Show();
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            player1Score = 0;
            player2Score = 0;


            if (comboBox1.SelectedIndex == 0)
            {
                timer1.Start();
                comboBox1.Hide();
                button1.Hide();
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                timer1.Start();
                comboBox1.Hide();
                button1.Hide();
                
            }
            if (comboBox1.SelectedIndex == 2)
            {
                timer1.Start();
                comboBox1.Hide();
                button1.Hide();
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            currentDifficulty = comboBox1.SelectedIndex;
            
        }
    }
}