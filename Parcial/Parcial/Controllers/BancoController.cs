using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial.Controllers
{
    public class BancoController : Controller
    {
        // GET: Banco
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cajero()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Correcto()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cajero (Cajero caj)
        {
            if (caj.Monto%5==0)
            {
                return Redirect("Correcto");
            }
            else
            {
                return Redirect("Error");
            }
        }
    }
}