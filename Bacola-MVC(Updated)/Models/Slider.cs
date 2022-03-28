using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Models
{
    public class Slider:BaseEntity
    {
        public string Image { get; set; }
        public string Header { get; set; }
        public string Offer { get; set; }
        public string UpTitle { get; set; }
        public string DownTitle { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
