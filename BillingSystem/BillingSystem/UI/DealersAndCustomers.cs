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
    public partial class DealersAndCustomers : Form
    {
        public DealersAndCustomers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        dealerCustomerBLL dc = new dealerCustomerBLL(); 
        dealerCustomerDAL dal = new dealerCustomerDAL();
        userDAL udal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = inputComboType.Text;
            dc.name = inputName.Text;
            dc.email = inputEmail.Text;
            dc.contact = inputContact.Text;
            dc.address = inputAdress.Text;
            dc.added_date = DateTime.Now;

            string loogedinUser = login.loggedin;
            userBLL usr = udal.GetIDFromUsername(loogedinUser);
            dc.added_by = usr.id;

            bool succes = dal.Insert(dc);
            
            if (succes == true)
            {
                MessageBox.Show("Added Succesfully");
                clear();

                DataTable dt = dal.Select();
                displayDealersAndCustomers.DataSource = dt;
            }
            else {
                MessageBox.Show("Add failed");
            }

          

        }
        public void clear()
        {
            inputComboType.Text = "";
            inputName.Text = "";
            inputEmail.Text = "";
            inputContact.Text = "";
            inputAdress.Text = "";
            inputID.Text = "";

        }

        private void DealersAndCustomers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            displayDealersAndCustomers.DataSource = dt;
        }

        private void displayDealersAndCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            inputID.Text = displayDealersAndCustomers.Rows[RowIndex].Cells[0].Value.ToString();
            inputComboType.Text = displayDealersAndCustomers.Rows[RowIndex].Cells[1].Value.ToString();
            inputName.Text = displayDealersAndCustomers.Rows[RowIndex].Cells[2].Value.ToString();
            inputEmail.Text = displayDealersAndCustomers.Rows[RowIndex].Cells[3].Value.ToString();
            inputContact.Text = displayDealersAndCustomers.Rows[RowIndex].Cells[4].Value.ToString();
            inputAdress.Text = displayDealersAndCustomers.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            dc.dealerCustomerid = int.Parse(inputID.Text);
            dc.type = inputComboType.Text;
            dc.name = inputName.Text;
            dc.email = inputEmail.Text;
            dc.contact = inputContact.Text;
            dc.address = inputAdress.Text;
            dc.added_date = DateTime.Now;

            string loogedinUser = login.loggedin;
            userBLL usr = udal.GetIDFromUsername(loogedinUser);
            dc.added_by = usr.id;

            bool succes = dal.Update(dc);

            if (succes == true)
            {
                MessageBox.Show("Added Succesfully");
                clear();

                DataTable dt = dal.Select();
                displayDealersAndCustomers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Add failed");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.dealerCustomerid=int.Parse(inputID.Text);

            bool success = dal.Delete(dc);

            if (success == true)
            {
                MessageBox.Show("Deleted Succesfully");
                clear();

                DataTable dt = dal.Select();
                displayDealersAndCustomers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Delete failed");
            }


        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = inputSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                displayDealersAndCustomers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                displayDealersAndCustomers.DataSource = dt;
            }
        }
    }
}
