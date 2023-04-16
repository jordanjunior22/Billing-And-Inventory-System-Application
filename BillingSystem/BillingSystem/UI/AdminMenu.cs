using BillingSystem.UI;

namespace BillingSystem
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoggedInUser.Text = login.loggedin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Users user = new Users();
            user.Show();
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void LoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category cat = new category();
            cat.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products prod = new products();
            prod.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealersAndCustomers dealers_customers = new DealersAndCustomers();
            dealers_customers.Show();

        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions();
            transaction.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventry = new Inventory();
            inventry.Show();
        }

        private void AppFirstName_Click(object sender, EventArgs e)
        {

        }

        private void userApplıcatıonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminConfirm adminconfirmpage = new AdminConfirm();
            adminconfirmpage.Show();
        }

        private void debtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debtsMenu debts = new debtsMenu();
            debts.Show();

        }
    }
}