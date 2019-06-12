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



        }
    }
}
