using FlaGoThew.model.users;
using FlaGoThew.model.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaGoThew
{
    public partial class LoginForm : UserControl
    {

        private MainForm main;

        public LoginForm(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.txtAlert.Text = "...";
            string email = this.txtEmail.Text;
            string password = this.txtPwd.Text;

            bool isLogin = UserManager.Login(email, password);

            if(!isLogin)
            {
                this.txtAlert.Text = "Email ou mot de passe incorrect !";
                return;
            }

            this.main.LoadPage(new Project());
            //FormUtil.SwapForm(this, new Project());

        }
    }
}
