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
            var resp2 = Products.GetCategories();

            var data = new IndexModelData();

            data.categories = resp2.Select(x => new Categories
            {
                ID = x.ID,
                Category = x.Category,
            }).ToList();
            
            data.items = resp.Select(x => new ProductModel
            {
                ID = x.ID,
                Description = x.Description,
                Name = x.Name,
                Price = x.Price,
                ImgUrl = x.ImgUrl,
                IsOffer = x.IsOffer
            }).ToList();
            
            return View(data);
        }
    }
}