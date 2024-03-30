
namespace CHUNGKHOAN
{
    partial class frmCapNhatCoPhieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatCoPhieu));
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label soDienThoaiLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label tenCongTyLabel;
            System.Windows.Forms.Label maCoPhieuLabel1;
            this.panel2 = new System.Windows.Forms.Panel();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.bar10 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.DS = new CHUNGKHOAN.DS();
            this.bdsCoPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.coPhieuTableAdapter = new CHUNGKHOAN.DSTableAdapters.CoPhieuTableAdapter();
            this.tableAdapterManager = new CHUNGKHOAN.DSTableAdapters.TableAdapterManager();
            this.coPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar11 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.colMaCoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDT = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtTenCongTy = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCP = new DevExpress.XtraEditors.TextEdit();
            websiteLabel = new System.Windows.Forms.Label();
            soDienThoaiLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            tenCongTyLabel = new System.Windows.Forms.Label();
            maCoPhieuLabel1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongTy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(websiteLabel);
            this.panel2.Controls.Add(this.txtWebsite);
            this.panel2.Controls.Add(soDienThoaiLabel);
            this.panel2.Controls.Add(this.txtSoDT);
            this.panel2.Controls.Add(faxLabel);
            this.panel2.Controls.Add(this.txtFax);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(tenCongTyLabel);
            this.panel2.Controls.Add(this.txtTenCongTy);
            this.panel2.Controls.Add(maCoPhieuLabel1);
            this.panel2.Controls.Add(this.txtMaCP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 672);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1954, 180);
            this.panel2.TabIndex = 28;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 46);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(1954, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 852);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(1954, 0);
            // 
            // bar10
            // 
            this.bar10.BarName = "Main menu";
            this.bar10.DockCol = 0;
            this.bar10.DockRow = 0;
            this.bar10.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar10.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar10.FloatSize = new System.Drawing.Size(926, 36);
            this.bar10.OptionsBar.MultiLine = true;
            this.bar10.OptionsBar.UseWholeRow = true;
            this.bar10.Text = "Main menu";
            // 
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar7.FloatSize = new System.Drawing.Size(926, 36);
            this.bar7.OptionsBar.MultiLine = true;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Main menu";
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar6.FloatSize = new System.Drawing.Size(926, 36);
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar5.FloatSize = new System.Drawing.Size(926, 36);
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar4.FloatSize = new System.Drawing.Size(926, 36);
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar3.FloatSize = new System.Drawing.Size(926, 36);
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar1.FloatSize = new System.Drawing.Size(926, 36);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(256, 222);
            this.bar2.FloatSize = new System.Drawing.Size(926, 36);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCoPhieu
            // 
            this.bdsCoPhieu.DataMember = "CoPhieu";
            this.bdsCoPhieu.DataSource = this.DS;
            // 
            // coPhieuTableAdapter
            // 
            this.coPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietQuyDinhCongTyTableAdapter = null;
            this.tableAdapterManager.ChiTietQuyDinhSanTableAdapter = null;
            this.tableAdapterManager.CongTyCKTableAdapter = null;
            this.tableAdapterManager.CoPhieuTableAdapter = this.coPhieuTableAdapter;
            this.tableAdapterManager.LenhDatTableAdapter = null;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.LichSuGiaTableAdapter = null;
            this.tableAdapterManager.LoaiLenhTableAdapter = null;
            this.tableAdapterManager.NganHangTableAdapter = null;
            this.tableAdapterManager.NhaDauTuTableAdapter = null;
            this.tableAdapterManager.NhanVienCongTyTableAdapter = null;
            this.tableAdapterManager.NhanVienSanTableAdapter = null;
            this.tableAdapterManager.PhatHanhTableAdapter = null;
            this.tableAdapterManager.QuyDinhCongTyTableAdapter = null;
            this.tableAdapterManager.QuyDinhSanTableAdapter = null;
            this.tableAdapterManager.SoHuuTableAdapter = null;
            this.tableAdapterManager.TaiKhoanGiaoDichTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNganHangTableAdapter = null;
            this.tableAdapterManager.TrangThaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CHUNGKHOAN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coPhieuGridControl
            // 
            this.coPhieuGridControl.DataSource = this.bdsCoPhieu;
            this.coPhieuGridControl.Location = new System.Drawing.Point(12, 56);
            this.coPhieuGridControl.MainView = this.gridView1;
            this.coPhieuGridControl.Name = "coPhieuGridControl";
            this.coPhieuGridControl.Size = new System.Drawing.Size(1786, 587);
            this.coPhieuGridControl.TabIndex = 37;
            this.coPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCoPhieu,
            this.colTenCongTy,
            this.colEmail,
            this.colFax,
            this.colSoDienThoai,
            this.colWebsite});
            this.gridView1.GridControl = this.coPhieuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // bar8
            // 
            this.bar8.BarName = "Main menu";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar8.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar8.FloatSize = new System.Drawing.Size(926, 36);
            this.bar8.OptionsBar.MultiLine = true;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar9,
            this.bar11});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnThem,
            this.BtnXoa,
            this.BtnGhi,
            this.BtnHoanTac,
            this.BtnLamMoi,
            this.BtnChuyenCN,
            this.BtnThoat});
            this.barManager1.MainMenu = this.bar9;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar11;
            // 
            // bar9
            // 
            this.bar9.BarName = "Main menu";
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar9.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar9.FloatSize = new System.Drawing.Size(926, 36);
            this.bar9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar9.OptionsBar.MultiLine = true;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Main menu";
            // 
            // BtnThem
            // 
            this.BtnThem.Caption = "Thêm";
            this.BtnThem.Id = 0;
            this.BtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThem.ImageOptions.SvgImage")));
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(80, 0);
            this.BtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThem_ItemClick);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Caption = "Xoá";
            this.BtnXoa.Id = 1;
            this.BtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnXoa.ImageOptions.SvgImage")));
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(70, 0);
            this.BtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoa_ItemClick);
            // 
            // BtnHoanTac
            // 
            this.BtnHoanTac.Caption = "Hoàn Tác";
            this.BtnHoanTac.Id = 3;
            this.BtnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnHoanTac.ImageOptions.SvgImage")));
            this.BtnHoanTac.Name = "BtnHoanTac";
            // 
            // BtnGhi
            // 
            this.BtnGhi.Caption = "Ghi";
            this.BtnGhi.Id = 2;
            this.BtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGhi.ImageOptions.SvgImage")));
            this.BtnGhi.Name = "BtnGhi";
            this.BtnGhi.Size = new System.Drawing.Size(70, 0);
            this.BtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhi_ItemClick);
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Caption = "Làm Mới";
            this.BtnLamMoi.Id = 4;
            this.BtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnLamMoi.ImageOptions.SvgImage")));
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLamMoi_ItemClick);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Caption = "Thoát";
            this.BtnThoat.Id = 6;
            this.BtnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThoat.ImageOptions.SvgImage")));
            this.BtnThoat.Name = "BtnThoat";
            // 
            // bar11
            // 
            this.bar11.BarName = "Status bar";
            this.bar11.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar11.DockCol = 0;
            this.bar11.DockRow = 0;
            this.bar11.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar11.OptionsBar.AllowQuickCustomization = false;
            this.bar11.OptionsBar.DrawDragBorder = false;
            this.bar11.OptionsBar.UseWholeRow = true;
            this.bar11.Text = "Status bar";
            this.bar11.Visible = false;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl1.Size = new System.Drawing.Size(1954, 46);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 852);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl2.Size = new System.Drawing.Size(1954, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 806);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1954, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 806);
            // 
            // BtnChuyenCN
            // 
            this.BtnChuyenCN.Caption = "Chuyển Chi Nhánh";
            this.BtnChuyenCN.Id = 5;
            this.BtnChuyenCN.Name = "BtnChuyenCN";
            // 
            // colMaCoPhieu
            // 
            this.colMaCoPhieu.FieldName = "MaCoPhieu";
            this.colMaCoPhieu.MinWidth = 40;
            this.colMaCoPhieu.Name = "colMaCoPhieu";
            this.colMaCoPhieu.Visible = true;
            this.colMaCoPhieu.VisibleIndex = 0;
            this.colMaCoPhieu.Width = 150;
            // 
            // colTenCongTy
            // 
            this.colTenCongTy.FieldName = "TenCongTy";
            this.colTenCongTy.MinWidth = 40;
            this.colTenCongTy.Name = "colTenCongTy";
            this.colTenCongTy.Visible = true;
            this.colTenCongTy.VisibleIndex = 1;
            this.colTenCongTy.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 40;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 150;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.MinWidth = 40;
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 3;
            this.colFax.Width = 150;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.MinWidth = 40;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 4;
            this.colSoDienThoai.Width = 150;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.MinWidth = 40;
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 5;
            this.colWebsite.Width = 150;
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(668, 125);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(93, 25);
            websiteLabel.TabIndex = 57;
            websiteLabel.Text = "Website:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCoPhieu, "Website", true));
            this.txtWebsite.Location = new System.Drawing.Point(767, 122);
            this.txtWebsite.MenuManager = this.barManager1;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(200, 40);
            this.txtWebsite.TabIndex = 59;
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.Location = new System.Drawing.Point(124, 137);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new System.Drawing.Size(149, 25);
            soDienThoaiLabel.TabIndex = 55;
            soDienThoaiLabel.Text = "So Dien Thoai:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCoPhieu, "SoDienThoai", true));
            this.txtSoDT.Location = new System.Drawing.Point(279, 134);
            this.txtSoDT.MenuManager = this.barManager1;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(200, 40);
            this.txtSoDT.TabIndex = 58;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(1546, 32);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(51, 25);
            faxLabel.TabIndex = 53;
            faxLabel.Text = "Fax:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCoPhieu, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(1603, 29);
            this.txtFax.MenuManager = this.barManager1;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(200, 40);
            this.txtFax.TabIndex = 56;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(1113, 36);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(70, 25);
            emailLabel.TabIndex = 51;
            emailLabel.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCoPhieu, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(1189, 33);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 40);
            this.txtEmail.TabIndex = 54;
            // 
            // tenCongTyLabel
            // 
            tenCongTyLabel.AutoSize = true;
            tenCongTyLabel.Location = new System.Drawing.Point(623, 39);
            tenCongTyLabel.Name = "tenCongTyLabel";
            tenCongTyLabel.Size = new System.Drawing.Size(138, 25);
            tenCongTyLabel.TabIndex = 49;
            tenCongTyLabel.Text = "Ten Cong Ty:";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCoPhieu, "TenCongTy", true));
            this.txtTenCongTy.Location = new System.Drawing.Point(767, 36);
            this.txtTenCongTy.MenuManager = this.barManager1;
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(200, 40);
            this.txtTenCongTy.TabIndex = 52;
            // 
            // maCoPhieuLabel1
            // 
            maCoPhieuLabel1.AutoSize = true;
            maCoPhieuLabel1.Location = new System.Drawing.Point(137, 43);
            maCoPhieuLabel1.Name = "maCoPhieuLabel1";
            maCoPhieuLabel1.Size = new System.Drawing.Size(136, 25);
            maCoPhieuLabel1.TabIndex = 48;
            maCoPhieuLabel1.Text = "Ma Co Phieu:";
            // 
            // txtMaCP
            // 
            this.txtMaCP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCoPhieu, "MaCoPhieu", true));
            this.txtMaCP.Location = new System.Drawing.Point(279, 40);
            this.txtMaCP.MenuManager = this.barManager1;
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(200, 40);
            this.txtMaCP.TabIndex = 50;
            // 
            // frmCapNhatCoPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1954, 874);
            this.Controls.Add(this.coPhieuGridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmCapNhatCoPhieu";
            this.Text = "frmCapNhatCoPhieu";
            this.Load += new System.EventHandler(this.frmCapNhatCoPhieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongTy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.Bar bar10;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsCoPhieu;
        private DSTableAdapters.CoPhieuTableAdapter coPhieuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl coPhieuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnHoanTac;
        private DevExpress.XtraBars.BarButtonItem BtnGhi;
        private DevExpress.XtraBars.BarButtonItem BtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem BtnThoat;
        private DevExpress.XtraBars.Bar bar11;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraBars.BarButtonItem BtnChuyenCN;
        private DevExpress.XtraEditors.TextEdit txtSoDT;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtTenCongTy;
        private DevExpress.XtraEditors.TextEdit txtMaCP;
    }
}