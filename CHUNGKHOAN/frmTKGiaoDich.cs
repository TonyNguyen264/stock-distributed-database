using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOAN
{
    public partial class frmTKGiaoDich : DevExpress.XtraEditors.XtraForm
    {
        public frmTKGiaoDich()
        {
            InitializeComponent();
        }





        int vitriTK = 0;

        Boolean isEditingTK = false;
        String maCN;
        DateTime now = DateTime.Now;
     
        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaTKGD.Text.Trim() == "")
            {
                MessageBox.Show("Sô lượng không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaTKGD.Focus();
                return false;
            }
            else if (txtMaCongTy.Text.Trim() == "")
            {
                MessageBox.Show("Mã cổ phiếu không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaCongTy.Focus();
            }
            else if (dteNgay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày phát hành!", "Thông báo!", MessageBoxButtons.OK);
            }

            return true;
        }

    

        private void frmTKGiaoDich_Load(object sender, EventArgs e) { 

            cmbCN.DataSource = Program.bdsDSPM;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.mCN;

            DS.EnforceConstraints = false;
            this.congTyCKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congTyCKTableAdapter.Fill(this.DS.CongTyCK);
            maCN = ((DataRowView)bdsCongTyCK[0])["MaCongTy"].ToString().Trim();

            // TODO: This line of code loads data into the 'DS.sp_HienThiNDT' table. You can move, or remove it, as needed.
            this.sp_HienThiNDTTableAdapter.Fill(this.DS.sp_HienThiNDT);
            // TODO: This line of code loads data into the 'DS.TaiKhoanGiaoDich' table. You can move, or remove it, as needed.
            this.taiKhoanGiaoDichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanGiaoDichTableAdapter.Fill(this.DS.TaiKhoanGiaoDich);



        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataRowView currentNDT = (DataRowView)bdsNDT.Current;
            txtMaNDT.Focus();

            vitriTK = bdsTKGiaoDich.Position;
            isEditingTK = true;
            bdsTKGiaoDich.AddNew();
            taiKhoanGiaoDichGridControl.Enabled = false;
            txtMaNDT.ReadOnly = false;
            txtMaCongTy.Focus();
            sp_HienThiNDTGridControl.Enabled = true;
            txtMaNDT.Text = (string)currentNDT["MaNDT"];
            dteNgay.EditValue = now;
            BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = false; 
        }

        

        
       

 

        private void sp_HienThiNDTGridControl_Click(object sender, EventArgs e)
        {
            /*DataRowView currentNDT = (DataRowView)bdsNDT.Current;
            txtMaNDT.Text = (string)currentNDT["MaNDT"];*/
        }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();

            String TKGD = txtMaTKGD.Text.Trim();// Trim() de loai bo khoang trang thua
            String cauTruyVan =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_TraCuu_KiemtramaTKGD] '" +
                   TKGD + "' " +
                   "SELECT 'Value' = @result"; ;
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

           
            if (result == 1 && isEditingTK == true)
            {
                MessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else if (result == 0 && isEditingTK == true)
            {
/*                DateTime NGAYMOTK = (DateTime)((DataRowView)bdsTKGiaoDich[bdsTKGiaoDich.Position])["NGAYMOTK"];
*/                string themntaikhoan =
               string.Format("INSERT INTO LINK0.CHUNGKHOAN.DBO.TaiKhoanGiaoDich(MATKGD,MaCongTy,NgayMoTaiKhoan,MaNDT)" +
           "VALUES('{0}','{1}',CAST({2} AS DATETIME),'{3}')",
           txtMaTKGD.Text, txtMaCongTy.Text, dteNgay.Text.ToString(),txtMaNDT.Text.ToString());
                if (Program.KetNoi() == 0)
                {
                    return;
                }

                int n = Program.ExecSqlNonQuery(themntaikhoan);
                isEditingTK = false;
                taiKhoanGiaoDichGridControl.Enabled = true;
                BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                sp_HienThiNDTGridControl.Enabled = false;
                MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    bdsTKGiaoDich.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                    bdsTKGiaoDich.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                    this.taiKhoanGiaoDichTableAdapter.Update(this.DS.TaiKhoanGiaoDich);         // cập nhật dl từ dataset về database thông qua tableadapter
                    isEditingTK = false;
                    taiKhoanGiaoDichGridControl.Enabled = true;
                    BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                    sp_HienThiNDTGridControl.Enabled = false;
                    MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi tài khoản. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taiKhoanGiaoDichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanGiaoDichTableAdapter.Fill(this.DS.TaiKhoanGiaoDich);
            if (isEditingTK == true)
            {
                bdsTKGiaoDich.CancelEdit();
                bdsTKGiaoDich.Position = vitriTK;
                taiKhoanGiaoDichGridControl.Enabled = true;
                txtMaNDT.ReadOnly = true;
                BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                isEditingTK = false;
                sp_HienThiNDTGridControl.Enabled = false;
            }
        }
    }
}