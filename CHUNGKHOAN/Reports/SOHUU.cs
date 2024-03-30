using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CHUNGKHOAN.Reports
{
    public partial class SOHUU : DevExpress.XtraReports.UI.XtraReport
    {
        public SOHUU(String txtMaNDT)
        {
            InitializeComponent();
            var query = this.sqlDataSource1.Queries[0];
            query.Parameters[0].Value = txtMaNDT;
            this.sqlDataSource1.Fill();
            lbMaNDT.Text = txtMaNDT;

        }

    }
}
