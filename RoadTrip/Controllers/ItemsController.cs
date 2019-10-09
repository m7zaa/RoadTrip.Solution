using Microsoft.AspNetCore.Mvc;
using RoadTrip.Models;
using System.Collections.Generic;
using System;

namespace RoadTrip.Controllers
{
    public class ItemsController : Controller
    {
        // KEEP THIS FOR LATER USE
        [HttpGet("/items")]
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }
        // This http method is get because its not related to a form.
        [HttpGet("/items/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string description)
        {
            Item myItem = new Item(description);
            return RedirectToAction("Index");
        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }

        // Form routes need to be HttpPost NOT HttpGet.
        [HttpPost("/items/{id}")]
        // here the HTTP method MUST be post, and its the cshtml file the method is also post. 
        public ActionResult Show(int id)
        {
            Item foundItem = Item.Find(id);
            return View(foundItem);
        }
    }
}