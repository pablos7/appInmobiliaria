using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTP.Controllers
{
    public class ProductosController : Controller
    {
        //
        // GET: /Productos/

        public ActionResult Casas(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

        public ActionResult Departamentos(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

        public ActionResult Terrenos(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

        [HttpPost]
        public ActionResult Comentario(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

    }
}
