using DevExpress.XtraBars;
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
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm

    {

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

        public frmmain()
        {
            InitializeComponent();
        }
        public void status()
        {
            toolStripStatusLabel2.Text = Program.Hoten + "  " + Program.userName + "  " + Program.Role;
        }
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
            Program.serverName = "";//servername
            Program.serverNameLeft = "";
            Program.userName = "";//username mã nhân viên hoặc cmnd
            Program.loginName = "";//mlogin gõ tên 
            Program.loginPassword = "";//password pass 
            Program.currentLogin = "";//mloginDN
            Program.currentPassword = "";//passwordDN
            Program.Role = "";// mGroup CHi nhanh -0 NGAN hàng 1 khach 2
            Program.Hoten = "";//mHoten họ tên
            status();
    }


        private void btndangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            /*frmdangnhap form = new frmdangnhap();
           *//* form.MdiParent = this;*//*
            form.Show();
*/
            Form f = this.CheckExists(typeof(frmdangnhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmdangnhap form = new frmdangnhap();
                form.MdiParent = this;
                form.Show();
            }

        }


        private void btnNhanVienCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmnhanviencongty));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmnhanviencongty form = new frmnhanviencongty();
                form.MdiParent = this;
                form.Show();
            }
        }

   


      

        private void btnNhaDauTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmnhadautu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmnhadautu form = new frmnhadautu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {

            DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                logout();

          /*      BtnDangNhap.Enabled = true;
                BtnDangXuat.Enabled = false;
                RBGiaoDich.Visible = false;
                RBadmin.Visible = false;
                RBBaoCao.Visible = false;*/

            }
        }

        private void btnNhanVienSan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmNhanVienSan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmNhanVienSan form = new frmNhanVienSan();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTKNganHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmtknganhang));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmtknganhang form = new frmtknganhang();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTKGiaoDich_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmTKGiaoDich));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmTKGiaoDich form = new frmTKGiaoDich();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmPhatHanh));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmPhatHanh form = new frmPhatHanh();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnCoPhieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmCapNhatCoPhieu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmCapNhatCoPhieu form = new frmCapNhatCoPhieu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDatLenhMua_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDatLenhMua));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDatLenhMua form = new frmDatLenhMua();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDatLenhBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDatLenhBan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDatLenhBan form = new frmDatLenhBan();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}