using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using htmlHelpersFormulario.Models;

namespace htmlHelpersFormulario.Controllers
{
    public class PersonaController : Controller
    {
        // GET : /User/Index
        public ActionResult Index()
        {
            return View(new Persona());
        }


        public ActionResult Resultados(Persona user)
        {
            return View(user);
        }

        // GET : /User/Create
        public ActionResult Create()
        {
            return View(new Persona());
        }

        [HttpPost]
        // GET : /User/Create
        public ActionResult Create(Persona user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            return View("Resultados", user);
        }
    }
}