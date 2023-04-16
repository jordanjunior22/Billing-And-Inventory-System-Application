using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.BLL;
using BillingSystem.DAL;

namespace BillingSystem.UI
{
    public partial class debtsMenu : Form
    {
        public debtsMenu()
        {
            InitializeComponent();
        }

        debtsBLL d = new debtsBLL();
        debtsDAL Ddal = new debtsDAL();

        private void debtsMenu_Load(object sender, EventArgs e)
        {

            DataTable debtsDt = Ddal.Select();
            debtsDVG.DataSource = debtsDt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
