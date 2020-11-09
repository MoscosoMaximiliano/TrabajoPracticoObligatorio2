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
            var items = CNTPO2.GetItems();
            var categories = CNTPO2.GetCategories();
            var subCategories = CNTPO2.GetSubCategories();



            var data = new IndexDataModel
            {
                Items = items.Select(x => new CNProduct
                {
                    ID = x.ID,
                    Name = x.Name,
                    ImgUrl = x.ImgUrl,
                    Price = x.Price,
                    IsOffer = x.IsOffer,
                    IsFeatured = x.IsFeatured
                    
                }).ToList(),
                Categories = categories.Select(y => new CNCategories
                {
                    ID = y.ID,
                    Category = y.Category
                }).ToList(),
                SubCategorieses = subCategories.Select(w => new CNSubCategories
                {
                   ID = w.ID,
                   Name = w.Name,
                   IdCategory = w.IdCategory
                }).ToList()
                
            };

            return View(data);
        }
    }
}