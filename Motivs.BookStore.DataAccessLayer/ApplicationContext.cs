using Motivs.BookStore.Models.DBModel;
using Microsoft.EntityFrameworkCore;

namespace Motivs.BookStore.DataAccessLayer
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SQLEXPRESS;Database=BookStoreDB;Trusted_Connection=True;");
        }
    }
}
