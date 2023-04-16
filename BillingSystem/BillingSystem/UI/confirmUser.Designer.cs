namespace BillingSystem.UI
{
    partial class confirmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmUser));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.displayUsers = new System.Windows.Forms.DataGridView();
            this.inputUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.inputGenderConfirm = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.inputAddressConfirm = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.inputContactConfirm = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.inputLastNameConfirm = new System.Windows.Forms.TextBox();
            this.inputEmailConfirm = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.InputUsernameConfirm = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.inputPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.Label();
            this.inputFirstNameConfirm = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(869, 631);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 61);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(644, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 61);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Location = new System.Drawing.Point(412, 631);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(178, 61);
            this.btnADD.TabIndex = 51;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // displayUsers
            // 
            this.displayUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayUsers.Location = new System.Drawing.Point(412, 149);
            this.displayUsers.Name = "displayUsers";
            this.displayUsers.RowHeadersWidth = 51;
            this.displayUsers.RowTemplate.Height = 29;
            this.displayUsers.Size = new System.Drawing.Size(837, 433);
            this.displayUsers.TabIndex = 48;
            this.displayUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayUsers_CellContentClick);
            this.displayUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.displayUsers_RowHeaderMouseClick);
            // 
            // inputUserID
            // 
            this.inputUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputUserID.Location = new System.Drawing.Point(142, 100);
            this.inputUserID.Name = "inputUserID";
            this.inputUserID.ReadOnly = true;
            this.inputUserID.Size = new System.Drawing.Size(217, 27);
            this.inputUserID.TabIndex = 47;
            this.inputUserID.TextChanged += new System.EventHandler(this.inputUserID_TextChanged);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(34, 102);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(57, 20);
            this.lblUserID.TabIndex = 46;
            this.lblUserID.Text = "User ID";
            this.lblUserID.Click += new System.EventHandler(this.lblUserID_Click);
            // 
            // inputGenderConfirm
            // 
            this.inputGenderConfirm.FormattingEnabled = true;
            this.inputGenderConfirm.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.inputGenderConfirm.Location = new System.Drawing.Point(142, 503);
            this.inputGenderConfirm.Name = "inputGenderConfirm";
            this.inputGenderConfirm.Size = new System.Drawing.Size(151, 28);
            this.inputGenderConfirm.TabIndex = 43;
            this.inputGenderConfirm.SelectedIndexChanged += new System.EventHandler(this.inputGenderConfirm_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(34, 503);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 42;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // inputAddressConfirm
            // 
            this.inputAddressConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAddressConfirm.Location = new System.Drawing.Point(142, 428);
            this.inputAddressConfirm.Multiline = true;
            this.inputAddressConfirm.Name = "inputAddressConfirm";
            this.inputAddressConfirm.Size = new System.Drawing.Size(217, 68);
            this.inputAddressConfirm.TabIndex = 41;
            this.inputAddressConfirm.TextChanged += new System.EventHandler(this.inputAddressConfirm_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 430);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 40;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // inputContactConfirm
            // 
            this.inputContactConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContactConfirm.Location = new System.Drawing.Point(142, 364);
            this.inputContactConfirm.Name = "inputContactConfirm";
            this.inputContactConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputContactConfirm.TabIndex = 39;
            this.inputContactConfirm.TextChanged += new System.EventHandler(this.inputContactConfirm_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(34, 366);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 20);
            this.lblContact.TabIndex = 38;
            this.lblContact.Text = "Contact";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // inputLastNameConfirm
            // 
            this.inputLastNameConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLastNameConfirm.Location = new System.Drawing.Point(142, 189);
            this.inputLastNameConfirm.Name = "inputLastNameConfirm";
            this.inputLastNameConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputLastNameConfirm.TabIndex = 37;
            this.inputLastNameConfirm.TextChanged += new System.EventHandler(this.inputLastNameConfirm_TextChanged);
            // 
            // inputEmailConfirm
            // 
            this.inputEmailConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputEmailConfirm.Location = new System.Drawing.Point(142, 233);
            this.inputEmailConfirm.Name = "inputEmailConfirm";
            this.inputEmailConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputEmailConfirm.TabIndex = 35;
            this.inputEmailConfirm.TextChanged += new System.EventHandler(this.inputEmailConfirm_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // InputUsernameConfirm
            // 
            this.InputUsernameConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsernameConfirm.Location = new System.Drawing.Point(142, 277);
            this.InputUsernameConfirm.Name = "InputUsernameConfirm";
            this.InputUsernameConfirm.Size = new System.Drawing.Size(217, 27);
            this.InputUsernameConfirm.TabIndex = 33;
            this.InputUsernameConfirm.TextChanged += new System.EventHandler(this.InputUsernameConfirm_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(34, 277);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(75, 20);
            this.txtUsername.TabIndex = 32;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // inputPasswordConfirm
            // 
            this.inputPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPasswordConfirm.Location = new System.Drawing.Point(142, 323);
            this.inputPasswordConfirm.Name = "inputPasswordConfirm";
            this.inputPasswordConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputPasswordConfirm.TabIndex = 31;
            this.inputPasswordConfirm.TextChanged += new System.EventHandler(this.inputPasswordConfirm_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Location = new System.Drawing.Point(34, 325);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(70, 20);
            this.textPassword.TabIndex = 30;
            this.textPassword.Text = "Password";
            this.textPassword.Click += new System.EventHandler(this.textPassword_Click);
            // 
            // inputFirstNameConfirm
            // 
            this.inputFirstNameConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFirstNameConfirm.Location = new System.Drawing.Point(142, 149);
            this.inputFirstNameConfirm.Name = "inputFirstNameConfirm";
            this.inputFirstNameConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputFirstNameConfirm.TabIndex = 29;
            this.inputFirstNameConfirm.TextChanged += new System.EventHandler(this.inputFirstNameConfirm_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(34, 151);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(80, 20);
            this.FirstName.TabIndex = 28;
            this.FirstName.Text = "Firsr Name";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
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
            this.label1.Location = new System.Drawing.Point(622, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textLastName
            // 
            this.textLastName.AutoSize = true;
            this.textLastName.Location = new System.Drawing.Point(34, 191);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(79, 20);
            this.textLastName.TabIndex = 36;
            this.textLastName.Text = "Last Name";
            this.textLastName.Click += new System.EventHandler(this.textLastName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 48);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(412, 104);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 20);
            this.lblSearch.TabIndex = 49;
            this.lblSearch.Text = "Search";
            // 
            // inputSearch
            // 
            this.inputSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSearch.Location = new System.Drawing.Point(522, 102);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(727, 27);
            this.inputSearch.TabIndex = 50;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // confirmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 722);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.displayUsers);
            this.Controls.Add(this.inputUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.inputGenderConfirm);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.inputAddressConfirm);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.inputContactConfirm);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.inputLastNameConfirm);
            this.Controls.Add(this.inputEmailConfirm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.InputUsernameConfirm);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.inputPasswordConfirm);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.inputFirstNameConfirm);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "confirmUser";
            this.Load += new System.EventHandler(this.confirmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnADD;
        private DataGridView displayUsers;
        private TextBox inputUserID;
        private Label lblUserID;
        private ComboBox inputGenderConfirm;
        private Label lblGender;
        private TextBox inputAddressConfirm;
        private Label lblAddress;
        private TextBox inputContactConfirm;
        private Label lblContact;
        private TextBox inputLastNameConfirm;
        private TextBox inputEmailConfirm;
        private Label lblEmail;
        private TextBox InputUsernameConfirm;
        private Label txtUsername;
        private TextBox inputPasswordConfirm;
        private Label textPassword;
        private TextBox inputFirstNameConfirm;
        private Label FirstName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label textLastName;
        private Panel panel1;
        private Label lblSearch;
        private TextBox inputSearch;
    }
}