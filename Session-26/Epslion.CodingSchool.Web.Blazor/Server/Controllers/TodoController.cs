using Epsilon.CodingSchool.EF.Repository;
using Epsilon.CodingSchool.Model;
using Epslion.CodingSchool.Web.Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Epslion.CodingSchool.Web.Blazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IEntityRepo<Todo> _todoRepo;

        public TodoController(IEntityRepo<Todo> todoRepo)
        {
            _todoRepo = todoRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TodoListDto>> Get()
        {
            var result = _todoRepo.GetAll();
            return result.Select(todo => new TodoListDto
            {
                Title = todo.Title,
                Finished = todo.Finished,
                Id = todo.Id,
                TodoType = todo.TodoType,
                CreateDate = todo.Detail.CreateDate,
                FinishDate = todo.Detail.FinishDate
            });
        }

        [HttpGet("{id}")]
        public async Task<TodoEditDto> GetById(int id)
        {
            var result = _todoRepo.GetById(id);
            return new TodoEditDto
            {
                Id = id,
                Title = result.Title,
                TodoType = result.TodoType,
                Finished = result.Finished
            };
        }

        [HttpPost]
        public async Task Post(TodoEditDto todo)
        {
            var newTodo = new Todo(todo.Title);
            //newTodo.Finished = todo.Finished;
            newTodo.TodoType = todo.TodoType;
            _todoRepo.Add(newTodo);
        }

        [HttpPut]
        public async Task Put(TodoEditDto todo)
        {
            var itemToUpdate = _todoRepo.GetById(todo.Id);
            itemToUpdate.Title = todo.Title;
            itemToUpdate.Finished= todo.Finished;
            itemToUpdate.TodoType = todo.TodoType;
            _todoRepo.Update(todo.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _todoRepo.Delete(id);
        }
    }
}
