using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Model
{
    public class User
    {
        int userId;
        DateTime createDate;
        UserStatus status;
        int refUserId;
        string userName;
        string password;

        public int UserId { get => userId; set => userId = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public int RefUserId { get => refUserId; set => refUserId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
