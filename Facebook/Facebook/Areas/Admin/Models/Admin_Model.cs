using model.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook.Areas.Admin.Models;


namespace Facebook.Areas.Admin.Models
{
    public class Admin_Model
    {
        [Required(ErrorMessage = "Mời bạn nhập tài khoản")]
        public String user_name { set; get; }

        [Required(ErrorMessage = "Mời bạn nhập mật khẩu")]
        public String password { set; get; }
    }
}