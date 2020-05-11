using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var post1 = new Post()
            {
                Title = "Day 1",
                ImageUrl = "https://media.daysoftheyear.com/20171223113230/look-up-at-the-sky-day-1.jpg",
                Description = "the sky is very blue"
            };

            var post2 = new Post()
            {
                Title = "Day 2",
                ImageUrl = "https://www.lovethispic.com/uploaded_images/121991-Golden-Sunny-Day.jpg",
                Description = "old tree"
            };

            var posts = new List<Post>();

            posts.Add(post1);
            posts.Add(post2);

            return View(posts);
        }

        
    }
}
