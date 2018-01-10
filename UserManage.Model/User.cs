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

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return createDate;
            }

            set
            {
                createDate = value;
            }
        }

        public UserStatus Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int RefUserId
        {
            get
            {
                return refUserId;
            }

            set
            {
                refUserId = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
