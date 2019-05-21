using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoardApp
{
    static class Program
    {
        public static int ScorePlayer1;
        public static int ScorePlayer2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            ScorePlayer1 = 0;
            ScorePlayer2 = 0;
        }
    }
}
