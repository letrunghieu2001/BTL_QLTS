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
    public partial class Frm_HoSoTuyenSinh : Form
    {
        public Frm_HoSoTuyenSinh()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HoSoTuyenSinh()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from HoSoTuyenSinh");
            HIENTHIDULIEU();
            dataGridView1.DataSource = dta;
        }

        private void HIENTHIDULIEU()
        {
            txtb_id_hs.DataBindings.Clear();
            txtb_id_hs.DataBindings.Add("Text", dataGridView1.DataSource, "sohoso");
        }
        private void Frm_HoSoTuyenSinh_Load(object sender, EventArgs e)
        {
            HoSoTuyenSinh();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtb_id_hs.Text = txtb_name.Text = txtb_sbd.Text= txtb_id_truong.Text=txtb_name_truong.Text = "";
        }
    }
}
