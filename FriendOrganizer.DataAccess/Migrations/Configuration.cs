using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

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

            context.ProgrammingLanguages
                .AddOrUpdate(f => f.Name,
                    new ProgrammingLanguage {Name = "C#"},
                    new ProgrammingLanguage {Name = "TypeScript"},
                    new ProgrammingLanguage {Name = "F#"},
                    new ProgrammingLanguage {Name = "Swift"},
                    new ProgrammingLanguage {Name = "Java"});
        }
    }
}
