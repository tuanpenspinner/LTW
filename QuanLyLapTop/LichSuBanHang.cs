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
    public partial class LichSuBanHang : UserControl
    {
        Database Db = new Database();
        public LichSuBanHang()
        {
            InitializeComponent();
            cmbSearch.SelectedIndex = 0;
        }

        private void LichSuBanHang_Load(object sender, EventArgs e)
        {
            Db.Connection_Open();
            string SQL = "SELECT * FROM TbSell";

            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            dataGridView.DataSource = dt;

            Db.Connection_Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbSearch.Text== "Theo tên khách hàng")
            {
                SerchTenKhachHang();
            }

            if (cmbSearch.Text == "Theo tên laptop")
            {
                SerchTenLaptop();
            }
            if (cmbSearch.Text == "Theo loại laptop")
            {
                SerchHangLaptop();
            }
            if(cmbSearch.Text=="Tất cả")
            {
                SerchAll();
            }
        }

        private void SerchAll()
        {
            Db.Connection_Open();
            string SQL = "SELECT * FROM TbSell";

            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            dataGridView.DataSource = dt;

            Db.Connection_Close();
        }

        private void SerchTenKhachHang()
        {
            Db.Connection_Open();
            string SQL = "SELECT * FROM TbSell WHERE NameCustomer = '"+txtSearch.Text+"'";

            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            dataGridView.DataSource = dt;

            Db.Connection_Close();
        }

        private void SerchTenLaptop()
        {
            Db.Connection_Open();
            string SQL = "SELECT * FROM TbSell WHERE NameLaptop='" + txtSearch.Text + "'";

            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            dataGridView.DataSource = dt;

            Db.Connection_Close();
        }

        private void SerchHangLaptop()
        {
            Db.Connection_Open();
            string SQL = "SELECT * FROM TbSell WHERE Brand='" + txtSearch.Text + "'";

            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            dataGridView.DataSource = dt;

            Db.Connection_Close();
        }


    }
}
