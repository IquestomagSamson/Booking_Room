using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Entities
{
    [Table("Users_s")]
    public class User_s
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "User ID")]
        public string User_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "User's name")]
        public string User_name { get; set; }


    }
}
