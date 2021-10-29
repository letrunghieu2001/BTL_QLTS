using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TuyenSinh
{
    public partial class Frm_Truong : Form
    {
        public Frm_Truong()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void Trường_Load(object sender, EventArgs e)
        {
            ChiTietTruong();
        }

        private void ChiTietTruong()
        {
            DataTable dta = kn.Lay_Dulieu("Select * from ChiTietTruong");
            cbo_id.DataSource = cbo_name.DataSource = dta;
            cbo_id.DisplayMember = "matruong";
            cbo_name.DisplayMember = "tentruong";
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_id_CheckedChanged(object sender, EventArgs e)
        {
            cbo_id.Focus();
            cbo_id.Enabled = true;
            cbo_name.Enabled = false;
        }

        private void rbtn_name_CheckedChanged(object sender, EventArgs e)
        {
            cbo_name.Focus();
            cbo_id.Enabled = false;
            cbo_name.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql_search;
            DataTable dta = new DataTable();
            if (rbtn_id.Checked == true)
            {
                sql_search = "select * from ChiTietTruong where matruong =  '" + cbo_id.Text + "'";
                dta = kn.Lay_Dulieu(sql_search);
            }
            if (rbtn_name.Checked == true)
            {
                sql_search = "select * from ChiTietTruong where tentruong = '" + cbo_name.Text + "'";
                dta = kn.Lay_Dulieu(sql_search);
            }
           
            dataGridView1.DataSource = dta;
        }

        private void cbo_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
