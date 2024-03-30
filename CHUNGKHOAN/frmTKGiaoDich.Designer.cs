
namespace CHUNGKHOAN
{
    partial class frmTKGiaoDich
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
            System.Windows.Forms.Label maTKGDLabel;
            System.Windows.Forms.Label maCongTyLabel;
            System.Windows.Forms.Label ngayMoTaiKhoanLabel;
            System.Windows.Forms.Label maNDTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKGiaoDich));
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.congTyCKTableAdapter = new CHUNGKHOAN.DSTableAdapters.CongTyCKTableAdapter();
            this.bar10 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNDT = new DevExpress.XtraEditors.TextEdit();
            this.bdsTKGiaoDich = new System.Windows.Forms.BindingSource(this.components);
            this.dteNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaCongTy = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTKGD = new DevExpress.XtraEditors.TextEdit();
            this.bdsCongTyCK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanGiaoDichTableAdapter = new CHUNGKHOAN.DSTableAdapters.TaiKhoanGiaoDichTableAdapter();
            this.bdsNDT = new System.Windows.Forms.BindingSource(this.components);
            this.sp_HienThiNDTTableAdapter = new CHUNGKHOAN.DSTableAdapters.sp_HienThiNDTTableAdapter();
            this.sp_HienThiNDTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNDT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanGiaoDichGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTKGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            maTKGDLabel = new System.Windows.Forms.Label();
            maCongTyLabel = new System.Windows.Forms.Label();
            ngayMoTaiKhoanLabel = new System.Windows.Forms.Label();
            maNDTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTKGiaoDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCongTy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTKGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongTyCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_HienThiNDTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGiaoDichGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maTKGDLabel
            // 
            maTKGDLabel.AutoSize = true;
            maTKGDLabel.Location = new System.Drawing.Point(257, 50);
            maTKGDLabel.Name = "maTKGDLabel";
            maTKGDLabel.Size = new System.Drawing.Size(105, 25);
            maTKGDLabel.TabIndex = 0;
            maTKGDLabel.Text = "Ma TKGD:";
            // 
            // maCongTyLabel
            // 
            maCongTyLabel.AutoSize = true;
            maCongTyLabel.Location = new System.Drawing.Point(668, 50);
            maCongTyLabel.Name = "maCongTyLabel";
            maCongTyLabel.Size = new System.Drawing.Size(130, 25);
            maCongTyLabel.TabIndex = 2;
            maCongTyLabel.Text = "Ma Cong Ty:";
            // 
            // ngayMoTaiKhoanLabel
            // 
            ngayMoTaiKhoanLabel.AutoSize = true;
            ngayMoTaiKhoanLabel.Location = new System.Drawing.Point(1106, 50);
            ngayMoTaiKhoanLabel.Name = "ngayMoTaiKhoanLabel";
            ngayMoTaiKhoanLabel.Size = new System.Drawing.Size(200, 25);
            ngayMoTaiKhoanLabel.TabIndex = 4;
            ngayMoTaiKhoanLabel.Text = "Ngay Mo Tai Khoan:";
            // 
            // maNDTLabel
            // 
            maNDTLabel.AutoSize = true;
            maNDTLabel.Location = new System.Drawing.Point(1597, 46);
            maNDTLabel.Name = "maNDTLabel";
            maNDTLabel.Size = new System.Drawing.Size(93, 25);
            maNDTLabel.TabIndex = 6;
            maNDTLabel.Text = "Ma NDT:";
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
            this.BtnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLamMoi_ItemClick_1);
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
            this.barDockControl1.Size = new System.Drawing.Size(2586, 46);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1046);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl2.Size = new System.Drawing.Size(2586, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1000);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2586, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1000);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 46);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(2586, 0);
            // 
            // congTyCKTableAdapter
            // 
            this.congTyCKTableAdapter.ClearBeforeFill = true;
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
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1046);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(2586, 0);
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
            // panel2
            // 
            this.panel2.Controls.Add(maNDTLabel);
            this.panel2.Controls.Add(this.txtMaNDT);
            this.panel2.Controls.Add(ngayMoTaiKhoanLabel);
            this.panel2.Controls.Add(this.dteNgay);
            this.panel2.Controls.Add(maCongTyLabel);
            this.panel2.Controls.Add(this.txtMaCongTy);
            this.panel2.Controls.Add(maTKGDLabel);
            this.panel2.Controls.Add(this.txtMaTKGD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 897);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2586, 149);
            this.panel2.TabIndex = 16;
            // 
            // txtMaNDT
            // 
            this.txtMaNDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGiaoDich, "MaNDT", true));
            this.txtMaNDT.Location = new System.Drawing.Point(1696, 43);
            this.txtMaNDT.MenuManager = this.barManager1;
            this.txtMaNDT.Name = "txtMaNDT";
            this.txtMaNDT.Size = new System.Drawing.Size(200, 40);
            this.txtMaNDT.TabIndex = 7;
            // 
            // bdsTKGiaoDich
            // 
            this.bdsTKGiaoDich.DataMember = "TaiKhoanGiaoDich";
            this.bdsTKGiaoDich.DataSource = this.DS;
            // 
            // dteNgay
            // 
            this.dteNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGiaoDich, "NgayMoTaiKhoan", true));
            this.dteNgay.EditValue = null;
            this.dteNgay.Location = new System.Drawing.Point(1312, 47);
            this.dteNgay.MenuManager = this.barManager1;
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Size = new System.Drawing.Size(200, 40);
            this.dteNgay.TabIndex = 5;
            // 
            // txtMaCongTy
            // 
            this.txtMaCongTy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGiaoDich, "MaCongTy", true));
            this.txtMaCongTy.Location = new System.Drawing.Point(804, 47);
            this.txtMaCongTy.MenuManager = this.barManager1;
            this.txtMaCongTy.Name = "txtMaCongTy";
            this.txtMaCongTy.Size = new System.Drawing.Size(200, 40);
            this.txtMaCongTy.TabIndex = 3;
            // 
            // txtMaTKGD
            // 
            this.txtMaTKGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTKGiaoDich, "MaTKGD", true));
            this.txtMaTKGD.Location = new System.Drawing.Point(368, 47);
            this.txtMaTKGD.MenuManager = this.barManager1;
            this.txtMaTKGD.Name = "txtMaTKGD";
            this.txtMaTKGD.Size = new System.Drawing.Size(200, 40);
            this.txtMaTKGD.TabIndex = 1;
            // 
            // bdsCongTyCK
            // 
            this.bdsCongTyCK.DataMember = "CongTyCK";
            this.bdsCongTyCK.DataSource = this.DS;
            // 
            // taiKhoanGiaoDichTableAdapter
            // 
            this.taiKhoanGiaoDichTableAdapter.ClearBeforeFill = true;
            // 
            // bdsNDT
            // 
            this.bdsNDT.DataMember = "sp_HienThiNDT";
            this.bdsNDT.DataSource = this.DS;
            // 
            // sp_HienThiNDTTableAdapter
            // 
            this.sp_HienThiNDTTableAdapter.ClearBeforeFill = true;
            // 
            // sp_HienThiNDTGridControl
            // 
            this.sp_HienThiNDTGridControl.DataSource = this.bdsNDT;
            this.sp_HienThiNDTGridControl.Location = new System.Drawing.Point(1312, 168);
            this.sp_HienThiNDTGridControl.MainView = this.gridView1;
            this.sp_HienThiNDTGridControl.MenuManager = this.barManager1;
            this.sp_HienThiNDTGridControl.Name = "sp_HienThiNDTGridControl";
            this.sp_HienThiNDTGridControl.Size = new System.Drawing.Size(1089, 693);
            this.sp_HienThiNDTGridControl.TabIndex = 29;
            this.sp_HienThiNDTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sp_HienThiNDTGridControl.Click += new System.EventHandler(this.sp_HienThiNDTGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNDT1,
            this.colHO,
            this.colTEN,
            this.colPHAI});
            this.gridView1.GridControl = this.sp_HienThiNDTGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaNDT1
            // 
            this.colMaNDT1.FieldName = "MaNDT";
            this.colMaNDT1.MinWidth = 40;
            this.colMaNDT1.Name = "colMaNDT1";
            this.colMaNDT1.Visible = true;
            this.colMaNDT1.VisibleIndex = 0;
            this.colMaNDT1.Width = 150;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 40;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 150;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 40;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 150;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 40;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 150;
            // 
            // taiKhoanGiaoDichGridControl
            // 
            this.taiKhoanGiaoDichGridControl.DataSource = this.bdsTKGiaoDich;
            this.taiKhoanGiaoDichGridControl.Location = new System.Drawing.Point(12, 168);
            this.taiKhoanGiaoDichGridControl.MainView = this.gridView2;
            this.taiKhoanGiaoDichGridControl.MenuManager = this.barManager1;
            this.taiKhoanGiaoDichGridControl.Name = "taiKhoanGiaoDichGridControl";
            this.taiKhoanGiaoDichGridControl.Size = new System.Drawing.Size(1252, 693);
            this.taiKhoanGiaoDichGridControl.TabIndex = 35;
            this.taiKhoanGiaoDichGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTKGD,
            this.colMaCongTy,
            this.colNgayMoTaiKhoan,
            this.colMaNDT});
            this.gridView2.GridControl = this.taiKhoanGiaoDichGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMaTKGD
            // 
            this.colMaTKGD.FieldName = "MaTKGD";
            this.colMaTKGD.MinWidth = 40;
            this.colMaTKGD.Name = "colMaTKGD";
            this.colMaTKGD.Visible = true;
            this.colMaTKGD.VisibleIndex = 0;
            this.colMaTKGD.Width = 150;
            // 
            // colMaCongTy
            // 
            this.colMaCongTy.FieldName = "MaCongTy";
            this.colMaCongTy.MinWidth = 40;
            this.colMaCongTy.Name = "colMaCongTy";
            this.colMaCongTy.Visible = true;
            this.colMaCongTy.VisibleIndex = 1;
            this.colMaCongTy.Width = 150;
            // 
            // colNgayMoTaiKhoan
            // 
            this.colNgayMoTaiKhoan.FieldName = "NgayMoTaiKhoan";
            this.colNgayMoTaiKhoan.MinWidth = 40;
            this.colNgayMoTaiKhoan.Name = "colNgayMoTaiKhoan";
            this.colNgayMoTaiKhoan.Visible = true;
            this.colNgayMoTaiKhoan.VisibleIndex = 2;
            this.colNgayMoTaiKhoan.Width = 150;
            // 
            // colMaNDT
            // 
            this.colMaNDT.FieldName = "MaNDT";
            this.colMaNDT.MinWidth = 40;
            this.colMaNDT.Name = "colMaNDT";
            this.colMaNDT.Visible = true;
            this.colMaNDT.VisibleIndex = 3;
            this.colMaNDT.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Công ty";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2586, 102);
            this.panel1.TabIndex = 15;
            // 
            // cmbCN
            // 
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(454, 42);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(800, 33);
            this.cmbCN.TabIndex = 7;
            // 
            // frmTKGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2586, 1068);
            this.Controls.Add(this.taiKhoanGiaoDichGridControl);
            this.Controls.Add(this.sp_HienThiNDTGridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmTKGiaoDich";
            this.Text = "frmTKGiaoDich";
            this.Load += new System.EventHandler(this.frmTKGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTKGiaoDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCongTy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTKGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongTyCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_HienThiNDTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGiaoDichGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarButtonItem BtnChuyenCN;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.CongTyCKTableAdapter congTyCKTableAdapter;
        private DevExpress.XtraBars.Bar bar10;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar5;
        private System.Windows.Forms.BindingSource bdsCongTyCK;
        private System.Windows.Forms.BindingSource bdsTKGiaoDich;
        private DSTableAdapters.TaiKhoanGiaoDichTableAdapter taiKhoanGiaoDichTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaNDT;
        private DevExpress.XtraEditors.DateEdit dteNgay;
        private DevExpress.XtraEditors.TextEdit txtMaCongTy;
        private DevExpress.XtraEditors.TextEdit txtMaTKGD;
        private System.Windows.Forms.BindingSource bdsNDT;
        private DSTableAdapters.sp_HienThiNDTTableAdapter sp_HienThiNDTTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_HienThiNDTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNDT1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.GridControl taiKhoanGiaoDichGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTKGD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMoTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCN;
    }
}