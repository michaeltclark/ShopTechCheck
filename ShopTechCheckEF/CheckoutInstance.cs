using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{

    public class CheckoutInstance
    {
        [Key, Column(Order = 0)]
        public int ShopUserSignInID { get; set; }

        [Key, Column(Order = 1)]
        public int CheckoutItemID { get; set; }

        [Required]
        public TimeSpan TimeOut { get; set; }

        public TimeSpan? TimeIn { get; set; }

        public ShopUserSignIn ShopUserSignIn { get; set; }
        public CheckoutItem CheckoutItem { get; set; }
    }
}
