using Epsilon.CodingSchool.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Epsilon.CodingSchool.EF.Configuration;

public class TodoDetailConfiguration : IEntityTypeConfiguration<TodoDetail>
{
  /// <inheritdoc />
  public void Configure(EntityTypeBuilder<TodoDetail> builder)
  {
    builder.ToTable("TodoDetail", "App");

    builder.HasKey(todoDetail => todoDetail.Id);
    builder.Property(todoDetail => todoDetail.Id).ValueGeneratedOnAdd();

    builder.Property(todoDetail => todoDetail.CreateDate).IsRequired();

    builder.HasOne(todoDetail => todoDetail.Todo).WithOne(todo => todo.Detail)
        .HasForeignKey<TodoDetail>(todoDetail => todoDetail.TodoId).IsRequired();
  }
}