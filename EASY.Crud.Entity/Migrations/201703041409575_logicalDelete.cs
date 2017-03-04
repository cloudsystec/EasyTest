namespace EASY.Crud.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class logicalDelete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BankInfos", "IsDeleted", c => c.Boolean(nullable: false, defaultValue:false));
            AddColumn("dbo.Knowledges", "IsDeleted", c => c.Boolean(nullable: false, defaultValue: false));
            AddColumn("dbo.KnowledgeBases", "IsDeleted", c => c.Boolean(nullable: false, defaultValue: false));
            AddColumn("dbo.Persons", "IsDeleted", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "IsDeleted");
            DropColumn("dbo.KnowledgeBases", "IsDeleted");
            DropColumn("dbo.Knowledges", "IsDeleted");
            DropColumn("dbo.BankInfos", "IsDeleted");
        }
    }
}
