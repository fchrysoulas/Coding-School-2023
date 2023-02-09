using Epsilon.CodingSchool.EF.Configuration;
using Epsilon.CodingSchool.Model;

using Microsoft.EntityFrameworkCore;

namespace Epsilon.CodingSchool.EF.Context;

public class TodoContext : DbContext
{
  public TodoContext()
  {
  }

  public TodoContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<Todo> Todos { get; set; } = null!;
  public DbSet<TodoComment> TodoComments { get; set; } = null!;

  /// <inheritdoc />
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new TodoConfiguration());
    modelBuilder.ApplyConfiguration(new TodoDetailConfiguration());
    modelBuilder.ApplyConfiguration(new TodoCommentConfiguration());
    base.OnModelCreating(modelBuilder);
  }

  /// <inheritdoc />
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    base.OnConfiguring(optionsBuilder);
  }
}