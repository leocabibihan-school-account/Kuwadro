using Kuwaderno.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Kuwaderno.Models;

namespace Kuwaderno.Controllers
{
    public class UserController : Controller
    {
        //use IActionResult instead of string

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index(string id)
        {
            var user = _context.Users.Where(User => User.Id == id).SingleOrDefault();
            if(user == null)
            {
                return View();
            }
            var arts = _context.artList
                 .Where(p => p.User.Id == id)
                 .OrderBy(p => p.CreationDate).ToList();


            var record = new ProfilePageModel()
            {
                ArtList = arts,
                User = user
            };

            return View(record);
        }

        public string Upload(int id)
        {
            return "this page is a form that allows upload";
        }

        [HttpPost]
        public string Upload(int id, Object record)
        {
            //takes the request body and returns some data
            return "this page allows takes the request body and redirects";
        }

        public string Art(int id)
        {
            return "shows some art given the id";
        }

        public string UpdateProfile(int id)
        {
            return "just use the template";
        }

        [HttpPost]
        public string UpdateProfile(int id, Object record)
        {
            return "redirects to profile";
        }

        //add individual art pages

        //maybe add reviews?
    }
}
