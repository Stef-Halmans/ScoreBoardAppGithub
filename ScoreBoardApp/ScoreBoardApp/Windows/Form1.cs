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
        public Form1()
        {
            InitializeComponent();
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
        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KickButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("Player1", 2);
        }

        private void HitButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("Player1", 1);
        }

        private void TakeDownButton1_Click(object sender, EventArgs e)
        {
            ChangeScore("Player1", 3);
        }

        private void KickButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("Player2", 2);
        }

        private void HitButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("Player2", 1);
        }

        private void TakeDownButton2_Click(object sender, EventArgs e)
        {
            ChangeScore("Player2", 3);
        }

        private void Player1Score_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
