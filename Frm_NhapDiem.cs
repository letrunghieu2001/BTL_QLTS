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
    public partial class Frm_NhapDiem : Form
    {
        public Frm_NhapDiem()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void NhapDiem()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From DiemThi");
            DataGrid_NhapDiem.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void MaMon()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select mamon From MonThi");
            cbomm.DataSource = dta;
            cbomm.DisplayMember = "mamon";
        }
        private void HIENTHIDULIEU()
        {
            txtsbd.DataBindings.Clear();
            txtsbd.DataBindings.Add("Text", DataGrid_NhapDiem.DataSource, "sbd");
            txtkt.DataBindings.Clear();
            txtkt.DataBindings.Add("Text", DataGrid_NhapDiem.DataSource, "makhoi");
            txtht.DataBindings.Clear();
            txtht.DataBindings.Add("Text", DataGrid_NhapDiem.DataSource, "hoten");
            cbomm.DataBindings.Clear();
            cbomm.DataBindings.Add("Text", DataGrid_NhapDiem.DataSource, "mamon");
            txtdt.DataBindings.Clear();
            txtdt.DataBindings.Add("Text", DataGrid_NhapDiem.DataSource, "diemthi");

            
        }

        private void Frm_NhapDiem_Load(object sender, EventArgs e)
        {
            MaMon();
            NhapDiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsbd.Text = txtkt.Text = txtht.Text = cbomm.Text = txtdt.Text = "";
            txtsbd.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ktra = "Select sbd from HoSoTuyenSinh where sbd = '" + txtsbd.Text + "'";
            SqlCommand cmd = new SqlCommand(ktra, kn.cnn);
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read() == false)
            {
                MessageBox.Show("Không có thông tin sinh viên. " +
                                "Mời bạn nhập lại thông tin sinh viên trong phần hồ sơ tuyển sinh  !", "Thông Báo");
                read.Close();
                read.Dispose();
            }
            else
            {
                string sql_luu;
                sql_luu = "insert into DiemThi values (N'" + txtsbd.Text + "',N'" + txtkt.Text + "',N'" + txtht.Text + "',N'" + cbomm.Text + "','" + txtdt.Text + "')";
                kn.ThucThi(sql_luu);
                NhapDiem();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql_update;
            sql_update = "Update DiemThi set hoten = N'" + txtht.Text + "', makhoi = N'" + txtkt.Text + "', mamon = N'" + cbomm.Text + "', diemthi = '" + txtdt.Text + "' where sbd = '" + txtsbd.Text + "'";
            kn.ThucThi(sql_update);
            NhapDiem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "Delete DiemThi where sbd ='" + txtsbd.Text + "'";
            kn.ThucThi(sql_xoa);
            NhapDiem();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form MDI = new MDI();
            MDI.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DataGrid_NhapDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql_sbd = "select sbd from DiemThi where sbd = '" + txtsbd.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_sbd, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read())
            {
                txtsbd.Text = datRed["sbd"].ToString();

                string sql_tong = "select SUM(diemthi) AS tongdiem from DiemThi where sbd = '" + txtsbd.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql_tong, kn.cnn);
                SqlDataReader datRed1 = cmd1.ExecuteReader();
                if (datRed1.Read())
                {
                    txtt.DataBindings.Clear();
                    txtt.Text = datRed1["tongdiem"].ToString();
                }
            }
        }
    }
    
}
