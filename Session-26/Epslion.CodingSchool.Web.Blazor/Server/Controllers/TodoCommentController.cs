using Epsilon.CodingSchool.EF.Repository;
using Epsilon.CodingSchool.Model;
using Epslion.CodingSchool.Web.Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Epslion.CodingSchool.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoCommentController : ControllerBase
    {
        private readonly IEntityRepo<TodoComment> _todoCommentRepo;
        private readonly IEntityRepo<Todo> _todoRepo;

        public TodoCommentController(IEntityRepo<TodoComment> todoCommentRepo, IEntityRepo<Todo> todoRepo)
        {
            _todoCommentRepo = todoCommentRepo;
            _todoRepo = todoRepo;
        }

        [HttpGet]
        public IEnumerable<TodoCommentListDto> Get()
        {
            var comments = _todoCommentRepo.GetAll();
            return comments.Select(comment => new TodoCommentListDto
            {
                Id = comment.Id,
                Text = comment.Text,
                TodoTitle = comment.Todo.Title
            });
        }

        [HttpGet("{id}")]
        public TodoCommentEditDto GetById(int id)
        {
            var todoComment = _todoCommentRepo.GetById(id);
            var todos = _todoRepo.GetAll();
            return new TodoCommentEditDto
            {
                Id = todoComment.Id,
                Text = todoComment.Text,
                TodoId = todoComment.TodoId,
                Todos = todos.Select(todo => new TodoListDto
                {
                    Id = todo.Id,
                    Title = todo.Title
                }).ToList()
            };
        }

        [HttpPost]
        public async Task Post(TodoCommentEditDto todoComment)
        {
            var newTodoComment = new TodoComment(todoComment.Text);
            newTodoComment.TodoId = todoComment.TodoId.Value;
            _todoCommentRepo.Add(newTodoComment);
        }

        [HttpPut]
        public async Task Put(TodoCommentEditDto todoComment)
        {
            var todoCommentToUpdate = _todoCommentRepo.GetById(todoComment.Id);
            todoCommentToUpdate.Text = todoComment.Text;
            todoCommentToUpdate.TodoId = todoComment.TodoId.Value;

            _todoCommentRepo.Update(todoComment.Id, todoCommentToUpdate);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _todoCommentRepo.Delete(id);
        }
    }
}
