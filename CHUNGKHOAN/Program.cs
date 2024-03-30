using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;


namespace CHUNGKHOAN
{
    static class Program
    {
        /**********************************************
         * conn: biến để kết nối tới cơ sở dữ liệu
         * connstr: connection String , chuỗi kết nối động
         * dataReader: 
         **********************************************/
        public static SqlConnection conn = new SqlConnection();//conn
        public static SqlCommand Sqlcmd = new SqlCommand();

        public static String connstr = "";//connstr
        public static String connstrPublisher = @"Data Source=DESKTOP-JN8NVTU\SERVER;Initial Catalog=CHUNGKHOAN;Integrated Security=True";
        public static SqlDataReader myReader;//myReader


        public static String serverName = "";//servername
        public static String serverNameLeft = "";
        public static String userName = "";//username mã nhân viên hoặc cmnd

        public static String loginName = "";//mlogin gõ tên 
        public static String loginPassword = "";//password pass 

        public static BindingSource bdsDSPM = new BindingSource();



        public static String database = "CHUNGKHOAN";

        public static String remoteLogin = "HTKN";//remotelogin
        public static String remotePassword = "1234";//remotepassword

        public static String currentLogin = "";//mloginDN
        public static String currentPassword = "";//passwordDN

        public static String Role = "";// mGroup CHi nhanh -0 NGAN hàng 1 khach 2
        public static String Hoten = "";//mHoten họ tên
        public static int mCN = 0;//mChiNhanh 1

        public static Regex isValidInputNumber = new Regex(@"^0(\d{9})$");

        public static frmdangnhap frmdangnhap;
        public static frmmain frmmain;

        /*        public static Regex isValidInputCMNDSTK = new Regex(@"^\d{9}$");
        */




        /*bidSou: BindingSource -> liên kết dữ liệu từ bảng dữ liệu vào chương trình*/
        /*        public static BindingSource bindingSource = new BindingSource();//bds_dspm
        */
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.loginName + ";password=" + Program.loginPassword;
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }

        public static DataTable LoadSP(string storedProcedureName, SqlParameter[] parameters)
        {

            using (SqlCommand command = new SqlCommand(storedProcedureName, conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào câu lệnh SQL
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmmain = new frmmain();
            Application.Run(frmmain);
        /*    Program.FrmNhanVien = new frmNhanVien();
            Application.Run(FrmNhanVien);*/

            /*        FrmMain.Hide();
                    Program.FrmDangNhap = new frmDangNhap();
                    Application.Run(FrmDangNhap);*/

        }
    }
}
