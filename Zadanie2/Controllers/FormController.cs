using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie2.Models;

namespace Zadanie2.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Create()
        {
           
                return View();
        }

        [HttpPost]
        public IActionResult Create(FormModel model , int Number)
        {

            if (ModelState.IsValid && Number >= 1 && Number <= 5)
            {
                return View("Created", model);
            }

                return View(model);
            
        }
    }
}
