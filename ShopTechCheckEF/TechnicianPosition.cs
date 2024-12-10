using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class TechnicianPosition
    {
        [Key]
        public int TechnicianPositionID { get; set; }

        [Required]
        public string ShopUserID { get; set; }

        [Required]
        public int PositionID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Technician Technician { get; set; }
        public Position Position { get; set; }
    }
}
