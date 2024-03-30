using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace CHUNGKHOAN.Reports
{
    public partial class frmDSLK : DevExpress.XtraEditors.XtraForm
    {
        public frmDSLK()
        {
            InitializeComponent();
        }

        private void frmDSLK_Load(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(txtMaCP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã cổ phiếu", "Thông báo !", MessageBoxButtons.OK);
                txtMaCP.Focus();
                return;
            }

            if (CheckNDT(txtMaNDT.Text.Trim()) == 0)
            {
                MessageBox.Show("Nhà đầu tư không tồn tại", "Thông báo", MessageBoxButtons.OK);
                txtMaNDT.Text = "";
                txtMaNDT.Focus();
                return;
            }
            else
            {


                btnXem.Enabled = true;
                DSLK report = new DSLK(txtMaNDT.Text.Trim(), txtMaCP.Text.Trim());
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
                return;
            }
        }
        public int CheckNDT(string MaNDT)
        {
            String MaNhaDauTu = MaNDT;// Trim() de loai bo khoang trang thua
            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[SP_KiemTraTonTaiNDT] '" +
                   MaNDT + "' " +
                   "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            return result;


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