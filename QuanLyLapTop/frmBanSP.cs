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
    public partial class frmBanSP : Form
    {

        SellLaptop Selllatop = new SellLaptop();
        Database Db = new Database();
        public frmBanSP()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = 0;
            
        }
        public void SellLaptop(Laptop laptop)
        {
            Selllatop.IDLaptop = laptop.IDLaptop;
            Selllatop.NameLaptop = laptop.Name;
            Selllatop.Brand = laptop.Brand;
            Selllatop.Cost = laptop.Cost;

            lblCost.Text = String.Format("{0:0,0 VNĐ}", laptop.Cost);
            lblNameLaptop.Text = laptop.Name;
            lblNameBrand.Text = laptop.Brand;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            Selllatop.Status = cmbStatus.SelectedItem.ToString();
            if(lblSumMoney.Text=="" ||txtNameCustomer.Text==""||txtPhonNumber.Text==""|| nudNumber.Value <= 0 || nudNumber.Value > GetNumber())
            {
              
                    MessageBox.Show("Dữ liệu chưa hợp lệ");   
            }
           else
            {
                Sell();
                UpDateNumber();
                MessageBox.Show("Bán thành công");
                this.Dispose();

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Selllatop.NameCustomer = txtNameCustomer.Text;
            Selllatop.PhoneNumber = txtPhonNumber.Text;
            Selllatop.NumberSell = Convert.ToInt32(nudNumber.Value);
            Selllatop.Date_Time = datDate.Value;
            Selllatop.Sell = Convert.ToInt32(txtSell.Text);
            Selllatop.TongTien = Convert.ToInt32(Selllatop.Cost * Selllatop.NumberSell *Convert.ToDouble((100-Selllatop.Sell)/100.0));
            lblSumMoney.Text = String.Format("{0:0,0 VNĐ}", Selllatop.TongTien);
        }

        private void Sell()
        {
            Db.Connection_Open();
            String SQL = "INSERT INTO TbSell VALUES('" + Selllatop.IDLaptop + "','" + Selllatop.NameLaptop + "',"
               +"'" + Selllatop.Cost + "','" + Selllatop.Brand + "','" + Selllatop.NameCustomer + "',"
               +"'" + Selllatop.PhoneNumber + "','" + Selllatop.NumberSell + "','" + Selllatop.Date_Time + "','" + Selllatop.TongTien + "',"
               +"'" + Selllatop.Sell + "','" + Selllatop.Status + "')";
            Db.Exc(Db.Connec, SQL);
            Db.Connection_Close();
        }

        private void UpDateNumber()
        {
            Db.Connection_Open();

            int number = GetNumber();
            number -= Selllatop.NumberSell;
            string SQL = "UPDATE TbLaptop SET Num = '" + number + "' WHERE ID=" + Selllatop.IDLaptop;
            Db.Exc(Db.Connec, SQL);
            Db.Connection_Close();
        }

        private int GetNumber()
        {

            int number = 0;
            Db.Connection_Open();
            string SQL = "SELECT Num FROM Tblaptop WHERE ID=" + Selllatop.IDLaptop;
            OleDbCommand cmd = new OleDbCommand(SQL, Db.Connec);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                number = Convert.ToInt32(dr["Num"]);
            }
            return number;
        }

        private void frmBanSP_Load(object sender, EventArgs e)
        {

        }
    }
}
