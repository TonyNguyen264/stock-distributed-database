using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CHUNGKHOAN.Reports
{
    public partial class DSLK : DevExpress.XtraReports.UI.XtraReport
    {
        public DSLK(String txtMaNDT, String txtMaCP)
        {
            InitializeComponent();
            var query = this.sqlDataSource1.Queries[0];
            query.Parameters[0].Value = txtMaNDT;
            query.Parameters[0].Value = txtMaCP;
            this.sqlDataSource1.Fill();
            lbMaNDT.Text = txtMaNDT;
            lbMaCP.Text = txtMaCP;
        }

    }
}
