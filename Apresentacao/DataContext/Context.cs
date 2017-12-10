using Apresentacao.Mapeamentos;
using Apresentacao.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.DataContext
{
    public class Context : DbContext
    {
        public Context() : base("name = MyConnectionString") //parâmetro da connection string
        {
            Configuration.LazyLoadingEnabled = false; //mecanismo que faz com que carregue automaticamente os relacionamentos em memória - perda de perfomace
            Configuration.ProxyCreationEnabled = false; //por padrão cria um proxy toda vez que é instanciado uma entidade POCO
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EmpresaSantaEdwige> EmpresaSantaEdwiges { get; set; }
        public DbSet<EmpresaQuingrax> EmpresaQuingrax { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Algumas configurações

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Aqui remove a pluralização padrão do Etity Framework que é em inglês
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Desabilitando o delete em cascata em relacionamentos 1:N - Evitando ter registros filhos     sem registros pai
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Basicamente a mesma configuração, porém em relacionamenos N:N
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); //Toda propriedade do tipo string na entidade POCO seja configurado como VARCHAR no SQL Server
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());//Definimos usando reflexão que toda propriedade que contenha "Nome da classe" + Id como "UsuarioID" por exemplo, seja dada como chave primária, caso não tenha sido especificado

            #endregion

            //Utilizando as configuraçoes das classes de mapeamentos
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new EmpresaSantaEdwigeMap());
            modelBuilder.Configurations.Add(new EmpresaQuingraxMap());

            base.OnModelCreating(modelBuilder);
        }



    }
}
