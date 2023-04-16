using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.DAL;

namespace BillingSystem.UI
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        categoryDAL cdal = new categoryDAL();
        productsDAL pdal = new productsDAL();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //Display the categories in combobox
            DataTable cDt = cdal.Select();
            cmbCategories.DataSource = cDt;
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            //Display all product in dataGridView when form is loaded
            DataTable pdt = pdal.Select();
            InventoryDisplay.DataSource = pdt;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display products based on categories 
            string category = cmbCategories.Text;
            DataTable dt = pdal.displayProductByCategory(category);
            InventoryDisplay.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            InventoryDisplay.DataSource = dt;
        }
    }
}
