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
    public partial class confirmUser : Form
    {
        public confirmUser()
        {
            InitializeComponent();
        }
        confirmBLL u = new confirmBLL();
        confirmDAL uDAL = new confirmDAL();
        userDAL dal = new userDAL();
        adminConfirmBLL c = new adminConfirmBLL();
        private void btnADD_Click(object sender, EventArgs e)
        {
            string loggedUser = login.loggedin;

            //getiing data from UI
            u.first_name = inputFirstNameConfirm.Text;
            u.last_name = inputLastNameConfirm.Text;
            u.email = inputEmailConfirm.Text;
            u.username = InputUsernameConfirm.Text;
            u.password = inputPasswordConfirm.Text;
            u.contact = inputContactConfirm.Text;
            u.address = inputAddressConfirm.Text;
            u.gender = inputGenderConfirm.Text;
            u.added_date = DateTime.Now;

            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;

            //inserting Data

            bool success = uDAL.Insert(u);

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
            DataTable dt = uDAL.Select();
            displayUsers.DataSource = dt;
        }

        private void clear()
        {
            inputFirstNameConfirm.Text = "";
            inputLastNameConfirm.Text = "";
            inputEmailConfirm.Text = "";
            InputUsernameConfirm.Text = "";
            inputPasswordConfirm.Text = "";
            inputContactConfirm.Text = "";
            inputAddressConfirm.Text = "";
            inputGenderConfirm.Text = "";
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            //Get values from UI
            u.id = Convert.ToInt32(inputUserID.Text);
            u.first_name = inputFirstNameConfirm.Text;
            u.last_name = inputLastNameConfirm.Text;
            u.email = inputEmailConfirm.Text;
            u.username = InputUsernameConfirm.Text;
            u.password = inputPasswordConfirm.Text;
            u.contact = inputContactConfirm.Text;
            u.address = inputAddressConfirm.Text;
            u.gender = inputGenderConfirm.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = uDAL.Update(u);

            if (success == true)
            {
                MessageBox.Show("Success");
                clear();
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
            DataTable dt = uDAL.Select();
            displayUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(inputUserID.Text);
            bool success = uDAL.Delete(u);

            if (success == true)
            {
                MessageBox.Show("Delete Succesfully");
                clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
            DataTable dt = uDAL.Select();
            displayUsers.DataSource = dt;
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = inputSearch.Text;

            if (keywords != null)
            {
                DataTable dt = uDAL.Search(keywords);
                displayUsers.DataSource = dt;

            }
            else
            {
                //show all users

            }
        }

        private void displayUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            inputUserID.Text = displayUsers.Rows[rowIndex].Cells[0].Value.ToString();
            inputFirstNameConfirm.Text = displayUsers.Rows[rowIndex].Cells[1].Value.ToString();
            inputLastNameConfirm.Text = displayUsers.Rows[rowIndex].Cells[2].Value.ToString();
            inputEmailConfirm.Text = displayUsers.Rows[rowIndex].Cells[3].Value.ToString();
            InputUsernameConfirm.Text = displayUsers.Rows[rowIndex].Cells[4].Value.ToString();
            inputPasswordConfirm.Text = displayUsers.Rows[rowIndex].Cells[5].Value.ToString();
            inputContactConfirm.Text = displayUsers.Rows[rowIndex].Cells[6].Value.ToString();
            inputAddressConfirm.Text = displayUsers.Rows[rowIndex].Cells[7].Value.ToString();
            inputGenderConfirm.Text = displayUsers.Rows[rowIndex].Cells[8].Value.ToString();
            
        }

        private void confirmUser_Load(object sender, EventArgs e)
        {
            DataTable dt = uDAL.Select();
            displayUsers.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void inputGenderConfirm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void inputAddressConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void inputContactConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void inputLastNameConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputEmailConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void InputUsernameConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void inputPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_Click(object sender, EventArgs e)
        {

        }

        private void inputFirstNameConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void textLastName_Click(object sender, EventArgs e)
        {

        }

        private void inputUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
