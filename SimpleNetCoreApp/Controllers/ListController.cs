using Microsoft.AspNetCore.Mvc;
using SimpleNetCoreApp.Models;
using System.Collections.Generic;

namespace SimpleNetCoreApp.Controllers
{
    public class ListController : Controller
    {
        private static List<ItemModel> items = new List<ItemModel>
        {
            new ItemModel { Id = 1, Name = "Item 1", Description = "Description for Item 1" },
            new ItemModel { Id = 2, Name = "Item 2", Description = "Description for Item 2" }
        };

        public IActionResult Index()
        {
            return View(items);
        }
    }
}