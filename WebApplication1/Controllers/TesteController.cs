using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
namespace WebApplication1.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {

            ///*ViewData["Nome"] = "Rita";
            //ViewData["Email"] = "rita.cinel.pt";
            //ViewData["Curso"] = "ASP.NET MVC";
            //ViewData["DataInicio"] = new DateTime(2021, 07, 01);*/


            //ViewBag.Nome = "Maria Joana";
            //ViewBag.Email = "rita.cinel.pt";
            //ViewBag.Curso = "ASP.NET MVC";
            //ViewBag.DataInicio = new DateTime(2021, 07, 01);

            ViewBag.Paises = new List<string>()
            {
                "Brasil",
                "Peru",
                "China",
                "Portugal"
            };

            return View();
        }
 
    }
}
