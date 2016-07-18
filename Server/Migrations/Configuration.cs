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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Server.Models.ServerContext context)
        {

            context.Clients.AddOrUpdate(x => x.Id,
        new Client() { Id = 1, Name = "Jane Austen" ,Password="clock"},
        new Client() { Id = 2, Name = "Charles Dickens", Password="clock1" },
        new Client() { Id = 3, Name = "Miguel de Cervantes", Password = "clock1" }
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
