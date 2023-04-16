

namespace BillingSystem.UI
{
    partial class PurchaseAndSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PurchaseTitle = new System.Windows.Forms.Label();
            this.pnlDealerCustomer = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputContact = new System.Windows.Forms.TextBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputAddressLbl = new System.Windows.Forms.Label();
            this.inputContactLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.inputProductQty = new System.Windows.Forms.TextBox();
            this.inputProductRate = new System.Windows.Forms.TextBox();
            this.inputProductName = new System.Windows.Forms.TextBox();
            this.inputProductInventory = new System.Windows.Forms.TextBox();
            this.inputProductSearch = new System.Windows.Forms.TextBox();
            this.lblinven = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.displayAddedProducts = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.productReturnAmount = new System.Windows.Forms.TextBox();
            this.productPaidAmount = new System.Windows.Forms.TextBox();
            this.productGrandTotal = new System.Windows.Forms.TextBox();
            this.productVAT = new System.Windows.Forms.TextBox();
            this.productDiscount = new System.Windows.Forms.TextBox();
            this.productSubTotal = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDealerCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddedProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PurchaseTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 48);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1254, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PurchaseTitle
            // 
            this.PurchaseTitle.AutoSize = true;
            this.PurchaseTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PurchaseTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PurchaseTitle.Location = new System.Drawing.Point(571, 9);
            this.PurchaseTitle.Name = "PurchaseTitle";
            this.PurchaseTitle.Size = new System.Drawing.Size(262, 31);
            this.PurchaseTitle.TabIndex = 0;
            this.PurchaseTitle.Text = "PURCHASE AND SALES";
            // 
            // pnlDealerCustomer
            // 
            this.pnlDealerCustomer.Controls.Add(this.dateTimePicker1);
            this.pnlDealerCustomer.Controls.Add(this.inputAddress);
            this.pnlDealerCustomer.Controls.Add(this.inputContact);
            this.pnlDealerCustomer.Controls.Add(this.inputEmail);
            this.pnlDealerCustomer.Controls.Add(this.inputName);
            this.pnlDealerCustomer.Controls.Add(this.inputSearch);
            this.pnlDealerCustomer.Controls.Add(this.label9);
            this.pnlDealerCustomer.Controls.Add(this.inputAddressLbl);
            this.pnlDealerCustomer.Controls.Add(this.inputContactLbl);
            this.pnlDealerCustomer.Controls.Add(this.label5);
            this.pnlDealerCustomer.Controls.Add(this.label3);
            this.pnlDealerCustomer.Controls.Add(this.label2);
            this.pnlDealerCustomer.Controls.Add(this.title);
            this.pnlDealerCustomer.Location = new System.Drawing.Point(11, 67);
            this.pnlDealerCustomer.Name = "pnlDealerCustomer";
            this.pnlDealerCustomer.Size = new System.Drawing.Size(1269, 133);
            this.pnlDealerCustomer.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1022, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(698, 32);
            this.inputAddress.Multiline = true;
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(234, 72);
            this.inputAddress.TabIndex = 14;
            // 
            // inputContact
            // 
            this.inputContact.Location = new System.Drawing.Point(378, 77);
            this.inputContact.Name = "inputContact";
            this.inputContact.Size = new System.Drawing.Size(234, 27);
            this.inputContact.TabIndex = 13;
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(378, 32);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(234, 27);
            this.inputEmail.TabIndex = 12;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(62, 77);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(234, 27);
            this.inputName.TabIndex = 11;
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(62, 36);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(234, 27);
            this.inputSearch.TabIndex = 4;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(955, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bill Date";
            // 
            // inputAddressLbl
            // 
            this.inputAddressLbl.AutoSize = true;
            this.inputAddressLbl.Location = new System.Drawing.Point(630, 39);
            this.inputAddressLbl.Name = "inputAddressLbl";
            this.inputAddressLbl.Size = new System.Drawing.Size(62, 20);
            this.inputAddressLbl.TabIndex = 8;
            this.inputAddressLbl.Text = "Address";
            // 
            // inputContactLbl
            // 
            this.inputContactLbl.AutoSize = true;
            this.inputContactLbl.Location = new System.Drawing.Point(312, 84);
            this.inputContactLbl.Name = "inputContactLbl";
            this.inputContactLbl.Size = new System.Drawing.Size(60, 20);
            this.inputContactLbl.TabIndex = 7;
            this.inputContactLbl.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(286, 28);
            this.title.TabIndex = 4;
            this.title.Text = "Dealer And Customer Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddProducts);
            this.panel2.Controls.Add(this.inputProductQty);
            this.panel2.Controls.Add(this.inputProductRate);
            this.panel2.Controls.Add(this.inputProductName);
            this.panel2.Controls.Add(this.inputProductInventory);
            this.panel2.Controls.Add(this.inputProductSearch);
            this.panel2.Controls.Add(this.lblinven);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.lblprice);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(9, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 83);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddProducts.Location = new System.Drawing.Point(1106, 23);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(143, 36);
            this.btnAddProducts.TabIndex = 15;
            this.btnAddProducts.Text = "ADD";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // inputProductQty
            // 
            this.inputProductQty.AccessibleDescription = "inputQty";
            this.inputProductQty.Location = new System.Drawing.Point(1025, 31);
            this.inputProductQty.Name = "inputProductQty";
            this.inputProductQty.Size = new System.Drawing.Size(46, 27);
            this.inputProductQty.TabIndex = 14;
            this.inputProductQty.TextChanged += new System.EventHandler(this.inputProductQty_TextChanged);
            // 
            // inputProductRate
            // 
            this.inputProductRate.AccessibleDescription = "inputPrice";
            this.inputProductRate.Location = new System.Drawing.Point(854, 32);
            this.inputProductRate.Name = "inputProductRate";
            this.inputProductRate.Size = new System.Drawing.Size(81, 27);
            this.inputProductRate.TabIndex = 13;
            // 
            // inputProductName
            // 
            this.inputProductName.Location = new System.Drawing.Point(334, 32);
            this.inputProductName.Name = "inputProductName";
            this.inputProductName.Size = new System.Drawing.Size(179, 27);
            this.inputProductName.TabIndex = 12;
            // 
            // inputProductInventory
            // 
            this.inputProductInventory.Location = new System.Drawing.Point(613, 32);
            this.inputProductInventory.Name = "inputProductInventory";
            this.inputProductInventory.Size = new System.Drawing.Size(179, 27);
            this.inputProductInventory.TabIndex = 11;
            this.inputProductInventory.TextChanged += new System.EventHandler(this.inputProductInventory_TextChanged);
            // 
            // inputProductSearch
            // 
            this.inputProductSearch.Location = new System.Drawing.Point(65, 31);
            this.inputProductSearch.Name = "inputProductSearch";
            this.inputProductSearch.Size = new System.Drawing.Size(169, 27);
            this.inputProductSearch.TabIndex = 4;
            this.inputProductSearch.TextChanged += new System.EventHandler(this.inputProductSearch_TextChanged);
            // 
            // lblinven
            // 
            this.lblinven.AutoSize = true;
            this.lblinven.Location = new System.Drawing.Point(536, 36);
            this.lblinven.Name = "lblinven";
            this.lblinven.Size = new System.Drawing.Size(70, 20);
            this.lblinven.TabIndex = 8;
            this.lblinven.Text = "Inventory";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(941, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quantity";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(265, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 20);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(806, 35);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(41, 20);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Search";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "Product Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.displayAddedProducts);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(9, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 295);
            this.panel3.TabIndex = 17;
            // 
            // displayAddedProducts
            // 
            this.displayAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAddedProducts.Location = new System.Drawing.Point(6, 31);
            this.displayAddedProducts.Name = "displayAddedProducts";
            this.displayAddedProducts.RowHeadersWidth = 51;
            this.displayAddedProducts.RowTemplate.Height = 29;
            this.displayAddedProducts.Size = new System.Drawing.Size(686, 261);
            this.displayAddedProducts.TabIndex = 17;
            this.displayAddedProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayAddedProducts_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Added Products";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.productReturnAmount);
            this.panel4.Controls.Add(this.productPaidAmount);
            this.panel4.Controls.Add(this.productGrandTotal);
            this.panel4.Controls.Add(this.productVAT);
            this.panel4.Controls.Add(this.productDiscount);
            this.panel4.Controls.Add(this.productSubTotal);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(721, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 292);
            this.panel4.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(313, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 37);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // productReturnAmount
            // 
            this.productReturnAmount.Location = new System.Drawing.Point(142, 201);
            this.productReturnAmount.Name = "productReturnAmount";
            this.productReturnAmount.ReadOnly = true;
            this.productReturnAmount.Size = new System.Drawing.Size(170, 27);
            this.productReturnAmount.TabIndex = 29;
            // 
            // productPaidAmount
            // 
            this.productPaidAmount.Location = new System.Drawing.Point(142, 168);
            this.productPaidAmount.Name = "productPaidAmount";
            this.productPaidAmount.Size = new System.Drawing.Size(170, 27);
            this.productPaidAmount.TabIndex = 28;
            this.productPaidAmount.TextChanged += new System.EventHandler(this.productPaidAmount_TextChanged);
            // 
            // productGrandTotal
            // 
            this.productGrandTotal.Location = new System.Drawing.Point(142, 135);
            this.productGrandTotal.Name = "productGrandTotal";
            this.productGrandTotal.ReadOnly = true;
            this.productGrandTotal.Size = new System.Drawing.Size(170, 27);
            this.productGrandTotal.TabIndex = 27;
            // 
            // productVAT
            // 
            this.productVAT.Location = new System.Drawing.Point(142, 101);
            this.productVAT.Name = "productVAT";
            this.productVAT.ReadOnly = true;
            this.productVAT.Size = new System.Drawing.Size(170, 27);
            this.productVAT.TabIndex = 26;
            this.productVAT.Text = "18";
            this.productVAT.TextChanged += new System.EventHandler(this.productVAT_TextChanged);
            // 
            // productDiscount
            // 
            this.productDiscount.Location = new System.Drawing.Point(142, 69);
            this.productDiscount.Name = "productDiscount";
            this.productDiscount.Size = new System.Drawing.Size(170, 27);
            this.productDiscount.TabIndex = 25;
            this.productDiscount.TextChanged += new System.EventHandler(this.inputDiscount_TextChanged);
            // 
            // productSubTotal
            // 
            this.productSubTotal.Location = new System.Drawing.Point(142, 31);
            this.productSubTotal.Name = "productSubTotal";
            this.productSubTotal.ReadOnly = true;
            this.productSubTotal.Size = new System.Drawing.Size(170, 27);
            this.productSubTotal.TabIndex = 24;
            this.productSubTotal.Text = "0";
            this.productSubTotal.TextChanged += new System.EventHandler(this.productSubTotal_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 204);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 20);
            this.label22.TabIndex = 23;
            this.label22.Text = "Return Amount";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 20);
            this.label23.TabIndex = 22;
            this.label23.Text = "Paid Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 21;
            this.label18.Text = "Grand Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = "VAT (%)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Discount (%)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Sub Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 28);
            this.label15.TabIndex = 18;
            this.label15.Text = "Calculations";
            // 
            // PurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1293, 695);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDealerCustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseAndSales";
            this.Load += new System.EventHandler(this.PurchaseAndSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDealerCustomer.ResumeLayout(false);
            this.pnlDealerCustomer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayAddedProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label PurchaseTitle;
        private Panel pnlDealerCustomer;
        private DateTimePicker dateTimePicker1;
        private TextBox inputAddress;
        private TextBox inputContact;
        private TextBox inputEmail;
        private TextBox inputName;
        private TextBox inputSearch;
        private Label label9;
        private Label inputAddressLbl;
        private Label inputContactLbl;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label title;
        private Panel panel2;
        private Button btnAddProducts;
        private TextBox inputProductQty;
        private TextBox inputProductRate;
        private TextBox inputProductName;
        private TextBox inputProductInventory;
        private TextBox inputProductSearch;
        private Label lblinven;
        private Label label10;
        private Label lblname;
        private Label lblprice;
        private Label label13;
        private Label label14;
        private Panel panel3;
        private DataGridView displayAddedProducts;
        private Label label6;
        private Panel panel4;
        private Button btnSave;
        private TextBox productReturnAmount;
        private TextBox productPaidAmount;
        private TextBox productGrandTotal;
        private TextBox productVAT;
        private TextBox productDiscount;
        private TextBox productSubTotal;
        private Label label22;
        private Label label23;
        private Label label18;
        private Label label19;
        private Label label17;
        private Label label16;
        private Label label15;
    }
}