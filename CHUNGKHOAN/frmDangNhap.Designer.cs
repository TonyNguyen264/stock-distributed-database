
namespace CHUNGKHOAN
{
    partial class frmdangnhap
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
            this.chbShowPass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbShowPass
            // 
            this.chbShowPass.AutoSize = true;
            this.chbShowPass.Location = new System.Drawing.Point(914, 444);
            this.chbShowPass.Margin = new System.Windows.Forms.Padding(5);
            this.chbShowPass.Name = "chbShowPass";
            this.chbShowPass.Size = new System.Drawing.Size(136, 29);
            this.chbShowPass.TabIndex = 20;
            this.chbShowPass.Text = "ShowPass";
            this.chbShowPass.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Đăng Nhập";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(706, 515);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(133, 51);
            this.BtnThoat.TabIndex = 11;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            // 
            // cmbCN
            // 
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(486, 304);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(352, 33);
            this.cmbCN.TabIndex = 12;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(486, 370);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(352, 33);
            this.txtUsername.TabIndex = 16;
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Location = new System.Drawing.Point(486, 515);
            this.BtnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(144, 51);
            this.BtnDangNhap.TabIndex = 19;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn Chi Nhánh";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(486, 444);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(352, 33);
            this.txtPass.TabIndex = 17;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // frmdangnhap
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 821);
            this.Controls.Add(this.chbShowPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.cmbCN);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Name = "frmdangnhap";
            this.Text = "frmdangnhap";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbShowPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
    }
}