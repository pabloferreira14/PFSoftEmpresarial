using Apresentacao.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Mapeamentos
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {

        public UsuarioMap()
        {
            ToTable("Usuarios");

            HasKey(p => p.UsuarioID); 
            Property(p => p.UsuarioID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            
            Property(p => p.Nome).HasMaxLength(80).HasColumnType("varchar").IsRequired();
            Property(p => p.Telefone).HasMaxLength(15).HasColumnType("varchar").IsOptional();
            Property(p => p.Celular).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            Property(p => p.Email).HasMaxLength(60).HasColumnType("varchar").IsOptional();
            Property(p => p.UsuarioLogin).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            Property(p => p.SenhaLogin).HasMaxLength(80).HasColumnType("varchar").IsRequired();
            Property(p => p.ConfirmaSenha).HasMaxLength(80).HasColumnType("varchar").IsRequired();
            Property(p => p.Status).IsRequired();
            Property(p => p.DataCadastro).HasColumnType("DateTime").IsRequired();

        }
    }
}
