using Apresentacao.DataContext;
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
    public partial class FrmConfiguracoesIniciais : Form
    {
        public FrmConfiguracoesIniciais()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
                GravaParametroIniciais();

            try
            {
                using (Context ct = new Context())
                {
                    Cryptografia cryptografia = new Cryptografia();

                    var result = (from p in ct.ConfiguracoesIniciais select p).FirstOrDefault();

                    ct.ConfiguracoesIniciais.Add(new ConfiguracoesIniciais
                    {
                        DataSource = txtDataSource.Text,
                        Banco = txtBanco.Text,
                        Usuario = cryptografia.Crypto(txtUsuario.Text, true),
                        Senha = cryptografia.Crypto(txtSenha.Text, true)
                    });

                    ct.SaveChanges();
                    MessageBox.Show("Configurações cadastradas com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    FrmLogin frmLogin = new FrmLogin();
                    this.Hide();
                    frmLogin.Closed += (s, args) => this.Close();
                    frmLogin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!\n\n" + ex.Message.ToString(), "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region GRAVA CONFIGURAÇÕES INICIAIS NO REGISTRO DE WINDOWS

        public void GravaParametroIniciais()
        {
            try
            {
                Cryptografia cryptografia = new Cryptografia();
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

                if ((registryKey != null))
                {
                    registryKey = registryKey.CreateSubKey("ConfiguracoesIniciais");

                    registryKey.SetValue("DataSource", txtDataSource.Text);
                    registryKey.SetValue("Banco", txtBanco.Text);
                    registryKey.SetValue("Usuario ", cryptografia.Crypto(txtUsuario.Text, true));
                    registryKey.SetValue("Senha ", cryptografia.Crypto(txtSenha.Text, true));

                    registryKey.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no gravação do Registro: " + ex.Message);
            }
        }

        #endregion

        #region VALIDA CAMPOS 

        private Boolean ValidaCampos()
        {
            string erro = "";

            if (string.IsNullOrEmpty(txtDataSource.Text))
            {
                erro = "\nDataSource!";
            }
            if (string.IsNullOrEmpty(txtBanco.Text))
            {
                erro += "\nBanco!";
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erro += "\nUsuário!";
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erro += "\nSenha!";
            }
            if (erro != "")
            {
                MessageBox.Show("Os seguintes campos não foram informados : \n\n" + erro, "Informação do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        #endregion

        private void FrmConfiguracoesIniciais_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
