using ScoreBoardApp.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoardApp.Windows
{
    public partial class LoginPage : Form
    {
        private string username;
        private string password;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            username = UsernameTextbox.Text;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            password = PasswordTextbox.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Program.Login.CanLogin(username, password))
            {
                ScoreBoard scoreBoard = new ScoreBoard();
                this.Hide();
                scoreBoard.ShowDialog();
            }
        }
    }
}
