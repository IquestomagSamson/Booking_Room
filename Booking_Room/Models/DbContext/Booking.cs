namespace Booking_Room.Models.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        [StringLength(10)]
        public string booking_id { get; set; }

        [Required]
        [StringLength(100)]
        public string booking_title { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime start_time { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime end_time { get; set; }

        [StringLength(1000)]
        public string participants { get; set; }

        [StringLength(1000)]
        public string note { get; set; }

        [Required]
        [StringLength(10)]
        public string room_id { get; set; }

        [Required]
        [StringLength(10)]
        public string users_id { get; set; }

        public virtual Room Room { get; set; }

        public virtual User_s User_s { get; set; }
    }
}
