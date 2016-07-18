namespace Server.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Repository.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Server.Models.ServerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Server.Models.ServerContext context)
        {

            context.Users.AddOrUpdate(x => x.ID,
        new User() { ID = 1, Name = "Jane Austen" ,Password="clock"},
        new User() { ID = 2, Name = "Charles Dickens", Password="clock1" },
        new User() { ID = 3, Name = "Miguel de Cervantes", Password = "clock1" }
        );

            context.Fields.AddOrUpdate(x => x.Id,
        new Field() { Id = 11, Name = "ClujArena", Location = "clock" }
        
        );
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
        }
    }
}
