namespace QuanLyLapTop
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.flwHome = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSX = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSangTrong = new System.Windows.Forms.Button();
            this.btnGaming = new System.Windows.Forms.Button();
            this.btnDoHoa = new System.Windows.Forms.Button();
            this.btnHocTap = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(382, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý bán hàng laptop";
            // 
            // flwHome
            // 
            this.flwHome.AutoScroll = true;
            this.flwHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flwHome.ForeColor = System.Drawing.Color.DimGray;
            this.flwHome.Location = new System.Drawing.Point(337, 212);
            this.flwHome.Name = "flwHome";
            this.flwHome.Size = new System.Drawing.Size(835, 403);
            this.flwHome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sắp xếp:";
            // 
            // cmbSX
            // 
            this.cmbSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSX.FormattingEnabled = true;
            this.cmbSX.Items.AddRange(new object[] {
            "Giá tăng dần",
            "Giá giảm dần"});
            this.cmbSX.Location = new System.Drawing.Point(118, 186);
            this.cmbSX.Name = "cmbSX";
            this.cmbSX.Size = new System.Drawing.Size(142, 28);
            this.cmbSX.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSangTrong);
            this.groupBox1.Controls.Add(this.btnGaming);
            this.groupBox1.Controls.Add(this.btnDoHoa);
            this.groupBox1.Controls.Add(this.btnHocTap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 361);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // btnSangTrong
            // 
            this.btnSangTrong.BackColor = System.Drawing.Color.White;
            this.btnSangTrong.Image = global::QuanLyLapTop.Properties.Resources.gold_ingot_icon;
            this.btnSangTrong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSangTrong.Location = new System.Drawing.Point(5, 277);
            this.btnSangTrong.Name = "btnSangTrong";
            this.btnSangTrong.Size = new System.Drawing.Size(274, 40);
            this.btnSangTrong.TabIndex = 0;
            this.btnSangTrong.Text = "Cao cấp sang trọng";
            this.btnSangTrong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSangTrong.UseVisualStyleBackColor = false;
            this.btnSangTrong.Click += new System.EventHandler(this.btnSangTrong_Click);
            // 
            // btnGaming
            // 
            this.btnGaming.BackColor = System.Drawing.Color.White;
            this.btnGaming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGaming.Image = global::QuanLyLapTop.Properties.Resources.Devices_input_gaming_icon;
            this.btnGaming.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGaming.Location = new System.Drawing.Point(6, 209);
            this.btnGaming.Name = "btnGaming";
            this.btnGaming.Size = new System.Drawing.Size(273, 40);
            this.btnGaming.TabIndex = 0;
            this.btnGaming.Text = "Laptop Gaming";
            this.btnGaming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGaming.UseVisualStyleBackColor = false;
            this.btnGaming.Click += new System.EventHandler(this.btnGaming_Click);
            // 
            // btnDoHoa
            // 
            this.btnDoHoa.BackColor = System.Drawing.Color.White;
            this.btnDoHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDoHoa.Image = global::QuanLyLapTop.Properties.Resources.PSD_File_icon;
            this.btnDoHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoHoa.Location = new System.Drawing.Point(6, 130);
            this.btnDoHoa.Name = "btnDoHoa";
            this.btnDoHoa.Size = new System.Drawing.Size(273, 40);
            this.btnDoHoa.TabIndex = 0;
            this.btnDoHoa.Text = "Đồ họa kĩ thuật";
            this.btnDoHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoHoa.UseVisualStyleBackColor = false;
            this.btnDoHoa.Click += new System.EventHandler(this.btnDoHoa_Click);
            // 
            // btnHocTap
            // 
            this.btnHocTap.BackColor = System.Drawing.Color.White;
            this.btnHocTap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHocTap.Image = global::QuanLyLapTop.Properties.Resources._10206_man_student_icon;
            this.btnHocTap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHocTap.Location = new System.Drawing.Point(5, 50);
            this.btnHocTap.Name = "btnHocTap";
            this.btnHocTap.Size = new System.Drawing.Size(274, 40);
            this.btnHocTap.TabIndex = 0;
            this.btnHocTap.Text = "Học tập văn phòng";
            this.btnHocTap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocTap.UseVisualStyleBackColor = false;
            this.btnHocTap.Click += new System.EventHandler(this.btnHocTap_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(930, 159);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 29);
            this.txtSearch.TabIndex = 12;
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(117, 144);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(142, 28);
            this.cmbBrand.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hãng:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.Image = global::QuanLyLapTop.Properties.Resources.Search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(805, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 35);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.White;
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRevenue.Image = global::QuanLyLapTop.Properties.Resources.money_icon;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(968, 24);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(165, 67);
            this.btnRevenue.TabIndex = 6;
            this.btnRevenue.Text = "Doanh thu";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevenue.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.White;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHistory.Image = global::QuanLyLapTop.Properties.Resources.store_icon;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(641, 24);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(234, 67);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Lịch sử bán hàng";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.White;
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemSanPham.Image = global::QuanLyLapTop.Properties.Resources.laptop_icon;
            this.btnThemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSanPham.Location = new System.Drawing.Point(261, 24);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(219, 67);
            this.btnThemSanPham.TabIndex = 4;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.White;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTrangChu.Image = global::QuanLyLapTop.Properties.Resources.Home_icon;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(27, 24);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(127, 67);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "Home";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flwHome);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý laptop";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnTrangChu;
        public System.Windows.Forms.Button btnThemSanPham;
        public System.Windows.Forms.Button btnHistory;
        public System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.FlowLayoutPanel flwHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoHoa;
        private System.Windows.Forms.Button btnHocTap;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSangTrong;
        private System.Windows.Forms.Button btnGaming;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
    }
}

