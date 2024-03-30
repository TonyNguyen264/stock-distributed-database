
namespace CHUNGKHOAN
{
    partial class frmNhanVienSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVienSan));
            System.Windows.Forms.Label trangThaiXoaLabel1;
            System.Windows.Forms.Label maCongTyLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label phaiLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maNhanVienLabel;
            this.nhanVienSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new CHUNGKHOAN.DS();
            this.tableAdapterManager = new CHUNGKHOAN.DSTableAdapters.TableAdapterManager();
            this.nhanVienSanTableAdapter = new CHUNGKHOAN.DSTableAdapters.NhanVienSanTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.BtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.BtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.nhanVienSanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtttx = new DevExpress.XtraEditors.TextEdit();
            this.txtmacongty = new DevExpress.XtraEditors.TextEdit();
            this.txtsdt = new DevExpress.XtraEditors.TextEdit();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.txtphai = new DevExpress.XtraEditors.TextEdit();
            this.dtengaysinh = new DevExpress.XtraEditors.DateEdit();
            this.txten = new DevExpress.XtraEditors.TextEdit();
            this.txtho = new DevExpress.XtraEditors.TextEdit();
            this.txtmanhanvien = new DevExpress.XtraEditors.TextEdit();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            trangThaiXoaLabel1 = new System.Windows.Forms.Label();
            maCongTyLabel = new System.Windows.Forms.Label();
            soDTLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            phaiLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maNhanVienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienSanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienSanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtttx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacongty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtengaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtengaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanhanvien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienSanBindingSource
            // 
            this.nhanVienSanBindingSource.DataMember = "NhanVienSan";
            this.nhanVienSanBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietQuyDinhCongTyTableAdapter = null;
            this.tableAdapterManager.ChiTietQuyDinhSanTableAdapter = null;
            this.tableAdapterManager.CongTyCKTableAdapter = null;
            this.tableAdapterManager.CoPhieuTableAdapter = null;
            this.tableAdapterManager.LenhDatTableAdapter = null;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.LichSuGiaTableAdapter = null;
            this.tableAdapterManager.LoaiLenhTableAdapter = null;
            this.tableAdapterManager.NganHangTableAdapter = null;
            this.tableAdapterManager.NhaDauTuTableAdapter = null;
            this.tableAdapterManager.NhanVienCongTyTableAdapter = null;
            this.tableAdapterManager.NhanVienSanTableAdapter = this.nhanVienSanTableAdapter;
            this.tableAdapterManager.PhatHanhTableAdapter = null;
            this.tableAdapterManager.QuyDinhCongTyTableAdapter = null;
            this.tableAdapterManager.QuyDinhSanTableAdapter = null;
            this.tableAdapterManager.SoHuuTableAdapter = null;
            this.tableAdapterManager.TaiKhoanGiaoDichTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNganHangTableAdapter = null;
            this.tableAdapterManager.TrangThaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CHUNGKHOAN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienSanTableAdapter
            // 
            this.nhanVienSanTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar9});
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
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
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar9;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar3.FloatSize = new System.Drawing.Size(926, 36);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // BtnThem
            // 
            this.BtnThem.Caption = "Thêm";
            this.BtnThem.Id = 0;
            this.BtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnThem.ImageOptions.SvgImage")));
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(80, 0);
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
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Caption = "Làm Mới";
            this.BtnLamMoi.Id = 4;
            this.BtnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnLamMoi.ImageOptions.SvgImage")));
            this.BtnLamMoi.Name = "BtnLamMoi";
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
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl2.Size = new System.Drawing.Size(1911, 46);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 1096);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl3.Size = new System.Drawing.Size(1911, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1050);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1911, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1050);
            // 
            // BtnChuyenCN
            // 
            this.BtnChuyenCN.Caption = "Chuyển Chi Nhánh";
            this.BtnChuyenCN.Id = 5;
            this.BtnChuyenCN.Name = "BtnChuyenCN";
            // 
            // nhanVienSanGridControl
            // 
            this.nhanVienSanGridControl.DataSource = this.nhanVienSanBindingSource;
            this.nhanVienSanGridControl.Location = new System.Drawing.Point(69, 103);
            this.nhanVienSanGridControl.MainView = this.gridView1;
            this.nhanVienSanGridControl.MenuManager = this.barManager1;
            this.nhanVienSanGridControl.Name = "nhanVienSanGridControl";
            this.nhanVienSanGridControl.Size = new System.Drawing.Size(1553, 589);
            this.nhanVienSanGridControl.TabIndex = 32;
            this.nhanVienSanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhanVien,
            this.colHo,
            this.colTen,
            this.colNgaySinh,
            this.colPhai,
            this.colDiaChi,
            this.colSoDT,
            this.colTrangThaiXoa,
            this.colTenSan});
            this.gridView1.GridControl = this.nhanVienSanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.MinWidth = 40;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 150;
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
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 40;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            this.colNgaySinh.Width = 150;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.MinWidth = 40;
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 4;
            this.colPhai.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 40;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            this.colDiaChi.Width = 150;
            // 
            // colSoDT
            // 
            this.colSoDT.FieldName = "SoDT";
            this.colSoDT.MinWidth = 40;
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.Visible = true;
            this.colSoDT.VisibleIndex = 6;
            this.colSoDT.Width = 150;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 40;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 150;
            // 
            // colTenSan
            // 
            this.colTenSan.FieldName = "TenSan";
            this.colTenSan.MinWidth = 40;
            this.colTenSan.Name = "colTenSan";
            this.colTenSan.Visible = true;
            this.colTenSan.VisibleIndex = 8;
            this.colTenSan.Width = 150;
            // 
            // trangThaiXoaLabel1
            // 
            trangThaiXoaLabel1.AutoSize = true;
            trangThaiXoaLabel1.Location = new System.Drawing.Point(92, 257);
            trangThaiXoaLabel1.Name = "trangThaiXoaLabel1";
            trangThaiXoaLabel1.Size = new System.Drawing.Size(162, 25);
            trangThaiXoaLabel1.TabIndex = 18;
            trangThaiXoaLabel1.Text = "Trang Thai Xoa:";
            // 
            // maCongTyLabel
            // 
            maCongTyLabel.AutoSize = true;
            maCongTyLabel.Location = new System.Drawing.Point(928, 266);
            maCongTyLabel.Name = "maCongTyLabel";
            maCongTyLabel.Size = new System.Drawing.Size(130, 25);
            maCongTyLabel.TabIndex = 16;
            maCongTyLabel.Text = "Ma Cong Ty:";
            // 
            // soDTLabel
            // 
            soDTLabel.AutoSize = true;
            soDTLabel.Location = new System.Drawing.Point(622, 165);
            soDTLabel.Name = "soDTLabel";
            soDTLabel.Size = new System.Drawing.Size(75, 25);
            soDTLabel.TabIndex = 12;
            soDTLabel.Text = "So DT:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(611, 257);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(86, 25);
            diaChiLabel.TabIndex = 10;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // phaiLabel
            // 
            phaiLabel.AutoSize = true;
            phaiLabel.Location = new System.Drawing.Point(195, 169);
            phaiLabel.Name = "phaiLabel";
            phaiLabel.Size = new System.Drawing.Size(59, 25);
            phaiLabel.TabIndex = 8;
            phaiLabel.Text = "Phai:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(917, 165);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(114, 25);
            ngaySinhLabel.TabIndex = 6;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(977, 75);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(54, 25);
            tenLabel.TabIndex = 4;
            tenLabel.Text = "Ten:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(653, 75);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(44, 25);
            hoLabel.TabIndex = 2;
            hoLabel.Text = "Ho:";
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Location = new System.Drawing.Point(104, 69);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(150, 25);
            maNhanVienLabel.TabIndex = 0;
            maNhanVienLabel.Text = "Ma Nhan Vien:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(trangThaiXoaLabel1);
            this.panel2.Controls.Add(this.txtttx);
            this.panel2.Controls.Add(maCongTyLabel);
            this.panel2.Controls.Add(this.txtmacongty);
            this.panel2.Controls.Add(soDTLabel);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(diaChiLabel);
            this.panel2.Controls.Add(this.txtdiachi);
            this.panel2.Controls.Add(phaiLabel);
            this.panel2.Controls.Add(this.txtphai);
            this.panel2.Controls.Add(ngaySinhLabel);
            this.panel2.Controls.Add(this.dtengaysinh);
            this.panel2.Controls.Add(tenLabel);
            this.panel2.Controls.Add(this.txten);
            this.panel2.Controls.Add(hoLabel);
            this.panel2.Controls.Add(this.txtho);
            this.panel2.Controls.Add(maNhanVienLabel);
            this.panel2.Controls.Add(this.txtmanhanvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 634);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1911, 462);
            this.panel2.TabIndex = 31;
            // 
            // txtttx
            // 
            this.txtttx.Location = new System.Drawing.Point(260, 254);
            this.txtttx.Name = "txtttx";
            this.txtttx.Size = new System.Drawing.Size(200, 40);
            this.txtttx.TabIndex = 19;
            // 
            // txtmacongty
            // 
            this.txtmacongty.Location = new System.Drawing.Point(1064, 263);
            this.txtmacongty.Name = "txtmacongty";
            this.txtmacongty.Size = new System.Drawing.Size(200, 40);
            this.txtmacongty.TabIndex = 17;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(703, 162);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(200, 40);
            this.txtsdt.TabIndex = 13;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(703, 254);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 40);
            this.txtdiachi.TabIndex = 11;
            // 
            // txtphai
            // 
            this.txtphai.Location = new System.Drawing.Point(260, 166);
            this.txtphai.Name = "txtphai";
            this.txtphai.Size = new System.Drawing.Size(200, 40);
            this.txtphai.TabIndex = 9;
            // 
            // dtengaysinh
            // 
            this.dtengaysinh.EditValue = null;
            this.dtengaysinh.Location = new System.Drawing.Point(1037, 162);
            this.dtengaysinh.Name = "dtengaysinh";
            this.dtengaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtengaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtengaysinh.Size = new System.Drawing.Size(200, 40);
            this.dtengaysinh.TabIndex = 7;
            // 
            // txten
            // 
            this.txten.Location = new System.Drawing.Point(1037, 72);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(200, 40);
            this.txten.TabIndex = 5;
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(703, 72);
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(200, 40);
            this.txtho.TabIndex = 3;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(260, 63);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(200, 40);
            this.txtmanhanvien.TabIndex = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 46);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(1911, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 46);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControl1.Size = new System.Drawing.Size(1911, 0);
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
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(122, 214);
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
            this.bar2.FloatLocation = new System.Drawing.Point(122, 214);
            this.bar2.FloatSize = new System.Drawing.Size(926, 36);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // frmNhanVienSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1911, 1118);
            this.Controls.Add(this.nhanVienSanGridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl2);
            this.Name = "frmNhanVienSan";
            this.Text = "frmNhanVienSan";
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienSanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienSanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtttx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacongty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtengaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtengaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanhanvien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nhanVienSanBindingSource;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.NhanVienSanTableAdapter nhanVienSanTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem BtnThem;
        private DevExpress.XtraBars.BarButtonItem BtnXoa;
        private DevExpress.XtraBars.BarButtonItem BtnHoanTac;
        private DevExpress.XtraBars.BarButtonItem BtnGhi;
        private DevExpress.XtraBars.BarButtonItem BtnLamMoi;
        private DevExpress.XtraBars.BarButtonItem BtnThoat;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl nhanVienSanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDT;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSan;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtttx;
        private DevExpress.XtraEditors.TextEdit txtmacongty;
        private DevExpress.XtraEditors.TextEdit txtsdt;
        private DevExpress.XtraEditors.TextEdit txtdiachi;
        private DevExpress.XtraEditors.TextEdit txtphai;
        private DevExpress.XtraEditors.DateEdit dtengaysinh;
        private DevExpress.XtraEditors.TextEdit txten;
        private DevExpress.XtraEditors.TextEdit txtho;
        private DevExpress.XtraEditors.TextEdit txtmanhanvien;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarButtonItem BtnChuyenCN;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
    }
}