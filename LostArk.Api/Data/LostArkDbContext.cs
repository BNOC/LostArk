using LostArk.Api.Entities;
using LostArk.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace LostArk.Api.Data
{
    public class LostArkDbContext : DbContext
    {
        public LostArkDbContext(DbContextOptions<LostArkDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User ------------------------------------------------
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "BNOC",
                Characters = new List<Character>()
            });

            // Characters ------------------------------------------------
            var charNames = new List<string>()
            {
                "Bnoc", "Skex", "Bnocx", "Bnocy", "Bnocz"
            };
            var charCount = 1;
            foreach (var charName in charNames)
            {
                modelBuilder.Entity<Character>().HasData(new Character
                {
                    Id = charCount,
                    Name = charName,
                    UserId = 1,
                    CharacterTasks = new List<CharacterTask>()
                });
                charCount++;
            }


            // Tasks ------------------------------------------------
            // Chaos
            var taskCount = 1;
            for (var i = 1; i <= charNames.Count; i++)
            {
                // Chaos
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 1,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 1,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;

                // Guardian
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 2,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;                
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 2,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;

                // Unas daily
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 3,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 3,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 3,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;

                // Event
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 4,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;

                // Rapport
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 5,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;

                // Guild
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 6,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Daily
                });
                taskCount++;

                // Una's Weekly
                modelBuilder.Entity<CharacterTask>().HasData(new CharacterTask
                {
                    Id = taskCount,
                    CharacterId = i,
                    CharacterTaskTypeId = 7,
                    IsCompleted = false,
                    Period = CharacterTaskPeriod.Weekly
                });
                taskCount++;
            }

            // TaskTypes 
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 1,
                Name = "Chaos Dungeon"
            });
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 2,
                Name = "Guardian Raid"
            });
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 3,
                Name = "Una's Daily"
            });
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 4,
                Name = "Event"
            });
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 5,
                Name = "Rapport"
            });
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 6,
                Name = "Guild"
            });
            modelBuilder.Entity<CharacterTaskType>().HasData(new CharacterTaskType
            {
                Id = 7,
                Name = "Una's Weekly"
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterTask> CharacterTasks { get; set; }
        public DbSet<CharacterTaskType> CharacterTaskTypes { get; set; }

    }
}
