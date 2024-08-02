using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiTarefas.Views;

namespace ApiTarefas.Controller
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public HomeView Index()
        {
            return new HomeView
            {
                Mensagem = "Bem-vindo a API de tarefas",
                Documentacao = "/swagger"
            };
        }
    }
}