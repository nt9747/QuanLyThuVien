/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien;

namespace QuanLyThuVien
{
    class connection
    {
        private SqlConnection conn = null;
        public int connect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(globalParameter.str);
            }
            try
            {
                conn.Open();
                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int isOpen()
        {
            if (conn == null) return -1;
            if (conn.State == ConnectionState.Closed) return -1;
            return 0;
        }
        public void close()
        {
            if (isOpen() == 0)
            {
                conn.Close();
                conn = null;
            }
        }
        public int doSql(string sql, params SqlParameter[] pr)
        {
            int ret = 0;
            if (isOpen() < 0) ret = connect();
            if (ret < 0) return -2;
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = sql;
            foreach (SqlParameter p in pr)
            {
                cm.Parameters.Add(p);
            }
            try
            {
                ret = cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = -1;
            }
            return ret;
        }
        public int doStored(string storedName, params SqlParameter[] pr)
        {
            int ret = 0;
            if (isOpen() < 0) ret = connect();
            if (ret < 0) return -2;
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedName;
            foreach (SqlParameter p in pr)
            {
                cm.Parameters.Add(p);
            }
            try
            {
                ret = cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = -1;
            }
            return ret;
        }
        public int getSql(ref DataSet ds, string tableName, string sql, params SqlParameter[] pr)
        {
            int ret = 0;
            if (isOpen() < 0) ret = connect();
            if (ret < 0) return -2;
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            foreach (SqlParameter p in pr)
                cm.Parameters.Add(p);
            try
            {
                ret = da.Fill(ds, tableName);
            }
            catch (Exception e)
            {
                ret = -1;
            }
            return ret;
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace WinFormDemo
{
    public class sqlQuery
    {
        public static SqlConnection con;
        //public static bool isLoginSuccess;
        //Properties.Settings st = new DataAccessLayer.Properties.Settings();    
        //public static string ConnectionString2 = @"server ='VTF-PC' ;database ='QLCQSVN' ;User ID=sa;password=vtf;Integrated Security = false";//;Integrated Security = false
        public static string ConnectionString = @"server ='(local)' ;database ='ABC' ;Integrated Security = true";//;Integrated Security = false
        public sqlQuery()
        {
            try
            {
                if (con != null && con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                else if (con == null)
                {
                    con = new SqlConnection();
                    con.ConnectionString = ConnectionString;// DataAccessLayer.Properties.Settings.Default.ConnectionString; //st.ConnectionString
                    con.Open();
                }
            }
            catch (Exception)
            {
            }
        }
        public sqlQuery(String strConnect)
        {
            try
            {
                if (con != null)
                    con.Close();
                con = new SqlConnection();
                con.ConnectionString = strConnect;
                con.Open();
            }
            catch (Exception)
            {
                //throw;
            }
        }
        public sqlQuery(string MayChu, string KieuXacThuc, string TenCSDL, string TaiKhoan, string MatKhau)
        {
            string strConnect = "";
            if (KieuXacThuc == "SQL Server Authentication")
                strConnect = "server=" + MayChu + ";database=" + TenCSDL + ";User ID=" + TaiKhoan + ";password= " + MatKhau + " ;Integrated Security = false";
            else
                strConnect = "server =(local);database =" + TenCSDL + " ;Integrated Security = true";

            try
            {
                if (con != null)
                    con.Close();
                con = new SqlConnection();
                //DataAccessLayer.Properties.Settings.Default.ConnectionString = strConnect;
                ConnectionString = strConnect;
                con.ConnectionString = ConnectionString;
                con.Open();
            }
            catch (Exception ex)
            {
                // throw;
            }
        }

        public DataTable Get_table(string query)
        {
            //SqlCommand Command = new SqlCommand(query, con);
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                sqldataAdapter.Fill(dt);//;, "CONFIG");

            }
            catch (Exception ex)
            {
                //throw;
            }
            return dt;
        }


        public void Exe_Nonquery(string query)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // throw;
            }
        }

        // Hàm thực thi các câu lệnh: thêm, sữa, xóa. 
        public void ExecuteSPNoneQuery(string strCode)
        {
            // Trả vể số lượng bản ghi thực hiện được khi thực thi câu lệnh. 
            int ressult = 0;
            if (strCode != "")
            {
                // Mở kết nối trước khi sử dụng đối tượng sqlCommand. 
                if (con.State == ConnectionState.Closed)
                    con.Open();
                // Khởi tạo đối tượng sqlCommand. 
                SqlCommand sqlCommand = new SqlCommand(strCode, con);
                sqlCommand.CommandType = CommandType.Text;
                // Sổ bản ghi thực hiện được. 
                ressult = sqlCommand.ExecuteNonQuery();
                // 
                // Đóng kết nối. 
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        // Hàm thực thi các câu lệnh trả về 1 giá trị. 
        public string ExecuteScalarQuery(string strCode)
        {
            string result = "";
            // Mở kết nối. 
            if (con.State == ConnectionState.Closed)
                con.Open();
            // Khởi tạo đối tượng sqlCommand. 
            SqlCommand sqlCommand = new SqlCommand(strCode, con);
            sqlCommand.CommandType = CommandType.Text;
            result = sqlCommand.ExecuteScalar().ToString();
            if (con.State == ConnectionState.Open)
                con.Close();
            return result;
        }

        public DataTable LayDuLieu(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LayDuLieu(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int update(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteNonQuery();
        }
        public int update(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
