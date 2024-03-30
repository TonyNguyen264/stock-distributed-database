
namespace CHUNGKHOAN
{
    partial class frmPhatHanh
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
            System.Windows.Forms.Label maCoPhieuLabel;
            System.Windows.Forms.Label ngayLabel;
            System.Windows.Forms.Label soLuongPhatHanhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhatHanh));
            this.bdsPhatHanh = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new CHUNGKHOAN.DS();
            this.bar10 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bdsCoPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.coPhieuTableAdapter = new CHUNGKHOAN.DSTableAdapters.CoPhieuTableAdapter();
            this.coPhieuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phatHanhTableAdapter = new CHUNGKHOAN.DSTableAdapters.PhatHanhTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new CHUNGKHOAN.DSTableAdapters.TableAdapterManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.dteNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaCoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.phatHanhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCoPhieu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongPhatHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            maCoPhieuLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            soLuongPhatHanhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhatHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phatHanhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // maCoPhieuLabel
            // 
            maCoPhieuLabel.AutoSize = true;
            maCoPhieuLabel.Location = new System.Drawing.Point(133, 44);
            maCoPhieuLabel.Name = "maCoPhieuLabel";
            maCoPhieuLabel.Size = new System.Drawing.Size(136, 25);
            maCoPhieuLabel.TabIndex = 0;
            maCoPhieuLabel.Text = "Ma Co Phieu:";
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Location = new System.Drawing.Point(568, 44);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(66, 25);
            ngayLabel.TabIndex = 2;
            ngayLabel.Text = "Ngay:";
            // 
            // soLuongPhatHanhLabel
            // 
            soLuongPhatHanhLabel.AutoSize = true;
            soLuongPhatHanhLabel.Location = new System.Drawing.Point(951, 41);
            soLuongPhatHanhLabel.Name = "soLuongPhatHanhLabel";
            soLuongPhatHanhLabel.Size = new System.Drawing.Size(211, 25);
            soLuongPhatHanhLabel.TabIndex = 4;
            soLuongPhatHanhLabel.Text = "So Luong Phat Hanh:";
            // 
            // bdsPhatHanh
            // 
            this.bdsPhatHanh.DataMember = "PhatHanh";
            this.bdsPhatHanh.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // BtnGhi
            // 
            this.BtnGhi.Caption = "Ghi";
            this.BtnGhi.Id = 2;
            this.BtnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGhi.ImageOptions.SvgImage")));
            this.BtnGhi.Name = "BtnGhi";
            this.BtnGhi.Size = new System.Drawing.Size(70, 0);
            this.BtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhi_ItemClick);
            // 
            // BtnHoanTac
            // 
            this.BtnHoanTac.Caption = "Hoàn Tác";
            this.BtnHoanTac.Id = 3;
            this.BtnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnHoanTac.ImageOptions.SvgImage")));
            this.BtnHoanTac.Name = "BtnHoanTac";
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
            // bdsCoPhieu
            // 
            this.bdsCoPhieu.DataMember = "CoPhieu";
            this.bdsCoPhieu.DataSource = this.DS;
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
            this.barDockControl2.Location = new System.Drawing.Point(0, 919);
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
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 873);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2586, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 873);
            // 
            // BtnChuyenCN
            // 
            this.BtnChuyenCN.Caption = "Chuyển Chi Nhánh";
            this.BtnChuyenCN.Id = 5;
            this.BtnChuyenCN.Name = "BtnChuyenCN";
            // 
            // coPhieuTableAdapter
            // 
            this.coPhieuTableAdapter.ClearBeforeFill = true;
            // 
            // coPhieuGridControl
            // 
            this.coPhieuGridControl.DataSource = this.bdsCoPhieu;
            this.coPhieuGridControl.Location = new System.Drawing.Point(34, 84);
            this.coPhieuGridControl.MainView = this.gridView1;
            this.coPhieuGridControl.MenuManager = this.barManager1;
            this.coPhieuGridControl.Name = "coPhieuGridControl";
            this.coPhieuGridControl.Size = new System.Drawing.Size(1641, 273);
            this.coPhieuGridControl.TabIndex = 24;
            this.coPhieuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.coPhieuGridControl.Click += new System.EventHandler(this.coPhieuGridControl_Click);
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
            this.gridView1.OptionsBehavior.Editable = false;
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
            // phatHanhTableAdapter
            // 
            this.phatHanhTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2586, 10);
            this.panel1.TabIndex = 22;
            // 
            // cmbCN
            // 
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(451, 38);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(800, 33);
            this.cmbCN.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.Controls.Add(soLuongPhatHanhLabel);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(ngayLabel);
            this.panel2.Controls.Add(this.dteNgay);
            this.panel2.Controls.Add(maCoPhieuLabel);
            this.panel2.Controls.Add(this.txtMaCoPhieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 759);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2586, 160);
            this.panel2.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhatHanh, "SoLuongPhatHanh", true));
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(1168, 38);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(200, 40);
            this.txtSoLuong.TabIndex = 5;
            // 
            // dteNgay
            // 
            this.dteNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhatHanh, "Ngay", true));
            this.dteNgay.EditValue = null;
            this.dteNgay.Location = new System.Drawing.Point(640, 41);
            this.dteNgay.MenuManager = this.barManager1;
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Size = new System.Drawing.Size(200, 40);
            this.dteNgay.TabIndex = 3;
            // 
            // txtMaCoPhieu
            // 
            this.txtMaCoPhieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhatHanh, "MaCoPhieu", true));
            this.txtMaCoPhieu.Location = new System.Drawing.Point(275, 41);
            this.txtMaCoPhieu.MenuManager = this.barManager1;
            this.txtMaCoPhieu.Name = "txtMaCoPhieu";
            this.txtMaCoPhieu.Size = new System.Drawing.Size(200, 40);
            this.txtMaCoPhieu.TabIndex = 1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 919);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(2586, 0);
            // 
            // phatHanhGridControl
            // 
            this.phatHanhGridControl.DataSource = this.bdsPhatHanh;
            this.phatHanhGridControl.Location = new System.Drawing.Point(34, 400);
            this.phatHanhGridControl.MainView = this.gridView2;
            this.phatHanhGridControl.MenuManager = this.barManager1;
            this.phatHanhGridControl.Name = "phatHanhGridControl";
            this.phatHanhGridControl.Size = new System.Drawing.Size(1597, 359);
            this.phatHanhGridControl.TabIndex = 26;
            this.phatHanhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.phatHanhGridControl.Click += new System.EventHandler(this.phatHanhGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCoPhieu1,
            this.colNgay,
            this.colSoLuongPhatHanh});
            this.gridView2.GridControl = this.phatHanhGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMaCoPhieu1
            // 
            this.colMaCoPhieu1.FieldName = "MaCoPhieu";
            this.colMaCoPhieu1.MinWidth = 40;
            this.colMaCoPhieu1.Name = "colMaCoPhieu1";
            this.colMaCoPhieu1.Visible = true;
            this.colMaCoPhieu1.VisibleIndex = 0;
            this.colMaCoPhieu1.Width = 150;
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.MinWidth = 40;
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 150;
            // 
            // colSoLuongPhatHanh
            // 
            this.colSoLuongPhatHanh.FieldName = "SoLuongPhatHanh";
            this.colSoLuongPhatHanh.MinWidth = 40;
            this.colSoLuongPhatHanh.Name = "colSoLuongPhatHanh";
            this.colSoLuongPhatHanh.Visible = true;
            this.colSoLuongPhatHanh.VisibleIndex = 2;
            this.colSoLuongPhatHanh.Width = 150;
            // 
            // frmPhatHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2620, 934);
            this.Controls.Add(this.phatHanhGridControl);
            this.Controls.Add(this.coPhieuGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmPhatHanh";
            this.Text = "frmPhatHanh";
            this.Load += new System.EventHandler(this.frmPhatHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhatHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coPhieuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phatHanhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsPhatHanh;
        private DS DS;
        private DevExpress.XtraBars.Bar bar10;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnGhi;
        private DevExpress.XtraBars.BarButtonItem BtnHoanTac;
        private DevExpress.XtraBars.BarButtonItem BtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem BtnThoat;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private System.Windows.Forms.BindingSource bdsCoPhieu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl phatHanhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCoPhieu1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongPhatHanh;
        private DevExpress.XtraGrid.GridControl coPhieuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.DateEdit dteNgay;
        private DevExpress.XtraEditors.TextEdit txtMaCoPhieu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarButtonItem BtnChuyenCN;
        private DSTableAdapters.CoPhieuTableAdapter coPhieuTableAdapter;
        private DSTableAdapters.PhatHanhTableAdapter phatHanhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}