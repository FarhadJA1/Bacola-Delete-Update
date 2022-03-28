using Bacola_MVC_Updated_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.ViewModels
{
    public class HomeVM
    {
        public Slider Slider { get; set; }
        public List<Categories> Categories { get; set; }
        public List<DiscountProducts> DiscountProducts { get; set; }

    }
}
