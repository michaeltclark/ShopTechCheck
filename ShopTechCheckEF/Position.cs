using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }

        [Required, MaxLength(255)]
        public string PositionName { get; set; }

        public string PositionDescription { get; set; }

        [Required]
        public decimal PayRate { get; set; }
    }
}
