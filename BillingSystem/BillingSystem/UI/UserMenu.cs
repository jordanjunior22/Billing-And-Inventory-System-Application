using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.UI;

namespace BillingSystem
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        public static string transactionType;


        private void UserMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            LoggedInUser.Text = login.loggedin;
        }

        private void dealersAndCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealersAndCustomers dealers_customer = new DealersAndCustomers();
            dealers_customer.Show();    
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Purchase";
            PurchaseAndSales purchase = new PurchaseAndSales();
            purchase.Show();
            transactionType = "Purchase";
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            PurchaseAndSales sales = new PurchaseAndSales();
            sales.Show();
            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventry = new Inventory();
            inventry.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            howtouse how = new howtouse();
            how.Show();
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutus = new about();
            aboutus.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmUser confirmuserpage = new confirmUser();
            confirmuserpage.Show(); 
        }
    }
}
