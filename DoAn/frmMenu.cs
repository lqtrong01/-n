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
    public delegate void DelegateMethod(object objects = null);
    public partial class frmMenu : Form
    {
        bool boolThongKe;
        bool sidebarExpand;
        bool boolQuanLy;
        bool drag = false;
        Point start_point = new Point(0, 0);
        public frmMenu()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tsslTimer.Text = DateTime.Now.ToString("hh:mm:ss");
            tsslDateTime.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMoveform_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panelMoveform_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - start_point.X, point.Y - start_point.Y);
            }
        }

        private void panelMoveform_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void QuanLyTimer_Tick(object sender, EventArgs e)
        {
            if (boolQuanLy)
            {
                QuanLyContainer.Height += 10;
                if(QuanLyContainer.Height == QuanLyContainer.MaximumSize.Height)
                {
                    boolQuanLy = false;
                    QuanLyTimer.Stop();
                }
            }
            else
            {
                QuanLyContainer.Height -= 10;
                if(QuanLyContainer.Height == QuanLyContainer.MinimumSize.Height)
                {
                    boolQuanLy = true;
                    QuanLyTimer.Stop();
                }
            }    
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLyTimer.Start();
        }

        private void ThongKeTimer_Tick(object sender, EventArgs e)
        {
            if (boolThongKe)
            {
                ThongKeContainer.Height += 10;
                if (ThongKeContainer.Height == ThongKeContainer.MaximumSize.Height)
                {
                    boolThongKe = false;
                    ThongKeTimer.Stop();
                }
            }
            else
            {
                ThongKeContainer.Height -= 10;
                if (ThongKeContainer.Height == ThongKeContainer.MinimumSize.Height)
                {
                    boolThongKe = true;
                    ThongKeTimer.Stop();
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeTimer.Start();
        }

        private void btnQuanLy_MouseHover(object sender, EventArgs e)
        {
            QuanLyTimer.Start();
        }

        private void btnThongKe_MouseHover(object sender, EventArgs e)
        {
            ThongKeTimer.Start();
        }
        private void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelRightContainer.Controls.Add(form);
            panelRightContainer.Tag = form;
            form.Show();
            form.BringToFront();
        }
        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            ShowFormInPanel(frm);
            //frmNhanVien frm = Application.OpenForms.OfType<frmNhanVien>().FirstOrDefault();
            //if (frm == null)
            //{
            //    frm = new frmNhanVien();
            //    frm.MdiParent = this;
            //    frm.StartPosition = FormStartPosition.Manual; // Thiết lập StartPosition
            //    frm.Location = new Point(0, 0); // Thiết lập vị trí của form
            //    frm.Show(); // Hiển thị form
            //}
            //else
            //{
            //    // Nếu đã được tạo, đưa form lên phía trước
            //    frm.BringToFront();
            //}
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            ShowFormInPanel(frm);

            //frmSanPham frm = Application.OpenForms.OfType<frmSanPham>().FirstOrDefault();
            //if (frm == null)
            //{
            //    frm = new frmSanPham();
            //    frm.MdiParent = this;
            //    frm.StartPosition = FormStartPosition.Manual; // Thiết lập StartPosition
            //    frm.Location = new Point(0, 0); // Thiết lập vị trí của form
            //    frm.Show(); // Hiển thị form
            //}
            //else
            //{
            //    // Nếu đã được tạo, đưa form lên phía trước
            //    frm.BringToFront();
            //}
        }


        private void btnDatHang_Click(object sender, EventArgs e)
        {
            frmDatHang frm = new frmDatHang();
            ShowFormInPanel(frm);
            //frmDatHang frm = Application.OpenForms.OfType<frmDatHang>().FirstOrDefault();
            //if (frm == null)
            //{
            //    frm = new frmDatHang();
            //    frm.IsMdiContainer = false;
            //    frm.MdiParent = this;
            //    frm.StartPosition = FormStartPosition.Manual; // Thiết lập StartPosition
            //    frm.Location = new Point(0, 0); // Thiết lập vị trí của form
            //    frm.Show(); // Hiển thị form
            //}
            //else
            //{
            //    // Nếu đã được tạo, đưa form lên phía trước
            //    frm.BringToFront();
            //}
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (panelRightContainer.Controls.Count > 0)
            {
                Form form = panelRightContainer.Controls[0] as Form;
                if (form != null)
                {
                    form.Dock = DockStyle.None;
                    form.Dispose();
                }
            }
        }
    }
}
