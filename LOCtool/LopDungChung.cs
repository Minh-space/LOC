using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOCtool
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project Measurements\Group1\LOCtool\Database.mdf"";Integrated Security=True";
        SqlConnection conn;

        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public DataTable LoadDuLieu(string sqlLoadCombo)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlLoadCombo, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } // end LoadDuLieu
        public void Nonquery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1)
                    MessageBox.Show("SUCCESS !");
                else MessageBox.Show("Error!!");
            } catch
            {
                MessageBox.Show("Error!!");
            }finally
            {
                conn.Close();
            }
        } // end Nonquery

        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int dem = (int)comm.ExecuteScalar();
            conn.Close();
            return dem;
        }

        public void Nonquery_LoadNam(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon,conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
        }
    }

}
