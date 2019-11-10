namespace BTL_Nhom_7
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCaHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoiGian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhongHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucDanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNgheNghiep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCoQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrinhDo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDSDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDSLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.grpIntro = new System.Windows.Forms.GroupBox();
            this.richInTro = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.grpIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tậpTinToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.mnuTK,
            this.mnuBCDSDiem,
            this.mnuGioiThieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMonHoc,
            this.mnuLopHoc,
            this.mnuGiaoVien,
            this.mnuCaHoc,
            this.mnuThoiGian,
            this.mnuPhongHoc,
            this.mnuChucDanh,
            this.mnuNgheNghiep,
            this.mnuHocVien,
            this.mnuChuyenMon,
            this.mnuCoQuan,
            this.mnuXepLoai,
            this.mnuTrinhDo});
            this.danhMụcToolStripMenuItem.Image = global::BTL_Nhom_7.Properties.Resources.DanhMuc;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Image = global::BTL_Nhom_7.Properties.Resources.monhoc;
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(181, 26);
            this.mnuMonHoc.Text = "Môn Học";
            this.mnuMonHoc.Click += new System.EventHandler(this.MnuMonHoc_Click);
            // 
            // mnuLopHoc
            // 
            this.mnuLopHoc.Image = global::BTL_Nhom_7.Properties.Resources._class;
            this.mnuLopHoc.Name = "mnuLopHoc";
            this.mnuLopHoc.Size = new System.Drawing.Size(181, 26);
            this.mnuLopHoc.Text = "Lớp Học";
            // 
            // mnuGiaoVien
            // 
            this.mnuGiaoVien.Image = global::BTL_Nhom_7.Properties.Resources.teacher;
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(181, 26);
            this.mnuGiaoVien.Text = "Giáo Viên ";
            // 
            // mnuCaHoc
            // 
            this.mnuCaHoc.Image = global::BTL_Nhom_7.Properties.Resources.cahoc;
            this.mnuCaHoc.Name = "mnuCaHoc";
            this.mnuCaHoc.Size = new System.Drawing.Size(181, 26);
            this.mnuCaHoc.Text = "Ca Học";
            // 
            // mnuThoiGian
            // 
            this.mnuThoiGian.Image = global::BTL_Nhom_7.Properties.Resources.time;
            this.mnuThoiGian.Name = "mnuThoiGian";
            this.mnuThoiGian.Size = new System.Drawing.Size(181, 26);
            this.mnuThoiGian.Text = "Thời Gian";
            // 
            // mnuPhongHoc
            // 
            this.mnuPhongHoc.Image = global::BTL_Nhom_7.Properties.Resources.phonghoc;
            this.mnuPhongHoc.Name = "mnuPhongHoc";
            this.mnuPhongHoc.Size = new System.Drawing.Size(181, 26);
            this.mnuPhongHoc.Text = "Phòng Học";
            // 
            // mnuChucDanh
            // 
            this.mnuChucDanh.Image = global::BTL_Nhom_7.Properties.Resources.chucDanh;
            this.mnuChucDanh.Name = "mnuChucDanh";
            this.mnuChucDanh.Size = new System.Drawing.Size(181, 26);
            this.mnuChucDanh.Text = "Chức Danh";
            // 
            // mnuNgheNghiep
            // 
            this.mnuNgheNghiep.Image = global::BTL_Nhom_7.Properties.Resources.job;
            this.mnuNgheNghiep.Name = "mnuNgheNghiep";
            this.mnuNgheNghiep.Size = new System.Drawing.Size(181, 26);
            this.mnuNgheNghiep.Text = "Nghề Nghiệp";
            // 
            // mnuHocVien
            // 
            this.mnuHocVien.Image = global::BTL_Nhom_7.Properties.Resources.student;
            this.mnuHocVien.Name = "mnuHocVien";
            this.mnuHocVien.Size = new System.Drawing.Size(181, 26);
            this.mnuHocVien.Text = "Học Viên";
            // 
            // mnuChuyenMon
            // 
            this.mnuChuyenMon.Image = global::BTL_Nhom_7.Properties.Resources.major;
            this.mnuChuyenMon.Name = "mnuChuyenMon";
            this.mnuChuyenMon.Size = new System.Drawing.Size(181, 26);
            this.mnuChuyenMon.Text = "Chuyên Môn";
            // 
            // mnuCoQuan
            // 
            this.mnuCoQuan.Image = global::BTL_Nhom_7.Properties.Resources.noilamviec;
            this.mnuCoQuan.Name = "mnuCoQuan";
            this.mnuCoQuan.Size = new System.Drawing.Size(181, 26);
            this.mnuCoQuan.Text = "Cơ Quan ";
            // 
            // mnuXepLoai
            // 
            this.mnuXepLoai.Image = global::BTL_Nhom_7.Properties.Resources.rank;
            this.mnuXepLoai.Name = "mnuXepLoai";
            this.mnuXepLoai.Size = new System.Drawing.Size(181, 26);
            this.mnuXepLoai.Text = "Xếp Loại";
            // 
            // mnuTrinhDo
            // 
            this.mnuTrinhDo.Image = global::BTL_Nhom_7.Properties.Resources.level;
            this.mnuTrinhDo.Name = "mnuTrinhDo";
            this.mnuTrinhDo.Size = new System.Drawing.Size(181, 26);
            this.mnuTrinhDo.Text = "Trình Độ";
            // 
            // mnuTK
            // 
            this.mnuTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTKLopHoc,
            this.mnuTKGiaoVien});
            this.mnuTK.Image = global::BTL_Nhom_7.Properties.Resources.Tìm_Kiếm;
            this.mnuTK.Name = "mnuTK";
            this.mnuTK.Size = new System.Drawing.Size(110, 24);
            this.mnuTK.Text = "Tìm Kiếm ";
            // 
            // mnuTKLopHoc
            // 
            this.mnuTKLopHoc.Image = global::BTL_Nhom_7.Properties.Resources.phonghoc1;
            this.mnuTKLopHoc.Name = "mnuTKLopHoc";
            this.mnuTKLopHoc.Size = new System.Drawing.Size(156, 26);
            this.mnuTKLopHoc.Text = "Lớp Học";
            // 
            // mnuTKGiaoVien
            // 
            this.mnuTKGiaoVien.Image = global::BTL_Nhom_7.Properties.Resources.teacher1;
            this.mnuTKGiaoVien.Name = "mnuTKGiaoVien";
            this.mnuTKGiaoVien.Size = new System.Drawing.Size(156, 26);
            this.mnuTKGiaoVien.Text = "Giáo Viên";
            // 
            // mnuBCDSDiem
            // 
            this.mnuBCDSDiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchĐiểmToolStripMenuItem,
            this.mnuBCDoanhThu,
            this.mnuBC3,
            this.mnuBCDSLop});
            this.mnuBCDSDiem.Image = global::BTL_Nhom_7.Properties.Resources.BaoCao;
            this.mnuBCDSDiem.Name = "mnuBCDSDiem";
            this.mnuBCDSDiem.Size = new System.Drawing.Size(103, 24);
            this.mnuBCDSDiem.Text = "Báo Cáo ";
            // 
            // danhSáchĐiểmToolStripMenuItem
            // 
            this.danhSáchĐiểmToolStripMenuItem.Image = global::BTL_Nhom_7.Properties.Resources.monhoc1;
            this.danhSáchĐiểmToolStripMenuItem.Name = "danhSáchĐiểmToolStripMenuItem";
            this.danhSáchĐiểmToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.danhSáchĐiểmToolStripMenuItem.Text = "Danh Sách Điểm ";
            // 
            // mnuBCDoanhThu
            // 
            this.mnuBCDoanhThu.Image = global::BTL_Nhom_7.Properties.Resources.money;
            this.mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            this.mnuBCDoanhThu.Size = new System.Drawing.Size(231, 26);
            this.mnuBCDoanhThu.Text = "Doanh Thu";
            // 
            // mnuBC3
            // 
            this.mnuBC3.Image = global::BTL_Nhom_7.Properties.Resources.rank1;
            this.mnuBC3.Name = "mnuBC3";
            this.mnuBC3.Size = new System.Drawing.Size(231, 26);
            this.mnuBC3.Text = "3 SV Cao Điểm Nhất ";
            // 
            // mnuBCDSLop
            // 
            this.mnuBCDSLop.Image = global::BTL_Nhom_7.Properties.Resources.job1;
            this.mnuBCDSLop.Name = "mnuBCDSLop";
            this.mnuBCDSLop.Size = new System.Drawing.Size(231, 26);
            this.mnuBCDSLop.Text = "Danh Sách Các Lớp";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Image = global::BTL_Nhom_7.Properties.Resources.intro;
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(188, 24);
            this.mnuGioiThieu.Text = "Giới Thiệu Phần Mềm ";
            this.mnuGioiThieu.Click += new System.EventHandler(this.MnuGioiThieu_Click);
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngToolStripMenuItem});
            this.tậpTinToolStripMenuItem.Image = global::BTL_Nhom_7.Properties.Resources.file;
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.tậpTinToolStripMenuItem.Text = "Tập Tin";
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Image = global::BTL_Nhom_7.Properties.Resources.close;
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đóngToolStripMenuItem.Text = "&Đóng";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.ĐóngToolStripMenuItem_Click);
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Image = global::BTL_Nhom_7.Properties.Resources.homepage;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 821);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chương Trình Quản Lí Lớp Tin Học";
            // 
            // grpIntro
            // 
            this.grpIntro.Controls.Add(this.richInTro);
            this.grpIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIntro.Location = new System.Drawing.Point(0, 28);
            this.grpIntro.Name = "grpIntro";
            this.grpIntro.Size = new System.Drawing.Size(1370, 838);
            this.grpIntro.TabIndex = 2;
            this.grpIntro.TabStop = false;
            this.grpIntro.Text = "Giới Thiệu Phần Mềm";
            // 
            // richInTro
            // 
            this.richInTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richInTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richInTro.Location = new System.Drawing.Point(3, 18);
            this.richInTro.Name = "richInTro";
            this.richInTro.Size = new System.Drawing.Size(1364, 817);
            this.richInTro.TabIndex = 0;
            this.richInTro.Text = "";
            this.richInTro.DoubleClick += new System.EventHandler(this.RichInTro_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_Nhom_7.Properties.Resources.gestión_de_proyectos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 866);
            this.Controls.Add(this.grpIntro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chương Trính Quản Lí Lớp Tin Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpIntro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTK;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDSDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mnuCaHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuThoiGian;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuChucDanh;
        private System.Windows.Forms.ToolStripMenuItem mnuNgheNghiep;
        private System.Windows.Forms.ToolStripMenuItem mnuHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenMon;
        private System.Windows.Forms.ToolStripMenuItem mnuCoQuan;
        private System.Windows.Forms.ToolStripMenuItem mnuXepLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuTrinhDo;
        private System.Windows.Forms.ToolStripMenuItem mnuTKLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuTKGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuBC3;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDSLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpIntro;
        private System.Windows.Forms.RichTextBox richInTro;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
    }
}

