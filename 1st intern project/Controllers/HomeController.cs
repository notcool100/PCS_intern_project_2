using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp2.Models;

namespace ToDoListApp2.Controllers
{
    public class HomeController : Controller
    {
        private static List<TodoItem> todoList = new List<TodoItem>();

        public IActionResult Index()
        {
            return View(todoList);
        }

        [HttpPost]
        public IActionResult AddTodoItem(TodoItem todoItem)
        {
            todoList.Add(todoItem);
            return RedirectToAction("Index");
        }
    }
}
