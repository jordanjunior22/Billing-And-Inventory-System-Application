using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem.BLL;

namespace BillingSystem.DAL
{
    internal class LoginDAL
    {
        //STRING TO CONNECT DATABASE
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(LoginBLL l) 
        {
            bool isSuccess = false;

            //connecting to database

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "SELECT * FROM tbl_users WHERE username =@username AND password=@password AND user_type=@user_type";
                //creat connection

                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Login Success
                    isSuccess = true;
                }
                else 
                {
                    //Login Failed
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
            }

            return isSuccess;
        }
    }
}
