using Epsilon.CodingSchool.Model;

namespace Epsilon.CodingSchool.EF.Repository;

public interface ITodoCommentRepo
{
  IEnumerable<TodoComment> GetAllForTodo(int todoId);
}