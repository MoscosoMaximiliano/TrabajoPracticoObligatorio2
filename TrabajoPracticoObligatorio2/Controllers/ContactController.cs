using System.Web.Mvc;

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
        public ActionResult Contact(string name, string username)
        {
            var text = "LOGRADO";

            ViewBag.Message = text;

            return View();
        }
    }
}