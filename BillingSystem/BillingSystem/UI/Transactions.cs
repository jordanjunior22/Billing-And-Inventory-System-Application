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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        transactionDAL tdal = new transactionDAL();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            //Display all the transactions
            DataTable dt = tdal.DisplayAllTransaction();
            transactionDisplay.DataSource = dt;

        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the values from combobox
            string type = cmbTransactionType.Text;
            DataTable dt = tdal.DisplayTransactionByType(type);
            transactionDisplay.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransaction();
            transactionDisplay.DataSource = dt;
        }
    }
}
