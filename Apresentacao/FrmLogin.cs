using Apresentacao.DataContext;
using Apresentacao.Enumeradores;
using Apresentacao.Modelos;
using Apresentacao.Validacoes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            if (System.Diagnostics.Process.GetProcessesByName("SysControleInterno").Length >= 2)
            {
                MessageBox.Show("O Sistema já se encontra aberto!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            BuscaParametroIniciais();

            InitializeComponent(); //
        }

        #region Busca Parametros iniciais do sistema

        public void BuscaParametroIniciais()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\ConfiguracoesIniciais", true);

                string dataSource = string.Empty;
                string banco = string.Empty;
                string usuario = string.Empty;
                string senha = string.Empty; ; 

                if ((registryKey != null))
                {
                    return;
                }
                else
                {
                    FrmConfiguracoesIniciais frmConfiguracoesIniciais = new FrmConfiguracoesIniciais();
                    frmConfiguracoesIniciais.ShowDialog();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na leitura do Registro: " + erro.Message);
            }
        }

        #endregion


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            using (Context ct = new Context())
            {
                var result = (from p in ct.Usuarios select p).FirstOrDefault();

                if (result == null)
                {
                    FrmUsuario frmUsuario = new FrmUsuario();
                    frmUsuario.ShowDialog();
                }
                else
                {
                    VerificaDataExpiracao();

                    if (System.Diagnostics.Process.GetProcessesByName("PFSoftEmpresarial").Length > 2)
                    {
                        Application.Exit();
                    }
                    else
                    {

                    }

                    cbbEmpresas.DataSource = Enum.GetValues(typeof(enumEmpresas));
                }
            }
        }


        public void VerificaDataExpiracao()
        {
            try
            {
                using (Context ct = new Context())
                {
                    Cryptografia cryptografia = new Cryptografia();

                    var result = (from p in ct.EmpresaQuingrax select p.Chave).FirstOrDefault();
                    var chave = cryptografia.Crypto(result.ToString(), true);
                    DateTime limeteUso = Convert.ToDateTime(cryptografia.Crypto(chave.ToString(), false));

                    if (Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) > limeteUso)
                    {
                        FrmContato frmContato = new FrmContato();
                        frmContato.Mensagem = "Permissão de uso expirou!";
                        frmContato.Detalhes = "A data limite de uso do sistema expirou! Você pode escolher uma das opções abaixo para voltar a utilizar o sistema!";
                        frmContato.ShowInTaskbar = false;
                        frmContato.ShowDialog();

                        if (!frmContato.Autenticou)
                            Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
