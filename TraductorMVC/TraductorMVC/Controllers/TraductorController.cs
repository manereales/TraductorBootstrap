using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traductor.Logic;
using Traductor.Logic.Models;
using TraductorMVC.Models;

namespace TraductorMVC.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(ActionTypeEnum idioma,string palabra)
        {
            Translate trans = new Translate();

            Result traduccion = trans.TranslateWord(idioma, palabra);
            ResultViewModel response = new ResultViewModel()
            {
                TranslateWord = traduccion.TranslateWord,
                IsError = traduccion.IsError,
                Message = traduccion.Message
            };
            return View(response);
        }
    }
}