using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio1.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode(nombre);
            input = "<h1>" + input + "</h1>" + 
        "<input action = \"action\" onclick = \"window.history.go(-1); return false;\" type = \"submit\" value = \"Volver\"/> ";
            //Se que esto no es lo mas adecuado pero por cuestiones de tiempo decidi dejarlo de esta manera.
        return Content(input);
        }

        public ActionResult Index()
        {
            return View();
        }

    }


}