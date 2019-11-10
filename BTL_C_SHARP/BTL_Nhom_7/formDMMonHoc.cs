using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom_7
{
    public partial class formDMMonHoc : Form
    {
        database dt = new database();

        public formDMMonHoc()
        {
            InitializeComponent();
        }

        private void FormDMMonHoc_Load(object sender, EventArgs e)
        {
            dgvDMMonhoc.DataSource = dt.DocBang("select * from tblMonHoc");
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int k = 0;
            if(txtHocPhi.Text=="" && txtMaMon.Text=="" && txtTenMon.Text == "")
            {
                MessageBox.Show("Bạn Nhập Thiếu Thông Tin!!!");
                k = 1;
                return;
            }
            if(!int.TryParse(txtHocPhi.Text,out k))
            {
                MessageBox.Show("Mời Bạn Nhập Lại Học Phí");
                k = 1;
                return;
            }
            if(k==0)
            {
                string sql = "insert into tblMonHoc values ('" + txtMaMon.Text + "',N'" + txtTenMon.Text + "'," + int.Parse(txtHocPhi.Text) + ")";
                dt.CapNhatDuLieu(sql);
                dgvDMMonhoc.DataSource = dt.DocBang("select * from tblMonHoc");
            }
            
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblMonHoc set TenMon=N'" + txtTenMon.Text + "', HocPhi=" + txtHocPhi.Text + " where MaMon='" + txtMaMon.Text + "' ";
            dt.CapNhatDuLieu(sql);
            dgvDMMonhoc.DataSource = dt.DocBang("select * from tblMonHoc");
        }

        private void DgvDMMonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaMon.Text = dgvDMMonhoc.Columns[0, e.RowIndex].values.ToString();

        }
    }
}
