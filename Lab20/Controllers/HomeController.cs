using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
//using System.Data.Entity;
using System.Web.Mvc;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }

        public ActionResult UserRegistration()
        {
            ViewBag.Message = "User Registration here";
            return View();
        }
        [Required]
        public int Phone { get; set; }




        public ActionResult Summary()
        {

            ViewBag.Message = "Your First Name";
            return View();

        }

        public ActionResult Success(Register r)//register model passed into it, its an object//
        {

            ViewBag.Message = "Your email is " + r.Email;
            return View(r);
           
        }







        public class Register
        {
            [Required]
            [Key]
            public string FirstName { get; set; }
            [Required]
            public string Email { get; set; }
        }




    }

}
