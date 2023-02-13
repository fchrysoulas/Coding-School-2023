using Epsilon.CodingSchool.EF.Repository;
using Epsilon.CodingSchool.Model;
using Epsilon.CodingSchool.Web.Mvc.Models.Todo;

using Microsoft.AspNetCore.Mvc;

namespace Epsilon.CodingSchool.Web.Mvc.Controllers
{
    public class TodoController : Controller
    {
        private readonly IEntityRepo<Todo> _todoRepo;
        public TodoController(IEntityRepo<Todo> todoRepo)
        {
            _todoRepo = todoRepo;
        }

        // GET: TodoController
        public ActionResult Index()
        {
            var todos = _todoRepo.GetAll();
            var finishedTodos = todos.ToList();
            return View(model: finishedTodos);
        }

        // GET: TodoController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = _todoRepo.GetById(id.Value);
            if (todo == null)
            {
                return NotFound();
            }

            var viewTodo = new TodoDetailsDto
            {
                Id = todo.Id,
                Title = todo.Title,
                Finished = todo.Finished,
                CreateDate = todo.Detail.CreateDate,
                FinishDate = todo.Detail.FinishDate,
                Comments = todo.Comments.ToList()
            };
            return View(model: viewTodo);
        }

        // GET: TodoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoCreateDto todo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbTodo = new Todo(todo.Title);
            dbTodo.TodoType = todo.TodoType;
            _todoRepo.Add(dbTodo);
            return RedirectToAction("Index");
        }

        // GET: TodoController/Edit/5
        public ActionResult Edit(int id)
        {
            var dbTodo = _todoRepo.GetById(id);
            if (dbTodo == null)
            {
                return NotFound();
            }

            var viewTodo = new TodoEditDto
            {
                Title = dbTodo.Title,
                Id = dbTodo.Id,
                TodoType = dbTodo.TodoType
            };
            return View(model: viewTodo);
        }

        // POST: TodoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TodoEditDto todo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbTodo = _todoRepo.GetById(id);
            if (dbTodo == null)
            {
                return NotFound();
            }

            dbTodo.Title = todo.Title;
            dbTodo.TodoType = todo.TodoType;
            _todoRepo.Update(id, dbTodo);
            return RedirectToAction(nameof(Index));
        }

        // GET: TodoController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbTodo = _todoRepo.GetById(id);
            if (dbTodo == null)
            {
                return NotFound();
            }

            var viewTodo = new TodoDeleteDto
            {
                Title = dbTodo.Title,
                Id = dbTodo.Id
            };
            return View(model: viewTodo);
        }

        // POST: TodoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _todoRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
