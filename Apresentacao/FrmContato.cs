using Apresentacao.DataContext;
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
    public partial class FrmContato : Form
    {
        public FrmContato()
        {
            InitializeComponent();
        }

        #region Propriedades
        public string Mensagem { get; set; }
        public string Detalhes { get; set; }
        public bool Autenticou { get; set; }

        #endregion


        private void FrmContato_Load(object sender, EventArgs e)
        {
            using (Context ct = new Context())
            {
                var result = from p in ct.EmpresaQuingrax select p;



            }
        }
    }
}
