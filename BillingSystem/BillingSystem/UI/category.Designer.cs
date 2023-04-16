namespace BillingSystem.UI
{
    partial class category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryID = new System.Windows.Forms.Label();
            this.CategoryTitle = new System.Windows.Forms.Label();
            this.CategoryDescription = new System.Windows.Forms.Label();
            this.inputCategoryID = new System.Windows.Forms.TextBox();
            this.InputCategoryDes = new System.Windows.Forms.TextBox();
            this.InputCategoryTitle = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.displayCategory = new System.Windows.Forms.DataGridView();
            this.lblsearch = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 48);
            this.panel1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(590, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIES";
            // 
            // categoryID
            // 
            this.categoryID.AutoSize = true;
            this.categoryID.Location = new System.Drawing.Point(41, 72);
            this.categoryID.Name = "categoryID";
            this.categoryID.Size = new System.Drawing.Size(84, 20);
            this.categoryID.TabIndex = 2;
            this.categoryID.Text = "CategoryID";
            // 
            // CategoryTitle
            // 
            this.CategoryTitle.AutoSize = true;
            this.CategoryTitle.Location = new System.Drawing.Point(41, 131);
            this.CategoryTitle.Name = "CategoryTitle";
            this.CategoryTitle.Size = new System.Drawing.Size(38, 20);
            this.CategoryTitle.TabIndex = 3;
            this.CategoryTitle.Text = "Title";
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.AutoSize = true;
            this.CategoryDescription.Location = new System.Drawing.Point(41, 178);
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(85, 20);
            this.CategoryDescription.TabIndex = 4;
            this.CategoryDescription.Text = "Description";
            // 
            // inputCategoryID
            // 
            this.inputCategoryID.Location = new System.Drawing.Point(190, 65);
            this.inputCategoryID.Name = "inputCategoryID";
            this.inputCategoryID.ReadOnly = true;
            this.inputCategoryID.Size = new System.Drawing.Size(200, 27);
            this.inputCategoryID.TabIndex = 5;
            // 
            // InputCategoryDes
            // 
            this.InputCategoryDes.Location = new System.Drawing.Point(190, 178);
            this.InputCategoryDes.Multiline = true;
            this.InputCategoryDes.Name = "InputCategoryDes";
            this.InputCategoryDes.Size = new System.Drawing.Size(200, 150);
            this.InputCategoryDes.TabIndex = 6;
            // 
            // InputCategoryTitle
            // 
            this.InputCategoryTitle.Location = new System.Drawing.Point(190, 128);
            this.InputCategoryTitle.Name = "InputCategoryTitle";
            this.InputCategoryTitle.Size = new System.Drawing.Size(200, 27);
            this.InputCategoryTitle.TabIndex = 7;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnADD.Location = new System.Drawing.Point(190, 354);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(124, 45);
            this.btnADD.TabIndex = 8;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUPDATE.Location = new System.Drawing.Point(320, 354);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(124, 45);
            this.btnUPDATE.TabIndex = 9;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDELETE.Location = new System.Drawing.Point(450, 354);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(124, 45);
            this.btnDELETE.TabIndex = 10;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // displayCategory
            // 
            this.displayCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayCategory.Location = new System.Drawing.Point(430, 128);
            this.displayCategory.Name = "displayCategory";
            this.displayCategory.RowHeadersWidth = 51;
            this.displayCategory.RowTemplate.Height = 29;
            this.displayCategory.Size = new System.Drawing.Size(791, 200);
            this.displayCategory.TabIndex = 11;
            this.displayCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayCategory_CellContentClick);
            this.displayCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.displayCategory_RowHeaderMouseClick);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(430, 65);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(53, 20);
            this.lblsearch.TabIndex = 12;
            this.lblsearch.Text = "Search";
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(502, 65);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(719, 27);
            this.inputSearch.TabIndex = 13;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1291, 450);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.displayCategory);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.InputCategoryTitle);
            this.Controls.Add(this.InputCategoryDes);
            this.Controls.Add(this.inputCategoryID);
            this.Controls.Add(this.CategoryDescription);
            this.Controls.Add(this.CategoryTitle);
            this.Controls.Add(this.categoryID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "category";
            this.Load += new System.EventHandler(this.category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label categoryID;
        private Label CategoryTitle;
        private Label CategoryDescription;
        private TextBox inputCategoryID;
        private TextBox InputCategoryDes;
        private TextBox InputCategoryTitle;
        private Button btnADD;
        private Button btnUPDATE;
        private Button btnDELETE;
        private DataGridView displayCategory;
        private Label lblsearch;
        private TextBox inputSearch;
    }
}