using System;using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserManage.Model;

namespace UserManage.Web.Controllers
{
    public class ServerController : ApiController
    {
        public ServerInfo[] Get()
        {

            List<ServerInfo> servers = new List<ServerInfo>();
            IPAddress ip = IPAddress.Parse("67.209.177.98");

            var s = new ServerInfo(ip,443, "Reuters123", "Bandwagonhost", "US");
            servers.Add(s);
            ip = IPAddress.Parse("45.77.176.125");
            var s2 = new ServerInfo(ip, 443, "Reuters123", "vultr.toyo", "Tokyo");
            servers.Add(s2);

            return servers.ToArray();
            
          
        }
    }
}
