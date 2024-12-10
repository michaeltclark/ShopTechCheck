using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTechCheckEF
{
    public class StudentClubMembership
    {
        [Key, Column(Order = 0)]
        public int ClubID { get; set; }

        [Key, Column(Order = 1)]
        public string ShopUserID { get; set; }

        public Club Club { get; set; }
        public Student Student { get; set; }
    }
}
