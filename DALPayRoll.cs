using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BAL;


namespace DAL
{
   public class DALPayRoll
    {

        //SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
           
        public void Add_PayRoll(PayRoll pay)
        {
            // SqlConnection con1 = Connect();
            SqlConnection con1 = new SqlConnection("Data Source=WIN-H2BOI1OIV30;Initial Catalog=HRMSystem;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("PayRoll_Add", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", pay.ID);
            cmd.Parameters.AddWithValue("@BasicPay", pay.BasicPay);
            cmd.Parameters.AddWithValue("@Allowances", pay.Allowance);
            cmd.Parameters.AddWithValue("@Deductions", pay.Deductions);
            cmd.Parameters.AddWithValue("@GrossPay", pay.GrossPay);
            cmd.Parameters.AddWithValue("@NetPay", pay.NetPay);
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();
        }

        private static SqlConnection Connect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        }

        public void Update_PayRoll(PayRoll pay)
        {
            SqlConnection con1 = Connect();
            SqlCommand cmd = new SqlCommand("PayRoll_Updating", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", pay.ID);
            cmd.Parameters.AddWithValue("@BasicPay", pay.BasicPay);
            cmd.Parameters.AddWithValue("@Allowances", pay.Allowance);
            cmd.Parameters.AddWithValue("@Deduction", pay.Deductions);
            cmd.Parameters.AddWithValue("@GrossPay", pay.GrossPay);
            cmd.Parameters.AddWithValue("@NetPay", pay.NetPay);
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();

        }

        public DataSet Show_PayRoll(int ID)
        {
            SqlConnection con1 = Connect();
            SqlCommand cmd = new SqlCommand("PayRoll_Lists", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        

        }

        public void Delete_PayRoll(int id)
        {
            SqlConnection con1 = Connect();
            SqlCommand cmd = new SqlCommand("PayRoll_Deleting", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();


        }


    }
}
