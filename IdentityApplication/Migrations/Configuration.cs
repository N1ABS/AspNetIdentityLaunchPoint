using IdentityApplication.Models;

namespace IdentityApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(new Role() {Id = 1, Name = "ADMIN"});
            context.Roles.AddOrUpdate(new Role() {Id = 2, Name = "USER"});
        }
    }
}
