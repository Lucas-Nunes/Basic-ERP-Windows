using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IniParser.Model;
using IniParser;
using System.IO;

namespace Basic_ERP_Windows
{
    public partial class uLogin : Form
    {
        public uLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData DadosINI = parser.ReadFile(uFuncoes.CaminhoConfigINI);
            string sConexao = "Data Source="+ DadosINI["[SISTEMA]"]["Instancia"]+ ";Initial Catalog="+ DadosINI["[SISTEMA]"]["Dados"]+";User ID="+ DadosINI["[SISTEMA]"]["Usuario"]+ ";Password="+DadosINI["[SISTEMA]"]["Senha"];

            using (SqlConnection conexaoBD = new SqlConnection(sConexao))
            {
                conexaoBD.Open();

                using (SqlCommand comando = new SqlCommand("select u.NOME from USUARIO u where u.NOME = @NOME AND U.SENHA = @SENHA ", conexaoBD))
                {
                    comando.Parameters.AddWithValue("@Nome", usuario.Text);
                    comando.Parameters.AddWithValue("@Senha", senha.Text);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           uFuncoes.NomeUsuario = reader.GetString(0);
                           this.Close();
                        }
                        else 
                        {
                            MessageBox.Show("Senha ou nome de usuário incorretos.", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }                           
                }
            }
        }
    }
}
