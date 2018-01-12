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

        public UserInfo Login(string username, string password)
        {
            return null;
        }



        public CreateUserResult CreateUser(string userName, string password, int refUserId)
        {           
            //UserExist? or not
            bool userExist = false;
            using (IDbConnection db = new SqlConnection(connstr))
            {
                userExist = db.ExecuteScalar<bool>("SELECT count(1) FROM UserInfo Where UserName=@userName", new { userName });
            }
            if (userExist) return CreateUserResult.UserExits;
            
            using (IDbConnection db = new SqlConnection(connstr))
            {
                db.Execute("INSERT INTO [UserInfo]([UserName] , [Password] , [RefUserId] , [Status]) VALUES (@userName, @password, @refUserId, @Status)",
                    new { userName, password, refUserId, Status=1 });
            }
            return CreateUserResult.Success;
        }

        public UserInfo GetUserInfo(int userid)
        {
            return null;
        }

        public List<Order> GetOrders(int userId)
        {
            return null;
        }
        
    }
}
