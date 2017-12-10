using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Modelos
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string UsuarioLogin { get; set; }
        public string SenhaLogin { get; set; }
        public string ConfirmaSenha { get; set; }
        public bool Status { get; set; }
        public DateTime? DataCadastro { get; set; }

    }
}
