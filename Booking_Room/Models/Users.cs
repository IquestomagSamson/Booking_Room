using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Entities
{
    [Table("Room")]
    public class Users
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
