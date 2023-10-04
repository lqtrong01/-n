using System;
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
    public partial class frmSanPham : Form
    {
        static string sql = "SELECT * FROM SANPHAM WHERE TRANGTHAI=1";
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = DataProvider.ExecuteSelectCommand(sql,null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO SANPHAM (MASP,MANCC,TENSP,SOLUONG,DONVITINH,DONGIA,MOTA,TRANGTHAI) VALUES (@MASP,@MANCC,@TENSP,@SOLUONG,@DONVITINH,@DONGIA,@MOTA,1)";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MANCC", txtMaNCC.Text);
            parameters[1] = new SqlParameter("@TENSP", txtTen.Text);
            parameters[2] = new SqlParameter("@SOLUONG", txtSoLuong.Text);
            parameters[3] = new SqlParameter("@DONVITINH", txtDonViTinh.Text);
            parameters[4] = new SqlParameter("@DONGIA", txtDonGia.Text);
            parameters[5] = new SqlParameter("@MOTA", txtMoTa.Text);
            parameters[6] = new SqlParameter("@MASP", txtMaSP.Text);

            dgvDSSP.DataSource = DataProvider.ExecuteInsertCommand(insert, parameters);
            dgvDSSP.DataSource = DataProvider.ExecuteSelectCommand(sql, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string update = "UPDATE SANPHAM SET MANCC=@MANCC,TENSP=@TENSP,SOLUONG=@SOLUONG,DONVITINH=@DONVITINH,DONGIA=@DONGIA,MOTA=@MOTA WHERE MASP=@MASP";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MANCC", txtMaNCC.Text);
            parameters[1] = new SqlParameter("@TENSP", txtTen.Text);
            parameters[2] = new SqlParameter("@SOLUONG", txtSoLuong.Text);
            parameters[3] = new SqlParameter("@DONVITINH", txtDonViTinh.Text);
            parameters[4] = new SqlParameter("@DONGIA", txtDonGia.Text);
            parameters[5] = new SqlParameter("@MOTA", txtMoTa.Text);
            parameters[6] = new SqlParameter("@MASP", txtMaSP.Text);

            dgvDSSP.DataSource = DataProvider.ExecuteUpdateCommand(update, parameters);
            dgvDSSP.DataSource = DataProvider.ExecuteSelectCommand(sql, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "UPDATE SANPHAM SET TRANGTHAI=0 WHERE MASP=@MASP";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@MANCC", txtMaNCC.Text);
            parameters[1] = new SqlParameter("@TENSP", txtTen.Text);
            parameters[2] = new SqlParameter("@SOLUONG", txtSoLuong.Text);
            parameters[3] = new SqlParameter("@DONVITINH", txtDonViTinh.Text);
            parameters[4] = new SqlParameter("@DONGIA", txtDonGia.Text);
            parameters[5] = new SqlParameter("@MOTA", txtMoTa.Text);
            parameters[6] = new SqlParameter("@MASP", txtMaSP.Text);

            dgvDSSP.DataSource = DataProvider.ExecuteDeleteCommand(delete, parameters);
            dgvDSSP.DataSource = DataProvider.ExecuteSelectCommand(sql, null);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtDonViTinh.Text = String.Empty;
            txtDonGia.Text = String.Empty;
            txtMaNCC.Text = String.Empty;
            txtSoLuong.Text = String.Empty;
            txtMoTa.Text = string.Empty;
        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvDSSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaNCC.Text = dgvDSSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTen.Text = dgvDSSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDSSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDonViTinh.Text = dgvDSSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDonGia.Text = dgvDSSP.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMoTa.Text = dgvDSSP.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
