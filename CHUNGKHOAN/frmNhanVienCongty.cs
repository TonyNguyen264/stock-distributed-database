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
    public partial class frmnhanviencongty : DevExpress.XtraEditors.XtraForm
    {

        int viTri = 0;
        /********************************************
         * đang thêm mới -> true -> đang dùng btnTHEM
         *              -> false -> có thể là btnGHI( chỉnh sửa) hoặc btnXOA
         *              
         * Mục đích: dùng biến này để phân biệt giữa btnTHEM - thêm mới hoàn toàn
         * và việc chỉnh sửa nhân viên( do mình ko dùng thêm btnXOA )
         * Trạng thái true or false sẽ được sử dụng 
         * trong btnGHI - việc này để phục vụ cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;

        String maCN = "";
        /**********************************************************
         * undoList - phục vụ cho btnHOANTAC -  chứa các thông tin của đối tượng bị tác động 
         * 
         * nó là nơi lưu trữ các đối tượng cần thiết để hoàn tác các thao tác
         * 
         * nếu btnGHI sẽ ứng với INSERT
         * nếu btnXOA sẽ ứng với DELETE
         * nếu btnCHUYENCHINHANH sẽ ứng với CHANGEBRAND
         **********************************************************/
        Stack undoList = new Stack();

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }


        private void BtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.nhanVienCongTyTableAdapter.Fill(this.DS.NhanVienCongTy);
                this.nhanVienCongTyGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        private bool kiemTraDuLieuDauVao()
        {
            /*            kiem tra txtMANV
            */
            if (txtmanhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtmanhanvien.Focus();
                return false;
            }
            else if (txtho.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtho.Focus();
                return false;

            }
            else if (txten.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txten.Focus();
                return false;

            }
            else if (txtsdt.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtsdt.Focus();
                return false;

            }

     
            else if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtdiachi.Focus();
                return false;

            }
            return true;
        }
        public frmnhanviencongty()
        {
            InitializeComponent();
        }

        private void nhanVienCongTyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVienCongty.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmnhanviencongty_Load(object sender, EventArgs e)
        {
   /*         // TODO: This line of code loads data into the 'DS.CongTyCK' table. You can move, or remove it, as needed.
            this.congTyCKTableAdapter.Fill(this.DS.CongTyCK);
            // TODO: This line of code loads data into the 'dS.NhanVienCongTy' table. You can move, or remove it, as needed.
            this.nhanVienCongTyTableAdapter.Fill(this.DS.NhanVienCongTy);
*/

            cmbCN.DataSource = Program.bdsDSPM;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.mCN;

            viTri = bdsNhanVienCongty.Position;
            /*            this.panelNhap.Enabled = true;
            */
            dangThemMoi = true;


            if (Program.Role.Trim() == "SOGD")
            {
                
                cmbCN.Enabled = true;
            }
            else
            {
                cmbCN.Enabled = false;
            }
            DS.EnforceConstraints = false;
            this.congTyCKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congTyCKTableAdapter.Fill(this.DS.CongTyCK);
            maCN = ((DataRowView)bdsCongTyCK[0])["MaCongTy"].ToString().Trim();

            this.nhanVienCongTyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienCongTyTableAdapter.Fill(this.DS.NhanVienCongTy);


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nhanVienCongTyGridControl_Click(object sender, EventArgs e)
        {

        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhanVienCongty.Position;
            /*            this.panelNhap.Enabled = true;
            */
            dangThemMoi = true;

            bdsNhanVienCongty.AddNew();
            txtmacongty.Text = maCN;
            txtmacongty.ReadOnly = true;
            this.txtmacongty.ReadOnly = false;

         /*   cmb.SelectedIndex = 1;
            cmbPhai.SelectedIndex = 0;*/
            /*            this.cmbPhai.ReadOnly = true;
            *//*
            this.BtnThem.Enabled = false;
            this.BtnXoa.Enabled = false;
            this.BtnGhi.Enabled = true;

            this.BtnHoanTac.Enabled = true;
            this.BtnLamMoi.Enabled = false;
            this.BtnChuyenCN.Enabled = false;
            this.BtnThoat.Enabled = false;
            this.chbTTX.Enabled = false;
            this.chbTTX.Checked = false;

            this.nhanVienGridControl.Enabled = false;*/
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaNV = ((DataRowView)bdsNhanVienCongty[bdsNhanVienCongty.Position])["MaNhanVien"].ToString();
            /*Step 1*/

            // khong cho xoa nguoi dang dang nhap ke ca nguoi do khong co don hang - phieu nhap - phieu xuat
            if (MaNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsNhanVienCongty.Count == 0)
            {
                BtnXoa.Enabled = false;
            }
 

            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa hoàn toàn nhân viên này?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                String cauTruyVan =
                "DECLARE	@result int " +
                "EXEC @result = [dbo].[sp_Kiem_Tra_Xoa_NhanVien_quydinh] '" +
                MaNV + "' " +
                "SELECT 'Value' = @result"; ;
                SqlCommand sqlCommand = new SqlCommand("", Program.conn);
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Nhân viên đã tạo quy định không thể xóa");
                    return;
                }
                else if (result == 0)
                {
                    DialogResult ds1 = MessageBox.Show("bạn có chắc muốn xóa hoàn toàn nhân viên này?\nThao tác này không thể hoàn tác!!", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds1 == DialogResult.Yes)
                    {
                        try
                        {
   
                            bdsNhanVienCongty.RemoveCurrent();              // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
/*                            bdsNhanVienCongty.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
*/                           this.nhanVienCongTyTableAdapter.Update(this.DS.NhanVienCongTy);
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

        private void BtnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            String maNhanVien = txtmanhanvien.Text.Trim();// Trim() de loai bo khoang trang thua
          /*  DataRowView drv = ((DataRowView)bdsNhanVienCongty[bdsNhanVienCongty.Position]);
            String ho = drv["HO"].ToString();
            String ten = drv["TEN"].ToString();

            String ngaysinh = drv["NGAYSINH"].ToString();
            String phai = drv["PHAI"].ToString();
            String daichi = drv["DIACHI"].ToString();
            String sodt = drv["SODT"].ToString();
            String macongty = drv["MaCongTy"].ToString();
            int trangThai = 0;*/


            String cauTruyVanMaNV =
                   "DECLARE	@result int " +
                   "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNhanVien_congty] '" +
                   maNhanVien + "' " +
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

            int viTriConTro = bdsNhanVienCongty.Position;
            int viTriMaNhanVien = bdsNhanVienCongty.Find("MaNhanVien", txtmanhanvien.Text);

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

                        this.txtmanhanvien.Enabled = false;
                        this.bdsNhanVienCongty.EndEdit();
                        this.nhanVienCongTyTableAdapter.Update(this.DS.NhanVienCongTy);
                    
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsNhanVienCongty.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}