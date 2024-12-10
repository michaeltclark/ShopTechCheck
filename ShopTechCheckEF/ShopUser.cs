using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    /// <summary>
    /// Highest level of entity that may check into a shop, check out tools, or earn certification. 
    /// </summary>
    public class ShopUser
    {
        [Key, MaxLength(255)]
        public string ShopUserID { get; set; } // Email

        [Required, MaxLength(255)]
        public string FirstName { get; set; }

        [Required, MaxLength(255)]
        public string LastName { get; set; }
    }
}
