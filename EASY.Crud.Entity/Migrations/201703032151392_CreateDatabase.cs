namespace EASY.Crud.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankInfos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cpf = c.String(nullable: false),
                        Bank = c.String(nullable: false),
                        Agency = c.String(nullable: false),
                        Account = c.String(nullable: false),
                        AccountType = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Knowledges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Points = c.Int(nullable: false),
                        KnowledgeBaseId = c.Int(nullable: false),
                        PersonId = c.Guid(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeBases", t => t.KnowledgeBaseId, cascadeDelete: true)
                .ForeignKey("dbo.Persons", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.KnowledgeBaseId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.KnowledgeBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Skype = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        HourlySalary = c.String(nullable: false),
                        MoreLanguages = c.String(),
                        Linkedin = c.String(),
                        Portifolio = c.String(),
                        CrudLink = c.String(),
                        BestTime = c.Int(nullable: false),
                        Disponibility = c.Int(nullable: false),
                        BankInfoId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BankInfos", t => t.BankInfoId, cascadeDelete: true)
                .Index(t => t.BankInfoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Knowledges", "PersonId", "dbo.Persons");
            DropForeignKey("dbo.Persons", "BankInfoId", "dbo.BankInfos");
            DropForeignKey("dbo.Knowledges", "KnowledgeBaseId", "dbo.KnowledgeBases");
            DropIndex("dbo.Persons", new[] { "BankInfoId" });
            DropIndex("dbo.Knowledges", new[] { "PersonId" });
            DropIndex("dbo.Knowledges", new[] { "KnowledgeBaseId" });
            DropTable("dbo.Persons");
            DropTable("dbo.KnowledgeBases");
            DropTable("dbo.Knowledges");
            DropTable("dbo.BankInfos");
        }
    }
}
