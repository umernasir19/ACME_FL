﻿using HrProperty.Models;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Setups;

namespace ACME.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        User_BLL _objUserBLL;
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(LoginProperty Login)
        {
            var flag = false;
           var msg = "";
            if (ModelState.IsValid)
            {
                try
                {
                    User_Property _objuser = new User_Property()
                    {
                        UserName=Login.email,
                        Password=Login.password
                    };

                    _objUserBLL = new User_BLL(_objuser);
                    _objUserBLL.GetUserByIDPass();
                    return Json(new { Login = flag, statuscode = 400, msg = msg, url = "/Home/Dashboard" }, JsonRequestBehavior.AllowGet);

                }
                catch (Exception ex)
                {
                    return Json(new { Login = flag, statuscode = 400, msg = ex.Message, url = "/Account/Login" }, JsonRequestBehavior.AllowGet);

                }
            }
            else
            {
                msg = "Validation Failed";
                return Json(new { Login = flag, statuscode = 400, msg = msg, url = "/Account/Login" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}