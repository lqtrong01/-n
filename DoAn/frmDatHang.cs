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
    public partial class frmDatHang : Form
    {
        private bool isFormOpened = false;
        
        public frmDatHang()
        {
            InitializeComponent();
            PhongBan();
        }
        private void PhongBan()
        {
            frmPhongBan frm = new frmPhongBan(FillData);
            frm.TopLevel = false; // Đặt TopLevel = false để trở thành control trên form cha
            frm.FormBorderStyle = FormBorderStyle.None; // Đặt FormBorderStyle để không có khung viền
            frm.Dock = DockStyle.Fill; // Đặt Dock để lấp đầy panel
            panelLeftContainer.Controls.Add(frm); // Thêm form vào panel
            frm.Show(); // Hiển thị form
            // Nếu đã được tạo, đưa form lên phía trước
            frm.BringToFront();
        }
        private void ThucDon()
        {

            


        }
        private void FillData(object objects= null)
        {
            txtSoBan.Text = objects.ToString();
        }
        private void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Kiểm tra xem trong panel đã có form nào hay chưa
            if (panelLeftContainer.Controls.Count > 0)
            {
                Form existingForm = panelLeftContainer.Controls[0] as Form;
                if (existingForm != null)
                {
                    // Nếu có, loại bỏ form hiện tại khỏi panel
                    existingForm.Dock = DockStyle.None;
                    existingForm.Dispose();
                }
            }

            panelLeftContainer.Controls.Add(form);
            panelLeftContainer.Tag = form;
            form.Show();
            form.BringToFront();
        }
        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            btnDatBan.BackColor = Color.White;
            //if (isFormOpened)
            //{
            //    return;
            //}

            frmPhongBan frm = new frmPhongBan(FillData);
            //frm.FormClosed += (s, args) => {
            //    isFormOpened = false;
            //};
            ShowFormInPanel(frm);

            //isFormOpened = true;
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            btnThucDon.BackColor = Color.White;
            //if (isFormOpened)
            //{
            //    return;
            //}

            frmThucDon frm = new frmThucDon(FillData);
            //frm.FormClosed += (s, args) => {
            //    isFormOpened = false;
            //};
            ShowFormInPanel(frm);

            //isFormOpened = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát Đặt hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                this.Close();
        }

        private void frmDatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (panelLeftContainer.Controls.Count > 0)
            {
                Form form = panelLeftContainer.Controls[0] as Form;
                if (form != null)
                {
                    form.Dock = DockStyle.None;
                    form.Dispose();
                }
            }
        }
    }
}
