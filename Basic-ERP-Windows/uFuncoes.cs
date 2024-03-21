using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ERP_Windows
{
    internal static class uFuncoes
    {
        public static string NomeUsuario { get; set; }
        public static string DiretorioDeExecução = Directory.GetCurrentDirectory();
        public static string NomeDoArquivo = "Config.ini";
        public static string CaminhoConfigINI { get; set; } = Path.Combine(DiretorioDeExecução, NomeDoArquivo);
    }
}
