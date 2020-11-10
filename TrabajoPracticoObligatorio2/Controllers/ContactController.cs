using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.WebPages;
using CapaNegocio;
using TrabajoPracticoObligatorio2.Models;

namespace TrabajoPracticoObligatorio2.Controllers
{
    public class ContactController : Controller
    {
        // GET
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddQuery(string name, string email, string phone, string message)
        {
            string errs = "";
            
            var response = CNTPO2.AddQuery(name, email, phone, message);

            if (!response) errs = CNTPO2.ErrorsValidation(name, email, phone, message); 
            
            ViewBag.Response = response;
            ViewBag.Message = response ? "Se completo con exito el registro del formulario" : "Hubo un error con el registro del formulario";
            
            return Json(new {res = ViewBag.Response, msg = ViewBag.Message, err = errs}, JsonRequestBehavior.AllowGet);
        }
    }
}