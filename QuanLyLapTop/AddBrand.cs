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
    public partial class AddBrand : Form
    {
        Database Db = new Database();
        public AddBrand()
        {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if(txtAddBrand.Text!="")
            {
                Db.Connection_Open();
                string SQL = "INSERT INTO TbCategory ([NameBrand]) VALUES('" + txtAddBrand.Text +"')";
                Db.Exc(Db.Connec, SQL);
                MessageBox.Show("Thêm hãng laptop thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
