using ScoreBoardApp.Scripts;
using ScoreBoardApp.Windows;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ScoreBoardApp
{
    static class Program
    {
        public static string DatabaseUrl;

        public static int ScorePlayer1;
        public static int ScorePlayer2;

        public static int HitsPlayer1;
        public static int HitsPlayer2;

        public static Login Login;
        public static DatabaseController DatabaseController;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            DatabaseUrl = "http://192.168.1.189:8090/";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseController = new DatabaseController(DatabaseUrl);
            ScorePlayer1 = 0;
            ScorePlayer2 = 0;

            HitsPlayer1 = 0;
            HitsPlayer2 = 0;

            Login = new Login("Username", "e7cf3ef4f17c3999a94f2c6f612e8a888e5b1026878e4e19398b23bd38ec221a");
            Application.Run(new Form1());



        }
    }
}
