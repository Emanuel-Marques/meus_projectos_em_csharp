using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas
{
    class Globais
    {
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string pasta = @"\banco\";
        public static string banco = "DataBase.db";
        public static string caminhoFotos = caminho +@"\fotos_funcionarios\";

        public static string nome;
        public static string username;
        public static string senha;
        public static int nivel;
    }
}
