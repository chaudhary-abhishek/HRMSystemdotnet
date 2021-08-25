using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMSystem.Context;

namespace HRMSystem.Controllers
{
    public class EmployeeController : Controller
    {
        HRMSystemEntities2 entobj = new HRMSystemEntities2();
        // GET: Employee

        public ActionResult Employee()
        {
            return View();
        }


        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeTable model)
        {
            EmployeeTable obj = new EmployeeTable();
            obj.ID = model.ID;
            obj.Name = model.Name;
            obj.Nationality = model.Nationality;
            obj.Address = model.Address;
            obj.PhoneNumber = model.PhoneNumber;
            obj.SupervisorName = model.SupervisorName;
            obj.Department = model.Department;
            obj.EmployeeStatus = model.EmployeeStatus;

            entobj.EmployeeTables.Add(obj);
            entobj.SaveChanges();
            return View("Employee");
        }

        public ActionResult EmployeeList()
        {
            var v = entobj.EmployeeTables.ToList();
            return View(v);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            var v1 = entobj.EmployeeTables.Where(x => x.ID==id).First();
            entobj.EmployeeTables.Remove(v1);
            entobj.SaveChanges();
            var list = entobj.EmployeeTables.ToList();
            return View("EmployeeList",list);
        }

        
    }
}

