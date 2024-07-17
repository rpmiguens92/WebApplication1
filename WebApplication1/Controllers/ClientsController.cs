using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Detail()
        {

            Client client = new Client()
            {
                ClientId = 200,
                ClientName = "Rafael",
                ClientEmail = "rafael.santos@cinel.pt",
                ClientPhone = "123456789"
            };

            ViewBag.ClientName = client.ClientName;
            ViewData["Email"] = client.ClientEmail;


            return View(client);
        }

        [HttpPost] //este controlador recebe um post
       // [HttpGet] //usa-se quando o formulario  é pequeno, tem problemas de segurança
        //recebe o objecto tipo cliente quando ha submit esta action recebe o cliente deste lado
        public IActionResult SaveClient(Client model) //recebe um cliente
        {
            return View(model); //chama a view model

        }
    }
}
