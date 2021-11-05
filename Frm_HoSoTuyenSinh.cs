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
            Form MDI = new MDI();
            MDI.Show();
            this.Hide();
        }
        private void HoSoTuyenSinh()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from HoSoTuyenSinh");
            DataGrid_HSTS.DataSource = dta;
            HIENTHIDULIEU();
       
        }
        private void GioiTinh()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from GioiTinh");
            cbogt.DataSource = dta;
            cbogt.DisplayMember = "gioitinh";
        }
        
        private void NganhHoc()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from NganhHoc");
            DataGrid_HSTS.DataSource = dta;
            cbomn.DataSource = dta;
            cbomn.DisplayMember = "manganh";
            cbonh.DataSource = dta;
            cbonh.DisplayMember = "tennganh";
            cbomk.DataSource = dta;
            cbomk.DisplayMember = "makhoi";
        }


        private void HIENTHIDULIEU()
        {
            txtsbd.DataBindings.Clear();
            txtsbd.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "sbd");
            txtht.DataBindings.Clear();
            txtht.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "hoten");
            datetime.DataBindings.Clear();
            datetime.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "ngaysinh");
            cbogt.DataBindings.Clear();
            cbogt.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "gioitinh");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "diachi");
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "dienthoai");
            txtcmnd.DataBindings.Clear();
            txtcmnd.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "socmt");
            cbomk.DataBindings.Clear();
            cbomk.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "makhoi");
            cbomn.DataBindings.Clear();
            cbomn.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "manganh");
            cbonh.DataBindings.Clear();
            cbonh.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "tennganh");



        }
        private void Frm_HoSoTuyenSinh_Load(object sender, EventArgs e)
        {
            GioiTinh();
            NganhHoc();
            HoSoTuyenSinh();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtsbd.Text = txtht.Text = datetime.Text = cbogt.Text = txtdiachi.Text = txtsdt.Text = txtcmnd.Text = cbomk.Text = cbomn.Text = cbonh.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql_luu;
            sql_luu = "insert into HoSoTuyenSinh values (N'" + txtsbd.Text + "',N'" + txtht.Text + "','" + datetime.Text + "',N'" + cbogt.Text + "',N'"+txtdiachi.Text+"','"+txtsdt.Text+"','"+txtcmnd.Text+"','"+cbomk.Text+"','"+cbomn.Text+"',N'"+cbonh.Text+"')";
            kn.ThucThi(sql_luu);
            HoSoTuyenSinh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbmv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbodc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtht_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sql_update;
            sql_update = "Update HoSoTuyenSinh set hoten = N'" + txtht.Text + "',ngaysinh = '" + datetime.Text + "', gioitinh = N'" + cbogt.Text + "', diachi = N'" + txtdiachi.Text + "', dienthoai = '" + txtsdt.Text + "', socmt = '" + txtcmnd.Text + "', makhoi = '" + cbomk.Text + "', manganh = '" + cbomn.Text + "', tennganh = N'" + cbonh.Text + "' where sbd = '" + txtsbd.Text + "'";
            kn.ThucThi(sql_update);
            HoSoTuyenSinh();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "Delete HoSoTuyenSinh where sbd ='" + txtsbd.Text + "'";
            kn.ThucThi(sql_xoa);
            HoSoTuyenSinh();
        }
    }
}
