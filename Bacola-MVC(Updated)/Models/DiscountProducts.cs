using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Models
{
    public class DiscountProducts:BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Discount { get; set; }
        public decimal FirstPrice { get; set; }
        public decimal SecondPrice { get; set; }
    }
}
