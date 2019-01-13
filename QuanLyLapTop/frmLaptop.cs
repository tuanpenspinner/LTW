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
    public partial class frmLaptop : Form
    {
        Database Db = new Database();
        string ImagePath = "";
        public frmLaptop()
        {
            InitializeComponent();
        }

        private void frmLaptop_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
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
                string SQL = "INSERT INTO TbLaptop ([Name],[Brand],[Funtion],[Cost],[Hard],[RAM],[Memory],[Desktop],[Species],[Card],[CPU],[Resolution],[Weight],[Number],[Image])"
                    + "VALUES('" + txtNameLaptop.Text + "','" + cmbHangSX.Text + "','" + cmbMucDichSD.SelectedItem.ToString() + "','" + Convert.ToInt32(txtGia.Text) + "','" + cbmLoaiOCung.SelectedItem.ToString() + "','" + txtRAM.Text + "','" + txtDungLuong.Text + "','" + Convert.ToDouble(txtKichThuocManHinh.Text) + "','" + LoaiCard + "','" + txtCardManHinh.Text + "','" + cmbCPU.SelectedItem.ToString() + "','" + txtKichThuocManHinh.Text + "','" + Convert.ToDouble(txtKhoiLuong.Text) + "','" + Convert.ToInt16(txtSoLuong.Text) + "','" + ImagePath+ "')";
                Db.Exc(Db.Connec, SQL);
                MessageBox.Show("Thêm sản phẩm thành công");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();

            frmHome frm = new frmHome();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
