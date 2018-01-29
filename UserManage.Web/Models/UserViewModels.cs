using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UserManage.Model;

namespace UserManage.Web.Models
{
    public class UserViewModels
    {

        [Display(Name="手机号")]
        [DataType(DataType.PhoneNumber)]
        public string UserName { get; set; }

        [Display(Name = "密码")]
        public string Password { get; set; }

        
        [Display(Name = "验证码")]
        public string SMSStr { get; set; }

        [Display(Name = "推荐人")]
        public string RefUserId { get; set; }
    }
}