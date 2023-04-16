using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem.BLL;

namespace BillingSystem.DAL
{
    internal class transactiondetailsDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert new 

        public bool Insert(transactiondetailBLL td)
        {
            bool isSucces = false;
            
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO tbl_transaction_detail (product_id, price, qty, total, dea_cust_id, added_date, added_by) VALUES (@product_id, @price, @qty, @total, @dea_cust_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@price", td.price);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);


                conn.Open();

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    
                    isSucces = true;

                }
                else
                {
                    isSucces = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucces;

        }

        #endregion
    }
}
