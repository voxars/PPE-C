using System;
using System.Windows.Forms;

namespace PPE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txbLog_TextChanged(object sender, EventArgs e)
        {
        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txbLog.Text;
            string password = txbPass.Text;
            
            bool testLog = Login.testLogin(login, password);

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