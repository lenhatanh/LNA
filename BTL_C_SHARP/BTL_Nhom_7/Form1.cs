using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTL_Nhom_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            grpIntro.Visible = false;
        }

        private void ĐóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void MnuMonHoc_Click(object sender, EventArgs e)
        {
            formDMMonHoc DMMonHoc = new formDMMonHoc();
            DMMonHoc.Show();
        }

        private void MnuGioiThieu_Click(object sender, EventArgs e)
        {
            string path = @"E:\CODE\C#\BTL_Nhom_7\BTL_Nhom_7\intro.txt";
            StreamReader textFile = new StreamReader(path);
            string fileContents = textFile.ReadToEnd();
            richInTro.Text = fileContents;
            textFile.Close();

            grpIntro.Visible = true;
        }

     

        private void RichInTro_DoubleClick(object sender, EventArgs e)
        {
            grpIntro.Visible = false;
        }
    }
}
