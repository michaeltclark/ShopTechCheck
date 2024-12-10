using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class Student
    {
        [Key, ForeignKey("ShopUser")]
        public string ShopUserID { get; set; }

        public Major Major { get; set; }
        public ShopUser ShopUser { get; set; }
    }
}
