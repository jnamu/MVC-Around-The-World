using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAroundTheWorld.Models;

namespace MvcAroundTheWorld.Controllers
{
    public class ViewModelController : Controller
    {
        //
        // GET: /ViewModel/
        public ActionResult Index() // Competition Form
        {
            var model = new ViewModel();
            return View(model);
        }

        //POST: /ViewModel/
        [HttpPost]
        public ActionResult SaveAction(ViewModel model) // Saves the Entry
        {
            if (ModelState.IsValid)
            { 
            model.SaveEntry();
            return View("Thankyou", model);
            }
            return View("Index", model); // Stays on the page if there is an error
        }

        public JsonResult AutocompleteSuggestions(string searchString)
        {
            var model = new ViewModel();
            var suggestions = model.GetSuggestion(searchString);
            return Json(suggestions, JsonRequestBehavior.AllowGet);
        }
    }
}