using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestPlain.ViewModels;
using WestPlain.Models;


namespace WestPlain.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var businessTypes = _context.BusinessTypes.ToList();
            var viewModel = new RegisterationViewModel
            {
               Register = new Register(),
               BusinessTypes = businessTypes
            };
            return View("Index", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Register register)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new RegisterationViewModel
                {
                    Register = register,
                    BusinessTypes = _context.BusinessTypes.ToList()
                };
                return View("Index", viewModel);
            }

            _context.Registers.Add(register);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}