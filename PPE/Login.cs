﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PPE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void txbLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text;
            string password = txbPassword.Text;
            
            bool testLog = log.testLogin(login, password);

            if (testLog)
            {
                this.Hide();
                main main = new main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong Login or password !");
            }
        }
    }
}