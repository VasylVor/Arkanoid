using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
     class Racket
    {
        public int totalBrick = 0;
        static Random rnd = new Random();
        public bool newGame = true;


        int ballShiftX = 7;// max ball shit
        int ballShiftY = 4;

        public Label lbText { set; get; }
        public int Life { set; get; }
        public int Count { set; get; }
        public int RacketX { set; get; }
        public int RacketY { set; get; }
        public int RacketWidth { set; get; }
        public int startPositionRacket { set; get; }

        public int SideLX  { set; get; }
        public int SideRX { set; get; }
        public int SideUY { set; get; }

        public int BallX { set; get; }
        public int BallY { set; get; }
        public int BallSX { set; get; }
        public int BallSY { set; get; }
        public int BallWidth { set; get; }
        public int BallHeight { set; get; }
        public int startPositionBallX { set; get; }
        public int startPositionBallY { set; get; }




        public Racket(int totalBrick)
        {
            this.totalBrick = totalBrick;
            Life = 3;
            BallSX = ballShiftX;
            BallSY = ballShiftY;
        }

        public void racketMove(int sx, Button racket)
        {
            int ax1 = RacketX + sx;
            int ax2 = ax1 + RacketWidth;
            if (SideLX > ax1) ax1 = SideLX;
            if (SideRX < ax2) ax1 = SideRX - RacketWidth;
            RacketX = ax1;
            racket.Location = new Point(RacketX, RacketY);
        }

        public void MoveBall(RadioButton ball,Timer timer, List<Label> bricks)
        {
            int bx1, by1,
                bx2, by2;
            bx1 = BallX;
            bx2 = BallX + BallWidth;
            by1 = BallY;
            by2 = BallY + BallHeight;

            if (bx1 + BallSX < SideLX)
                BallSX = ballShiftX;
            if (bx2 + BallSX > SideRX)
                BallSX = -ballShiftX;
            if (by1 + BallSY < SideUY)
                BallSY = ballShiftY;
            if (by2 + BallSY > RacketY)
            {
                int bx0, by0;
                bx0 = (bx1 + bx2) / 2;
                by0 = (by1 + by2) / 2;
                int rx1, rx2;
                rx1 = RacketX;
                rx2 = RacketX + RacketWidth;
                if (rx1 <= bx0 && bx0 <= rx2)
                {
                    BallSY = -ballShiftY + rnd.Next(-2, 2);
                }
                else if (rx1 <= bx2 + BallWidth && bx2 + BallWidth <= rx2)
                {
                    BallSY = -ballShiftY + rnd.Next(-2, 2);
                    BallSX = -ballShiftX + rnd.Next(-2, 2);
                }
                else if (rx1 <= bx1 - BallWidth && bx1 - BallWidth <= rx2)
                {
                    BallSY = -ballShiftY + rnd.Next(-2, 2);
                    BallSX = -ballShiftX + rnd.Next(-2, 2);
                }
                else
                    loseBall(timer);
            }

            BallX += BallSX;
            BallY += BallSY;
            ball.Location = new Point(BallX, BallY);

            foreach (var brick in bricks)
            {
                CrossBrick(timer, brick);
            }
        }

        private void loseBall(Timer timer)
        {
            timer.Enabled = false;
            lbText.Visible = true;
            Life--;
            MessageBox.Show("You lose!!!", "Game over");
            if (Life == 0)
                newGame = false;
        }

        private void CrossBrick(Timer timer, Label brick)
        {
            if (!brick.Visible) return;
            int bx1, bx2, bx0,
                by1, by2, by0;

            int rx1, rx2,
                ry1, ry2;

            bx1 = BallX;
            bx2 = BallX + BallWidth;
            bx0 = (bx1 + bx2) / 2;

            by1 = BallY;
            by2 = BallY + BallHeight;
            by0 = (by1 + by2) / 2;

            rx1 = brick.Location.X;
            rx2 = rx1 + brick.Width;
            ry1 = brick.Location.Y;
            ry2 = ry1 + brick.Height;

            if (rx1 <= bx0 && bx0 <= rx2 &&
                ry1 <= by2 && by2 <= ry2)
            {
                Count++;
                if (Count == 4)
                    Life++;
                DropBrick(timer, brick);
                BallSY = -BallSY;
                return;
            }

            if (rx1 <= bx0 && bx0 <= rx2 &&
              ry1 <= by1 && by1 <= ry2)
            {
                Count++;
                if (Count == 4)
                    Life++;
                DropBrick(timer, brick);
                BallSY = -BallSY;
                return;
            }


            if (rx1 <= bx2 && bx2 <= rx2 &&
              ry1 <= by0 && by0 <= ry2)
            {
                Count++;
                if (Count == 4)
                    Life++;
                DropBrick(timer, brick);
                BallSX = -BallSX;
                return;
            }

            if (rx1 <= bx1 && bx1 <= rx2 &&
              ry1 <= by0 && by0 <= ry2)
            {
                Count++;
                if (Count == 4)
                    Life++;
                DropBrick(timer, brick);
                BallSX = -BallSX;
                return;
            }

            if ((rx1 <= bx2 && bx2 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
                (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
                (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by1 && by1 <= ry2) ||
                (rx1 <= bx2 && bx2 <= rx2 && ry1 <= by1 && by1 <= ry2))
            {
                Count++;
                if (Count == 4)
                    Life++;
                DropBrick(timer, brick);
                BallSX = -BallSX;
                BallSY = -BallSY;
                return;
            }
        }

        private void DropBrick(Timer timer,Label brick)
        {
            brick.Visible = false;
            totalBrick--;
            if (Count == 4)
                Life++;
            if (totalBrick == 0)
            {
                timer.Enabled = false;
                MessageBox.Show("You Win!!!!!!", "Game finished");
                newGame = false;
            }
        }
    }
}