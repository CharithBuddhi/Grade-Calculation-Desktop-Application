using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__E2140110_
{
    public partial class frmLoginWindow : Form
    {
        string UserName = "Buddhika";
        string Password = "1234";
        int loginFrequency = 0;
        public frmLoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string EnteredUsername = txtUserName.Text;
            string EnteredPassword = txtPassword.Text;
            

            if (EnteredUsername.Equals(UserName) && EnteredPassword.Equals(Password))
            {
                FrmStudentDetais Form2 = new FrmStudentDetais();
                Form2.Show();
                this.Hide();
            }
            else
            {
                loginFrequency = loginFrequency + 1;
                if (loginFrequency > 4)
                {
                    MessageBox.Show("End Of Your Login Frequency");
                    Application.Exit();
                }
                MessageBox.Show("Invalid Login,Please try again");
            }
        }
    }
 }
