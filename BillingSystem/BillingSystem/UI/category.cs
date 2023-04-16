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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoryBLL c = new categoryBLL();
        categoryDAL dal = new categoryDAL();
        userDAL udal = new userDAL();
        private void btnADD_Click(object sender, EventArgs e)
        {
            c.title = InputCategoryTitle.Text;
            c.description = InputCategoryDes.Text;
            c.added_date = DateTime.Now;

            string loggeduser = login.loggedin;
            userBLL usr = udal.GetIDFromUsername(loggeduser);

            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if(success == true)
            {
                MessageBox.Show("new category inserted successfuly");
                Clear();

                DataTable dt = dal.Select();
                displayCategory.DataSource = dt;

            }
            else
            {
                MessageBox.Show("failed to insert new category");
            }
        }

        public void Clear()
        {
            InputCategoryTitle.Text = "";
            InputCategoryDes.Text = "";
            inputSearch.Text = "";
            inputCategoryID.Text = "";
        }

        private void category_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            displayCategory.DataSource = dt;
        }

        private void displayCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            inputCategoryID.Text = displayCategory.Rows[RowIndex].Cells[0].Value.ToString();
            InputCategoryTitle.Text = displayCategory.Rows[RowIndex].Cells[1].Value.ToString();
            InputCategoryDes.Text = displayCategory.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(inputCategoryID.Text);
            c.title = InputCategoryTitle.Text;
            c.description = InputCategoryDes.Text;
            c.added_date = DateTime.Now;

            string loggeduser = login.loggedin;
            userBLL usr = udal.GetIDFromUsername(loggeduser);

            c.added_by = usr.id;

            bool success = dal.Update(c);

            if(success == true)
            {
                MessageBox.Show("Category updated successfuly");
                Clear();

                DataTable dt = dal.Select();
                displayCategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category failed to update!");
            }

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(inputCategoryID.Text);

            bool success = dal.Delete(c);

            if(success == true)
            {
                MessageBox.Show("Category deleted successfuly");
                Clear();

                DataTable dt = dal.Select();
                displayCategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category failed to delete");
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = inputSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                displayCategory.DataSource = dt;
            }
            else 
            {
                DataTable dt = dal.Select();
                displayCategory.DataSource = dt;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
