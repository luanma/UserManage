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
        string Description;
        string Location;

        public ServerInfo()
        { }

        public ServerInfo(IPAddress ip, int portNumber, string password, string description, string location)
        {
            this.ip = ip;
            this.PortNumber = portNumber;
            this.Password = password;
            Description1 = description;
            Location = location;
        }

        public int SeraverId { get => seraverId; set => seraverId = value; }
        public int PortNumber { get => portNumber; set => portNumber = value; }
        public string Password { get => password; set => password = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Location1 { get => Location; set => Location = value; }
    }
}
