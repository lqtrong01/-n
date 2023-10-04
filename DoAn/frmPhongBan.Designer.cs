namespace DoAn
{
    partial class frmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lsvPhongBan = new System.Windows.Forms.ListView();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnBanCho = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icons8-table-50.png");
            this.imageList.Images.SetKeyName(1, "table_ban.png");
            this.imageList.Images.SetKeyName(2, "table_cho.png");
            // 
            // lsvPhongBan
            // 
            this.lsvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsvPhongBan.HideSelection = false;
            this.lsvPhongBan.Location = new System.Drawing.Point(0, 0);
            this.lsvPhongBan.Name = "lsvPhongBan";
            this.lsvPhongBan.Scrollable = false;
            this.lsvPhongBan.Size = new System.Drawing.Size(350, 505);
            this.lsvPhongBan.TabIndex = 0;
            this.lsvPhongBan.UseCompatibleStateImageBehavior = false;
            this.lsvPhongBan.SelectedIndexChanged += new System.EventHandler(this.lsvPhongBan_SelectedIndexChanged);
            // 
            // btnDatBan
            // 
            this.btnDatBan.Location = new System.Drawing.Point(12, 536);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(75, 32);
            this.btnDatBan.TabIndex = 1;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.UseVisualStyleBackColor = true;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnBanCho
            // 
            this.btnBanCho.Location = new System.Drawing.Point(142, 536);
            this.btnBanCho.Name = "btnBanCho";
            this.btnBanCho.Size = new System.Drawing.Size(75, 32);
            this.btnBanCho.TabIndex = 1;
            this.btnBanCho.Text = "Bàn chờ";
            this.btnBanCho.UseVisualStyleBackColor = true;
            this.btnBanCho.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(263, 536);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // frmPhongBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 580);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBanCho);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.lsvPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPhongBan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvPhongBan;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnBanCho;
        private System.Windows.Forms.Button btnReset;
    }
}