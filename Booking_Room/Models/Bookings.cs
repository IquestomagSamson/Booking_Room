using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models.Entities
{
    [Table("Booking")]
    public class Bookings
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Booking ID")]
        public string Booking_id { get; set; }

        [Required]
        [Display(Name = "Booking title")]
        public string booking_title { get; set; }

        [Required]
        [Display(Name = "Start time")]
        public DateTime start_time { get; set; }

        [Required]
        [Display(Name = "End time")]
        public DateTime end_time { get; set; }

        [Display(Name = "Participants")]
        public string participants { get; set; }

        [Display(Name = "Note")]
        public string note { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Room ID")]
        public string room_id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "User ID")]
        public string users_id { get; set; }

    }
}
