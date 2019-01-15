using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace QuanLyLapTop
{
    public partial class Home : UserControl
    {
        public frmHome frm = new frmHome();
        Database Db = new Database();
        public ThemSP Themsp=new ThemSP();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            flwHome.Controls.Clear();
            string SQL = "SELECT * FROM Tblaptop";
            Loaddata(SQL);
        }

        private void Loaddata(string SQL)
        {
            //Tạo combobox chọn hãng sản xuất
            Db.Connection_Open();
            string SQLBrand = "SELECT NameBrand FROM TbCategory";
            OleDbDataAdapter da = new OleDbDataAdapter(SQLBrand, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "NameBrand";
            cmbBrand.ValueMember = "NameBrand";

            //Hiển thị hình ảnh

            Db.Connection_Open();
            OleDbCommand cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ToolTip Tol = new ToolTip();
                Laptop laptop = new Laptop();
                laptop.ImagePath = "";
                laptop.IDLaptop = Convert.ToInt32(dr["ID"]);
                laptop.Name = dr["Name"].ToString();
                laptop.Brand = dr["Brand"].ToString();
                laptop.Funtion = dr["Funt"].ToString();
                laptop.Cost = Convert.ToInt32(dr["Cost"]);
                laptop.CPU = dr["CPU"].ToString();
                laptop.Ram = Convert.ToInt32(dr["RAM"]);
                laptop.Hard = dr["Hard"].ToString();
                laptop.Memory = Convert.ToInt32(dr["Memory"]);
                laptop.Desktop = Convert.ToDouble(dr["Desktop"]);
                laptop.Species = dr["Species"].ToString();
                laptop.Card = dr["Card"].ToString();
                laptop.Resolution = dr["Resolution"].ToString();
                laptop.Weight = Convert.ToDouble(dr["Weight"]);
                laptop.Number = Convert.ToInt32(dr["Num"]);
                laptop.ImagePath = dr["Img"].ToString();
                laptop.Status = Convert.ToBoolean(dr["Status"]);
                //Tạo danh sách sản phẩm
                Panel panel = new Panel();
                panel.Size = new Size(400, 400);
                panel.BackColor = Color.White;

                Label lblName = new Label();
                lblName.Text = laptop.Name;
                lblName.Size = new Size(400, 40);
                lblName.Location = new Point(0, 220);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblName.ForeColor = Color.BlueViolet;

                Label lblCost = new Label();
                if (laptop.Status)
                {
                    lblCost.Text = "Ngừng kinh doanh";
                }
                else
                {
                    lblCost.Text = String.Format("{0:0,0 VNĐ}", laptop.Cost);

                }

                lblCost.Size = new Size(400, 40);
                lblCost.Location = new Point(0, 260);
                lblCost.TextAlign = ContentAlignment.MiddleCenter;
                lblCost.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblCost.ForeColor = Color.Blue;


                PictureBox pic = new PictureBox();
                pic.Size = new Size(400, 200);
                pic.Location = new Point(0, 10);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                if(laptop.ImagePath!="")
                {
                    pic.Image = Image.FromFile(laptop.ImagePath);
                }  
                pic.MouseLeave += Pic_MouseLeave;
                pic.MouseMove += Pic_MouseMove;
                Tol.ToolTipTitle = "Thông tin sản phẩm";
                Tol.ToolTipIcon = ToolTipIcon.Info;
                Tol.SetToolTip(pic, laptop.ToString());


                //Tạo button bán
                var btnSell = new btnEditLaptop();
                btnSell.laptop = laptop;
                btnSell.Text = "Bán";
                btnSell.Location = new Point(50, 350);
                btnSell.AutoSize = true;
                btnSell.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnSell.ForeColor = Color.Red;
                btnSell.Click += BtnSell_Click;

                //Tạo button sửa thông tin
                var btnEdit = new btnEditLaptop();
                btnEdit.laptop = laptop;
                btnEdit.Text = "Sửa thông tin";
                btnEdit.Location = new Point(190, 349);
                btnEdit.AutoSize = true;
                btnEdit.Click += BtnEdit_Click;
                btnEdit.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnEdit.ForeColor = Color.Red;

                //Tạo label số lương lap top
                Label lblNumbe = new Label();
                lblNumbe.Text = "Số lượng: ";
                lblNumbe.Font = lblCost.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblNumbe.Location = new Point(221, 310);
                lblNumbe.ForeColor = Color.Black;

                Label lblNumber = new Label();
                if (laptop.Number == 0)
                {
                    lblNumber.Text = "Hết hàng";
                    lblNumbe.Visible = false;
                }

                else
                {
                    lblNumber.Text = laptop.Number + " chiếc";
                }

                lblNumber.Location = new Point(318, 310);
                lblNumber.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblNumber.ForeColor = Color.Cyan;

                panel.Controls.Add(pic);
                panel.Controls.Add(lblCost);
                panel.Controls.Add(lblName);
                panel.Controls.Add(btnEdit);
                panel.Controls.Add(btnSell);
                panel.Controls.Add(lblNumbe);
                panel.Controls.Add(lblNumber);

                flwHome.Controls.Add(panel);
            }

            Db.Connection_Close();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            var btn = sender as btnEditLaptop;
            frmBanSP frm = new frmBanSP();
            frm.SellLaptop(btn.laptop);
            frm.ShowDialog();

        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            var pic = sender as PictureBox;
            pic.Size = new Size(420, 220);
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            pic.Size = new Size(400, 200);
        }

        private void frmHome_Load_Search(object sender, EventArgs e)
        {
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            string name = "'" + "%" + txtSearch.Text + "%" + "'";
            string SQL = "SELECT* FROM TbLaptop WHERE Name LIKE " + name + "";

            Loaddata(SQL);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var btn = sender as btnEditLaptop;
            ThemSP ThemSP = new ThemSP();
            ThemSP.btnDelete.Visible = true;
            ThemSP.SetLaptop(btn.laptop);
            ThemSP.btnAdd.Visible = false;
            ThemSP.btnUpdate.Visible = true;

            this.frm.Edit(ThemSP);
        }

        private void btnHocTap_Click(object sender, EventArgs e)
        {
            string SQL;
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            if (cmbSX.Text == "Giá tăng dần")
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnHocTap.Text + "'ORDER BY Cost ASC";
            }
            else
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnHocTap.Text + "'ORDER BY Cost DESC";
            }
            Loaddata(SQL);
        }

        private void btnDoHoa_Click(object sender, EventArgs e)
        {
            string SQL;
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            if (cmbSX.Text == "Giá tăng dần")
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnDoHoa.Text + "'ORDER BY Cost ASC";
            }
            else
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnDoHoa.Text + "'ORDER BY Cost DESC";
            }

            Loaddata(SQL);
        }

        private void btnGaming_Click(object sender, EventArgs e)
        {
            string SQL;
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            if (cmbSX.Text == "Giá tăng dần")
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnGaming.Text + "'ORDER BY Cost ASC";
            }
            else
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnGaming.Text + "'ORDER BY Cost DESC";
            }

            Loaddata(SQL);
        }

        private void btnSangTrong_Click(object sender, EventArgs e)
        {
            string SQL;
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            if (cmbSX.Text == "Giá tăng dần")
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnSangTrong.Text + "'ORDER BY Cost ASC";
            }
            else
            {
                SQL = "SELECT* FROM TbLaptop WHERE Funt= '" + btnSangTrong.Text + "'ORDER BY Cost DESC";
            }

            Loaddata(SQL);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Home_Load_Search();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbBrand.Text == "Tất cả")
            {
                Home_Load_ALL();
            }
            else
            {
                Home_Load_Fitler();
            }
        }

        private void Home_Load_Fitler()
        {
            string SQL;
            flwHome.Controls.Clear();
            if (cmbSX.Text == "Giá tăng dần")
            {
                SQL = "SELECT* FROM TbLaptop WHERE Brand ='" + cmbBrand.Text + "'ORDER BY Cost ASC";
            }
            else
            {
                SQL = "SELECT* FROM TbLaptop WHERE Brand ='" + cmbBrand.Text + "'ORDER BY Cost DESC";
            }

            Loaddata(SQL);
        }

        private void Home_Load_Search()
        {
            flwHome.Controls.Clear();
            string name = "'" + "%" + txtSearch.Text + "%" + "'";
            string SQL = "SELECT* FROM TbLaptop WHERE Name LIKE " + name + "";

            Loaddata(SQL);
        }

        private void Home_Load_ALL()
        {
            string SQL;

            flwHome.Controls.Clear();
            if (cmbSX.Text == "Giá tăng dần")
            {
                SQL = "SELECT* FROM TbLaptop ORDER BY Cost ASC";
            }
            else
            {
                SQL = "SELECT* FROM TbLaptop ORDER BY Cost DESC";
            }

            Loaddata(SQL);
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand frm = new AddBrand();
            frm.ShowDialog();
        }
    }
}
