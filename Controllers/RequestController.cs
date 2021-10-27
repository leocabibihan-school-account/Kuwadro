using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kuwaderno.Controllers
{
    //where all the requesting commision stuff is happening
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            //shows first 3 of requested received and sent for the logged in user, displays neither if both r 0  MIKE TEST
            return View();
        }

        public IActionResult Received()
        {
            //shows a list of all requests for art, allows user to manage it
            return View();
        }

        public IActionResult Sent()
        {
            //gives a status update on the art that the user requested from someone else
            return View();
        }





    }
}
