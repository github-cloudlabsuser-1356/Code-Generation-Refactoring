using Microsoft.AspNetCore.Mvc;
using SimpleNetCoreApp.Models;

namespace SimpleNetCoreApp.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public IActionResult Index()
        {
            return View();
        }

        // POST: Add
        [HttpPost]
        public IActionResult Index(ItemModel item)
        {
            if (ModelState.IsValid)
            {
                // Logic to add the item (e.g., save to a list or in-memory storage)
                // Redirect to the list view or another appropriate action
                return RedirectToAction("Index", "List");
            }
            return View(item);
        }
    }
}