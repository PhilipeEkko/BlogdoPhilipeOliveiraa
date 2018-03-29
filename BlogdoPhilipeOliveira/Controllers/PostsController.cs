using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogdoPhilipeOliveira.Models;

namespace BlogdoPhilipeOliveira.Controllers
{
    public class PostsController : Controller
    {
        private BlogContext _context = new BlogContext();

        // GET: Posts
        public ActionResult Index()
        {
            var posts = _context.Posts.ToList();
            

            return View(posts);
        }

        public ActionResult Details(int id)
        {
            var posts = _context.Posts.SingleOrDefault(p => p.Id == id);
            if (posts == null)
            {
                return HttpNotFound();
            }
            return View(posts);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delet(int id)
        {
            return View();
        }

        public ActionResult DeleteCompleto(int id)
        {
            return View();
        }

        public ActionResult Save(Post post)
        {
            return View();
        }


    }

}