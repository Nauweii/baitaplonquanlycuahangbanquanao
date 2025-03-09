using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplonquanlycuahangbanquanao
{
    internal class hamdungchung
    {
        public string str = @"Data Source=TRANDUY;Initial Catalog=quanlycuahangbanquanao;Integrated Security=True";
        public SqlConnection cnn = new SqlConnection();

        public static bool thuchiendoanmasql(string constr, string sqlinsert)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlinsert, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        public bool ketnoi()
        {
            try
            {
                if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
                cnn.ConnectionString = str;
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("loi ket noi");
                return false;
            }
            return true;

        }

        public DataTable getTable(string tenbang)
        {
            string sql = "Select * from " + tenbang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }

        public void loadgridview(string bangmuonnhapjdulieu, DataGridView dgv)
        {
            if (ketnoi() == false)
            {
                return;
            }
            try
            {
                DataTable dt = getTable(bangmuonnhapjdulieu);
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dt.Dispose();
            }
            catch { MessageBox.Show("box"); }
        }


        public void loadcombobox(string tenbang, ComboBox cmb)
        {
            DataTable tbl = getTable(tenbang);
            cmb.DataSource = tbl;
            cmb.ValueMember = tbl.Columns[0].ColumnName;
            cmb.DisplayMember = tbl.Columns[1].ColumnName;
        }

        public static bool thuchienkiemtrakhoachinh(string constr, int Ma, string bangthuchien)
        {
            string sqlinsert = $"SELECT * from dbo.tblSinhVien Where '{bangthuchien}' = '{Ma}' ";
            bool check;
            check = false;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlinsert, cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read() == true) check = true;
                        else check = false;
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            Console.WriteLine("check");
            Console.WriteLine(check);
            return check;
        }


    }
}
