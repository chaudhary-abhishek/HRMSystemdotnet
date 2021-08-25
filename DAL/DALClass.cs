using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;



namespace DAL
{
    public class DALClass
    {
        BAL.Account_BAL b = new Account_BAL();
        public Boolean Login(int id,string password)
        {
            string cnstring = "Data Source=WIN-H2BOI1OIV30;Initial Catalog=HRMSystem;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("SELECT [dbo].[Verify] (@id,@password)", cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);

            cn.Open();
            bool status=false;
            SqlDataReader  dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                if (Convert.ToInt32(dr[0]) == 1)
                {
                    status = true;
                }
            }
           
            return status;

        }
       
    }
}
