//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAroundTheWorld.Controllers
{
    public class AroundTheWorldController : Controller
    {
        //
        // GET: /AroundTheWorld/
        public ActionResult Welcome() // Home/welcome page
        {
            ViewBag.Message = "Welcome";
            return View();
        }

        // GET: /AroundTheWorld/Tutorials/
        public ActionResult Tutorials() // Tutorial info page
        {
            ViewBag.Message = "Beginning of tutorials";
            return View();
        }

        // GET: /AroundTheWorld/ScoreBoard/
        public ActionResult ScoreBoard() // Scoreboard page
        {
            ViewBag.Message = "ScoreBoard";
            return View();
        }

        //
        // GET: /AroundTheWorld//Tutorials/Tutorial1/
        public ActionResult Tutorial1() // Tutorial 1 page
        {
            ViewBag.Message = "Tutorial1";
            return View();
        }

        // GET: /AroundTheWorld//Tutorials/Tutorial2/
        public ActionResult Tutorial2() // Tutorial 2 page
        {
            ViewBag.Message = "Tutorial2";
            return View();
        }

        // GET: /AroundTheWorld//Tutorials/Tutorial3/
        public ActionResult Tutorial3() // Tutorial 3 page
        {
            ViewBag.Message = "Tutorial3";
            return View();
        }

        // GET: /AroundTheWorld//Tutorials/Tutorial3/
        public ActionResult Tutorial4() // Tutorial 4 page
        {
            ViewBag.Message = "Tutorial4";
            return View();
        }

        // GET: /AroundTheWorld//Contact/
        public ActionResult Contact() // Contact page
        {
            ViewBag.Message = "Contact";
            return View();
        }
	}
}