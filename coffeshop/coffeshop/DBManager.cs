using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeshop
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();

        private DBManager()
        {

        }
        public static DBManager getInstance()
        {
            return instance_;
        }
        string strConn = "Server=106.10.39.218;Database=s5360262;Uid=s5360262;Pwd=s5360262;Charset=utf8";

        public int insert(string query)
        {
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
            return rdr;
        }
        public DataTable select(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();

                return dt;
            }
        }
        public int update(string query)
        {
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {

                conn.Open();
                MySqlCommand cmd =
                      new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
            return rdr;
        }
        public int delete(string query)
        {
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {

                conn.Open();
                MySqlCommand cmd =
                      new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
            return rdr;
        }
    }
}
