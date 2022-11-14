using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using BLL;


namespace DAL
{
    public class AddStudents
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TermPaperTask\DAL\studentsdb.mdf;Integrated Security=True");

        public void add(Variables obj)
        {
            SqlCommand cmd = new SqlCommand("addstudentdb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name", obj.Name);
            cmd.Parameters.AddWithValue("Phone",obj.Phone);
            cmd.Parameters.AddWithValue("Country",obj.Country);
            cmd.Parameters.AddWithValue("Email", obj.Email);
           
           

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
