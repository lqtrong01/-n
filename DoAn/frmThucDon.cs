using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmThucDon : Form
    {
        DelegateMethod _delegateMethod;
        public frmThucDon(DelegateMethod delegateMethod)
        {
            InitializeComponent();
            _delegateMethod = delegateMethod;
        }
        private void ThucDon()
        {
            // Chuỗi truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
            string sql = "SELECT * FROM ThucDon";

            // Thực hiện truy vấn SELECT để lấy dữ liệu vào DataTable
            DataTable dtThucDon = DataProvider.ExecuteSelectCommand(sql, null);

            // Xóa tất cả các mục trong ListView trước khi thêm dữ liệu mới
            lsvThucDon.Items.Clear();

            // Duyệt qua từng dòng dữ liệu trong DataTable và thêm vào ListView
            foreach (DataRow row in dtThucDon.Rows)
            {
                // Tạo một ListViewItem mới
                ListViewItem item = new ListViewItem(row["MASP"].ToString()); // Lấy giá trị của cột "MaMon"
                item.SubItems.Add(row["MANCC"].ToString()); // Lấy giá trị của cột "TenMon"
                item.SubItems.Add(row["TENSP"].ToString()); // Lấy giá trị của cột "DonGia"
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["DONVITINH"].ToString());
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["MOTA"].ToString());
                item.SubItems.Add(row["TRANGTHAI"].ToString());

                // Thêm ListViewItem vào ListView
                lsvThucDon.Items.Add(item);
            }
        }
        private void FillData()
        {

        }
    }
}
