using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOAN
{
    public partial class frmtknganhang : DevExpress.XtraEditors.XtraForm
    {

        int vitriTK = 0;

        Boolean isEditingTK = false;
        String maCN;
 

        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaNDT.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhà đầu tư không không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaNDT.Focus();
                return false;
            }
            else if (txtSoDu.Text.Trim() == "")
            {
                MessageBox.Show("Số dư không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoDu.Focus();
            }
            else if (txtSTK.Text.Trim() == "")
            {
                MessageBox.Show("số tài khoản không được bỏ trống!", "Thông báo!", MessageBoxButtons.OK);
            }

            return true;
        }
        public frmtknganhang()
        {
            InitializeComponent();
        }

        

        private void frmtknganhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.NganHang' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'DS.TaiKhoanNganHang' table. You can move, or remove it, as needed.
        

/*            this.nhaDauTuTableAdapter.Fill(this.DS.NhaDauTu);*/

            this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDauTuTableAdapter.Fill(this.DS.NhaDauTu);

            this.taiKhoanNganHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanNganHangTableAdapter.Fill(this.DS.TaiKhoanNganHang);


            this.nganHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nganHangTableAdapter.Fill(this.DS.NganHang);
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView currentNDT = (DataRowView)bdsNDT.Current;
            txtMaNDT.Focus();

               }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* bool ketQua = kiemTraDuLieuDauVao();

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
                *//*                DateTime NGAYMOTK = (DateTime)((DataRowView)bdsTKGiaoDich[bdsTKGiaoDich.Position])["NGAYMOTK"];
                *//*
                string themntaikhoan =
             string.Format("INSERT INTO LINK0.CHUNGKHOAN.DBO.TaiKhoanGiaoDich(MATKGD,MaCongTy,NgayMoTaiKhoan,MaNDT)" +
         "VALUES('{0}','{1}',CAST({2} AS DATETIME),'{3}')",
         txtMaTKGD.Text, txtMaCongTy.Text, dteNgay.Text.ToString(), txtMaNDT.Text.ToString());
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
            }*/
        }

        private void BtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*this.nhaDauTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaDauTuTableAdapter.Fill(this.DS.NhaDauTu);

            this.taiKhoanNganHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanNganHangTableAdapter.Fill(this.DS.TaiKhoanNganHang);


            this.nganHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nganHangTableAdapter.Fill(this.DS.NganHang);
        
            if (isEditingTK == true)
            {
                bdsTKGiaoDich.CancelEdit();
                bdsTKGiaoDich.Position = vitriTK;
                taiKhoanGiaoDichGridControl.Enabled = true;
                txtMaNDT.ReadOnly = true;
                BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                isEditingTK = false;
                sp_HienThiNDTGridControl.Enabled = false;
            }*/
        }
    }
}