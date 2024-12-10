using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class ShopUserSignIn
    {
        [Key]
        public int ShopUserSignInID { get; set; }

        public int? LocationID { get; set; }

        [Required]
        public string ShopUserID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan TimeIn { get; set; }

        public TimeSpan? TimeOut { get; set; }

        public ShopUser ShopUser { get; set; }
        public Location Location { get; set; }
    }
}
