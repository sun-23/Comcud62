using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // for sound

namespace Pong
{
    public partial class Form1 : Form
    {

        bool isP1Up, isP1Down, isP2Up, isP2Down; //updown
        bool isBallLeft, isBallRight, isBallUp, isBallDown, isBallOut; // ball
        int p1score = 0, p2score = 0; // score
        int level = 0; //speed ball

        public Form1()
        {
            InitializeComponent();
        }

        //Timer
        private void aTimerPaddle_Tick(object sender, EventArgs e)
        {
            DoMove(isP1Up, isP1Down, paddle1);//move paddle1
            DoMove(isP2Up, isP2Down, paddle2);//move paddle2
            CheckMoveBall(aBall, paddle1, paddle2); //Check Move Ball
            MoveBall(aBall,isBallLeft,isBallRight,isBallOut,isBallDown,isBallUp); //move ball
            CheckScore();
        }

        //Domove
        void DoMove(bool isUp,bool isDown, PictureBox paddle)
        {
            int position_y = 0;

            if (isUp)
            {
                position_y = -20;//move up
            }
            else if(isDown)
            {
                position_y = 20;//move down
            }
                                                                   // topFrom, BottomFrom
            paddle.Location = new Point(paddle.Location.X, Math.Max(0,Math.Min(Height-140,paddle.Location.Y + position_y)));// set paddle position
        }

        //MoveBall
        void MoveBall(PictureBox Ball, bool isLeft, bool isRight, bool isOut, bool isDown, bool isUp)
        {
            int positionBallX = 0;
            int positionBallY = 0;

            if (isLeft)
            {
                positionBallX = -(10+level);//ball go left
            }
            else if (isRight)
            {
                positionBallX = 10+level; //ball go right
            }
            else if (isOut)
            {
                //set ball center
                positionBallX = Width/2 - Ball.Location.X;
                positionBallY = Height / 2 - Ball.Location.Y;
                // reset speed ball
                level = 0;
                // runball again
                bool myRandomBoolUp = new Random().Next(100) <= 50 ? true : false;
                if (myRandomBoolUp)
                {
                    isBallLeft = true;
                }
                else
                {
                    isBallRight = true;
                }
                //isBallDown = false;
                //isBallUp = false;
                
            }

            if (isBallUp)
            {
                positionBallY = -10; //ball go up
            }
            else if (isBallDown)
            {
                positionBallY = 10; //ball go down
            }

            Ball.Location = new Point(Ball.Location.X + positionBallX, Ball.Location.Y + positionBallY);
        }

        //CheckMoveBall
        void CheckMoveBall(PictureBox Ball,PictureBox Paddle1, PictureBox Paddle2)
        {
            if (Ball.Location.X >= Paddle2.Location.X - Paddle2.Width && Ball.Location.Y >= Paddle2.Location.Y && Ball.Location.Y <= Paddle2.Location.Y + Paddle2.Height)
            {
                //ball touch paddle 2 then go left
                isBallRight = false;
                isBallLeft = true;
                isBallOut = false;
                level += 5;
                RandomYAxis();
            }
            else if (Ball.Location.X <= Paddle1.Location.X + Paddle1.Width && Ball.Location.Y >= Paddle1.Location.Y && Ball.Location.Y <= Paddle1.Location.Y + Paddle1.Height)
            {
                //ball touch paddle 1 then go right
                isBallLeft = false;
                isBallRight = true;
                isBallOut = false;
                level += 5;
                RandomYAxis();
            }
            else if (Ball.Location.X <= Paddle1.Location.X - Paddle1.Width && Ball.Location.Y <= Paddle1.Location.Y || Ball.Location.X <= Paddle1.Location.X - Paddle1.Width && Ball.Location.Y >= Paddle1.Location.Y + Paddle1.Height)
            {
                //ball out of paddle 1
                isBallLeft = false;
                isBallRight = false;
                isBallOut = true;
                // p2 + 1
                Score(false);
                PlaySound("GameOver.wav");
                PlaySound("8bit.wav");
            }
            else if (Ball.Location.X >= Paddle2.Location.X + Paddle2.Width && Ball.Location.Y <= Paddle2.Location.Y || Ball.Location.X >= Paddle2.Location.X + Paddle2.Width && Ball.Location.Y >= Paddle2.Location.Y + Paddle2.Height)
            {
                //ball out of paddle 2
                isBallLeft = false;
                isBallRight = false;
                isBallOut = true;
                // p1 + 1
                Score(true);
                PlaySound("GameOver.wav");
                PlaySound("8bit.wav");
            }
            else if(Ball.Location.Y <= 0)
            {
                //Ball postitionY is 0 then Ball go Down
                isBallDown = true;
                isBallUp = false;
            }
            else if(Ball.Location.Y >= Height-Ball.Height*5)
            {
                //Ball postitionY is From Height then Ball go Up
                isBallDown = false;
                isBallUp = true;
            }
        }

        //PlaySound
        void PlaySound(string name)
        {
            SoundPlayer s = new SoundPlayer(@"Sound\"+name); //new sound file Sound\name.wav
            s.Play();
        }

        //CheckScore
        void CheckScore()
        {
            if (p1score == 2)
            {
                Reset();
                aTimerPaddle.Enabled = false; //stop timer
                Form2 f2 = new Form2();
                f2.Show(); // show form2
                MessageBox.Show("P1 WIN!!!!");
            }
            else if (p2score == 2)
            {
                Reset();
                aTimerPaddle.Enabled = false;//stop timer
                Form2 f2 = new Form2();
                f2.Show(); // show form2
                MessageBox.Show("P2 WIN!!!!");
            }
        }

        //Reset
        void Reset()
        {
            level = 0;
            p1score = 0;
            p2score = 0;
            P1Label.Text = p1score.ToString(); //setlabel
            P2Label.Text = p2score.ToString(); //setlabel
        }

        //Score
        void Score(bool isP1NotOut)
        {
            if (isP1NotOut)
            {
                p1score += 1;
                P1Label.Text = p1score.ToString(); //setlabel
            }
            else
            {
                p2score += 1;
                P2Label.Text = p2score.ToString(); //setlabel
            }
        }

        //Random
        void RandomYAxis()
        {
            bool myRandomBoolUp = new Random().Next(100) <= 50 ? true : false;
            if (myRandomBoolUp)
            {
                isBallDown = false;
                isBallUp = true;
            }
            else
            {
                isBallDown = true;
                isBallUp = false;
            }
        }

        // form load
        private void Form1_Load(object sender, EventArgs e)
        {
            isBallRight = true;
            PlaySound("8bit.wav");
        }

        // KeyDown
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeys(e, true);
        }

        // KeyUp
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }

        //ChackKeys
        void CheckKeys(KeyEventArgs e, bool isPresse)
        {
            switch(e.KeyCode) {
                case Keys.W:
                    isP1Up = isPresse;
                    break;
                case Keys.S:
                    isP1Down = isPresse;
                break;
                case Keys.Up:
                    isP2Up = isPresse;
                break;
                case Keys.Down:
                    isP2Down = isPresse;
                break;
            }
        }
    }
}