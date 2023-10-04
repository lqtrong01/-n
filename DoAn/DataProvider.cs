using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoAn
{
    public class DataProvider
    {
        static string strKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DB\QuanLyQuanCaPhe.mdf;Integrated Security=True;Connect Timeout=30";
        static SqlConnection conn = new SqlConnection(strKetNoi);
        static SqlDataAdapter daNSX = new SqlDataAdapter();
        public static SqlConnection OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        public static DataTable ExecuteSelectCommand(string sql, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql);
            DataTable tbl = new DataTable();

            cmd.Connection = OpenConnection();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            daNSX.SelectCommand = cmd;
            daNSX.Fill(tbl);

            conn.Close();

            return tbl;
        }
        public static int ExecuteInsertCommand(string sql, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql);
            int rows = 0;

            cmd.Connection = OpenConnection();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            rows = cmd.ExecuteNonQuery();

            conn.Close();

            return rows;
        }
        public static DataTable ExecuteUpdateCommand(string sql, SqlParameter[] parameters)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Connection = OpenConnection();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            daNSX.SelectCommand = cmd;
            daNSX.Fill(tbl);

            conn.Close();

            return tbl;
        }

        public static DataTable ExecuteDeleteCommand(string sql, SqlParameter[] parameters)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Connection = OpenConnection();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            daNSX.SelectCommand = cmd;
            daNSX.Fill(tbl);

            conn.Close();

            return tbl;
        }
    }
}
