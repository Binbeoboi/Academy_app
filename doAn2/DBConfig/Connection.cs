﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn2.DBConfig
{
    public class Connection
    {
        //private static string stringConnection = "Data Source=DESKTOP-Q1JJOI6\\SQLEXPRESS;Initial Catalog=TrungTamGiaoDuc;Integrated Security=True";
        private static string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\TrungTamGiaoDuc.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetSqlConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                return conn;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với Sql.");
                return null;
            }

        }
    }
}
