using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;

using Web.Models;
using Web.ViewModel;

namespace Web.Controllers.Admin
{
    public class AccountController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        public ActionResult Index()
        {
            return View(db.USERS.ToList());
        }

        #region Đăng kí thành viên
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register( UserVM model)
        {
            if (ModelState.IsValid)
            {
                var _OldUserName = db.USERS.FirstOrDefault(m => m.USERNAME == model.Loginname);
                if (_OldUserName == null)
                {
                    var _User = new USER { LOGINNAME = model.Loginname, PASS = model.Password.GetMD5(), USERNAME = model.Username,DT=model.Dt,DIACHI=model.Diachi,EMAIL=model.Diachi };
                    db.USERS.Add(_User);
                    db.SaveChanges();
                    return RedirectToAction("Index","Home");
                }
            }
            ViewBag.Message = "Tên đăng nhập đã tồn tại";
            return View(model);
        }
        #endregion

        #region Đăng nhập
        [HttpGet]
        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model)
        {
            if (ModelState.IsValid)
            {
                var UserLogOn = SneakerLogic.CheckUser(model.LoginName, model.Password);
                if (UserLogOn != null)
                {
                    FormsAuthentication.SetAuthCookie(UserLogOn.USERNAME, true);
                    return RedirectToAction("Index","Home");
                }
                return View("LogOn", model);
            }
            return View("LogOn", model);
        }
        #endregion

        #region ĐĂng xuất
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Đổi mật khẩu
        public ActionResult ChangePass()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePass(ChangePasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var UserLogOn = SneakerLogic.UserLogOn();
                if (UserLogOn.PASS == model.OldPassword.GetMD5())
                {
                    UserLogOn.PASS = model.NewPassword;
                    db.SaveChanges();
                    ViewBag.Message = "Đổi mật khẩu thành công";
                }
                else
                {
                    ViewBag.Message = "Mật Khẩu cũ không đúng";
                }
                return View();
            }
            return View();
        }
        #endregion
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}