namespace BillingSystem.UI
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.Label();
            this.inputContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.inputUserType = new System.Windows.Forms.ComboBox();
            this.inputUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.displayUsers = new System.Windows.Forms.DataGridView();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayUsers)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1295, 48);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERS";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(34, 121);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(80, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "Firsr Name";
            // 
            // inputFirstName
            // 
            this.inputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFirstName.Location = new System.Drawing.Point(142, 119);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(217, 27);
            this.inputFirstName.TabIndex = 2;
            // 
            // inputPassword
            // 
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPassword.Location = new System.Drawing.Point(142, 293);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(217, 27);
            this.inputPassword.TabIndex = 4;
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Location = new System.Drawing.Point(34, 295);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(70, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.Text = "Password";
            // 
            // InputUsername
            // 
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.Location = new System.Drawing.Point(142, 247);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(217, 27);
            this.InputUsername.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(34, 247);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(75, 20);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Username";
            // 
            // inputEmail
            // 
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputEmail.Location = new System.Drawing.Point(142, 203);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(217, 27);
            this.inputEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 203);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // inputLastName
            // 
            this.inputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLastName.Location = new System.Drawing.Point(142, 159);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(217, 27);
            this.inputLastName.TabIndex = 10;
            // 
            // textLastName
            // 
            this.textLastName.AutoSize = true;
            this.textLastName.Location = new System.Drawing.Point(34, 161);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(79, 20);
            this.textLastName.TabIndex = 9;
            this.textLastName.Text = "Last Name";
            // 
            // inputContact
            // 
            this.inputContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContact.Location = new System.Drawing.Point(142, 334);
            this.inputContact.Name = "inputContact";
            this.inputContact.Size = new System.Drawing.Size(217, 27);
            this.inputContact.TabIndex = 12;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(34, 336);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 20);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Contact";
            // 
            // inputAddress
            // 
            this.inputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAddress.Location = new System.Drawing.Point(142, 398);
            this.inputAddress.Multiline = true;
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(217, 68);
            this.inputAddress.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 400);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(34, 473);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender";
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.inputGender.Location = new System.Drawing.Point(142, 473);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(151, 28);
            this.inputGender.TabIndex = 16;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(34, 524);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(73, 20);
            this.lblUserType.TabIndex = 17;
            this.lblUserType.Text = "User Type";
            // 
            // inputUserType
            // 
            this.inputUserType.FormattingEnabled = true;
            this.inputUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.inputUserType.Location = new System.Drawing.Point(142, 524);
            this.inputUserType.Name = "inputUserType";
            this.inputUserType.Size = new System.Drawing.Size(151, 28);
            this.inputUserType.TabIndex = 18;
            // 
            // inputUserID
            // 
            this.inputUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputUserID.Location = new System.Drawing.Point(142, 70);
            this.inputUserID.Name = "inputUserID";
            this.inputUserID.ReadOnly = true;
            this.inputUserID.Size = new System.Drawing.Size(217, 27);
            this.inputUserID.TabIndex = 20;
            this.inputUserID.TextChanged += new System.EventHandler(this.inputUserID_TextChanged);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(34, 72);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(57, 20);
            this.lblUserID.TabIndex = 19;
            this.lblUserID.Text = "User ID";
            // 
            // displayUsers
            // 
            this.displayUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayUsers.Location = new System.Drawing.Point(412, 119);
            this.displayUsers.Name = "displayUsers";
            this.displayUsers.RowHeadersWidth = 51;
            this.displayUsers.RowTemplate.Height = 29;
            this.displayUsers.Size = new System.Drawing.Size(837, 433);
            this.displayUsers.TabIndex = 21;
            this.displayUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.displayUsers_RowHeaderMouseClick);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Location = new System.Drawing.Point(412, 601);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(178, 61);
            this.btnADD.TabIndex = 24;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(644, 601);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 61);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(869, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 61);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(412, 74);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 20);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search";
            // 
            // inputSearch
            // 
            this.inputSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSearch.Location = new System.Drawing.Point(522, 72);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(727, 27);
            this.inputSearch.TabIndex = 23;
            this.inputSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 741);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.displayUsers);
            this.Controls.Add(this.inputUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.inputUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.inputContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userlisttext";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label FirstName;
        private TextBox inputFirstName;
        private TextBox inputPassword;
        private Label textPassword;
        private TextBox InputUsername;
        private Label txtUsername;
        private TextBox inputEmail;
        private Label lblEmail;
        private TextBox inputLastName;
        private Label textLastName;
        private TextBox inputContact;
        private Label lblContact;
        private TextBox inputAddress;
        private Label lblAddress;
        private Label lblGender;
        private ComboBox inputGender;
        private Label lblUserType;
        private ComboBox inputUserType;
        private TextBox inputUserID;
        private Label lblUserID;
        private DataGridView displayUsers;
        private Button btnADD;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblSearch;
        private TextBox inputSearch;
    }
}