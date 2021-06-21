using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace salaoPortfolio
{
    class Helpers
    {
        MySqlConnection conexao;
        DataTable dt = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter();
        readonly string strQuery = "SELECT * FROM eventos";
        public DataTable DgvGet()
        {
            try
            {
                conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString());
                dt = new DataTable();
                da = new MySqlDataAdapter(strQuery, conexao);
                conexao.Open();
                da.Fill(dt);
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show(msqle.ToString());
            }
            finally
            {
                conexao.Close();
                conexao = null;
                da = null;
            }
            return dt;
        }
        public DataTable DgvGet(string query)
        {
            try
            {
                conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString());
                dt = new DataTable();
                da = new MySqlDataAdapter(strQuery + query, conexao);
                conexao.Open();
                da.Fill(dt);
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show(msqle.ToString());
            }
            finally
            {
                conexao.Close();
                conexao = null;
                da = null;
            }
            return dt;
        }
    }
}
