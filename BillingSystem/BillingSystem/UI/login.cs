using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.BLL;
using BillingSystem.DAL;

namespace BillingSystem.UI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        LoginBLL l = new LoginBLL();    
        LoginDAL dal = new LoginDAL();
        public static string loggedin;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //get info from ui
            l.username = InputUserLog.Text.Trim();
            l.password = InputPasswordLog.Text.Trim();
            l.user_type = UserType.Text.Trim();

            

            //Checking the login credentials

            bool sucess = dal.loginCheck(l);
            if(sucess == true)
            {
                MessageBox.Show("Login Successful");
                loggedin = l.username;
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            AdminMenu admin = new AdminMenu();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            UserMenu user = new UserMenu();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid user type");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login faild. Try again please");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
        }
    }
}
