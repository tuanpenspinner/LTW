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
    public partial class TinhTrangKhoHang : UserControl
    {
        Database Db = new Database();
        public TinhTrangKhoHang()
        {
            InitializeComponent();
        }

        private void TinhTrangKhoHang_Load(object sender, EventArgs e)
        {
            Db.Connection_Open();
            string SQL = "SELECT Name,Brand,Cost,Num,Status FROM TbLaptop";

            OleDbDataAdapter da = new OleDbDataAdapter(SQL, Db.Connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Db.Connection_Close();
            dataGridView.DataSource = dt;

            Db.Connection_Close();
        }
    }
}
