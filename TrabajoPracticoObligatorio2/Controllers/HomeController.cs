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
            
            

            var data = new IndexModelData
            {
                Items = items.Select(x => new ProductModel
                {
                    
                }).ToList(),
                Categories = categories.Select(y => new CategoriesModel
                {
                    
                }).ToList(),
                SubCategorieses = new SelectList(subCategories.Select(w => new SelectListItem
                {
                    
                }))
            }

            data.Categories = categories.Select(x => new CategoriesModel
            {
                ID = x.ID,
                Category = x.Category,
            }).ToList();
            
            data.Items = items.Select(x => new ProductModel
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