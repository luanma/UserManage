using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Model
{
    public class Product
    {
        int productId;
        string description;
        int durationInDays;
        ServerStaus status;

        public int ProductID { get => productId; set => productId = value; }
        public string Description { get => description; set => description = value; }
        public int DurationInDays { get => durationInDays; set => durationInDays = value; }
    }
}
