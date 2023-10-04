using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace DoAn
{
    public partial class frmPhongBan : Form
    {
        DelegateMethod _delegateMethod;
        public frmPhongBan(DelegateMethod delegateMethod)
        {
            InitializeComponent();
            _delegateMethod = delegateMethod;

            LoadImageList(0);
        }

        private void LoadImageList(int trangthai)
        {
            lsvPhongBan.View = View.LargeIcon;
            // Xóa các items cũ trong ListView
            lsvPhongBan.Items.Clear();
            int soBan = 8;
            int TrangThai;
            // Thêm ảnh vào ImageList

            imageList.Images.Add(Properties.Resources.icons8_table_50);
            // Thêm các items mới với hình ảnh từ ImageList
            for (int i = 0; i < soBan; i++)
            {
                TrangThai = trangthai;
                ListViewItem item = new ListViewItem();
                //Đổ ảnh vào listview theo trạng thái đã để trước đó



                if (TrangThai == 0)
                {
                    imageList.Images.Add(Properties.Resources.icons8_table_50);
                    item.ImageIndex = 0;
                }
                else if (TrangThai == 1)
                {
                    imageList.Images.Add(Properties.Resources.table_ban);
                    item.ImageIndex = 1;
                }
                else if (TrangThai == 2)
                {
                    imageList.Images.Add(Properties.Resources.table_cho);
                    item.ImageIndex = 2;
                }
                // Sử dụng ImageIndex của ảnh thêm vào
                item.Text = "Bàn " + (i + 1).ToString();
                lsvPhongBan.Items.Add(item);
            }

            // Thiết lập ImageList cho ListView
            lsvPhongBan.LargeImageList = imageList;
            lsvPhongBan.Scrollable = false;
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (lsvPhongBan.SelectedItems.Count > 0)
            {
                // Get the selected value
                var selectedValue = lsvPhongBan.SelectedItems[0].Text;
                _delegateMethod(selectedValue);
            }
        }

        private void lsvPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPhongBan.SelectedItems.Count > 0)
            {
                // Get the selected value
                var selectedValue = lsvPhongBan.SelectedItems[0].Text;
                _delegateMethod(selectedValue);
            }
            
        }
    }
}
