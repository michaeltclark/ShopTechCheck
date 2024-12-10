using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{

    public class Asset
    {
        [Key, ForeignKey("CheckoutItem")]
        public int CheckoutItemID { get; set; }

        [MaxLength(255)]
        public string SerialNumber { get; set; }

        [Required]
        public DateTime DateAcquired { get; set; }

        public DateTime? DateDisposed { get; set; }

        [Required]
        public int LocationID { get; set; }

        public CheckoutItem CheckoutItem { get; set; }
        public Location Location { get; set; }
    }
}
