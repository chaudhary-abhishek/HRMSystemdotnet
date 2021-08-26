using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BAL;
using System.Data;
using HRMSystem.Models;

namespace HRMSystem.Controllers
{
    public class PayRoll1Controller : Controller
    {
        DALPayRoll dalpay = new DALPayRoll();
        // GET: PayRoll
        [HttpGet]
        public ActionResult Show_PayRoll()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Show_PayRoll(int id)
        {
            DataSet ds = dalpay.Show_PayRoll(id);
            ViewBag.ab = ds.Tables[0];
            return View();
        }

        public ActionResult Add_PayRoll()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_PayRoll(PayRollClass form)
        {
            BAL.PayRoll payroll = new BAL.PayRoll();
            payroll.ID = Convert.ToInt32(form.ID);
            payroll.BasicPay = Convert.ToDecimal(form.BasicPay);
            payroll.Allowance = Convert.ToDecimal(form.Allowance);
            payroll.Deductions = Convert.ToDecimal(form.Deductions);
            payroll.GrossPay = Convert.ToDecimal(form.GrossPay);
            payroll.NetPay = Convert.ToDecimal(form.NetPay);
            dalpay.Add_PayRoll(payroll);
            TempData["message"] = "Data is Inserted";
            return RedirectToAction("Show_PayRoll");
        }

        public ActionResult Update_PayRoll(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update_PayRoll(int id, PayRollClass form)
        {
            BAL.PayRoll payroll = new BAL.PayRoll();
            payroll.ID = id;
            payroll.BasicPay = Convert.ToDecimal(form.BasicPay);
            payroll.Allowance = Convert.ToDecimal(form.Allowance);
            payroll.Deductions = Convert.ToDecimal(form.Deductions);
            payroll.GrossPay = Convert.ToDecimal(form.GrossPay);
            payroll.NetPay = Convert.ToDecimal(form.NetPay);
            dalpay.Update_PayRoll(payroll);
            TempData["message"] = "Data is Updated";
            return RedirectToAction("Show_PayRoll");
        }

        public ActionResult Delete_PayRoll(int id)
        {
            dalpay.Delete_PayRoll(id);
            TempData["message"] = "Data is Deleted";
            return RedirectToAction("Show_PayRoll");
        }
    }
}