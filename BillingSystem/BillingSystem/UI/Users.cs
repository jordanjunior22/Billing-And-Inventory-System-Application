using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.BLL;
using BillingSystem.DAL;

namespace BillingSystem.UI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        userBLL u= new userBLL();
        userDAL dal = new userDAL();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //reomeved
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string loggedUser = login.loggedin;

            //getiing data from UI
            u.first_name = inputFirstName.Text;
            u.last_name = inputLastName.Text;
            u.email = inputEmail.Text;
            u.username = InputUsername.Text;
            u.password = inputPassword.Text;
            u.contact = inputContact.Text;
            u.address = inputAddress.Text;
            u.gender = inputGender.Text;
            u.user_type = inputUserType.Text;
            u.added_date = DateTime.Now;

            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;

            //inserting Data

            bool success = dal.Insert(u);

            if (success == true)
            {
                //data inserted
                MessageBox.Show("Success");
                clear();
            }
            else 
            {
                //failed to insert
                MessageBox.Show("Failed insert Data");
            }

            //refresh grid view
            DataTable dt = dal.Select();
            displayUsers.DataSource = dt;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            displayUsers.DataSource = dt;

            

        }

        private void clear() 
        {
            inputFirstName.Text = "";
            inputLastName.Text = "";
            inputEmail.Text = "";
            InputUsername.Text = "";
            inputPassword.Text = "";
            inputContact.Text = "";
            inputAddress.Text = "";
            inputGender.Text = "";
            inputUserType.Text = "";

        }

        private void displayUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            inputUserID.Text = displayUsers.Rows[rowIndex].Cells[0].Value.ToString();
            inputFirstName.Text = displayUsers.Rows[rowIndex].Cells[1].Value.ToString();
            inputLastName.Text = displayUsers.Rows[rowIndex].Cells[2].Value.ToString();
            inputEmail.Text = displayUsers.Rows[rowIndex].Cells[3].Value.ToString();
            InputUsername.Text = displayUsers.Rows[rowIndex].Cells[4].Value.ToString();
            inputPassword.Text = displayUsers.Rows[rowIndex].Cells[5].Value.ToString();
            inputContact.Text = displayUsers.Rows[rowIndex].Cells[6].Value.ToString();
            inputAddress.Text = displayUsers.Rows[rowIndex].Cells[7].Value.ToString();
            inputGender.Text = displayUsers.Rows[rowIndex].Cells[8].Value.ToString();
            inputUserType.Text = displayUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get values from UI
            u.id = Convert.ToInt32(inputUserID.Text);
            u.first_name = inputFirstName.Text;
            u.last_name = inputLastName.Text;
            u.email = inputEmail.Text;
            u.username = InputUsername.Text;
            u.password = inputPassword.Text;
            u.contact = inputContact.Text;
            u.address = inputAddress.Text;
            u.gender = inputGender.Text;
            u.user_type = inputUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);

            if (success == true)
            {
                MessageBox.Show("Success");
                clear();
            }
            else 
            {
                MessageBox.Show("Update Fail");
            }
            DataTable dt = dal.Select();
            displayUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(inputUserID.Text);
            bool success = dal.Delete(u);

            if (success == true)
            {
                MessageBox.Show("Delete Succesfully");
                clear();
            }
            else 
            {
                MessageBox.Show("Error");
            }
            DataTable dt = dal.Select();
            displayUsers.DataSource = dt;
        }

        private void inputUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
