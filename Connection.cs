using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_TuyenSinh
{
    class Connection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
            string strKetnoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYTUYENSINH;Integrated Security=True;MultipleActiveResultSets=true;";
            cnn = new SqlConnection(strKetnoi);
            cnn.Open();

        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_Dulieu(string sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;

        }
        public void exec(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
        public void ThucThi(String sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
