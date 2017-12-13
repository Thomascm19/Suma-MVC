using MVC_APP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_APP1.Controllers
{
    public class NumerosController : Controller
    {
        // GET: Numeros
        public ActionResult Index(Numeros n)
        {
            double multi = n.n1 * n.n2;
            double iva = multi * 0.16;
            double suma =  multi + iva;
            if(suma > 50000)
            {
                double descuento = suma * 0.05;
                suma = suma - descuento;
                
            }
            //Al viebag se le coloca la palabra que quiera
            ViewBag.Suma = suma;
            return View();
        }
    }
}