using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesProject
{
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();

            int timeLeft = 3000;
            gpBox.Hide();
            picBoxWrong.Hide();
            picBoxCorrect.Hide();
            lblNumber.Parent = pictureBox1;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Location = new Point(2, 2);
            pictureBox1.BackColor = Color.Transparent;
            lblOver.BackColor = Color.Transparent;
            gpBox.BackColor = Color.Transparent;
            picBoxWrong.BackColor = Color.Transparent;
            picBoxCorrect.BackColor = Color.Transparent;
        }
        int score = 0;
        int timeLeft = 0;
        int ticks;
        private bool yesClicked;
        private bool noClicked;
        private int number;

        private void Numbers_Load(object sender, EventArgs e)
        {
            NumArray();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            yesClicked = true;
            NumberCheckOdd();
            GotoNext();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            noClicked = true;
            NumberCheckEven();
            GotoNext();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strNumber = lblNumber.Text;
            pictureBox1.Top = pictureBox1.Top + 1;
            ticks++;

            for (int x = 0; x <= 1000000; x++)
            {
                int y = 3000 * x;

                if (y == ticks)
                {
                    timer1.Stop();
                    gpBox.Show();
                    lblNumber.Hide();
                    btnNo.Enabled = false;
                    btnYes.Enabled = false;
                    btnResume.Enabled = false;
                    btnPause.Enabled = false;
                    lblFullScore.Text = "Time Out!\nYour score is : " + score.ToString();
                }
            }

            int height = this.Height; // get the width of Form.

            if (pictureBox1.Location.Y == height) //to check condition if pic box is touch the boundroy of form width
            {
                timer1.Stop();
                gpBox.Show();
                btnYes.Enabled = false;
                btnNo.Enabled = false;
                btnResume.Enabled = false;
                btnPause.Enabled = false;
                lblFullScore.Text = "Your score is : " + score.ToString();
            }

            if (yesClicked == true || noClicked == true)
            {
                timer1.Interval = 3000;
            }

            timer1.Interval = 40;
            picBoxWrong.Hide();
            picBoxCorrect.Hide();
        }

        private void GotoNext()
        {
            NumArray();
            SetBounds();
        }

        private void NumArray()
        {
            Random rand = new Random();
            int index = rand.Next(100, 1000);
            lblNumber.Text = index.ToString();
        }

        private void NumberCheckOdd()
        {
            int number = int.Parse(lblNumber.Text);

            if (number % 2 == 1)
            {
                picBoxCorrect.Show();
                string currentScore = lblScore.Text;
                int currscore = int.Parse(currentScore);
                score = currscore + 1;
                lblScore.Text = score.ToString();
            }
            else
            {
                picBoxWrong.Show();
            }

        }

        private void NumberCheckEven()
        {
            int number = int.Parse(lblNumber.Text);

            if (number % 2 == 1)
            {
                picBoxWrong.Show();
            }
            else
            {
                picBoxCorrect.Show();
                string currentScore = lblScore.Text;
                int currscore = int.Parse(currentScore);
                score = currscore + 1;
                lblScore.Text = score.ToString();
            }
        }


        private void SetBounds()
        {
            //Randomly set the starting points of the water bubble
            int[] xAxis = { 100, 200, 300, 400, 150, 250, 350, 50 };

            Random rand = new Random();
            int index = rand.Next(xAxis.Length);
            pictureBox1.Location = new Point(xAxis[index], 10);
            btnNo.Enabled = true;
            btnYes.Enabled = true;
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            gpBox.Hide();
            lblNumber.Show();
            SetBounds();
            btnResume.Enabled = true;
            btnPause.Enabled = true;
            timeLeft = 3000;
            lblScore.Text = "0";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnNo.Enabled = false;
            btnYes.Enabled = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnNo.Enabled = true;
            btnYes.Enabled = true;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            gpBox.Show();
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            btnResume.Enabled = false;
            btnPause.Enabled = false;
            lblFullScore.Text = "Your score is : "+score.ToString();
        }
        private void timeCount()
        {
            timeLeft = 3000;
            timeLeft = timeLeft - 1;    
        }
    }
}
