using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeePortal.Controllers
{
    public class HomeController : Controller
    {
        IEmployeeService EmployeeService;
        public HomeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }
        public ActionResult Index()
        {
            return View(EmployeeService.ListEmployees());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}