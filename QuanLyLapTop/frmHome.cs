using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QuanLyLapTop
{
    public partial class frmHome : Form
    {
        Database Db = new Database();
        public frmHome()
        {
            InitializeComponent();

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            var btnLap = sender as btnEditLaptop;
            frmLaptop frm = new frmLaptop();

            frm.btnAdd.Visible = true;
            frm.btnUpdate.Visible = false;
            frm.btnDelete.Visible = false;
            frm.btnTrangChu.BackColor = Color.White;
            frm.btnThemSanPham.BackColor = Color.Teal;
            frm.ShowDialog();
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
                laptop.Status =Convert.ToBoolean(dr["Status"]);
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
                if(laptop.Status)
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
                pic.Image = Image.FromFile(laptop.ImagePath);
                pic.MouseLeave += Pic_MouseLeave;
                pic.MouseMove += Pic_MouseMove;
                Tol.ToolTipTitle = "Thông tin sản phẩm";
                Tol.ToolTipIcon = ToolTipIcon.Info;
                Tol.SetToolTip(pic, laptop.ToString());


                //Tạo button bán
                Button btnSell = new Button();
                btnSell.Text = "Bán";
                btnSell.Location = new Point(50, 350);
                btnSell.AutoSize = true;
                btnSell.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnSell.ForeColor = Color.Red;

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
                if(laptop.Number==0)
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.Teal;
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            string SQL = "SELECT * FROM Tblaptop";
            Loaddata(SQL);
        }
        //Load lại màn hình 
        private void frmHome_Load_Search(object sender, EventArgs e)
        {
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
            string name = "'" + "%" + txtSearch.Text + "%" + "'";
            string SQL = "SELECT* FROM TbLaptop WHERE Name LIKE " + name + "";

            Loaddata(SQL);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var btn = sender as btnEditLaptop;
            frmLaptop frm = new frmLaptop();
            frm.btnDelete.Visible = true;
            frm.SetLaptop(btn.laptop);
            frm.btnAdd.Visible = false;
            frm.btnUpdate.Visible = true;
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            frmHome_Load_Search(sender, e);

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

            frmHome_Load(sender, e);
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {

            if (cmbBrand.Text == "Tất cả")
            {
                frmHome_Load_ALL(sender, e);
            }
            else
            {
                frmHome_Load_Fitler(sender, e);
            }
        }

        private void frmHome_Load_Fitler(object sender, EventArgs e)
        {
            string SQL;
            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
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
        private void frmHome_Load_ALL(object sender, EventArgs e)
        {
            string SQL;

            while (flwHome.Controls.Count > 0) flwHome.Controls.RemoveAt(0);
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
    }
}
