using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManage.Model;
using Dapper;
using System.Data.SqlClient;

namespace UserManage.BLL
{
    public class UserManager
    {
        private string connstr;
        public UserManager(string connstr)
        {
            this.connstr = connstr;
        }

        public UserInfo Login(string userName, string password)
        {
            UserInfo user;  
            using (IDbConnection db = new SqlConnection(connstr))
            {
                user = db.Query<UserInfo>("SELECT * FROM UserInfo Where UserName=@userName and Password=@password", new { userName,password }).SingleOrDefault();
            }
            return user;
        }



        public CreateUserResult CreateUser(string userName, string password, int refUserId)
        {           
            //Check inputs
            
            //UserExist? or not
            bool userExist = UserExists(userName);
            
            if (userExist) return CreateUserResult.UserExits;
            
            using (IDbConnection db = new SqlConnection(connstr))
            {
                db.Execute("INSERT INTO [UserInfo]([UserName] , [Password] , [RefUserId] , [Status]) VALUES (@userName, @password, @refUserId, @Status)",
                    new { userName, password, refUserId, Status=1 });
            }
            return CreateUserResult.Success;
        }

        public bool UpdatePassword(string userName, string password)
        {
            if (!UserExists(userName))
                return false;
       

            using (IDbConnection db = new SqlConnection(connstr))
            {
                db.Execute("Update UserInfo set password=@password Where UserName=@userName", new { password,userName });
            }
            return true;
        }

        public UserInfo GetUserInfo(int userid)
        {
            return null;
        }

        public UserInfo GetUserInfo(string userName)
        {
            return null;
        }

        public List<Order> GetOrders(int userId)
        {
            return null;
        }

        public bool UserExists(string userName)
        {
            bool userExist = false;
            using (IDbConnection db = new SqlConnection(connstr))
            {
                userExist = db.ExecuteScalar<bool>("SELECT count(1) FROM UserInfo Where UserName=@userName", new { userName });
            }
            return userExist;
        }
    }
}
