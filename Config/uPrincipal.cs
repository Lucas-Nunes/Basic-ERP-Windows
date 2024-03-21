using System;
using Microsoft.Win32;
using IniParser;
using IniParser.Model;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Config
{
    public partial class uPrincipal : Form
    {
        public uPrincipal()
        {
            InitializeComponent();
        }

        private void uPrincipal_Load(object sender, EventArgs e)
        {
            instancia.Items.Clear();
            List<string> instancias = new List<string>();

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL"))
            {
                if (key != null)
                {
                    foreach (string Nomeinstancia in key.GetValueNames())
                    {
                        instancias.Add(Nomeinstancia);
                    }
                    instancia.Items.AddRange(instancias.ToArray());
                }
            }
        }

        private void BntSalvar_Click(object sender, EventArgs e)
        {
            string DiretorioDeExecução = Directory.GetCurrentDirectory();
            string NomeDoArquivo = "Config.ini";
            string caminhoCompleto = Path.Combine(DiretorioDeExecução, NomeDoArquivo);

            if (!File.Exists(caminhoCompleto))
            {
                File.Create(caminhoCompleto);
                string DadosDoArquivo = @"[SISTEMA]" +
                    @"Instancia=" +
                    @"Dados=" +
                    @"Usuario=" +
                    @"Senha=";
               using (StreamWriter writer = new StreamWriter(caminhoCompleto)) { writer.WriteLine(DadosDoArquivo); }
            }

            FileIniDataParser parser = new FileIniDataParser();
            IniData DadosINI = parser.ReadFile(caminhoCompleto);

            DadosINI["[SISTEMA]"]["Instancia"] = Environment.MachineName +'\\'+ instancia.Text;
            DadosINI["[SISTEMA]"]["Dados"]     = BancoDeDados.Text;
            DadosINI["[SISTEMA]"]["Usuario"]   = Usuario.Text;
            DadosINI["[SISTEMA]"]["Senha"]     = Senha.Text;
            parser.WriteFile(caminhoCompleto, DadosINI);

            MessageBox.Show("Gravado com sucesso!");
            this.Close();
        }
    }
}
