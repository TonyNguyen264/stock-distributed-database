using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHUNGKHOAN.db
{
    public class ConnectDB
    {
        string chuoiketnoi = @"Data Source=DESKTOP-JN8NVTU\SERVER;Initial Catalog=CHUNGKHOAN;Integrated Security=True";
        SqlConnection conn;
        public ConnectDB()
        {
            //tạo kết nối
            conn = new SqlConnection(chuoiketnoi);
        }
        public void Mo()
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public void ThemSuaXoa(string sql)
        {//viết ra hàm chung để thực hiện thêm sửa xóa dữ liệu thông qua sql command
            SqlCommand comm = new SqlCommand(sql, conn);// 
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            if (ketqua >= 1) { }
            //MessageBox.Show("Thao tác thành công !!!");
            else { }
            // MessageBox.Show("Thao tác thất bại !!!");
        }
        public DataTable LoadDL(string sql)
        {
            //tạo đốt tương data table để lưu dữ liệu được lấy ở trên hàm thêm sưa xóa
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LoadSP(string storedProcedureName, SqlParameter[] parameters)
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

    }
}
