using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom_7
{
    public partial class login : Form
    {
        database ds = new database();
        public login()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLiLopTinHoc;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Count(*) from tblLogin where Username= N'"+txtUsername.Text+"' and Password= N'"+txtPassword.Text+"'",con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Bạn Đã Nhập Sai Mật Khẩu !!!!");
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "12345";
            txtUsername.Text = "admin";
        }
    }
}
