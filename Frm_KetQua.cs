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
            // TODO: This line of code loads data into the 'bTL_QLtuyensinhDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.bTL_QLtuyensinhDataSet.KetQua);
            dataGridView_Ketqua.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql_search = "Select * from KetQua where sbd = '" + txtb_id.Text + "'";
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu(sql_search);

            SqlCommand cmd = new SqlCommand(sql_search, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read() == true)
            {
                dataGridView_Ketqua.DataSource = dta;
                dataGridView_Ketqua.Enabled = true;
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
