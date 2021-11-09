using Kuwaderno.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kuwaderno.Data;

namespace Kuwaderno.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //todo send data of artists grouped by genre
            //_context.artList.GroupBy(art => art.Genre)
            Dictionary<string, List<Art>> artByGenre = new Dictionary<string, List<Art>>();
            //stupid linq groupby doesn't work so I'll implement it myself
            
            //now I realize I didn't update the database
            foreach (Art art in _context.artList.ToList())
            {
               // if (!artByGenre.ContainsKey(art.Genre))
                //{
               //     artByGenre.Add(art.Genre, new List<Art> { art });
               // }
               // else
               // {
                //    artByGenre[art.Genre].Add(art);
               // }
                
            }

            foreach (String genre in artByGenre.Keys)
            {
                System.Diagnostics.Debug.WriteLine(genre);
            }
            


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            //todo add about view
            return View();
        }

        public string Search(string name) //todo search keywords
        {
            return "suppossed to get all results with names " + name;
        }

        public string Genre(string name)
        {
            return "returns all artists with the " + name;
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
