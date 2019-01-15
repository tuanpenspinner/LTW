namespace QuanLyLapTop
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSangTrong = new System.Windows.Forms.Button();
            this.btnGaming = new System.Windows.Forms.Button();
            this.btnDoHoa = new System.Windows.Forms.Button();
            this.btnHocTap = new System.Windows.Forms.Button();
            this.cmbSX = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flwHome = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(131, 35);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(142, 28);
            this.cmbBrand.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hãng:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(944, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 29);
            this.txtSearch.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSangTrong);
            this.groupBox1.Controls.Add(this.btnGaming);
            this.groupBox1.Controls.Add(this.btnDoHoa);
            this.groupBox1.Controls.Add(this.btnHocTap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 361);
            this.groupBox1.TabIndex = 20;
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
            // cmbSX
            // 
            this.cmbSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSX.FormattingEnabled = true;
            this.cmbSX.Items.AddRange(new object[] {
            "Giá tăng dần",
            "Giá giảm dần"});
            this.cmbSX.Location = new System.Drawing.Point(132, 77);
            this.cmbSX.Name = "cmbSX";
            this.cmbSX.Size = new System.Drawing.Size(142, 28);
            this.cmbSX.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sắp xếp:";
            // 
            // flwHome
            // 
            this.flwHome.AutoScroll = true;
            this.flwHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flwHome.ForeColor = System.Drawing.Color.DimGray;
            this.flwHome.Location = new System.Drawing.Point(351, 103);
            this.flwHome.Name = "flwHome";
            this.flwHome.Size = new System.Drawing.Size(835, 403);
            this.flwHome.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(396, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý bán hàng laptop";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Image = global::QuanLyLapTop.Properties.Resources.Filter_2_icon;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(104, 136);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 37);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.Image = global::QuanLyLapTop.Properties.Resources.Search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(819, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 35);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.White;
            this.btnAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddBrand.Image = global::QuanLyLapTop.Properties.Resources.add_icon;
            this.btnAddBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBrand.Location = new System.Drawing.Point(295, 35);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(95, 35);
            this.btnAddBrand.TabIndex = 26;
            this.btnAddBrand.Text = "Thêm";
            this.btnAddBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flwHome);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1200, 570);
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSangTrong;
        private System.Windows.Forms.Button btnGaming;
        private System.Windows.Forms.Button btnDoHoa;
        private System.Windows.Forms.Button btnHocTap;
        private System.Windows.Forms.ComboBox cmbSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flwHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBrand;
    }
}
