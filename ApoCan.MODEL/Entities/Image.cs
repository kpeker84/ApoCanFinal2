using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoCan.MODEL.Entities
{
    public class Image : BaseEntity
    {
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }

        //Relations begin
        public virtual Product Product { get; set; }
    }
}
