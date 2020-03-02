namespace ToDo.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context);
        }

        protected void AddUsers(ToDo.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "u1@gmail.com" };
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            userManager.Create(user, "password");
        }
    }
}
