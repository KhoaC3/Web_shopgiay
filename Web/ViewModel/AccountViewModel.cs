using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Web.ViewModel
{
    public class UserVM
    {

        #region Tạo tài khoản mới
        public string Loginname { get; set; }

        [Required, Display(Name = "Mật Khẩu"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Nhập Lại Mật Khẩu"), DataType(DataType.Password), System.Web.Mvc.Compare("Password", ErrorMessage = "Mật khẩu mới và xác nhận mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }
        public string Username { get; set; }
        public string Dt { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        #endregion

    }

    #region Model đăng nhập
    public class LogOnModel
    {
        [Required, Display(Name = "Tên Đăng Nhập")]
        public string LoginName { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Mật Khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ đăng nhập")]
        public bool RememberMe { get; set; }
    }
    #endregion

    #region Model thay đổi mất khẩu
    public class ChangePasswordVM
    {
        [Required, DataType(DataType.Password), Display(Name = "Mật Khẩu Hiện Tại")]
        public string OldPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Mật Khẩu Mới")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password), Display(Name = "Nhập Lại Mật Khẩu Mới"), Compare("NewPassword", ErrorMessage = "Mật khẩu mới và xác nhận mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }
    }
    #endregion

}