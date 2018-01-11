using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManage.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int DurationInDays { get; set; }
        public ProductStatus Status { get; set; }

    }
}

