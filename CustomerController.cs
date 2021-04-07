using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingLib;
using Banking.Models;
namespace Banking.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var rm = (RegisterModel)Session["User"];
           
            ViewBag.User = rm.Account_Name;
            return View(rm);
        }
  
        public ActionResult Show()
        {
            var rm = (RegisterModel)Session["User"];
            AccountModel acdta = new AccountModel();
            AccountDAL dal = new AccountDAL();
            Account ac = new Account();
           
            ac = dal.ShowDetails(rm.Account_No);

            acdta.Account_NO = ac.Account_NO;
            acdta.Account_Balance = ac.Account_Balance;
            return View(acdta);
        }
    }
}