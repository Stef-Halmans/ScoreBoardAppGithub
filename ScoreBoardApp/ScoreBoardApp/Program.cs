using ScoreBoardApp.Scripts;
using ScoreBoardApp.Windows;
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
        public static Login login;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login = new Login("Username", "e7cf3ef4f17c3999a94f2c6f612e8a888e5b1026878e4e19398b23bd38ec221a");
            Application.Run(new LoginPage());
            ScorePlayer1 = 0;
            ScorePlayer2 = 0;
        }
    }
}
