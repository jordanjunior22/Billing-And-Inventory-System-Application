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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoryDAL cdal = new categoryDAL();
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();

        private void products_Load(object sender, EventArgs e)
        {
            DataTable CategoryDt = cdal.Select();
            cmbCategory.DataSource = CategoryDt;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable dt = pdal.Select();
            displayProducts.DataSource = dt;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            p.name = inputName.Text;
            p.category = cmbCategory.Text;
            p.description = inputDescription.Text;
            p.rate = (int)decimal.Parse(inputRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            string loggedUsr = login.loggedin;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);
            p.added_by = usr.id;

            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product Added Succesfully");
                Clear();

                DataTable dt = pdal.Select();
                displayProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed To Add Product");
            }


        }
        public void Clear()
        {
            inputName.Text = "";
            inputDescription.Text = "";
            inputSearch.Text = "";
            inputRate.Text = "";
            inputProductID.Text = "";
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = inputSearch.Text;
            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                displayProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                displayProducts.DataSource = dt;
            }
        }

        private void displayProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            inputProductID.Text = displayProducts.Rows[RowIndex].Cells[0].Value.ToString();
            inputName.Text = displayProducts.Rows[RowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = displayProducts.Rows[RowIndex].Cells[2].Value.ToString();
            inputDescription.Text = displayProducts.Rows[RowIndex].Cells[3].Value.ToString();
            inputRate.Text = displayProducts.Rows[RowIndex].Cells[4].Value.ToString();
           
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(inputProductID.Text);
            p.name = inputName.Text;
            p.category = cmbCategory.Text;
            p.description = inputDescription.Text;
            p.rate = (int)decimal.Parse(inputRate.Text);
            p.added_date = DateTime.Now;

            string loggeduser = login.loggedin;
            userBLL usr = udal.GetIDFromUsername(loggeduser);

            p.added_by = usr.id;

            bool success = pdal.Update(p);

            if (success == true)
            {
                MessageBox.Show("Product updated successfuly");
                Clear();

                DataTable dt = pdal.Select();
                displayProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Product failed to update!");
            }

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(inputProductID.Text);

            bool success = pdal.Delete(p);

            if (success == true)
            {
                MessageBox.Show("Product deleted successfuly");
                Clear();

                DataTable dt = pdal.Select();
                displayProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Product failed to delete");
            }
        }

        private void displayProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
