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
    public partial class Login : Form
    {
        Database Db = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") lblPassWordNull.Visible = true;
            else lblPassWordNull.Visible = false;

            if (txtUsename.Text == "") lblUseNameNull.Visible = true;
            else lblUseNameNull.Visible = false;

            Db.Connection_Open();

            string SQL = "SELECT UseName FROM TbLogin WHERE UseName='" + txtUsename.Text + "' AND PassWord= '" + txtPassword.Text + "'";
            
            OleDbCommand Cmd = new OleDbCommand(SQL, Db.Connec);
        
            OleDbDataReader ReadDb = Cmd.ExecuteReader();

            if (ReadDb.Read())
            {
                this.Hide();
                frmHome frm = new frmHome();
                frm.ShowDialog();
            }
            else
            {
                lblFaillLogin.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
