using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    class Banco
    {
        public static SQLiteConnection conexao;

        public static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source ="+Globais.caminho+Globais.pasta+Globais.banco);
            conexao.Open();
            return conexao;
        }

        public static void dml(string query)
        {
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
         
        }

        public static DataTable dql(string query)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = conexaoBanco();
            var cmd = vcon.CreateCommand();

            cmd.CommandText = query;

            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            return dt;
        }
    }
}
