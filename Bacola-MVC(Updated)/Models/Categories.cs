using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Models
{
    public class Categories:BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
