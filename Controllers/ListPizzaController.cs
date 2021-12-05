using PizzaBack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaBack.Controllers
{
    public class ListPizzaController : Controller
    {
        private PizzaContext db = new PizzaContext();
        // GET: ListPizza
        public JsonResult Index()
        {
            return Json(new { Pizzas = db.Pizzas.ToList() }, JsonRequestBehavior.AllowGet);
        }
    }
}