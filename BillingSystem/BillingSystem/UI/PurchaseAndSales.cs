using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using BillingSystem.BLL;
using BillingSystem.DAL;
using DGVPrinterHelper;

namespace BillingSystem.UI
{
    public partial class PurchaseAndSales : Form
    {
        public PurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        dealerCustomerDAL dcDal = new dealerCustomerDAL();
        productsDAL pDal = new productsDAL();
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactiondetailsDAL tdDAL = new transactiondetailsDAL();
        dealerCustomerBLL dcbll = new dealerCustomerBLL();
        debtsBLL debtbll = new debtsBLL();
        debtsDAL debtdal = new debtsDAL();
        DataTable transactionDT = new DataTable();
        public decimal debt_to_pay;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = UserMenu.transactionType;
            PurchaseTitle.Text = type;

            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = inputSearch.Text;
            
            if(keyword == "")
            {
                inputName.Text = "";
                inputEmail.Text = "";
                inputContact.Text = "";
                inputAddress.Text = "";
            }

            dealerCustomerBLL dc = dcDal.SearchDealerCustForTrans(keyword);

            inputName.Text = dc.name;
            inputEmail.Text = dc.email;
            inputContact.Text = dc.contact;
            inputAddress.Text = dc.address;
        }

        private void inputProductSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = inputProductSearch.Text;

            if(keyword == "")
            {
                inputProductName.Text = "";
                inputProductRate.Text = "";
                inputProductQty.Text = "";
                inputProductInventory.Text = "";

                return;
            }

            productsBLL p = pDal.getProductsForTrans(keyword);

            inputProductName.Text = p.name;
            inputProductRate.Text = p.rate.ToString();
            inputProductInventory.Text = p.qty.ToString();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            string productName = inputProductName.Text;
            decimal Rate = decimal.Parse(inputProductRate.Text);
            decimal Qty = decimal.Parse(inputProductQty.Text);

            decimal Total = Rate * Qty;

            decimal subTotal = decimal.Parse(productSubTotal.Text);
            subTotal += Total;

            if (productName == "")
            {
                MessageBox.Show("Select the prodcut first. Try again");
            }
            else
            {
                transactionDT.Rows.Add(productName, Rate, Qty, Total);


                displayAddedProducts.DataSource = transactionDT;

                productSubTotal.Text = subTotal.ToString();

                inputProductSearch.Text = "";
                inputProductName.Text = "";
                inputProductInventory.Text = "0.00";
                inputProductQty.Text = "0.00";
                inputProductRate.Text = "0.00";
            }
        }

        private void inputDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = productDiscount.Text;

            if(value == "")
            {
                MessageBox.Show("Please add discount first!");
            }
            else
            {
                decimal subTotal = decimal.Parse(productSubTotal.Text);
                decimal discount = decimal.Parse(productDiscount.Text);

                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                productGrandTotal.Text = grandTotal.ToString();
            }
        }

        
        
        private void productVAT_TextChanged(object sender, EventArgs e)
        {
            string check = productGrandTotal.Text;

            if(check == "")
            {
                MessageBox.Show("Calculate discount and set grand total first!");
            }
            else
            {
                decimal previousGrandTotal = decimal.Parse(productGrandTotal.Text);
                //decimal VAT = decimal.Parse(productVAT.Text);
                decimal VAT = 18;



                decimal grandTotalWithVAT = ((100 + VAT) / 100) * previousGrandTotal;

                productGrandTotal.Text = grandTotalWithVAT.ToString();
            }
        }

        private void productPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(productGrandTotal.Text);
            decimal paidAmount = decimal.Parse(productPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;
            debt_to_pay = returnAmount;


        productReturnAmount.Text = returnAmount.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (debt_to_pay < 0)
            {
                
                

                debtbll.username = inputName.Text;
                debtbll.debt = Math.Abs(debt_to_pay);
                debtbll.email = inputEmail.Text;
                debtbll.contact = inputContact.Text;
                debtbll.id = int.Parse(inputSearch.Text);

                debtdal.Insert(debtbll);
            }
            transactionsBLL transaction = new transactionsBLL();
            transaction.type = PurchaseTitle.Text;

            string dealercustName = inputName.Text;
            dealerCustomerBLL dc = dcDal.GetDealerCustFromname(dealercustName);

            transaction.dea_cust_id = dc.dealerCustomerid;
            transaction.grand_total = Math.Round(decimal.Parse(productGrandTotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(productVAT.Text);
            transaction.discount = decimal.Parse(productDiscount.Text);

            string username = login.loggedin;
            userBLL u = uDAL.GetIDFromUsername(username);
            transaction.added_by = u.id;
            transaction.transcationDetails = transactionDT;

            bool success = false;


            // Insert transcation & transaction details
            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //Create boolean value & insert transaction
                bool w = tDAL.Insert(transaction, out transactionID);

                //Insert transaction details

                for(int i =0; i<transactionDT.Rows.Count; i++)
                {
                    //Get details of the product
                    transactiondetailBLL transactiondetail = new transactiondetailBLL();
                    //Get product name & convert it to id
                    string productName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDal.GetProductIDFromname(productName);

                    transactiondetail.product_id = p.id;
                    transactiondetail.price = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactiondetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactiondetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactiondetail.dea_cust_id = dc.dealerCustomerid;
                    transactiondetail.added_date = DateTime.Now;
                    transactiondetail.added_by = u.id;
                    

                    //Increade or decreade product qty based on purchase or sales
                    string transactionType = PurchaseTitle.Text;

                    bool x = false;
                    if(transactionType == "Purchase")
                    {
                        x = pDal.IncreaseProduct(transactiondetail.product_id, transactiondetail.qty);
                    }
                    else if(transactionType == "Sales")
                    {
                        x = pDal.DecreaseProduct(transactiondetail.product_id, transactiondetail.qty);
                    }

                    //Insert transaction details in the DB
                    bool y = tdDAL.Insert(transactiondetail);
                    success = w && x && y;
                    
                }
                if (success == true)
                {
                    scope.Complete();
                    //Print Bill
                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n TIMS PVT LTD. \r\n\r\n";
                    printer.SubTitle = "Girne, North Cyprus \r\n Phone: +905733784\r\n\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount: " + productDiscount.Text + "% \r\n" + "VAT: " + productVAT.Text + "% \r\n" + "Grand Total: " + productGrandTotal.Text  +"\r\n" + "Paid Amount:" + productPaidAmount.Text  +"\r\n"+  "Returned Amount:" + productReturnAmount.Text + " \r\n thank you for making business with us";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(displayAddedProducts);


                    MessageBox.Show("Transaction completed successfuly");
                    //clear data grid view & clear all textboxes
                    displayAddedProducts.DataSource = null;
                    displayAddedProducts.Rows.Clear();

                    inputProductSearch.Text = "";
                    inputProductName.Text = "";
                    inputEmail.Text = "";
                    inputContact.Text = "";
                    inputAddress.Text = "";
                    inputSearch.Text = "";
                    inputName.Text = "";
                    inputProductRate.Text = "";
                    inputProductQty.Text = "";
                    inputProductInventory.Text = "0";
                    productSubTotal.Text = "0";
                    productGrandTotal.Text = "0";
                    productDiscount.Text = "0";
                    productVAT.Text = "18";
                    productPaidAmount.Text = "0";
                    productReturnAmount.Text = "0";

                }
                else
                {
                    MessageBox.Show("Transaction failed!");
                }

            }

        }

        private void inputProductQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputProductInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayAddedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productSubTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
