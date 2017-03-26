using FirstApplication.Models;

namespace FirstApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstApplication.Models.MvcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FirstApplication.Models.MvcContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Students.AddOrUpdate(
              p => p.Name,
              new Student { Name = "Andrew Peters" },
              new Student { Name = "Brice Lambson" },
              new Student { Name = "Rowan Miller" }
            );
            //
        }
    }
}
