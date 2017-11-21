using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSystem
{
    public partial class LoginForm : Form
    {
        private ChatForm f1;

        public LoginForm(ChatForm f)
        {
            f1 = f;
            InitializeComponent();
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;

            string password = PasswordTxt.Text;

            f1.Login(userName, password);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //f1.Show(false);
        }
    }
}
