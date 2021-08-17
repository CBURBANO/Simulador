using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Simulador.Web.Models;


namespace Simulador.Web.Controllers
{
    public class CreditoforController : Controller
    {

        //el nombre del controlador se llama Creditofor 
        // GET: Creditofor
        //[HttpGet]
        public ActionResult Index()//va el nombre del parametro o vista que vamos a llamar"Views-index.cshtml"
        {
            // RETORNA  
            //var creditof = new List<Creditofor>();
            //creditof.Add(new Creditofor{ });
            //ViewBag.ValorPrestamo = ("");
            //ViewBag.valorPrestamo = ("creditofor.ValorPrestamo");
            
            return View(); //este es para cargar el formulario

        }




        //carga el formulario 
       
        public ActionResult Registro(Creditofor creditofor)
        {

            double nroCuotas = creditofor.Cuotas;
            var valorPrestamo = creditofor.ValorPrestamo;
            var cuotaTasa = creditofor.CuotaTasa / 100; 
            var valorSeguro = valorPrestamo * 0.0024;
            double cuotaMensual = valorPrestamo * ((cuotaTasa * (Math.Pow((1 + cuotaTasa), nroCuotas))) / ((Math.Pow((1 + cuotaTasa), nroCuotas)) - 1));

            double abono = 0;
            double abonoCapital = 0;
            double saldo = 0;

            ViewBag.nroCuotas = nroCuotas;
            ViewBag.valorPrestamo = valorPrestamo;
            ViewBag.cuotaTasa = cuotaTasa;
            ViewBag.valorSeguro = valorSeguro;
            ViewBag.abono = abono;
            ViewBag.cuotaMensual = cuotaMensual;
            ViewBag.abonoCapital = abonoCapital;
            ViewBag.saldo = saldo;

            return View();

        }


    }
}