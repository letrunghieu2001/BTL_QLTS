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
    public partial class PBD : Form
    {
        public PBD()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DiemThi");
            PhieuBaoDiem pbd = new PhieuBaoDiem();
            pbd.SetDataSource(dta);
            CRV.ReportSource = pbd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form MDI = new MDI();
            MDI.Show();
            this.Hide();
        }
    }
}
