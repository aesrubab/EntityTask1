using ConsoleApp17.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp17.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Operation> Operations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Book>()
           .HasOne(p => p.Author)
           .WithMany(c => c.Books)
           .HasForeignKey(p => p.AuthorId);

        modelBuilder.Entity<Book>()
           .HasOne(p => p.BookType)
           .WithMany(c => c.Books)
           .HasForeignKey(p => p.AuthorId);

        modelBuilder.Entity<Student>()
            .HasMany(p => p.Books)
           .WithMany(c => c.Students);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=WINDOWS-2P363HE;Initial Catalog=LibraryTest;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
