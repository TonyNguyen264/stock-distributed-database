using DevExpress.XtraCharts.Native;
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
    public partial class frmDatLenhMua : DevExpress.XtraEditors.XtraForm
    {
        db.ConnectDB cn = new db.ConnectDB();
        public frmDatLenhMua()
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

        private void frmDatLenhMua_Load(object sender, EventArgs e)
        {

            

        }
  
        public void loadtaiKhoan()
        {

            string sql = "Select MaNganHang from dbo.TaiKhoanNganHang where MaNDT='" + txt_maNDT.Text + "'";
            DataTable dt = cn.LoadDL(sql);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cb_tk.Properties.Items.Add(row["MaNganHang"].ToString());
                }
            }
        }
        public void loadMaCoPhieu()
        {
            string sql = "Select MaCoPhieu from dbo.CoPhieu";
            DataTable dt = cn.LoadDL(sql);
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
                DataTable dt = cn.LoadSP(SP, parameter);
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
                MessageBox.Show("");
            }


        }
        private void cb_MaCoPHieu_EditValueChanged(object sender, EventArgs e)
        {
            laygiaCP();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void txt_maNDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            int slMua = Convert.ToInt32(txtSoLuongDat.Text);
            int giaMua = Convert.ToInt32(txtGia.Text);
            double thanhtien = slMua * giaMua;
            txtTongTien.Text = thanhtien.ToString();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           dateTimePicker1.Value=DateTime.Now;
        }

        private void btnDatLenh_Click_1(object sender, EventArgs e)
        {
            string sql1 = "select SoDu from dbo.TaiKhoanNganHang where MaNganHang='"+cb_tk.Text+"' and MaNDT='"+txt_maNDT.Text+"' ";
            DataTable soDu = cn.LoadDL(sql1);
            if (soDu.Rows.Count == 1)
            {
                double sodu = Convert.ToDouble(soDu.Rows[0]["SoDu"].ToString());
                double tt = Convert.ToDouble(txtTongTien.Text);
                int slmua = Convert.ToInt32(txtSoLuongDat.Text);
                if (tt <= sodu)
                {
                    if (slmua >= 100)
                    {
                        string matkhaudatlenh;
                        string sql3 = "Select MatKhauDatLenh from NhaDauTu where MaNDT='" + txt_maNDT.Text + "'";
                        DataTable dt = cn.LoadDL(sql3);
                        if (dt.Rows.Count == 1)
                        {
                            matkhaudatlenh = dt.Rows[0]["MatKhauDatLenh"].ToString();
                            if (txtMK.Text == matkhaudatlenh)
                            {
                                try
                                {
                                    string loaigd = "Mua";
                                    int giaMua = Convert.ToInt32(txtGia.Text);

                                    string SP = "DatLenhMua";
                                    SqlParameter outputParameter = new SqlParameter();
                                    outputParameter.ParameterName = "@MaTrangThai";
                                    outputParameter.Direction = ParameterDirection.Output;
                                    outputParameter.SqlDbType = SqlDbType.NVarChar;
                                    outputParameter.Size = 100;
                                    SqlParameter[] parameter =
                                    {
                                    new SqlParameter("@LoaiGiaoDich",loaigd),
                                    new SqlParameter("@GiaMua",giaMua),
                                    new SqlParameter("@SoLuongMua",Convert.ToInt32(txtSoLuongDat.Text)),
                                    new SqlParameter("@ThoiGian",dateTimePicker1.Value),
                                    new SqlParameter("@MaCoPhieu", cb_MaCoPHieu.Text),
                                    new SqlParameter("@MaLoaiLenh",cmbLoaiLenh.Text),
                                     new SqlParameter("@SoTaiKHoan", txt_stk.Text),
                                    outputParameter

                                };

                                    DataTable dt2 = cn.LoadSP(SP, parameter);
                                    if (dt2.Rows.Count > 0)
                                    {
                                        string trangthai = dt2.Rows[0]["@MaTrangThai"].ToString();
                                        MessageBox.Show("Lệnh đặt mua thành công: " + trangthai);
                                        try
                                        {
                                            double sodusaugiaodich = Convert.ToDouble(txtSoDu.Text) - Convert.ToDouble(txtTongTien.Text);
                                            string sql4 = "Update TaiKhoanNganhang set SoDu='"+sodusaugiaodich+"'where SoTaiKhoan='"+txt_stk.Text+"'";
                                            cn.LoadDL(sql4);
                                            txtSoDu.Text = sodusaugiaodich.ToString();
                                            MessageBox.Show("Số dư vừa được cập nhật");

                                        }
                                        catch { }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lệnh đặt mua thất bại");
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
                        MessageBox.Show("Số lượng mua >=100");
                    }
                }
                else
                {
                    MessageBox.Show("SỐ dư tài khoản không đủ giao dịch!!");
                }
               
            }
        }

        private void cb_tk_EditValueChanged(object sender, EventArgs e)
        {
            string sql = "select SoTaiKhoan, SoDu  from TaiKhoanNganHang where MaNDT='" + txt_maNDT.Text + "' and MaNganHang='" + cb_tk.Text + "'";
            DataTable dt= cn.LoadDL(sql);
            if (dt.Rows.Count > 0)
            {
                string stk =dt.Rows[0]["SoTaiKhoan"].ToString();
                txt_stk.Text = stk;
                string sodu = dt.Rows[0]["SoDu"].ToString();
                txtSoDu.Text = sodu;
            }
        }

        private void txt_maNDT_EditValueChanged(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maNDT.Text))
            {
            /*    cb_tk.;*/
            }
            else
            {loadtaiKhoan();

            }
            
        }
    }
}