using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoardApp
{
    public partial class Form1 : Form
    {
        private string data;
        public Form1()
        {
            InitializeComponent();
            data = Program.DatabaseController.GetData();
            Player1Score.Text = Program.ScorePlayer1.ToString();
            Player2Score.Text = Program.ScorePlayer2.ToString();
        }

        public void ChangeScore(string player, int score)
        {
            if(player == "Player1")
            {
                Program.ScorePlayer1 += score;
                Player1Score.Text = Program.ScorePlayer1.ToString();
            }
            else if(player == "Player2")
            {
                Program.ScorePlayer2 += score;
                Player2Score.Text = Program.ScorePlayer2.ToString();
            }
        }

        private void KickButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("Player1", 2);
            Program.DatabaseController.SubmitData("Player1","Kick");
        }

        private void HitButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("Player1", 1);
            Program.DatabaseController.SubmitData("Player1", "Hit");
        }

        private void TakeDownButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("Player1", 3);
            Program.DatabaseController.SubmitData("Player1", "TakeDown");
        }

        private void KickButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("Player2", 2);
            Program.DatabaseController.SubmitData("Player2", "Kick");
        }

        private void HitButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("Player2", 1);
            Program.DatabaseController.SubmitData("Player2", "Hit");
        }

        private void TakeDownButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("Player2", 3);
            Program.DatabaseController.SubmitData("Player2", "TakeDown");
        }


    }
}
