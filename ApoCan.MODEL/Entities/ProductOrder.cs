using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoCan.MODEL.Entities
{
    public class ProductOrder : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        //relations begin
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
