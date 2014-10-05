namespace SimpleAccounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Status = c.Boolean(nullable: false),
                        Category = c.String(),
                        Origin = c.String(),
                        TypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.ParentId)
                .ForeignKey("dbo.AccountType", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.ParentId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.AccountType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Website = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Password = c.String(nullable: false),
                        Status = c.String(),
                        Address = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JournalEntry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sequency = c.String(),
                        Period = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Debts = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Credit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Account_Id = c.Int(),
                        Journal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.Account_Id)
                .ForeignKey("dbo.Journal", t => t.Journal_Id)
                .Index(t => t.Account_Id)
                .Index(t => t.Journal_Id);
            
            CreateTable(
                "dbo.Journal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(),
                        Password = c.String(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.JournalEntry", "Journal_Id", "dbo.Journal");
            DropForeignKey("dbo.JournalEntry", "Account_Id", "dbo.Account");
            DropForeignKey("dbo.Account", "TypeId", "dbo.AccountType");
            DropForeignKey("dbo.Account", "ParentId", "dbo.Account");
            DropIndex("dbo.User", new[] { "CompanyId" });
            DropIndex("dbo.JournalEntry", new[] { "Journal_Id" });
            DropIndex("dbo.JournalEntry", new[] { "Account_Id" });
            DropIndex("dbo.Account", new[] { "TypeId" });
            DropIndex("dbo.Account", new[] { "ParentId" });
            DropTable("dbo.User");
            DropTable("dbo.Journal");
            DropTable("dbo.JournalEntry");
            DropTable("dbo.Company");
            DropTable("dbo.AccountType");
            DropTable("dbo.Account");
        }
    }
}
