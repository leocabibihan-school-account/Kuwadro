using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kuwaderno.Controllers
{
    public class UserController : Controller
    {
        //use IActionResult instead of string
        public string Index(int id)
        {
            //this is the gallery
            return "this should show the profile of a given user";
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
