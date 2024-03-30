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
    public partial class frmPhatHanh : DevExpress.XtraEditors.XtraForm
    {
        int vitriPH = 0;

        Boolean isEditingTK = false;
        String maCN;
        DateTime now = DateTime.Now;
        public frmPhatHanh()
        {
            InitializeComponent();
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Sô lượng không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtSoLuong.Focus();
                return false;
            }
            else if (txtMaCoPhieu.Text.Trim() == "")
            {
                MessageBox.Show("Mã cổ phiếu không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaCoPhieu.Focus();
            }
            else if (dteNgay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày phát hành!", "Thông báo!", MessageBoxButtons.OK);
            }
        
                return true;
        }

        private void frmPhatHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.phatHanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phatHanhTableAdapter.Fill(this.DS.PhatHanh);
            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.

            this.coPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.coPhieuTableAdapter.Fill(this.DS.CoPhieu);
            // TODO: This line of code loads data into the 'dS.sp_HienThiKhachHang' table. You can move, or remove it, as needed.
 

        /*    string MaCoPhieu = ((DataRowView)bdsCoPhieu[0])["MaCoPhieu"].ToString().Trim();*/
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
/*            DataRowView currentCP = (DataRowView)bdsCoPhieu.Current;
*//*            txtMaCoPhieu.Focus();
*/            vitriPH = bdsPhatHanh.Position;
            isEditingTK = true;
            bdsPhatHanh.AddNew();
            phatHanhGridControl.Enabled = false;
            txtMaCoPhieu.ReadOnly = false;
            txtMaCoPhieu.Focus();
            coPhieuGridControl.Enabled = true;
      
/*            txtMaCoPhieu.Text = (string)currentCP["MaCoPhieu"];
*/            

            dteNgay.EditValue = now;
            BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = false;
        }

        private void coPhieuGridControl_Click(object sender, EventArgs e)
        {
          /* txtMaCoPhieu.Text = ((DataRowView)bdsCoPhieu[bdsCoPhieu.Position])["MaCPhieu"].ToString().Trim();*/
            DataRowView currentCP = (DataRowView)bdsCoPhieu.Current;
            txtMaCoPhieu.Text = (string)currentCP["MaCoPhieu"];
        }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            
         if (isEditingTK == true)
            {
             /*   DateTime NGAYMOTK = (DateTime)((DataRowView)bdsTK[bdsTK.Position])["NGAYMOTK"];*/
                string themnph =
               string.Format("INSERT INTO DBO.PhatHanh(MaCoPhieu,Ngay, SoLuongPhatHanh)" +
                "VALUES('{0}',CAST({1} AS DATETIME),{2} )",
                 txtMaCoPhieu.Text.ToString(), now.ToString("yyyy-dd-mm"), txtSoLuong.Text);
                if (Program.KetNoi() == 0)
                {
                    return;
                }

                int n = Program.ExecSqlNonQuery(themnph);
                isEditingTK = false;
                phatHanhGridControl.Enabled = true;
                BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                coPhieuGridControl.Enabled = false;
                MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
            }
           else
            {
                try
                {
                    bdsPhatHanh.EndEdit();            // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                    bdsPhatHanh.ResetCurrentItem();           // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                    this.phatHanhTableAdapter.Update(this.DS.PhatHanh);         // cập nhật dl từ dataset về database thông qua tableadapter
                    isEditingTK = false;
                    phatHanhGridControl.Enabled = true;
                    BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                    coPhieuGridControl.Enabled = false;
                    MessageBox.Show("Lưu thành công!", "Thông báo !", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi phát hành cổ phiếu. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phatHanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phatHanhTableAdapter.Fill(this.DS.PhatHanh);
            if (isEditingTK == true)
            {
                bdsPhatHanh.CancelEdit();
                bdsPhatHanh.Position = vitriPH;
                phatHanhGridControl.Enabled = true;
                txtMaCoPhieu.ReadOnly = true;
                BtnThem.Enabled = BtnXoa.Enabled = BtnThoat.Enabled = true;
                isEditingTK = false;
                coPhieuGridControl.Enabled = false;
            }
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
                DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa phát hành cổ phiếu ?", "Thông báo !", MessageBoxButtons.YesNo);
                if (ds == DialogResult.Yes)
                {
                    try
                    {
                        bdsPhatHanh.RemoveCurrent();         //xóa row đang chọn ra khỏi dataset
                        this.phatHanhTableAdapter.Update(this.DS.PhatHanh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phát hành. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
  
            }
        }

        private void phatHanhGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}