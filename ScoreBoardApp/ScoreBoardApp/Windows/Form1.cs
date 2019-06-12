using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace ScoreBoardApp
{
    public partial class Form1 : Form
    {

        private bool player1Hit;
        private bool player2Hit;
        private delegate void Delegate();
        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Player1Score.Text = Program.ScorePlayer1.ToString();
            Player2Score.Text = Program.ScorePlayer2.ToString();

            player1Hit = false;
            player2Hit = false;

            Timer timer = new Timer(3000);
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            string newHits = Program.DatabaseController.GetData("getHits");
            Console.WriteLine(newHits);
          //  Console.WriteLine(newHits.Substring(1, 1));
            if (int.Parse(newHits.Substring(0,1)) > Program.HitsPlayer1)
            {
                Program.HitsPlayer1 = int.Parse(newHits.Substring(0, 1));
                Delegate del = new Delegate(Player1Hit);
                Invoke(del);

            }
            else if (int.Parse(newHits.Substring(1, 1)) > Program.HitsPlayer2)
            {
                Program.HitsPlayer2 = int.Parse(newHits.Substring(1, 1));
                Delegate del = new Delegate(Player2Hit);
                Invoke(del);
            }
        }

        public void Player1Hit()
        {
            player1Hit = true;
            NewHitInformation1.Visible = true;
        }

        public void Player2Hit()
        {
            player2Hit = true;
            NewHitInformation2.Visible = true;
        }

        public void ChangeScore(string player, int score)
        {
            if(player == "1")
            {
                Program.ScorePlayer1 += score;
                Player1Score.Text = Program.ScorePlayer1.ToString();
            }
            else if(player == "2")
            {
                Program.ScorePlayer2 += score;
                Player2Score.Text = Program.ScorePlayer2.ToString();
            }
        }

        private void ClearHitMessage(string player)
        {
            if (player1Hit && player == "1")
            {
                player1Hit = false;
                NewHitInformation1.Visible = false;
            }
            else if (player2Hit && player == "2")
            {
                player2Hit = false;
                NewHitInformation2.Visible = false;
            }
        }

        private void KickButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("1", 2);
            Program.DatabaseController.SubmitData("1", "2");
            ClearHitMessage("1");
        }

        private void HitButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("1", 1);
            Program.DatabaseController.SubmitData("1", "1");
            ClearHitMessage("1");
        }

        private void TakeDownButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("1", 3);
            Program.DatabaseController.SubmitData("1", "3");
            ClearHitMessage("1");
        }

        private void KickButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("2", 2);
            Program.DatabaseController.SubmitData("2", "2");
            ClearHitMessage("2");
        }

        private void HitButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("2", 1);
            Program.DatabaseController.SubmitData("2", "1");
            ClearHitMessage("2");
        }

        private void TakeDownButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("2", 3);
            Program.DatabaseController.SubmitData("2", "3");
            ClearHitMessage("2");
        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NoScoreButton1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Weet u zeker dat deze hit geen score was?", "Melding", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                ClearHitMessage("1");
            }

        }

        private void NoScoreButton2_Click(object sender, EventArgs e)
        {
            ClearHitMessage("2");
        }
    }
}
