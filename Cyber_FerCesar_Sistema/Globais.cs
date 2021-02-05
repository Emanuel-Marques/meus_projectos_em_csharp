using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_FerCesar_Sistema
{
    class Globais
    {
        public static int nivel = 0;
        public static string nome = "";

        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco.db";
        public static string caminhoBanco = caminho + @"\DataBase\";

        public static string caminhoFotos = caminho + @"\Fotos\";
        public static string FotosFuncionarios = @"Fotos_Funcionarios\";

    }
}
