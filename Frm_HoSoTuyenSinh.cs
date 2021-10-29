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
            DataGrid_HSTS.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void MaVung()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from DoiTuongUuTien");
            DataGrid_HSTS.DataSource = dta;
            cbbmv.DataSource = dta;
            cbbmv.DisplayMember = "mavung";
           
        }
        private void MaDVDK()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * from ChiTietDVDK");
            cbbmdv.DataSource = dta;
            cbbmdv.DisplayMember = "madv_DKDT";
          
        }

        private void HIENTHIDULIEU()
        {
            txtshs.DataBindings.Clear();
            txtshs.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "sohoso");
            txtdtut.DataBindings.Clear();
            txtdtut.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "doituonguutien");
            txtsbd.DataBindings.Clear();
            txtsbd.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "sbd");
            txtht.DataBindings.Clear();
            txtht.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "tenthisinh");
            datetime.DataBindings.Clear();
            datetime.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "ngaysinh");
            txtmt.DataBindings.Clear();
            txtmt.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "matruong");
            txttt.DataBindings.Clear();
            txttt.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "tentruong");
            cbbmv.DataBindings.Clear();
            cbbmv.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "mavung");
            cbbmdv.DataBindings.Clear();
            cbbmdv.DataBindings.Add("Text", DataGrid_HSTS.DataSource, "madv_DKDT");


        }
        private void Frm_HoSoTuyenSinh_Load(object sender, EventArgs e)
        {
            MaDVDK();
            MaVung();
            HoSoTuyenSinh();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtshs.Text = txtht.Text = txtsbd.Text= txtmt.Text = txttt.Text = cbbmv.Text = cbbmdv.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sql_luu;
            sql_luu = "insert into HoSoTuyenSinh values ('" + txtshs.Text + "','" + txtmt.Text + "','" + txttt.Text + "','" + txtsbd.Text + "','" + txtht.Text + "','"+datetime.Text+"','"+cbbmv.Text+"','"+txtdtut.Text+"','"+cbbmdv.Text+"')";
            kn.ThucThi(sql_luu);
            HoSoTuyenSinh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
