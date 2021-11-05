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
    public partial class Frm_KetQua : Form
    {
        Connection kn = new Connection();
        public Frm_KetQua()
        {
            InitializeComponent();
        }
  
        private void Frm_KetQua_Load(object sender, EventArgs e)
        {
            DataGrid_KQ.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form MDI = new MDI();
            MDI.Show();
            this.Hide();
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
            }
            else
            {
                
                MessageBox.Show("Số báo danh không tồn tại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtb_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
