using Microsoft.AspNetCore.Mvc;
using SimpleNetCoreApp.Models;

namespace SimpleNetCoreApp.Controllers
{
    public class EditController : Controller
    {
        // GET: Edit/5
        public IActionResult Index(int id)
        {
            // Here you would typically retrieve the item from a data source using the id
            // For this example, we'll just create a dummy item
            var item = new ItemModel
            {
                Id = id,
                Name = "Sample Item",
                Description = "This is a sample item description."
            };

            return View(item);
        }

        // POST: Edit/5
        [HttpPost]
        public IActionResult Index(ItemModel item)
        {
            if (ModelState.IsValid)
            {
                // Here you would typically update the item in a data source
                // Redirect to the list or another appropriate action
                return RedirectToAction("Index", "List");
            }

            return View(item);
        }
    }
}