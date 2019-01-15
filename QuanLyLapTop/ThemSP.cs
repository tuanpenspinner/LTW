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
    public partial class ThemSP : UserControl
    {
        Database Db = new Database();
        string ImagePath = "";
        bool sts = false;
        public ThemSP()
        {
            InitializeComponent();
            LoadData();
        }

        private void ThemSP_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            Db.Connection_Open();
            string SQL = "SELECT NameBrand FROM TbCategory";
            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();

            cmbHangSX.DataSource = dt;
            cmbHangSX.DisplayMember = "NameBrand";
            cmbHangSX.ValueMember = "NameBrand";

            Db.Connection_Close();
        }

        public void SetLaptop(Laptop laptop)
        {

            txtNameLaptop.Text = laptop.Name;
            ID = laptop.IDLaptop;
            for (int i = 0; i < cmbHangSX.Items.Count; i++)
            {
                if (laptop.Brand.Equals(cmbHangSX.GetItemText(cmbHangSX.Items[i])))
                    cmbHangSX.SelectedIndex = i;
            }

            for (int i = 0; i < cmbMucDichSD.Items.Count; i++)
            {
                if (laptop.Funtion.Equals(cmbMucDichSD.GetItemText(cmbMucDichSD.Items[i])))
                    cmbMucDichSD.SelectedIndex = i;
            }

            txtGia.Text = laptop.Cost.ToString();

            for (int i = 0; i < cbmLoaiOCung.Items.Count; i++)
            {
                if (laptop.Hard.Equals(cbmLoaiOCung.GetItemText(cbmLoaiOCung.Items[i])))
                    cbmLoaiOCung.SelectedIndex = i;
            }
            txtRAM.Text = laptop.Ram.ToString();
            txtDungLuong.Text = laptop.Memory.ToString();
            txtKichThuocManHinh.Text = laptop.Desktop.ToString();
            txtCardManHinh.Text = laptop.Card;
            if (laptop.Species == rdoOnBoard.Text)
            {
                rdoOnBoard.Checked = true;
            }

            if (laptop.Species == rdoRoi.Text)
            {
                rdoRoi.Checked = true;
            }

            if (laptop.Species == rdoRoiOn.Text)
            {
                rdoRoiOn.Checked = true;
            }

            for (int i = 0; i < cmbDoPhanGiai.Items.Count; i++)
            {
                if (laptop.Resolution.Equals(cmbDoPhanGiai.GetItemText(cmbDoPhanGiai.Items[i])))
                    cmbDoPhanGiai.SelectedIndex = i;
            }

            for (int i = 0; i < cmbCPU.Items.Count; i++)
            {
                if (laptop.CPU.Equals(cmbCPU.GetItemText(cmbCPU.Items[i])))
                    cmbCPU.SelectedIndex = i;
            }

            txtKhoiLuong.Text = laptop.Weight.ToString();
            txtSoLuong.Text = laptop.Number.ToString();
            if(laptop.ImagePath!="")
            {
                picImage.Image = Image.FromFile(laptop.ImagePath);
            } 
            ImagePath = laptop.ImagePath;
            chkNgungKinhDoanh.Checked = laptop.Status;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(opf.FileName);
                ImagePath = opf.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Upd();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (KT())
            {
                try
                {
                    string LoaiCard = "";
                    if (rdoRoi.Checked == true)
                    {
                        LoaiCard = "Rời";

                    }
                    if (rdoOnBoard.Checked == true)
                    {
                        LoaiCard = "OnBoard";

                    }
                    if (rdoRoiOn.Checked == true)
                    {
                        LoaiCard = "Rời + OnBoard";
                    }
                    Db.Connection_Open();
                    string SQL = "INSERT INTO TbLaptop ([Name],[Brand],[Funt],[Cost],[Hard],[RAM],[Memory],[Desktop],[Species],[Card],[CPU],[Resolution],[Weight],[Num],[Img])"
                        + "VALUES('" + txtNameLaptop.Text + "','" + cmbHangSX.Text + "','" + cmbMucDichSD.SelectedItem.ToString() + "','" + Convert.ToInt32(txtGia.Text) + "','" + cbmLoaiOCung.SelectedItem.ToString() + "','" + txtRAM.Text + "','" + txtDungLuong.Text + "','" + Convert.ToDouble(txtKichThuocManHinh.Text) + "','" + LoaiCard + "','" + txtCardManHinh.Text + "','" + cmbCPU.SelectedItem.ToString() + "','" + cmbDoPhanGiai.SelectedItem.ToString() + "','" + Convert.ToDouble(txtKhoiLuong.Text) + "','" + Convert.ToInt32(txtSoLuong.Text) + "','" + ImagePath + "')";
                    Db.Exc(Db.Connec, SQL);
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                    Db.Connection_Close();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ giữ liệu");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            chkNgungKinhDoanh.Checked = true;
            Upd();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KT()
        {
            if (txtCardManHinh.Text == "" || txtDungLuong.Text == "" || txtGia.Text == "" || txtKhoiLuong.Text == "" || txtKichThuocManHinh.Text == "" || txtNameLaptop.Text == "" || txtSoLuong.Text == "" || lblKichThuocManHinh.Text == "" || cbmLoaiOCung.Text == "" || cmbDoPhanGiai.Text == "" || cmbHangSX.Text == "" || cmbMucDichSD.Text == "" || cbmLoaiOCung.Text == "")
            {
                return false;
            }
            return true;
        }

        private void Upd()
        {
            string LoaiCard = "";
            if (KT())
            {
                if (rdoRoi.Checked == true)
                {
                    LoaiCard = "Rời";

                }
                if (rdoOnBoard.Checked == true)
                {
                    LoaiCard = "OnBoard";

                }
                if (rdoRoiOn.Checked == true)
                {
                    LoaiCard = "Rời + OnBoard";
                }

                if (chkNgungKinhDoanh.Checked == true)
                {
                    sts = true;
                }
                else
                {
                    sts = false;
                }
                Db.Connection_Open();
                OleDbCommand cmd = Db.Connec.CreateCommand();
                cmd.CommandText = " UPDATE TbLaptop SET Name = @name, Brand = @brand,Funt=@funtion,Cost = @cost,Hard = @hard,"
                   + "RAM = @ram,Memory = @memory,Desktop = @desktop,Species = @species,Card = @card"
               + ",CPU = @CPU,Resolution = @resolution,Weight =@weight,Num = @num,Img = @img,Status = @status"
                   + " WHERE [ID] = " + ID;

                cmd.Parameters.AddWithValue("@name", txtNameLaptop.Text);
                cmd.Parameters.AddWithValue("@brand", cmbHangSX.GetItemText(cmbHangSX.Items[cmbHangSX.SelectedIndex]));
                cmd.Parameters.AddWithValue("@funtion", cmbMucDichSD.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@cost", Convert.ToInt32(txtGia.Text));
                cmd.Parameters.AddWithValue("@hard", cbmLoaiOCung.GetItemText(cbmLoaiOCung.Items[cbmLoaiOCung.SelectedIndex]));

                cmd.Parameters.AddWithValue("@ram", Convert.ToInt32(txtRAM.Text));
                cmd.Parameters.AddWithValue("@memory", Convert.ToInt32(txtDungLuong.Text));
                cmd.Parameters.AddWithValue("@desktop", Convert.ToDouble(txtKichThuocManHinh.Text));
                cmd.Parameters.AddWithValue("@species", LoaiCard);
                cmd.Parameters.AddWithValue("@card", txtCardManHinh.Text);

                cmd.Parameters.AddWithValue("@CPU", cmbCPU.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@resolution", cmbDoPhanGiai.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@weight", Convert.ToDouble(txtKhoiLuong.Text));
                txtSoLuong.Text = (Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(txtThem.Text)).ToString();
                cmd.Parameters.AddWithValue("@num", Convert.ToInt32(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@img", ImagePath);
                cmd.Parameters.AddWithValue("@status", sts);

                cmd.ExecuteNonQuery();

                Db.Connection_Close();

            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
