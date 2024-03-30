
namespace CHUNGKHOAN
{
    partial class frmtknganhang
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
            System.Windows.Forms.Label maNDTLabel;
            System.Windows.Forms.Label soDuLabel;
            System.Windows.Forms.Label soTaiKhoanLabel;
            System.Windows.Forms.Label maNganHangLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtknganhang));
            this.bdsNDT = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new CHUNGKHOAN.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.tableAdapterManager = new CHUNGKHOAN.DSTableAdapters.TableAdapterManager();
            this.bdsTKNganhang = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNganHang = new System.Windows.Forms.BindingSource(this.components);
            this.nhaDauTuTableAdapter = new CHUNGKHOAN.DSTableAdapters.NhaDauTuTableAdapter();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.bar10 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.nhaDauTuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND_Passport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanNganHangTableAdapter = new CHUNGKHOAN.DSTableAdapters.TaiKhoanNganHangTableAdapter();
            this.taiKhoanNganHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNDT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nganHangTableAdapter = new CHUNGKHOAN.DSTableAdapters.NganHangTableAdapter();
            this.txtMaNDT = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDu = new DevExpress.XtraEditors.SpinEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNganHang = new DevExpress.XtraEditors.TextEdit();
            this.nganHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNganHang1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            maNDTLabel = new System.Windows.Forms.Label();
            soDuLabel = new System.Windows.Forms.Label();
            soTaiKhoanLabel = new System.Windows.Forms.Label();
            maNganHangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTKNganhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNganHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaDauTuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNganHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNganHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // maNDTLabel
            // 
            maNDTLabel.AutoSize = true;
            maNDTLabel.Location = new System.Drawing.Point(1743, 518);
            maNDTLabel.Name = "maNDTLabel";
            maNDTLabel.Size = new System.Drawing.Size(93, 25);
            maNDTLabel.TabIndex = 46;
            maNDTLabel.Text = "Ma NDT:";
            // 
            // soDuLabel
            // 
            soDuLabel.AutoSize = true;
            soDuLabel.Location = new System.Drawing.Point(1789, 715);
            soDuLabel.Name = "soDuLabel";
            soDuLabel.Size = new System.Drawing.Size(75, 25);
            soDuLabel.TabIndex = 44;
            soDuLabel.Text = "So Du:";
            // 
            // soTaiKhoanLabel
            // 
            soTaiKhoanLabel.AutoSize = true;
            soTaiKhoanLabel.Location = new System.Drawing.Point(1722, 616);
            soTaiKhoanLabel.Name = "soTaiKhoanLabel";
            soTaiKhoanLabel.Size = new System.Drawing.Size(142, 25);
            soTaiKhoanLabel.TabIndex = 42;
            soTaiKhoanLabel.Text = "So Tai Khoan:";
            // 
            // maNganHangLabel
            // 
            maNganHangLabel.AutoSize = true;
            maNganHangLabel.Location = new System.Drawing.Point(1728, 822);
            maNganHangLabel.Name = "maNganHangLabel";
            maNganHangLabel.Size = new System.Drawing.Size(158, 25);
            maNganHangLabel.TabIndex = 47;
            maNganHangLabel.Text = "Ma Ngan Hang:";
            // 
            // bdsNDT
            // 
            this.bdsNDT.DataMember = "NhaDauTu";
            this.bdsNDT.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar8,
            this.bar9});
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
            this.barManager1.MainMenu = this.bar8;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar9;
            // 
            // bar8
            // 
            this.bar8.BarName = "Main menu";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar8.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar8.FloatSize = new System.Drawing.Size(926, 36);
            this.bar8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar8.OptionsBar.MultiLine = true;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.Text = "Main menu";
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
            // bar9
            // 
            this.bar9.BarName = "Status bar";
            this.bar9.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar9.OptionsBar.AllowQuickCustomization = false;
            this.bar9.OptionsBar.DrawDragBorder = false;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Status bar";
            this.bar9.Visible = false;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl1.Size = new System.Drawing.Size(2435, 46);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1051);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl2.Size = new System.Drawing.Size(2435, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1005);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2435, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1005);
            // 
            // BtnChuyenCN
            // 
            this.BtnChuyenCN.Caption = "Chuyển Chi Nhánh";
            this.BtnChuyenCN.Id = 5;
            this.BtnChuyenCN.Name = "BtnChuyenCN";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietQuyDinhCongTyTableAdapter = null;
            this.tableAdapterManager.ChiTietQuyDinhSanTableAdapter = null;
            this.tableAdapterManager.CongTyCKTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoPhieuTableAdapter = null;
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
            // bdsTKNganhang
            // 
            this.bdsTKNganhang.DataMember = "TaiKhoanNganHang";
            this.bdsTKNganhang.DataSource = this.DS;
            // 
            // bdsNganHang
            // 
            this.bdsNganHang.DataMember = "NganHang";
            this.bdsNganHang.DataSource = this.DS;
            // 
            // nhaDauTuTableAdapter
            // 
            this.nhaDauTuTableAdapter.ClearBeforeFill = true;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1051);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(2435, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 46);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(2435, 0);
            // 
            // bar10
            // 
            this.bar10.BarName = "Main menu";
            this.bar10.DockCol = 0;
            this.bar10.DockRow = 0;
            this.bar10.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar10.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar10.FloatSize = new System.Drawing.Size(926, 36);
            this.bar10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // nhaDauTuGridControl
            // 
            this.nhaDauTuGridControl.DataSource = this.bdsNDT;
            this.nhaDauTuGridControl.Location = new System.Drawing.Point(27, 97);
            this.nhaDauTuGridControl.MainView = this.gridView1;
            this.nhaDauTuGridControl.MenuManager = this.barManager1;
            this.nhaDauTuGridControl.Name = "nhaDauTuGridControl";
            this.nhaDauTuGridControl.Size = new System.Drawing.Size(1264, 340);
            this.nhaDauTuGridControl.TabIndex = 33;
            this.nhaDauTuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNDT,
            this.colHo,
            this.colTen,
            this.colPhai,
            this.colCMND_Passport});
            this.gridView1.GridControl = this.nhaDauTuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNDT
            // 
            this.colMaNDT.FieldName = "MaNDT";
            this.colMaNDT.MinWidth = 40;
            this.colMaNDT.Name = "colMaNDT";
            this.colMaNDT.Visible = true;
            this.colMaNDT.VisibleIndex = 0;
            this.colMaNDT.Width = 150;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 40;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 150;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 40;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 150;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.MinWidth = 40;
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 3;
            this.colPhai.Width = 150;
            // 
            // colCMND_Passport
            // 
            this.colCMND_Passport.FieldName = "CMND_Passport";
            this.colCMND_Passport.MinWidth = 40;
            this.colCMND_Passport.Name = "colCMND_Passport";
            this.colCMND_Passport.Visible = true;
            this.colCMND_Passport.VisibleIndex = 4;
            this.colCMND_Passport.Width = 150;
            // 
            // taiKhoanNganHangTableAdapter
            // 
            this.taiKhoanNganHangTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanNganHangGridControl
            // 
            this.taiKhoanNganHangGridControl.DataSource = this.bdsTKNganhang;
            this.taiKhoanNganHangGridControl.Location = new System.Drawing.Point(27, 474);
            this.taiKhoanNganHangGridControl.MainView = this.gridView2;
            this.taiKhoanNganHangGridControl.MenuManager = this.barManager1;
            this.taiKhoanNganHangGridControl.Name = "taiKhoanNganHangGridControl";
            this.taiKhoanNganHangGridControl.Size = new System.Drawing.Size(1577, 536);
            this.taiKhoanNganHangGridControl.TabIndex = 33;
            this.taiKhoanNganHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoTaiKhoan,
            this.colSoDu,
            this.colMaNganHang,
            this.colMaNDT1});
            this.gridView2.GridControl = this.taiKhoanNganHangGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colSoTaiKhoan
            // 
            this.colSoTaiKhoan.FieldName = "SoTaiKhoan";
            this.colSoTaiKhoan.MinWidth = 40;
            this.colSoTaiKhoan.Name = "colSoTaiKhoan";
            this.colSoTaiKhoan.Visible = true;
            this.colSoTaiKhoan.VisibleIndex = 0;
            this.colSoTaiKhoan.Width = 150;
            // 
            // colSoDu
            // 
            this.colSoDu.FieldName = "SoDu";
            this.colSoDu.MinWidth = 40;
            this.colSoDu.Name = "colSoDu";
            this.colSoDu.Visible = true;
            this.colSoDu.VisibleIndex = 1;
            this.colSoDu.Width = 150;
            // 
            // colMaNganHang
            // 
            this.colMaNganHang.FieldName = "MaNganHang";
            this.colMaNganHang.MinWidth = 40;
            this.colMaNganHang.Name = "colMaNganHang";
            this.colMaNganHang.Visible = true;
            this.colMaNganHang.VisibleIndex = 2;
            this.colMaNganHang.Width = 150;
            // 
            // colMaNDT1
            // 
            this.colMaNDT1.FieldName = "MaNDT";
            this.colMaNDT1.MinWidth = 40;
            this.colMaNDT1.Name = "colMaNDT1";
            this.colMaNDT1.Visible = true;
            this.colMaNDT1.VisibleIndex = 3;
            this.colMaNDT1.Width = 150;
            // 
            // nganHangTableAdapter
            // 
            this.nganHangTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaNDT
            // 
            this.txtMaNDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKNganhang, "MaNDT", true));
            this.txtMaNDT.Location = new System.Drawing.Point(1892, 511);
            this.txtMaNDT.MenuManager = this.barManager1;
            this.txtMaNDT.Name = "txtMaNDT";
            this.txtMaNDT.Size = new System.Drawing.Size(200, 40);
            this.txtMaNDT.TabIndex = 47;
            // 
            // txtSoDu
            // 
            this.txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKNganhang, "SoDu", true));
            this.txtSoDu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoDu.Location = new System.Drawing.Point(1892, 700);
            this.txtSoDu.MenuManager = this.barManager1;
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoDu.Size = new System.Drawing.Size(200, 40);
            this.txtSoDu.TabIndex = 45;
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKNganhang, "SoTaiKhoan", true));
            this.txtSTK.Location = new System.Drawing.Point(1892, 601);
            this.txtSTK.MenuManager = this.barManager1;
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(200, 40);
            this.txtSTK.TabIndex = 43;
            // 
            // txtMaNganHang
            // 
            this.txtMaNganHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKNganhang, "MaNganHang", true));
            this.txtMaNganHang.Location = new System.Drawing.Point(1892, 819);
            this.txtMaNganHang.MenuManager = this.barManager1;
            this.txtMaNganHang.Name = "txtMaNganHang";
            this.txtMaNganHang.Size = new System.Drawing.Size(200, 40);
            this.txtMaNganHang.TabIndex = 48;
            // 
            // nganHangGridControl
            // 
            this.nganHangGridControl.DataSource = this.bdsNganHang;
            this.nganHangGridControl.Location = new System.Drawing.Point(1367, 97);
            this.nganHangGridControl.MainView = this.gridView3;
            this.nganHangGridControl.MenuManager = this.barManager1;
            this.nganHangGridControl.Name = "nganHangGridControl";
            this.nganHangGridControl.Size = new System.Drawing.Size(1031, 340);
            this.nganHangGridControl.TabIndex = 48;
            this.nganHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNganHang1,
            this.colTenNganHang});
            this.gridView3.GridControl = this.nganHangGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colMaNganHang1
            // 
            this.colMaNganHang1.FieldName = "MaNganHang";
            this.colMaNganHang1.MinWidth = 40;
            this.colMaNganHang1.Name = "colMaNganHang1";
            this.colMaNganHang1.Visible = true;
            this.colMaNganHang1.VisibleIndex = 0;
            this.colMaNganHang1.Width = 150;
            // 
            // colTenNganHang
            // 
            this.colTenNganHang.FieldName = "TenNganHang";
            this.colTenNganHang.MinWidth = 40;
            this.colTenNganHang.Name = "colTenNganHang";
            this.colTenNganHang.Visible = true;
            this.colTenNganHang.VisibleIndex = 1;
            this.colTenNganHang.Width = 150;
            // 
            // frmtknganhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2435, 1073);
            this.Controls.Add(this.nganHangGridControl);
            this.Controls.Add(maNganHangLabel);
            this.Controls.Add(this.txtMaNganHang);
            this.Controls.Add(maNDTLabel);
            this.Controls.Add(this.txtMaNDT);
            this.Controls.Add(soDuLabel);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(soTaiKhoanLabel);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.taiKhoanNganHangGridControl);
            this.Controls.Add(this.nhaDauTuGridControl);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmtknganhang";
            this.Text = "frmtknganhang";
            this.Load += new System.EventHandler(this.frmtknganhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsNDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTKNganhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNganHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaDauTuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNganHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNganHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nganHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsNDT;
        private DS DS;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnHoanTac;
        private DevExpress.XtraBars.BarButtonItem BtnGhi;
        private DevExpress.XtraBars.BarButtonItem BtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem BtnThoat;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl nhaDauTuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNDT;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND_Passport;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarButtonItem BtnChuyenCN;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.NhaDauTuTableAdapter nhaDauTuTableAdapter;
        private DevExpress.XtraBars.Bar bar10;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private System.Windows.Forms.BindingSource bdsTKNganhang;
        private DSTableAdapters.TaiKhoanNganHangTableAdapter taiKhoanNganHangTableAdapter;
        private DevExpress.XtraGrid.GridControl taiKhoanNganHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNDT1;
        private System.Windows.Forms.BindingSource bdsNganHang;
        private DSTableAdapters.NganHangTableAdapter nganHangTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaNDT;
        private DevExpress.XtraEditors.SpinEdit txtSoDu;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        private DevExpress.XtraGrid.GridControl nganHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNganHang1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNganHang;
        private DevExpress.XtraEditors.TextEdit txtMaNganHang;
    }
}