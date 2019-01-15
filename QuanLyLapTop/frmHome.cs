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
            btnTrangChu.BackColor = Color.White;
            btnThemSanPham.BackColor = Color.Teal;
            btnHistory.BackColor = Color.White;
            btnStatus.BackColor = Color.White;


            ThemSP ThemSP = new ThemSP();
            pnlThemSanPham.Size = new Size(1200, 590);
            pnlThemSanPham.Controls.Clear();
            pnlThemSanPham.Controls.Add(ThemSP);
            ThemSP.btnDelete.Visible = false;
            ThemSP.btnUpdate.Visible = false;

        }

        public void Edit(ThemSP ThemSP)
        {
            pnlThemSanPham.Size = new Size(1200, 590);
            pnlThemSanPham.Controls.Clear();
            pnlThemSanPham.Controls.Add(ThemSP);
            ThemSP.btnDelete.Visible = true;
            ThemSP.btnUpdate.Visible = true;
    
            btnTrangChu.BackColor = Color.White;
            btnThemSanPham.BackColor = Color.Teal;
          
        }
    
        private void frmHome_Load(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.Teal;
            btnThemSanPham.BackColor = Color.White;

            Home Home = new Home();
            Home.frm = this;
            pnlThemSanPham.Size = new Size(1200, 590);
            pnlThemSanPham.Controls.Clear();
            pnlThemSanPham.Controls.Add(Home);

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.Teal;
            btnThemSanPham.BackColor = Color.White;
            btnHistory.BackColor = Color.White;
            btnStatus.BackColor = Color.White;

            Home Home = new Home();
            Home.frm = this;
            pnlThemSanPham.Size = new Size(1200, 590);
            pnlThemSanPham.Controls.Clear();
            pnlThemSanPham.Controls.Add(Home);    
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.White;
            btnThemSanPham.BackColor = Color.White;
            btnHistory.BackColor = Color.Teal;
            btnStatus.BackColor = Color.White;


            LichSuBanHang History = new LichSuBanHang();
 
            pnlThemSanPham.Size = new Size(1200, 590);
            pnlThemSanPham.Controls.Clear();
            pnlThemSanPham.Controls.Add(History);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.White;
            btnThemSanPham.BackColor = Color.White;
            btnHistory.BackColor = Color.White;
            btnStatus.BackColor = Color.Teal;


            TinhTrangKhoHang Status = new TinhTrangKhoHang();
            pnlThemSanPham.Size = new Size(1200, 590);
            pnlThemSanPham.Controls.Clear();
            pnlThemSanPham.Controls.Add(Status);


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login frm = new Login();
            frm.Show();
        }
    }
}
