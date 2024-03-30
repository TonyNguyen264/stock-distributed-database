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
    public partial class frmnhadautu : DevExpress.XtraEditors.XtraForm
    {

        int viTri = 0;
        bool dangThemMoi = false;
        String maCN = "";
        public frmnhadautu()
        {
            InitializeComponent();
        }

        private bool kiemTraDuLieuDauVao()
        {
            /*            kiem tra txtMANV
            */
            if (txtMaNDT.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaNDT.Focus();
                return false;
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;

            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;

            }
            else if (txtPhai.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtPhai.Focus();
                return false;

            }

            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;

            }
            return true;
        }

        private void frmnhadautu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NhaDauTu' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DS.NhaDauTu' table. You can move, or remove it, as needed.

            dangThemMoi = true;

           
            this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDauTuTableAdapter.Fill(this.DS.NhaDauTu);
          


        }

  

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            String maNhaDauTu = txtMaNDT.Text.Trim();// Trim() de loai bo khoang trang thua
        /*    DataRowView drv = ((DataRowView)bdsNhanVienCongty[bdsNhanVienCongty.Position]);
            String ho = drv["HO"].ToString();
            String ten = drv["TEN"].ToString();

            String ngaysinh = drv["NGAYSINH"].ToString();
            String phai = drv["PHAI"].ToString();
            String daichi = drv["DIACHI"].ToString();
            String sodt = drv["SODT"].ToString();
            String macongty = drv["MaCongTy"].ToString();
            int trangThai = 0;
*/

            String cauTruyVanMaNV =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNDT] '" +
                   maNhaDauTu + "' " +
                   "SELECT 'Value' = @result"; ;

            /*       String cauTruyVanCMND =
                           "DECLARE	@result int " +
                           "EXEC @result = [dbo].[sp_TraCuu_KiemTraCMND] '" +
                           CMND + "' " +
                           "SELECT 'Value' = @result"; ;*/
            SqlCommand sqlCommand = new SqlCommand(cauTruyVanMaNV, Program.conn);
            Program.myReader = Program.ExecSqlDataReader(cauTruyVanMaNV);

            Program.myReader.Read();
            int result_MaNV = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsNhaDauTu.Position;
            int viTriMaNhanVien = bdsNhaDauTu.Find("MaNDT", txtMaNDT.Text);

            if (result_MaNV == 1 && viTriConTro != viTriMaNhanVien)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else/*them moi | sua nhan vien*/
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        BtnThem.Enabled = true;
                        BtnXoa.Enabled = true;
                        BtnGhi.Enabled = true;
                        BtnHoanTac.Enabled = true;

                        BtnLamMoi.Enabled = true;
                        BtnThoat.Enabled = true;

                        this.txtMaNDT.Enabled = false;
                        this.bdsNhaDauTu.EndEdit();
                        this.nhaDauTuTableAdapter.Update(this.DS.NhaDauTu);
                        
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsNhaDauTu.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnLamMoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.nhaDauTuTableAdapter.Fill(this.DS.NhaDauTu);
                this.nhaDauTuGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhaDauTu.Position;
            /*            this.panelNhap.Enabled = true;
            */
            dangThemMoi = true;
            bdsNhaDauTu.AddNew();

        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
  
            if (bdsNhaDauTu.Count == 0)
            {
                BtnXoa.Enabled = false;
            }


            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa hoàn toàn nhà đầu tu này?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                String cauTruyVan =
                "DECLARE	@result int " +
                "EXEC @result = [dbo].[sp_Kiem_Tra_Xoa_NhaDauTu_TaiKhoan] '" +
                txtMaNDT.Text.ToString() + "' " +
                "SELECT 'Value' = @result"; ;
                SqlCommand sqlCommand = new SqlCommand("", Program.conn);
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Nhà đầu tư đã có tài khoản không thể xóa");
                    return;
                }
                else if (result == 0)
                {
                    DialogResult ds1 = MessageBox.Show("bạn có chắc muốn xóa hoàn toàn nhà đầu tư này?\nThao tác này không thể hoàn tác!!", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds1 == DialogResult.Yes)
                    {
                        try
                        {

                            bdsNhaDauTu.RemoveCurrent();              // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                            /*                            bdsNhanVienCongty.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                            */
                            this.nhaDauTuTableAdapter.Update(this.DS.NhaDauTu);
                            MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa login. Xóa thất bại" + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }

            }

        }

       
    }
}