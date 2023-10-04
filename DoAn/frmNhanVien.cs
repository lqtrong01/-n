using System;
using System.Globalization;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn
{
    public partial class frmNhanVien : Form
    {
        static string sql = "SELECT * FROM NHANVIEN WHERE TRANGTHAI=1";
        public frmNhanVien()
        {
            InitializeComponent();
           
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = DataProvider.ExecuteSelectCommand(sql,null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO NHANVIEN (HOTEN,NGAYSINH,GIOITINH,DIACHI,SDT,CHUCVU,TRANGTHAI) VALUES (@HOTEN,@NGAYSINH,@GIOITINH,@DIACHI,@SODIENTHOAI,@CHUCVU,1)";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@HOTEN", txtHoTen.Text);
            parameters[1] = new SqlParameter("@NGAYSINH", dtpNgaySinh.Value.ToString());
            parameters[2] = new SqlParameter("@GIOITINH", txtGioiTinh.Text);
            parameters[3] = new SqlParameter("@DIACHI", txtDiaChi.Text);
            parameters[4] = new SqlParameter("@SODIENTHOAI", txtSDT.Text);
            parameters[5] = new SqlParameter("@CHUCVU", txtChucVu.Text);

            dgvDSNV.DataSource = DataProvider.ExecuteInsertCommand(insert,parameters);
            dgvDSNV.DataSource = DataProvider.ExecuteSelectCommand(sql, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string update = "UPDATE NHANVIEN SET HOTEN=@HOTEN,NGAYSINH=@NGAYSINH,GIOITINH=@GIOITINH,DIACHI=@DIACHI,SDT=@SODIENTHOAI,CHUCVU=@CHUCVU WHERE MANV=@MANV";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@HOTEN", txtHoTen.Text);
            parameters[1] = new SqlParameter("@NGAYSINH", dtpNgaySinh.Value.ToString());
            parameters[2] = new SqlParameter("@GIOITINH", txtGioiTinh.Text);
            parameters[3] = new SqlParameter("@DIACHI", txtDiaChi.Text);
            parameters[4] = new SqlParameter("@SODIENTHOAI", txtSDT.Text);
            parameters[5] = new SqlParameter("@CHUCVU", txtChucVu.Text);
            parameters[6] = new SqlParameter("@MANV", txtMaNV.Text);

            dgvDSNV.DataSource = DataProvider.ExecuteUpdateCommand(update, parameters);
            dgvDSNV.DataSource = DataProvider.ExecuteSelectCommand(sql, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "UPDATE NHANVIEN SET TRANGTHAI=0 WHERE MANV=@MANV";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@HOTEN", txtHoTen.Text);
            parameters[1] = new SqlParameter("@NGAYSINH", dtpNgaySinh.Value.ToString());
            parameters[2] = new SqlParameter("@GIOITINH", txtGioiTinh.Text);
            parameters[3] = new SqlParameter("@DIACHI", txtDiaChi.Text);
            parameters[4] = new SqlParameter("@SODIENTHOAI", txtSDT.Text);
            parameters[5] = new SqlParameter("@CHUCVU", txtChucVu.Text);
            parameters[6] = new SqlParameter("@MANV", txtMaNV.Text);

            dgvDSNV.DataSource = DataProvider.ExecuteDeleteCommand(delete, parameters);
            dgvDSNV.DataSource = DataProvider.ExecuteSelectCommand(sql, null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = String.Empty;
            txtHoTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtGioiTinh.Text = String.Empty;
            txtChucVu.Text = String.Empty;
            txtSDT.Text = String.Empty;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateValue;
            string dateString = dgvDSNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (DateTime.TryParse(dateString, out dateValue))
            {
                dtpNgaySinh.Value = dateValue;
                dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("Giá trị ngày tháng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtMaNV.Text = dgvDSNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDSNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvDSNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDSNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dgvDSNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtChucVu.Text = dgvDSNV.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

    }
}
