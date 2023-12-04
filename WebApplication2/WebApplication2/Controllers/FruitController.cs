using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class FruitController : Controlle
    {
        // GET: Fruit
        public ActionResult Index()
        {
            List<string> fruit = new List<string>();
            fruit.Add("Mango");
            fruit.Add("Apple");
           fruit.Add("Banana");

            ViewBag.store  = "Jackma Veggie";

            ViewBag.Name = "my favorite fruit"
            ViewBag.Fruit = fruit;




            return View();
        }
    }
}