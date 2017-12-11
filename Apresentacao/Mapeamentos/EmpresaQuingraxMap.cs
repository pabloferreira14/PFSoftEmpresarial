using Apresentacao.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Mapeamentos
{
    public class EmpresaQuingraxMap : EntityTypeConfiguration<EmpresaQuingrax>
    {
        public EmpresaQuingraxMap()
        {
            ToTable("EmpresaQuingrax");

            HasKey(p => p.EmpresaQuingraxID);
            Property(p => p.EmpresaQuingraxID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Nome).HasMaxLength(80).HasColumnType("varchar").IsRequired();
            Property(p => p.Chave).HasMaxLength(30).HasColumnType("varchar").IsRequired();
            Property(p => p.DataCadastro).HasColumnType("DateTime").IsRequired();
            Property(p => p.NomeFantasia).HasMaxLength(40).HasColumnType("varchar").IsOptional();
            Property(p => p.Endereco).HasMaxLength(60).HasColumnType("varchar").IsRequired();
            Property(p => p.Numero).HasColumnType("int").IsRequired();
            Property(p => p.Bairro).HasMaxLength(60).HasColumnType("varchar").IsRequired();
            Property(p => p.Cep).HasMaxLength(10).HasColumnType("varchar").IsRequired();
            Property(p => p.Telefone1).HasMaxLength(15).HasColumnType("varchar").IsRequired();
            Property(p => p.Telefone2).HasMaxLength(15).HasColumnType("varchar").IsOptional();
            Property(p => p.Telefone3).HasMaxLength(15).HasColumnType("varchar").IsOptional();
            Property(p => p.Cnpj).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            Property(p => p.IE).HasMaxLength(20).HasColumnType("varchar").IsRequired();
            Property(p => p.Email).HasMaxLength(20).HasColumnType("varchar").IsRequired();
        }
    }
}
