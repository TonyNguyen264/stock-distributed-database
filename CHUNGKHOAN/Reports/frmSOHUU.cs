using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOAN.Reports
{
    public partial class frmSOHUU : DevExpress.XtraEditors.XtraForm
    {
        public frmSOHUU()
        {
            InitializeComponent();
        }

        private void frmSOHUU_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNDT.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà đầu tư", "Thông báo !", MessageBoxButtons.OK);
                txtMaNDT.Focus();
                return;
            }
            else
            {

                btnXem.Enabled = true;
                SOHUU report = new SOHUU(txtMaNDT.Text.Trim());
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy ?",
                  "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}