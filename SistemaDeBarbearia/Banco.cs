using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace SistemaDeBarbearia
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = "+Globais.caminhoBanco+Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterUsuarios()
        {
            try
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();

                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable dql(string sql)//Data Query Language
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = sql;
            da = new SQLiteDataAdapter(cmd.CommandText,vcon);
            da.Fill(dt);
            return dt;
        }

        public static void dml(string sql)//Data Manipulation Language 
        {
            SQLiteDataAdapter da = null;
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = sql;
            da = new SQLiteDataAdapter(cmd.CommandText,vcon);
            cmd.ExecuteNonQuery();
        } 
    }
}
