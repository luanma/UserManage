using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UserManage.Model;

namespace Chitu.ViewModel
{
    public class ServicesManager
    {
        public List<ServerInfo> GetServcie()
        {
            List<ServerInfo> servers = new List<ServerInfo>();
            IPAddress ip = IPAddress.Parse("67.209.177.98");

            var s = new ServerInfo(1, ip, 443, "Reuters123", "Bandwagonhost", "US");
            servers.Add(s);
            ip = IPAddress.Parse("45.77.176.125");
            var s2 = new ServerInfo(2, ip, 443, "Reuters123", "vultr.toyo", "Tokyo");
            servers.Add(s2);

            return servers;
        }

    
    }
}
