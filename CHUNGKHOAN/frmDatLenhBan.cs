using DevExpress.CodeParser;
using DevExpress.XtraEditors;
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

namespace CHUNGKHOAN
{
    public partial class frmDatLenhBan : DevExpress.XtraEditors.XtraForm
    {
        string ndt = Program.userName;

        public void loadtaiKhoan()
        {

            string sql = "Select sotaikhoan from dbo.TaiKhoanNganHang where MaNDT='" + ndt + "'";
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cb_tk.Properties.Items.Add(row["sotaikhoan"].ToString());
                }
            }
        }
        public void loadMaCoPhieu()
        {
            string sql = "Select MaCoPhieu from dbo.SoHuu";
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cb_MaCoPHieu.Properties.Items.Add(row["MaCoPhieu"].ToString());
                }
            }
        }
        public void laygiaCP()
        {
            string maCoPhieu = cb_MaCoPHieu.Text;
            try
            {
                string SP = "TinhToanGiaTheoMaCP";
                SqlParameter[] parameter =
                {
                    new SqlParameter("@MaCoPhieu",maCoPhieu)
                };
                DataTable dt = Program.LoadSP(SP, parameter);
                if (dt.Rows.Count > 0)
                {
                    double giaThamChieu = Convert.ToDouble(dt.Rows[0]["GiaThamChieu"]);
                    double giaTran = Convert.ToDouble(dt.Rows[0]["GiaTran"]);
                    double giaSan = Convert.ToDouble(dt.Rows[0]["GiaSan"]);
                    txtGiaThamChieu.Text = giaThamChieu.ToString();
                    txt_giaTran.Text = giaTran.ToString();
                    txtsan.Text = giaSan.ToString();
                }
                else
                {
                    MessageBox.Show("Mã cổ phiếu chưa có dữ liệu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }

        }
        public frmDatLenhBan()
        {
            InitializeComponent();
            loadMaCoPhieu();
            // Đặt interval cho Timer (ví dụ 1000ms = 1 giây)
            timer1.Interval = 1000;

            // Đăng ký sự kiện Tick của Timer
            timer1.Tick += timer1_Tick;

            // Bắt đầu Timer
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void txt_maNDT_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ndt))
            {

            }
           
        }

        private void cb_tk_EditValueChanged(object sender, EventArgs e)
        {

            string sql = "Select SoTaiKhoan,SoDu from dbo.TaiKhoanNganHang where MaNDT='" + ndt + "'";
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                txtSoDu.Text = dt.Rows[0]["SoDu"].ToString();
                txt_stk.Text = dt.Rows[0]["SoTaiKHoan"].ToString();
            }


        }

        private void cmbLoaiLenh_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbLoaiLenh.Text == "MB")
            {
                txtGia.Text = txtGiaThamChieu.Text;
                txtGia.Enabled = false;
            }
        }

        
        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            int slban = Convert.ToInt32(txtSoLuongDat.Text);
            string sql1 = "Select SoLuong from SoHuu where MaNDT='" + ndt + "' and MaCoPhieu='" + cb_MaCoPHieu.Text + "'";
            DataTable soluongsohuu = Program.ExecSqlDataTable(sql1);
            if (soluongsohuu.Rows.Count == 1)
            {
                int soHuu = Convert.ToInt32(soluongsohuu.Rows[0]["SoLuong"].ToString());
                if (slban <= soHuu && slban >= 100)
                {
                    string matkhaudatlenh;
                    string sql = "Select MatKhauDatLenh from NhaDauTu where MaNDT='" + ndt + "'";
                    DataTable dt = Program.ExecSqlDataTable(sql);
                    if (dt.Rows.Count == 1)
                    {
                        matkhaudatlenh = dt.Rows[0]["MatKhauDatLenh"].ToString();
                        if (txtMK.Text == matkhaudatlenh)
                        {
                            try
                            {
                                string loaigd = "Ban";
                                int giaban = Convert.ToInt32(txtGia.Text);

                                string SP = "DatLenhBan";
                                SqlParameter outputParameter = new SqlParameter();
                                outputParameter.ParameterName = "@MaTrangThai";
                                outputParameter.Direction = ParameterDirection.Output;
                                outputParameter.SqlDbType = SqlDbType.NVarChar;
                                outputParameter.Size = 100;
                                SqlParameter[] parameter =
                                {
                                    new SqlParameter("@LoaiGiaoDich",loaigd),
                                    new SqlParameter("@GiaBan",giaban),
                                    new SqlParameter("@SoLuongBan",Convert.ToInt16(txtSoLuongDat.Text)),
                                        new SqlParameter("@ThoiGian",dateTimePicker1.Value),
                                        new SqlParameter("@MaCoPhieu", cb_MaCoPHieu.Text),
                                        new SqlParameter("@MaLoaiLenh",cmbLoaiLenh.Text),
                                         new SqlParameter("@SoTaiKHoan", txt_stk.Text),
                                        outputParameter

                                };

                                DataTable dt2 = Program.LoadSP(SP, parameter);
                                if (dt2.Rows.Count > 0)
                                {
                                    string trangthai = dt2.Rows[0]["@MaTrangThai"].ToString();
                                    MessageBox.Show("Lệnh đặt bán thành công: " + trangthai);
                                }
                                else
                                {
                                    MessageBox.Show("Lệnh đặt bán thất bại");
                                }
                            }
                            catch (Exception ezz)
                            {
                                MessageBox.Show("Lỗi kết nối" + ezz.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không khớp");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng bán >=100 và không vượt quả số lượng sở hữu");
                }

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

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void cb_MaCoPHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            laygiaCP();
        }

        private void frmDatLenhBan_Load(object sender, EventArgs e)
        {
            ndt = Program.userName;
            loadtaiKhoan(); 

        }


     

        private void cb_tk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select SoTaiKhoan,SoDu from dbo.TaiKhoanNganHang where MaNDT='" + ndt + "'";
            DataTable dt = Program.ExecSqlDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                txtSoDu.Text = dt.Rows[0]["SoDu"].ToString();
                txt_stk.Text = dt.Rows[0]["SoTaiKHoan"].ToString();
            }
        }


   

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            float slban = float.Parse(txtSoLuongDat.Text);
            float giaban = float.Parse(txtGia.Text);
            double thanhtien = slban * giaban;
            txtTongTien.Text = thanhtien.ToString();
        }

   
    }
}