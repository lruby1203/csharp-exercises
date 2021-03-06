﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private List<Cheese> Cheeses = new List<Cheese>();
        // GET: /<controller>/
        public IActionResult Index()
        {
          
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string desc)
        {
            // Add the new cheese to my list of cheeses
            Cheese newCheese = new Cheese();
            newCheese.Name = name;
            newCheese.Desc = desc;
            Cheeses.Add(newCheese);
            
            return Redirect("/Cheese");
        }



    }
}
