using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public string Hash(string password)
        {
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }
        internal bool CanLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
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
                if (this.username == username && this.password == Hash(password))
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
