using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model.Dao;
using Facebook.Areas.Admin.Models;
using Microsoft.Ajax.Utilities;

namespace Facebook.Areas.Admin.Controllers
{
    public class Admin_Controller : BaseController
    {
        public ActionResult Error()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin_Model model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                bool check = dao.Check_exist(model.user_name, model.password);
                if (check) // Account is exist
                {                  
                    return RedirectToAction("Error", "Admin_");
                }
                else
                {
                    dao.Add(model.user_name, model.password);
                    SetAlert("Số di động hoặc email bạn nhập không khớp với bất kì tài khoản nào","danger");
                    //ModelState.AddModelError("", "Số di động hoặc email bạn nhập không khớp với bất kì tài khoản nào ");
                }
            }
            return View("Index");
        }
    }
}
