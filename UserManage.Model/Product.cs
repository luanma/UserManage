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

        public Product(int durationInDays)
        {
            this.durationInDays = durationInDays;
        }

        public int ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
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

        public ProductStatus Status
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
    }
}
