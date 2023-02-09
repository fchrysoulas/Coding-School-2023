using Epsilon.CodingSchool.EF.Repository;
using Epsilon.CodingSchool.Model;
using Epsilon.CodingSchool.Web.Mvc.Models.TodoComment;

using Microsoft.AspNetCore.Mvc;

namespace Epsilon.CodingSchool.Web.Mvc.Controllers
{
    public class TodoCommentController : Controller
    {
        private readonly IEntityRepo<Todo> _todoRepo;
        private readonly IEntityRepo<TodoComment> _todoCommentRepo;

        public TodoCommentController(IEntityRepo<Todo> todoRepo, IEntityRepo<TodoComment> todoCommentRepo)
        {
            _todoRepo = todoRepo;
            _todoCommentRepo = todoCommentRepo;
        }

        // GET: TodoCommentController
        public ActionResult Index()
        {
            var todoComments = _todoCommentRepo.GetAll();
            return View(model: todoComments);
        }

        // GET: TodoCommentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoCommentController/Create
        public ActionResult Create()
        {
            var newTodoComment = new TodoCommentCreateDto();
            var todos = _todoRepo.GetAll();
            foreach (var todo in todos)
            {
                newTodoComment.Todos.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(todo.Title, todo.Id.ToString()));
            }

            return View(model: newTodoComment);
        }

        // POST: TodoCommentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoCommentCreateDto todoComment)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbTodoComment = new TodoComment(todoComment.Text)
            {
                TodoId = todoComment.TodoId
            };

            _todoCommentRepo.Add(dbTodoComment);
            return RedirectToAction("Index");
        }

        // GET: TodoCommentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoCommentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodoCommentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoCommentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
