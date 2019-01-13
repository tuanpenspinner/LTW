using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QuanLyLapTop
{
   public class Database
    {
        public OleDbConnection Connec { get; set; }
        public void Connection_Open()
        {
            try
            {
                string dir = AppDomain.CurrentDomain.BaseDirectory;
                string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+dir+"Database.mdb";
                Connec = new OleDbConnection(strConnection);
                Connec.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Exc(OleDbConnection Connec, string SQL)
        {
            OleDbCommand cmd = new OleDbCommand(SQL, Connec);
            cmd.ExecuteNonQuery();
        }

        public void Connection_Close()
        {
            Connec.Close();
        }
    }
}
