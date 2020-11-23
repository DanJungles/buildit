using Caixa_Eletronico.Repositories;
using Caixa_Eletronico.Repositories.Interface;
using Caixa_Eletronico.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Controllers
{
    public class HomeController : Controller
    {



        public HomeController()
        {

        }


        public ActionResult Index()
        {
            CaixaViewModel model = new CaixaViewModel();
            return View(model);
        }




        [HttpPost]
        public IActionResult Index(CaixaViewModel model)
        {
            //ModelState.Clear();
          

            int Saque = model.Valor_Saque;
            int resultado_Subtraido = Saque;
            int valor_sugerido = 0;
           

            foreach (var nota in model.List_Cedula)
            {
                if (nota.Quantidade > 0 )
                {

                    int contador = 1;

                    while (resultado_Subtraido >= nota.Valor & contador <= nota.Quantidade)
                    {
                        resultado_Subtraido -= nota.Valor;
                        contador += 1;
                        valor_sugerido += nota.Valor;
                    }
                }
            }


            if (resultado_Subtraido == 0)
            {

                ViewBag.Resultado = "Saque realizado";
            }
            else
            {

                ViewBag.Resultado = $"nova sugestão de saque {valor_sugerido}";
            }
            return View(model);
        }

    }
}




