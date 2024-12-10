using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class CheckoutItem
    {
        [Key]
        public int CheckoutItemID { get; set; }

        [Required, MaxLength(255)]
        public string BarCode { get; set; }

        [Required]
        public int CertificationID { get; set; }

        public Certification Certification { get; set; }
    }
}
