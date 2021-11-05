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
    public partial class PCN : Form
    {
        public PCN()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("select * from DiemThi");
            PhieuCaNhan pcn = new PhieuCaNhan();
            pcn.SetDataSource(dta);
            CRV1.ReportSource = pcn;

        }
    }
}
