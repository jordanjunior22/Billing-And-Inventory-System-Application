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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        registerBLL u = new registerBLL();
        registerDAL uDAL = new registerDAL();
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

           

            //inserting Data

            bool success = uDAL.Insert(u);

            if (success == true)
            {
                //data inserted
                MessageBox.Show("Success");
                clear();
                this.Hide();
            }
            else
            {
                //failed to insert
                MessageBox.Show("Failed insert Data");
            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
