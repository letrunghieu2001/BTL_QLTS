using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_TuyenSinh
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void button1_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();

            string DN = txtdn.Text;
            string MK = txtmk.Text;
            string sql_login = "select user_id, password from LOGIN where user_id = '" + DN + "' and password = '" + MK + "'";
            //Ten dang nhap: admin 
            //Mat khau: 1

            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("Đăng Nhập Thành Công !");
                Form MDI = new MDI();
                MDI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!");
                txtdn.Focus();
            }
        }
    }
 }

