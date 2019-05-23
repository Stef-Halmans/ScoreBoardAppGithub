using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoardApp.Scripts
{
    class Login
    {
        private string username;
        private string password;

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        internal bool CanLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username)){
                MessageBox.Show("Enter the username");
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter the password");
                return false;
            }
            else
            {
                if(this.username == username && this.password == password)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The username or password are not correct please try again");
                    return false;
                }

            }
        }
    }
}
