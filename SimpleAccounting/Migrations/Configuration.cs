namespace SimpleAccounting.Migrations
{
    using SimpleAccounting.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleAccounting.DAL.AccountingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleAccounting.DAL.AccountingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.AccountTypes.AddOrUpdate(
                new AccountType { Name = "Assets" },
                new AccountType { Name = "Capital" },
                new AccountType { Name = "Payable" },
                new AccountType { Name = "Receivable" },
                new AccountType { Name = "Spend" }
            );
        }
    }
}
