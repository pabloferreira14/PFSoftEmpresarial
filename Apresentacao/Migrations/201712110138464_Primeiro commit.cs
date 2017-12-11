namespace Apresentacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeirocommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpresaQuingrax",
                c => new
                    {
                        EmpresaQuingraxID = c.Int(nullable: false, identity: true),
                        Chave = c.String(nullable: false, maxLength: 30, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                        NomeFantasia = c.String(maxLength: 40, unicode: false),
                        Endereco = c.String(nullable: false, maxLength: 60, unicode: false),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(nullable: false, maxLength: 60, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, unicode: false),
                        Telefone1 = c.String(nullable: false, maxLength: 15, unicode: false),
                        Telefone2 = c.String(maxLength: 15, unicode: false),
                        Telefone3 = c.String(maxLength: 15, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 20, unicode: false),
                        IE = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.EmpresaQuingraxID);
            
            CreateTable(
                "dbo.EmpresaSantaEdwiges",
                c => new
                    {
                        EmpresaID = c.Int(nullable: false, identity: true),
                        Chave = c.String(nullable: false, maxLength: 30, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                        NomeFantasia = c.String(maxLength: 40, unicode: false),
                        Endereco = c.String(nullable: false, maxLength: 60, unicode: false),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(nullable: false, maxLength: 60, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 10, unicode: false),
                        Telefone1 = c.String(nullable: false, maxLength: 15, unicode: false),
                        Telefone2 = c.String(maxLength: 15, unicode: false),
                        Telefone3 = c.String(maxLength: 15, unicode: false),
                        Cnpj = c.String(nullable: false, maxLength: 20, unicode: false),
                        IE = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.EmpresaID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                        Telefone = c.String(maxLength: 15, unicode: false),
                        Celular = c.String(nullable: false, maxLength: 15, unicode: false),
                        Email = c.String(maxLength: 60, unicode: false),
                        UsuarioLogin = c.String(nullable: false, maxLength: 20, unicode: false),
                        SenhaLogin = c.String(nullable: false, maxLength: 80, unicode: false),
                        ConfirmaSenha = c.String(nullable: false, maxLength: 80, unicode: false),
                        Status = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.EmpresaSantaEdwiges");
            DropTable("dbo.EmpresaQuingrax");
        }
    }
}
