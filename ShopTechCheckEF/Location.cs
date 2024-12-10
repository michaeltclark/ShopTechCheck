using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{

    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required, MaxLength(255)]
        public string LocationName { get; set; }

        public string LocationDescription { get; set; }

        [Required]
        public int LocationMaximumCapacity { get; set; }
    }
}
