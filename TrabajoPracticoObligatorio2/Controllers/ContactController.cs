using System;
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
        public JsonResult Form(FormData form)
        {

            ViewBag.Message = "";
            ViewBag.Response = false;
            
            try
            {
                if (!form.Name.IsEmpty() && !form.Email.IsEmpty() && !form.Phone.IsEmpty() && !form.Message.IsEmpty())
                {
                    ViewBag.Response = true;
                    ViewBag.Message = "Se completo con exito el registro del formulario";
                }
            }
            catch (Exception e)
            {
                ViewBag.Response = false;
                ViewBag.Message = "Hubo un error con el registro del formulario";
            }

            return Json(new {res = ViewBag.Response, msg = ViewBag.Message}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void AddQuery(string name, string email, string number, string message)
        {
            var response = CNTPO2.AddQuery(name, email, number, message);
        }
    }
}