namespace DoAn
{
    partial class frmDatHang
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
            this.sideBarDatHanng = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTable = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.txtTamTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvOrder = new System.Windows.Forms.ListView();
            this.TENSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DONGIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLeftContainer = new System.Windows.Forms.Panel();
            this.txtSoBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sideBarDatHanng.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarDatHanng
            // 
            this.sideBarDatHanng.BackColor = System.Drawing.Color.YellowGreen;
            this.sideBarDatHanng.Controls.Add(this.panel1);
            this.sideBarDatHanng.Controls.Add(this.panel2);
            this.sideBarDatHanng.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBarDatHanng.Location = new System.Drawing.Point(0, 0);
            this.sideBarDatHanng.Name = "sideBarDatHanng";
            this.sideBarDatHanng.Size = new System.Drawing.Size(777, 50);
            this.sideBarDatHanng.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnTable);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(-13, -13);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(154, 71);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Đặt bàn";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.btnThucDon);
            this.panel2.Location = new System.Drawing.Point(129, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 50);
            this.panel2.TabIndex = 2;
            // 
            // btnThucDon
            // 
            this.btnThucDon.BackColor = System.Drawing.Color.Transparent;
            this.btnThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucDon.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucDon.Location = new System.Drawing.Point(-13, -14);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(154, 71);
            this.btnThucDon.TabIndex = 2;
            this.btnThucDon.Text = "Thực đơn";
            this.btnThucDon.UseVisualStyleBackColor = false;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbThongTin);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lsvOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(357, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 592);
            this.panel3.TabIndex = 2;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnClose);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.txtTongTien);
            this.gbThongTin.Controls.Add(this.btnDatBan);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.btnThanhToan);
            this.gbThongTin.Controls.Add(this.btnInHoaDon);
            this.gbThongTin.Controls.Add(this.txtSoBan);
            this.gbThongTin.Controls.Add(this.txtMaKH);
            this.gbThongTin.Controls.Add(this.btnThemMon);
            this.gbThongTin.Controls.Add(this.txtMaGiamGia);
            this.gbThongTin.Controls.Add(this.txtTamTinh);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Location = new System.Drawing.Point(3, 229);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(414, 363);
            this.gbThongTin.TabIndex = 11;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã KH:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(79, 159);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(137, 20);
            this.txtTongTien.TabIndex = 10;
            // 
            // btnDatBan
            // 
            this.btnDatBan.Location = new System.Drawing.Point(9, 213);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(75, 34);
            this.btnDatBan.TabIndex = 1;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tạm tính:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(116, 213);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 34);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(319, 310);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 34);
            this.btnInHoaDon.TabIndex = 1;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(79, 33);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(137, 20);
            this.txtMaKH.TabIndex = 7;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(221, 213);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 34);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.Location = new System.Drawing.Point(79, 102);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(137, 20);
            this.txtMaGiamGia.TabIndex = 6;
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.Location = new System.Drawing.Point(79, 65);
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.Size = new System.Drawing.Size(137, 20);
            this.txtTamTinh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã giảm giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ORDER";
            // 
            // lsvOrder
            // 
            this.lsvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TENSP,
            this.SOLUONG,
            this.DONGIA});
            this.lsvOrder.HideSelection = false;
            this.lsvOrder.Location = new System.Drawing.Point(3, 37);
            this.lsvOrder.Name = "lsvOrder";
            this.lsvOrder.Size = new System.Drawing.Size(414, 186);
            this.lsvOrder.TabIndex = 0;
            this.lsvOrder.UseCompatibleStateImageBehavior = false;
            this.lsvOrder.View = System.Windows.Forms.View.Details;
            // 
            // TENSP
            // 
            this.TENSP.Text = "Tên sản phẩm";
            this.TENSP.Width = 100;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Text = "Số lượng";
            // 
            // DONGIA
            // 
            this.DONGIA.Text = "Đơn giá";
            this.DONGIA.Width = 95;
            // 
            // panelLeftContainer
            // 
            this.panelLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftContainer.Location = new System.Drawing.Point(0, 50);
            this.panelLeftContainer.Name = "panelLeftContainer";
            this.panelLeftContainer.Size = new System.Drawing.Size(357, 592);
            this.panelLeftContainer.TabIndex = 3;
            // 
            // txtSoBan
            // 
            this.txtSoBan.Location = new System.Drawing.Point(296, 33);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.Size = new System.Drawing.Size(75, 20);
            this.txtSoBan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số bàn:";
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 642);
            this.Controls.Add(this.panelLeftContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sideBarDatHanng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatHang";
            this.Text = "frmDatHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatHang_FormClosing);
            this.sideBarDatHanng.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBarDatHanng;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamTinh;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.ListView lsvOrder;
        private System.Windows.Forms.ColumnHeader TENSP;
        private System.Windows.Forms.ColumnHeader SOLUONG;
        private System.Windows.Forms.ColumnHeader DONGIA;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.Panel panelLeftContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoBan;
    }
}