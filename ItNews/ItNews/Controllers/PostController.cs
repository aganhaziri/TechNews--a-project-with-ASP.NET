using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ItNews.Models;

namespace ItNews.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(NewsItem item)
        {
            if (ModelState.IsValid)
            {
                item.Post_Id = Guid.NewGuid();


                return RedirectToAction("Posts");
            }
            else
            {
                return View(item);
            }
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var item = Data.ItNews.SingleOrDefault(x => x.Post_Id == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(NewsItem item)
        {
            if (ModelState.IsValid)
            {
                var originalItem = Data.ItNews.SingleOrDefault(x => x.Post_Id == item.Post_Id);
                originalItem.Post_Title = item.Post_Title;
                originalItem.Post_Content = item.Post_Content;

                return RedirectToAction("Posts");
            }
            else
            {
                return View(item);
            }
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var item = Data.ItNews.SingleOrDefault(x => x.Post_Id == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(NewsItem item)
        {
            var originalItem = Data.ItNews.SingleOrDefault(x => x.Post_Id == item.Post_Id);
            Data.ItNews.Remove(originalItem);


            return RedirectToAction("Posts");
        }
        [HttpGet]
        public IActionResult Complete(Guid id)
        {
            var item = Data.ItNews.SingleOrDefault(x => x.Post_Id == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Complete(NewsItem item)
        {
            if (ModelState.IsValid)
            {
                var originalItem = Data.ItNews.SingleOrDefault(x => x.Post_Id == item.Post_Id);
                originalItem.Complete = true;
                return RedirectToAction("Posts");
            }
            else
            {
                return View(item);
            }
        }
    }
}
