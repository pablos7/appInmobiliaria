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

        public ActionResult casas(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

        public ActionResult departamentos(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

        public ActionResult terrenos(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

        [HttpPost]
        public ActionResult comentario(string id)
        {
            ViewBag.id = id;
            return View("Index");
        }

    }
}
