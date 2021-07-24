using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Web.Models
{
    public class SneakerLogic
    {
        #region Lấy về User đăng nhập
        public static USER UserLogOn()
        {
            SneakerEntities db = new SneakerEntities();
            return db.USERS.FirstOrDefault(m => m.LOGINNAME == System.Web.HttpContext.Current.User.Identity.Name);
        }
        #endregion

        #region Check UserLogOn
        public static USER CheckUser(string UserName, string Password)
        {
            var passMD5 = Password.GetMD5();
            SneakerEntities db = new SneakerEntities();
            var UserLogOn = db.USERS.SingleOrDefault(m => m.LOGINNAME == UserName && m.PASS == passMD5);
            return UserLogOn;
        }
        #endregion
    }
}