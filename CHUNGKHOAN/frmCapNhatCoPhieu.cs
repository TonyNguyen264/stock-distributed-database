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
    public partial class frmCapNhatCoPhieu : DevExpress.XtraEditors.XtraForm
    {

        int viTri = 0;
        bool dangThemMoi = false;
        String maCN = "";
        public frmCapNhatCoPhieu()
        {
            InitializeComponent();
        }

        private void frmCapNhatCoPhieu_Load(object sender, EventArgs e)
        {            // TODO: This line of code loads data into the 'dS.NhaDauTu' table. You can move, or remove it, as needed.
            this.coPhieuTableAdapter.Fill(this.DS.CoPhieu);
            // TODO: This line of code loads data into the 'DS.NhaDauTu' table. You can move, or remove it, as needed.
            this.coPhieuTableAdapter.Fill(this.DS.CoPhieu);
            dangThemMoi = true;
            this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.coPhieuTableAdapter.Fill(this.DS.CoPhieu);
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsCoPhieu.Position;
            /*            this.panelNhap.Enabled = true;
            */
            dangThemMoi = true;
            bdsCoPhieu.AddNew();
        }



        private bool kiemTraDuLieuDauVao()
        {
            /*            kiem tra txtMANV
            */
            if (txtMaCP.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaCP.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtEmail.Focus();
                return false;

            }
            else if (txtFax.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtFax.Focus();
                return false;

            }
            else if (txtTenCongTy.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenCongTy.Focus();
                return false;

            }

            else if (txtSoDT.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoDT.Focus();
                return false;

            }
            return true;
        }




    


        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            String maCoPhieu = txtMaCP.Text.Trim();// Trim() de loai bo khoang trang thua

            String cauTruyVanMaNV =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaCP] '" +
                   maCoPhieu + "' " +
                   "SELECT 'Value' = @result"; ;

            SqlCommand sqlCommand = new SqlCommand(cauTruyVanMaNV, Program.conn);
            Program.myReader = Program.ExecSqlDataReader(cauTruyVanMaNV);

            Program.myReader.Read();
            int result_MaNV = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsCoPhieu.Position;
            int viTriMaNhanVien = bdsCoPhieu.Find("MaNhanVien", txtMaCP.Text);

            if (result_MaNV == 1 && viTriConTro != viTriMaNhanVien)
            {
                MessageBox.Show("Mã cổ phiếu này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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

                        this.txtMaCP.Enabled = false;
                        this.bdsCoPhieu.EndEdit();
                        this.coPhieuTableAdapter.Update(this.DS.CoPhieu);

                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsCoPhieu.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.coPhieuTableAdapter.Fill(this.DS.CoPhieu);
                this.coPhieuGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaNV = ((DataRowView)bdsCoPhieu[bdsCoPhieu.Position])["MaCoPhieu"].ToString();
            /*Step 1*/

      
            if (bdsCoPhieu.Count == 0)
            {
                BtnXoa.Enabled = false;
            }


            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa  cổ phiếu?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                String cauTruyVan =
                "DECLARE	@result int " +
                "EXEC @result = [dbo].[sp_Kiem_Tra_Xoa_CoPhieu] '" +
                MaNV + "' " +
                "SELECT 'Value' = @result"; ;
                SqlCommand sqlCommand = new SqlCommand("", Program.conn);
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Cổ phiếu đã tạo đã phát hành không thể xóa");
                    return;
                }
                else if (result == 0)
                {
                   try{

                            bdsCoPhieu.RemoveCurrent();              // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                            /*                            bdsNhanVienCongty.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                            */
                            this.coPhieuTableAdapter.Update(this.DS.CoPhieu);
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