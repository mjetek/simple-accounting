namespace SimpleAccounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIsAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Account", "CompanyId", c => c.Int(nullable: false));
            AddColumn("dbo.Journal", "CompanyId", c => c.Int(nullable: false));
            AddColumn("dbo.User", "IsAdmin", c => c.Boolean(nullable: false));
            DropColumn("dbo.Company", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Company", "Password", c => c.String(nullable: false));
            DropColumn("dbo.User", "IsAdmin");
            DropColumn("dbo.Journal", "CompanyId");
            DropColumn("dbo.Account", "CompanyId");
        }
    }
}
