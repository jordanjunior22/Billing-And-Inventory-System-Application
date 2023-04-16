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
    public partial class AdminConfirm : Form
    {
        public AdminConfirm()
        {
            InitializeComponent();
        }
        confirmBLL u = new confirmBLL();
        confirmDAL uDAL = new confirmDAL();
        adminConfirmDAL adDAL = new adminConfirmDAL();
        adminConfirmBLL c = new adminConfirmBLL(); 
        userDAL dal = new userDAL();
        userBLL ub = new userBLL();

        private void ConfirmDisplay_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            c.id = Convert.ToInt32(ConfirmDisplay.Rows[rowIndex].Cells[0].Value.ToString());
            c.first_name = ConfirmDisplay.Rows[rowIndex].Cells[1].Value.ToString();
            c.last_name = ConfirmDisplay.Rows[rowIndex].Cells[2].Value.ToString();
            c.email = ConfirmDisplay.Rows[rowIndex].Cells[3].Value.ToString();
            c.username = ConfirmDisplay.Rows[rowIndex].Cells[4].Value.ToString();
            c.password  = ConfirmDisplay.Rows[rowIndex].Cells[5].Value.ToString();
            c.contact = ConfirmDisplay.Rows[rowIndex].Cells[6].Value.ToString();
            c.address = ConfirmDisplay.Rows[rowIndex].Cells[7].Value.ToString();
            c.status = ConfirmDisplay.Rows[rowIndex].Cells[8].Value.ToString();
            c.gender = ConfirmDisplay.Rows[rowIndex].Cells[9].Value.ToString();
            c.added_date = DateTime.Now;
            c.added_by = 1;
            

        }

        private void AdminConfirm_Load(object sender, EventArgs e)
        {
            DataTable dt = uDAL.Select();
            ConfirmDisplay.DataSource = dt;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            bool success = adDAL.Insert(c);

            if (success == true)
            {
                u.id = c.id;
                u.first_name = c.first_name;
                u.last_name = c.last_name;
                u.email = c.email;
                u.username = c.username;
                u.password = c.password;
                u.contact = c.contact;
                u.address = c.address;
                u.gender = c.gender;
                u.added_by = c.added_by;
                u.added_date = DateTime.Now;
                u.status = "Approved";
                adDAL.Update(u);
                //data inserted
                MessageBox.Show("Success");
                //clear();
            }
            else
            {
                //failed to insert
                MessageBox.Show("Failed insert Data");
            }
            DataTable dt = uDAL.Select();
            ConfirmDisplay.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = c.id;
            u.first_name = c.first_name;
            u.last_name = c.last_name;
            u.email = c.email;
            u.username = c.username;
            u.password = c.password;
            u.contact = c.contact;
            u.address = c.address;
            u.gender = c.gender;
            u.added_by = c.added_by;
            u.added_date = DateTime.Now;
            u.status = "Declined";

            ub.first_name = u.first_name;
            ub.last_name = u.last_name;

            
        
            bool success = adDAL.Update(u);


            if (success == true)
            {
                dal.DeleteByUser(ub);
                MessageBox.Show("Success");
                //clear();
            }
            else
            {
                //failed to insert
                MessageBox.Show("Failed UPDATE Data");
            }
            DataTable dt = uDAL.Select();
            ConfirmDisplay.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)

        {
            bool success = uDAL.Delete(u);


            if (success == true)
            {

                MessageBox.Show("Success");
                //clear();
            }
            else
            {
                //failed to insert
                MessageBox.Show("Failed UPDATE Data");
            }
            DataTable dt = uDAL.Select();
            ConfirmDisplay.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
