using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class Technician
    {
        [Key, ForeignKey("Student")]
        public string ShopUserID { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        public DateTime? RetireDate { get; set; }

        public Student Student { get; set; }
    }
}
