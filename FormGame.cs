using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormGame : Form
    {
        //static Random rnd = new Random();

        int racketShift = 9;
        List<Label> bricks = new List<Label>();

        Racket racket = new Racket(11);

        private void FormGame_Shown(object sender, EventArgs e)
        {
            racket.lbText = lbText;

            racket.RacketX = btnRacket.Location.X;
            racket.RacketY = btnRacket.Location.Y;
            racket.RacketWidth = btnRacket.Width;
            racket.startPositionRacket = btnRacket.Location.X;

            racket.SideLX = lbLeft.Location.X;
            racket.SideRX = lbRight.Location.X + lbRight.Width;
            racket.SideUY = lbTop.Location.X + lbTop.Height;

            racket.BallX = rball.Location.X;
            racket.BallY = rball.Location.Y;
            racket.BallWidth = rball.Width;
            racket.BallHeight = rball.Height;
            racket.startPositionBallX = rball.Location.X;
            racket.startPositionBallY = rball.Location.Y;


            bricks.Add(brick1);
            bricks.Add(brick2);
            bricks.Add(brick3);
            bricks.Add(brick4);
            bricks.Add(brick5);
            bricks.Add(brick6);
            bricks.Add(brick7);
            bricks.Add(brick8);
            bricks.Add(brick9);
            bricks.Add(brick10);
            bricks.Add(brick11);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            racket.MoveBall(rball, timer, bricks);
            //if(racket.newGame == false)
            //{
            //    DialogResult = DialogResult.Abort;
            //}
            if (racket.Count == 2)
            {
                FormLevel2 level2 = new FormLevel2();
                level2.Show();
            }
            lbCount.Text = "Count: " + Convert.ToString(racket.Count);
            lbLife.Text = Convert.ToString(racket.Life);
        }

        public FormGame()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keys = e.KeyCode;

            switch (keys)
            {
                case Keys.Left:
                    racket.racketMove(-racketShift, btnRacket);
                    break;
                case Keys.Right:
                    racket.racketMove(racketShift, btnRacket);
                    break;
                case Keys.Enter:
                    timer.Enabled = true;
                    lbText.Visible = false;
                    racket.BallX = racket.startPositionBallX;
                    racket.BallY = racket.startPositionBallY;
                    racket.RacketX = racket.startPositionRacket;
                    racket.racketMove(racketShift, btnRacket);
                    break;
            }
        }
    }
}
