using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeBarbearia
{
    class Globais
    {
        public static int nivel = 0;
        public static string nome = "";
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco.db";
        public static string caminhoBanco = caminho+ @"\BancoDeDados\";
    }
}
