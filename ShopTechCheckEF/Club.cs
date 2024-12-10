using System.ComponentModel.DataAnnotations;

namespace ShopTechCheckEF
{
    public class Club
    {
        [Key]
        public int ClubID { get; set; }

        [Required, MaxLength(255)]
        public string ClubName { get; set; }

        public string ClubDescription { get; set; }
    }
}
