﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LayoutMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employees")]
        public ActionResult GetList()
        {
            return View("GetList","_NewLayout");
        }
        [Route("NewEmployee")]
        public ActionResult AddEmployee()
        {
            return View();
        }
    }
}