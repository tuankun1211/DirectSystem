using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using DirectSystem.Web.Models;
using DirectSystem.Web.Entities;

namespace DirectSystem.Web.Controllers
{
   
    public class AccountController : Controller
    {
        //
        // GET: /Account/Login

        [HttpGet]
        public ActionResult Index()
        {
            var accountModel = new AccountModel();
            return View(accountModel);
        }
        [HttpPost]
        public ActionResult Login(AccountModel model)
        {
            var validateUser=checkUser(model);
            //var validateUser = true;
            if (validateUser)
            {
                Session["Profile"] = model;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Error"] = "Wrong UserName or Passwor. Try again.";
                return View("Index",model);
            }
           
          
        }
        [HttpPost]
        public ActionResult LogOff()
        {
            Session["Profile"] = null;
            return RedirectToAction("Index", "Account");
        }

        public AccountController()
        {
            entities = new DirectSystemEntities();
        }
        private bool checkUser(AccountModel model)
        {
            var accountList = entities.tbl_Account.ToList();
            var checkedAccount = accountList.Where(x => x.UserName.Equals(model.UserName, StringComparison.OrdinalIgnoreCase)
                                                    && x.Password.Equals(model.Password, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            if (checkedAccount != null)
            {
                return true;
            }

            return false;
        }
        private DirectSystemEntities entities;
    }
}
