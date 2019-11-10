using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Nhom_7
{
    class database
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLiLopTinHoc;Integrated Security=True";
        SqlConnection sqlConnection = null;


        //mở kết nối đến CSDL 
        private void ketnoiCSDL()
        {
            sqlConnection = new SqlConnection(con);
            if (sqlConnection.State!= ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        //đóng kết nối CSDL
        private void DongketnoiSQL()
        {
            if (sqlConnection.State==ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            ketnoiCSDL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,con);
            sqlDataAdapter.Fill(dtBang);
            DongketnoiSQL();
            return dtBang;

        }

        public void CapNhatDuLieu(string sql)
        {
            ketnoiCSDL();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sql;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            DongketnoiSQL();
        }
    }


}
