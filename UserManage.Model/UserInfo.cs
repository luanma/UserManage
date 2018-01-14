using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Model
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public UserStatus Status { get; set; }
        public int RefUserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
