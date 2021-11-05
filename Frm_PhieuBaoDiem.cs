using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TuyenSinh
{
    public partial class Frm_PhieuBaoDiem : Form
    {

        Connection kn = new Connection();
        public Frm_PhieuBaoDiem()
        {
            InitializeComponent();
        }

        private void lbl_info_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_search = "Select * from DiemThi where sbd = '" + txtsbd.Text + "'";
            dta = kn.Lay_Dulieu(sql_search);

            SqlCommand cmd = new SqlCommand(sql_search, kn.cnn);

            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read() == true)
            {
                DataGrid_KQ.DataSource = dta;
                DataGrid_KQ.Enabled = true;

                txtkhoi.DataBindings.Clear();
                txtkhoi.DataBindings.Add("Text", DataGrid_KQ.DataSource, "makhoi");

                string sql_diemchuan = "Select diemchuan from DiemChuan INNER JOIN NganhHoc on DiemChuan.makhoi = NganhHoc.makhoi where Diemchuan.makhoi = '" + txtkhoi.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql_diemchuan, kn.cnn);
                SqlDataReader datRed1 = cmd1.ExecuteReader();
                if (datRed1.Read())
                {
                    txtdiemchuan.Text = datRed1["diemchuan"].ToString();

                    string sql_tong = "select SUM(diemthi) AS tongdiem from DiemThi where sbd = '" + txtsbd.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(sql_tong, kn.cnn);
                    SqlDataReader datRed3 = cmd3.ExecuteReader();
                    if (datRed3.Read())
                    {
                        txtt.DataBindings.Clear();
                        txtt.Text = datRed3["tongdiem"].ToString();
                    }

                    string sql_ketqua = "SELECT SUM(diemthi) AS tongdiem, CASE WHEN SUM(diemthi) >= " + txtdiemchuan.Text + " THEN 'Do' ELSE 'Truot' END AS ketqua FROM DiemThi WHERE DiemThi.sbd = '" + txtsbd.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(sql_ketqua, kn.cnn);
                    SqlDataReader datRed2 = cmd2.ExecuteReader();
                    if (datRed2.Read())
                    {
                        txtketqua.Text = datRed2["ketqua"].ToString();
                    }


                }






            }
            else
            {

                MessageBox.Show("Số báo danh không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_PhieuBaoDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYTUYENSINHDataSet.DiemChuan' table. You can move, or remove it, as needed.
            

        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
