namespace DoAn
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.panelMoveform = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestoreDown = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.QuanLyContainer = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnQuanLySanPham = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.ThongKeContainer = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.QuanLyTimer = new System.Windows.Forms.Timer(this.components);
            this.ThongKeTimer = new System.Windows.Forms.Timer(this.components);
            this.panelRightContainer = new System.Windows.Forms.Panel();
            this.panelMoveform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.QuanLyContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ThongKeContainer.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMoveform
            // 
            this.panelMoveform.BackColor = System.Drawing.Color.Transparent;
            this.panelMoveform.Controls.Add(this.label3);
            this.panelMoveform.Controls.Add(this.btnRestoreDown);
            this.panelMoveform.Controls.Add(this.btnMinimize);
            this.panelMoveform.Controls.Add(this.btnClose);
            this.panelMoveform.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMoveform.Location = new System.Drawing.Point(0, 0);
            this.panelMoveform.Name = "panelMoveform";
            this.panelMoveform.Size = new System.Drawing.Size(1000, 30);
            this.panelMoveform.TabIndex = 3;
            this.panelMoveform.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMoveform_MouseDown);
            this.panelMoveform.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMoveform_MouseMove);
            this.panelMoveform.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMoveform_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "THT COFFEE APP";
            // 
            // btnRestoreDown
            // 
            this.btnRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDown.BackgroundImage = global::DoAn.Properties.Resources.icons8_maximize_window_24;
            this.btnRestoreDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestoreDown.Location = new System.Drawing.Point(960, 5);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(20, 20);
            this.btnRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestoreDown.TabIndex = 2;
            this.btnRestoreDown.TabStop = false;
            this.btnRestoreDown.Visible = false;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::DoAn.Properties.Resources.icons8_subtract_50;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Location = new System.Drawing.Point(940, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::DoAn.Properties.Resources.icons8_close_window_48;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Location = new System.Drawing.Point(980, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTimer,
            this.tsslDateTime,
            this.tsslHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTimer
            // 
            this.tsslTimer.ForeColor = System.Drawing.Color.White;
            this.tsslTimer.Name = "tsslTimer";
            this.tsslTimer.Size = new System.Drawing.Size(49, 17);
            this.tsslTimer.Text = "12:00:00";
            // 
            // tsslDateTime
            // 
            this.tsslDateTime.ForeColor = System.Drawing.Color.White;
            this.tsslDateTime.Name = "tsslDateTime";
            this.tsslDateTime.Size = new System.Drawing.Size(57, 17);
            this.tsslDateTime.Text = "DateTime";
            // 
            // tsslHoTen
            // 
            this.tsslHoTen.ForeColor = System.Drawing.Color.White;
            this.tsslHoTen.Name = "tsslHoTen";
            this.tsslHoTen.Size = new System.Drawing.Size(64, 17);
            this.tsslHoTen.Text = "Nhân viên:";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.YellowGreen;
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.QuanLyContainer);
            this.sideBar.Controls.Add(this.ThongKeContainer);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 30);
            this.sideBar.MaximumSize = new System.Drawing.Size(200, 1000);
            this.sideBar.MinimumSize = new System.Drawing.Size(60, 648);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(200, 648);
            this.sideBar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 69);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::DoAn.Properties.Resources.icons8_menu_rounded_24;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(9, 16);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDatHang);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.Transparent;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Image = global::DoAn.Properties.Resources.icons8_buying_24;
            this.btnDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatHang.Location = new System.Drawing.Point(-23, -13);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDatHang.Size = new System.Drawing.Size(223, 73);
            this.btnDatHang.TabIndex = 7;
            this.btnDatHang.Text = "               Đặt hàng";
            this.btnDatHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // QuanLyContainer
            // 
            this.QuanLyContainer.BackColor = System.Drawing.Color.DarkGreen;
            this.QuanLyContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuanLyContainer.Controls.Add(this.panel8);
            this.QuanLyContainer.Controls.Add(this.panel7);
            this.QuanLyContainer.Controls.Add(this.panel3);
            this.QuanLyContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuanLyContainer.Location = new System.Drawing.Point(3, 134);
            this.QuanLyContainer.MaximumSize = new System.Drawing.Size(200, 150);
            this.QuanLyContainer.MinimumSize = new System.Drawing.Size(200, 50);
            this.QuanLyContainer.Name = "QuanLyContainer";
            this.QuanLyContainer.Size = new System.Drawing.Size(200, 50);
            this.QuanLyContainer.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnQuanLySanPham);
            this.panel8.Location = new System.Drawing.Point(-5, 99);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 34);
            this.panel8.TabIndex = 12;
            // 
            // btnQuanLySanPham
            // 
            this.btnQuanLySanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLySanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySanPham.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySanPham.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySanPham.Image = global::DoAn.Properties.Resources.icons8_trolley_24;
            this.btnQuanLySanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySanPham.Location = new System.Drawing.Point(-8, -7);
            this.btnQuanLySanPham.Name = "btnQuanLySanPham";
            this.btnQuanLySanPham.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnQuanLySanPham.Size = new System.Drawing.Size(213, 50);
            this.btnQuanLySanPham.TabIndex = 7;
            this.btnQuanLySanPham.Text = "               Sản phẩm";
            this.btnQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySanPham.UseVisualStyleBackColor = false;
            this.btnQuanLySanPham.Click += new System.EventHandler(this.btnQuanLySanPham_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnQuanLyNhanVien);
            this.panel7.Location = new System.Drawing.Point(-8, 59);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 34);
            this.panel7.TabIndex = 11;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.Image = global::DoAn.Properties.Resources.icons8_manager_24;
            this.btnQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(-6, -7);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(214, 50);
            this.btnQuanLyNhanVien.TabIndex = 7;
            this.btnQuanLyNhanVien.Text = "               Nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnQuanLy);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 7;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.YellowGreen;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.White;
            this.btnQuanLy.Image = global::DoAn.Properties.Resources.icons8_repository_24;
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(-23, -13);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(223, 73);
            this.btnQuanLy.TabIndex = 7;
            this.btnQuanLy.Text = "               Quản lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            this.btnQuanLy.MouseHover += new System.EventHandler(this.btnQuanLy_MouseHover);
            // 
            // ThongKeContainer
            // 
            this.ThongKeContainer.BackColor = System.Drawing.Color.DarkGreen;
            this.ThongKeContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThongKeContainer.Controls.Add(this.panel10);
            this.ThongKeContainer.Controls.Add(this.panel9);
            this.ThongKeContainer.Controls.Add(this.panel4);
            this.ThongKeContainer.Location = new System.Drawing.Point(3, 190);
            this.ThongKeContainer.MaximumSize = new System.Drawing.Size(200, 150);
            this.ThongKeContainer.MinimumSize = new System.Drawing.Size(200, 50);
            this.ThongKeContainer.Name = "ThongKeContainer";
            this.ThongKeContainer.Size = new System.Drawing.Size(200, 50);
            this.ThongKeContainer.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDoanhThu);
            this.panel10.Location = new System.Drawing.Point(4, 97);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(197, 34);
            this.panel10.TabIndex = 14;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.Image = global::DoAn.Properties.Resources.icons8_get_revenue_241;
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(-13, -7);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoanhThu.Size = new System.Drawing.Size(213, 50);
            this.btnDoanhThu.TabIndex = 7;
            this.btnDoanhThu.Text = "               Doanh thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnHoaDon);
            this.panel9.Location = new System.Drawing.Point(-4, 55);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 34);
            this.panel9.TabIndex = 13;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = global::DoAn.Properties.Resources.icons8_paid_bill_241;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(-6, -7);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(213, 50);
            this.btnHoaDon.TabIndex = 7;
            this.btnHoaDon.Text = "               Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.YellowGreen;
            this.panel4.Controls.Add(this.btnThongKe);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 50);
            this.panel4.TabIndex = 8;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::DoAn.Properties.Resources.icons8_cash_register_24;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-23, -13);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(223, 73);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "               Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThongKe.MouseHover += new System.EventHandler(this.btnThongKe_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnAboutUs);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(3, 246);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 9;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::DoAn.Properties.Resources.icons8_info_24;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(-23, -13);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(223, 73);
            this.btnAboutUs.TabIndex = 7;
            this.btnAboutUs.Text = "               About Us";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // QuanLyTimer
            // 
            this.QuanLyTimer.Interval = 10;
            this.QuanLyTimer.Tick += new System.EventHandler(this.QuanLyTimer_Tick);
            // 
            // ThongKeTimer
            // 
            this.ThongKeTimer.Interval = 10;
            this.ThongKeTimer.Tick += new System.EventHandler(this.ThongKeTimer_Tick);
            // 
            // panelRightContainer
            // 
            this.panelRightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightContainer.Location = new System.Drawing.Point(200, 30);
            this.panelRightContainer.Name = "panelRightContainer";
            this.panelRightContainer.Size = new System.Drawing.Size(800, 648);
            this.panelRightContainer.TabIndex = 7;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelRightContainer);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMoveform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.panelMoveform.ResumeLayout(false);
            this.panelMoveform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.QuanLyContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ThongKeContainer.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMoveform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnRestoreDown;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTimer;
        private System.Windows.Forms.ToolStripStatusLabel tsslDateTime;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Panel QuanLyContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnQuanLySanPham;
        private System.Windows.Forms.Timer QuanLyTimer;
        private System.Windows.Forms.Panel ThongKeContainer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Timer ThongKeTimer;
        private System.Windows.Forms.ToolStripStatusLabel tsslHoTen;
        private System.Windows.Forms.Panel panelRightContainer;
    }
}