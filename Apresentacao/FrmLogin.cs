using Apresentacao.Enumeradores;
using Apresentacao.Modelos;
using Apresentacao.Validacoes;
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
        Cryptografia cryptografia = new Cryptografia();


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //VerificaDataExpiracao();
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PFSoftEmpresarial";

            if (System.Diagnostics.Process.GetProcessesByName("PFSoftEmpresarial").Length > 2)
            {
                Application.Exit();
            }
            else
            {

            }

            cbbEmpresas.DataSource = Enum.GetValues(typeof(enumEmpresas));
        }


        public void VerificaDataExpiracao()
        {
            try
            {
                List<EmpresaQuingrax> list = new List<EmpresaQuingrax>();

                var result = list.Where(p => p.Chave != null).FirstOrDefault();
                DateTime dataLimiteUso = Convert.ToDateTime(cryptografia.Crypto(result.ToString(), false));

                if (Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) > dataLimiteUso)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
