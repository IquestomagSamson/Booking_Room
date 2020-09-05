using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    [Table("Room")]
    public class Rooms
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Room ID")]
        public string room_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Room name")]
        public string room_name { get; set; }

        [Display(Name = "Capacity")]
        public int capacity { get; set; }
    }
}
