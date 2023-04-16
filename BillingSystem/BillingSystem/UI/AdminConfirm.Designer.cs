namespace BillingSystem.UI
{
    partial class AdminConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConfirm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InventoryLbl = new System.Windows.Forms.Label();
            this.ConfirmDisplay = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAPPROVE = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.InventoryLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 48);
            this.panel1.TabIndex = 7;
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
            // InventoryLbl
            // 
            this.InventoryLbl.AutoSize = true;
            this.InventoryLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InventoryLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventoryLbl.Location = new System.Drawing.Point(590, 9);
            this.InventoryLbl.Name = "InventoryLbl";
            this.InventoryLbl.Size = new System.Drawing.Size(241, 31);
            this.InventoryLbl.TabIndex = 0;
            this.InventoryLbl.Text = "CONFIRM NEW USER";
            // 
            // ConfirmDisplay
            // 
            this.ConfirmDisplay.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ConfirmDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConfirmDisplay.Location = new System.Drawing.Point(277, 86);
            this.ConfirmDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmDisplay.Name = "ConfirmDisplay";
            this.ConfirmDisplay.RowHeadersWidth = 51;
            this.ConfirmDisplay.RowTemplate.Height = 25;
            this.ConfirmDisplay.Size = new System.Drawing.Size(982, 504);
            this.ConfirmDisplay.TabIndex = 8;
            this.ConfirmDisplay.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConfirmDisplay_RowHeaderMouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(64, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 61);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAPPROVE
            // 
            this.btnAPPROVE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAPPROVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPPROVE.Location = new System.Drawing.Point(64, 159);
            this.btnAPPROVE.Name = "btnAPPROVE";
            this.btnAPPROVE.Size = new System.Drawing.Size(178, 61);
            this.btnAPPROVE.TabIndex = 27;
            this.btnAPPROVE.Text = "APPROVE";
            this.btnAPPROVE.UseVisualStyleBackColor = false;
            this.btnAPPROVE.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(64, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 61);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "DECLINE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AdminConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 683);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAPPROVE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminConfirm";
            this.Load += new System.EventHandler(this.AdminConfirm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label InventoryLbl;
        private DataGridView ConfirmDisplay;
        private Button btnDelete;
        private Button btnAPPROVE;
        private Button btnUpdate;
    }
}