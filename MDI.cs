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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form HSTS = new Frm_HoSoTuyenSinh();
            HSTS.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form PBD = new Frm_PhieuBaoDiem();
            PBD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ND = new Frm_NhapDiem();
            ND.Show();
            this.Hide();
        }
    }
}
