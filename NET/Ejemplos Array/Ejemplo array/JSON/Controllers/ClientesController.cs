using JSON_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSON_Example.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        //public ActionResult Clientes()
        //{
        //    return View();
        //}

        //generar un JSON  a partir de mi objeto  / modelo
        public ActionResult Clientes()
        {
            var cli = new Clientes() { Nombre = "Carlos", Apellido = "Guzman", Direccion = "Macul", Edad = "30" };
            return Json(cli, JsonRequestBehavior.AllowGet);
        }
    }
}