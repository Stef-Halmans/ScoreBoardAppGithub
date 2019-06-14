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

namespace ScoreBoardApp.Windows
{
    public partial class ScoreBoard : Form
    {

        private delegate void Delegate();
        public ScoreBoard()
        {
            InitializeComponent();
            Timer timer = new Timer(500);
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("timer");
            string data = Program.DatabaseController.GetData("getScore");
            Console.WriteLine(data);
            string[] dataArray = data.Split(',');
            if(int.Parse(dataArray[0]) > Program.ScorePlayer1)
            {
                Program.ScorePlayer1 = int.Parse(dataArray[0]);
                Delegate del = new Delegate(ChangePlayer1Score);
                Invoke(del);
            }
            else if(int.Parse(dataArray[1]) > Program.ScorePlayer2)
            {
                Program.ScorePlayer2 = int.Parse(dataArray[1]);
                Delegate del = new Delegate(ChangePlayer2Score);
                Invoke(del);
            }
        }

        private void ChangePlayer1Score()
        {
            Score1.Text = Program.ScorePlayer1.ToString();
        }

        private void ChangePlayer2Score()
        {
            Score2.Text = Program.ScorePlayer2.ToString();
        }


    }
}
