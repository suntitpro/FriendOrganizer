using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizerDbContext context)
        {
            context.Friends
                .AddOrUpdate(f => f.FirstName,
                    new Friend {Id = 1, FirstName = "Denis", LastName = "Zaharco", Email = "denyabit@gmail.com"},
                    new Friend {Id = 2, FirstName = "Natalia", LastName = "Zaharco", Email = "nata@gmail.com"},
                    new Friend {Id = 3, FirstName = "Ion", LastName = "Stratan", Email = "stratan@mail.md"},
                    new Friend {Id = 4, FirstName = "Julia", LastName = "Hansen", Email = "julia@mail.md"});
        }
    }
}
