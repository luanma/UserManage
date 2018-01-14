using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManage.Model;

namespace UserManage.BLL
{
    public class Campaign
    {
        public double GetPrice(Product p)
        {
            return p.Price;
        }
    }
}
