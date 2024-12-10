using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class Certification
    {
        [Key]
        public int CertificationID { get; set; }

        [Required, MaxLength(255)]
        public string CertificationName { get; set; }

        [Required]
        public decimal PassingScore { get; set; }
    }
}
