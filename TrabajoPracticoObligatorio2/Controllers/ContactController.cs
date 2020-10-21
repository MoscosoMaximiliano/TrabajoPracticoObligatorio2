using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.WebPages;

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
        public ActionResult Contact(string name, string email, string phone, string message)
        {
            //var text = "";
            Console.WriteLine(name + "  " + email + "  " + phone.ToString() + "  " + message.ToString());
            if (!name.IsEmpty() && !email.IsEmpty() && !phone.ToString().IsEmpty() && !message.IsEmpty())
                //text = "<script language='javascript' type='text/javascript'>alert('El formulario se completo con exito');</script>";
                TempData["Message"] = "Se completo con exito el registro del formulario";


            else
                //text = "<script language='javascript' type='text/javascript'>alert('Error al completar el formulario');</script>";
                TempData["Message"] = "Hubo un error con el registro del formulario";

            //ViewBag.Message = text;

            return View();
        }
    }
}