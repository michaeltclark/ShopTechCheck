using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class CertificationShopUser
    {
        [Key, Column(Order = 0)]
        public string ShopUserID { get; set; }

        [Key, Column(Order = 1)]
        public int CertificationID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Score { get; set; }

        public ShopUser ShopUser { get; set; }
        public Certification Certification { get; set; }
    }
}
