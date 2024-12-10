using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class Tool
    {
        [Key, ForeignKey("CheckoutItem")]
        public int CheckoutItemID { get; set; }

        [Required, MaxLength(255)]
        public string ToolName { get; set; }

        public string ToolDescription { get; set; }

        public CheckoutItem CheckoutItem { get; set; }
    }
}
