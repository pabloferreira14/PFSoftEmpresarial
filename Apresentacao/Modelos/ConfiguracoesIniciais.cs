using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Modelos
{
    public class ConfiguracoesIniciais
    {
        public int ConfiguracoesIniciaisID { get; set; }
        public string DataSource { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

    }
}
