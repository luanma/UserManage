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
        [Required]
        [Display(Name="用户名")]
        [MaxLength(11,ErrorMessage ="最长11位")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="密码")]
        public string Password { get; set; }
        
        
    }
}