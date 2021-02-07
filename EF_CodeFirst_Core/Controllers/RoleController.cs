using EF_CodeFirst_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_CodeFirst_Core.Controllers
{
    public class RoleController : Controller
    {
        private MyContext db;
        public RoleController(MyContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
           var roles = db.AllRoles;
            return View(roles);
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRole(Role role)
        {
            db.AllRoles.Add(role);
            db.SaveChanges();
            ViewBag.message = "New Role Added!";
            return View();
        }

    }
}
