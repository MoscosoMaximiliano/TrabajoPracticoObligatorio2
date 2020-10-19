using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using TrabajoPracticoObligatorio2.Models;

namespace TrabajoPracticoObligatorio2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var resp = CapaNegocio.Products.GetItems();

            var list_items = resp.Select(x => new Item
            {
                ID = x.ID,
                Description = x.Description,
                Name = x.Name,
                Price = x.Price
            }).ToList();
            
            return View(list_items);
        }
    }
}