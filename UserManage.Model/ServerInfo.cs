using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Model
{
    public class ServerInfo
    {
        int seraverId;
        IPAddress ip;
        int portNumber;
        string password;
        string description;
        string location;

        public int SeraverId
        {
            get
            {
                return seraverId;
            }

            set
            {
                seraverId = value;
            }
        }

        public IPAddress Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public int PortNumber
        {
            get
            {
                return portNumber;
            }

            set
            {
                portNumber = value;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public ServerInfo()
        { }

        public ServerInfo(int serverid,IPAddress ip, int portNumber, string password, string description, string location)
        {
            this.Ip = ip;
            this.PortNumber = portNumber;
            this.Password = password;
            this.Description = description;
            this.location = location;
        }
       }
}
