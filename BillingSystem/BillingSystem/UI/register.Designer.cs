namespace BillingSystem.UI
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.label1 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.textLastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Location = new System.Drawing.Point(143, 592);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(178, 61);
            this.btnADD.TabIndex = 71;
            this.btnADD.Text = "REGISTER";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inputUserID
            // 
            this.inputUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputUserID.Location = new System.Drawing.Point(143, 91);
            this.inputUserID.Name = "inputUserID";
            this.inputUserID.ReadOnly = true;
            this.inputUserID.Size = new System.Drawing.Size(217, 27);
            this.inputUserID.TabIndex = 70;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(35, 93);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(57, 20);
            this.lblUserID.TabIndex = 69;
            this.lblUserID.Text = "User ID";
            // 
            // inputGenderConfirm
            // 
            this.inputGenderConfirm.FormattingEnabled = true;
            this.inputGenderConfirm.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.inputGenderConfirm.Location = new System.Drawing.Point(143, 494);
            this.inputGenderConfirm.Name = "inputGenderConfirm";
            this.inputGenderConfirm.Size = new System.Drawing.Size(151, 28);
            this.inputGenderConfirm.TabIndex = 68;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(35, 494);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 67;
            this.lblGender.Text = "Gender";
            // 
            // inputAddressConfirm
            // 
            this.inputAddressConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAddressConfirm.Location = new System.Drawing.Point(143, 419);
            this.inputAddressConfirm.Multiline = true;
            this.inputAddressConfirm.Name = "inputAddressConfirm";
            this.inputAddressConfirm.Size = new System.Drawing.Size(217, 68);
            this.inputAddressConfirm.TabIndex = 66;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(35, 421);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 65;
            this.lblAddress.Text = "Address";
            // 
            // inputContactConfirm
            // 
            this.inputContactConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContactConfirm.Location = new System.Drawing.Point(143, 355);
            this.inputContactConfirm.Name = "inputContactConfirm";
            this.inputContactConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputContactConfirm.TabIndex = 64;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(35, 357);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 20);
            this.lblContact.TabIndex = 63;
            this.lblContact.Text = "Contact";
            // 
            // inputLastNameConfirm
            // 
            this.inputLastNameConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputLastNameConfirm.Location = new System.Drawing.Point(143, 180);
            this.inputLastNameConfirm.Name = "inputLastNameConfirm";
            this.inputLastNameConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputLastNameConfirm.TabIndex = 62;
            // 
            // inputEmailConfirm
            // 
            this.inputEmailConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputEmailConfirm.Location = new System.Drawing.Point(143, 224);
            this.inputEmailConfirm.Name = "inputEmailConfirm";
            this.inputEmailConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputEmailConfirm.TabIndex = 60;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "Email";
            // 
            // InputUsernameConfirm
            // 
            this.InputUsernameConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsernameConfirm.Location = new System.Drawing.Point(143, 268);
            this.InputUsernameConfirm.Name = "InputUsernameConfirm";
            this.InputUsernameConfirm.Size = new System.Drawing.Size(217, 27);
            this.InputUsernameConfirm.TabIndex = 58;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(35, 268);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(75, 20);
            this.txtUsername.TabIndex = 57;
            this.txtUsername.Text = "Username";
            // 
            // inputPasswordConfirm
            // 
            this.inputPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPasswordConfirm.Location = new System.Drawing.Point(143, 314);
            this.inputPasswordConfirm.Name = "inputPasswordConfirm";
            this.inputPasswordConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputPasswordConfirm.TabIndex = 56;
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Location = new System.Drawing.Point(35, 316);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(70, 20);
            this.textPassword.TabIndex = 55;
            this.textPassword.Text = "Password";
            // 
            // inputFirstNameConfirm
            // 
            this.inputFirstNameConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFirstNameConfirm.Location = new System.Drawing.Point(143, 140);
            this.inputFirstNameConfirm.Name = "inputFirstNameConfirm";
            this.inputFirstNameConfirm.Size = new System.Drawing.Size(217, 27);
            this.inputFirstNameConfirm.TabIndex = 54;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(35, 142);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(80, 20);
            this.FirstName.TabIndex = 53;
            this.FirstName.Text = "Firsr Name";
            // 
            // textLastName
            // 
            this.textLastName.AutoSize = true;
            this.textLastName.Location = new System.Drawing.Point(35, 182);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(79, 20);
            this.textLastName.TabIndex = 61;
            this.textLastName.Text = "Last Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 48);
            this.panel1.TabIndex = 52;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 716);
            this.Controls.Add(this.btnADD);
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
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnADD;
        private PictureBox pictureBox1;
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
        private Label textLastName;
        private Panel panel1;
    }
}