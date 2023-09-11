using Microsoft.EntityFrameworkCore;

namespace QuestionAnsweringAPI.Models
{
    public class QuestionDbContext : DbContext
    {
        public QuestionDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("QuestionAnswering");
        }

        public QuestionDbContext(DbContextOptions<QuestionDbContext> options)
            : base(options)
        {
            this.EnsureSeedData();
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}
