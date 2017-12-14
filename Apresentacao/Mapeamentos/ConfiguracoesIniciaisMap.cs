using Apresentacao.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Mapeamentos
{
    public class ConfiguracoesIniciaisMap : EntityTypeConfiguration<ConfiguracoesIniciais>
    {
        public ConfiguracoesIniciaisMap()
        {
            ToTable("ConfiguracoesIniciais");

            HasKey(p => p.ConfiguracoesIniciaisID);
            Property(p => p.ConfiguracoesIniciaisID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.DataSource).HasMaxLength(50).HasColumnType("varchar").IsRequired();
            Property(p => p.Banco).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            Property(p => p.Usuario).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            Property(p => p.Senha).HasMaxLength(20).HasColumnType("varchar").IsRequired();
        }


    }
}
