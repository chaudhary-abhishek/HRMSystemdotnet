using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMSystem.Models;
using BAL;
using DAL;

namespace HRMSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        
        // GET: Account
        [HttpGet]
        public ActionResult SignIn()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult SignIn(Account Acc)
        {
            Account_BAL acc = new Account_BAL();
            acc.id = Acc.id;
            acc.Password = Acc.Password;
            DAL.DALClass d = new DALClass();
            Boolean ans = d.Login(acc.id, acc.Password);
            if(ans)
            {
                return RedirectToAction("Index", "Home");
            }

            
            

            return View();

        }
    }
}