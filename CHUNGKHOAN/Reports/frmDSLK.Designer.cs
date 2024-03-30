namespace CHUNGKHOAN.Reports
{
    partial class frmDSLK
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCP = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtMaCP);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtMaNDT);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(109, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(764, 472);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập thông tin tra cứu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Nhà Đầu tư";
            // 
            // txtMaNDT
            // 
            this.txtMaNDT.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNDT.Location = new System.Drawing.Point(315, 174);
            this.txtMaNDT.Name = "txtMaNDT";
            this.txtMaNDT.Size = new System.Drawing.Size(389, 41);
            this.txtMaNDT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Cổ phiếu";
            // 
            // txtMaCP
            // 
            this.txtMaCP.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCP.Location = new System.Drawing.Point(315, 269);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(389, 41);
            this.txtMaCP.TabIndex = 12;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(429, 372);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(122, 51);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(204, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 51);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDSLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 611);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDSLK";
            this.Text = "frmDSLK";
            this.Load += new System.EventHandler(this.frmDSLK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNDT;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
    }
}