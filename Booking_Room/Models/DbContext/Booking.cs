namespace Booking_Room.Models.DbContext
{
    using Booking_Room.Data;
    using Microsoft.ApplicationInsights.Extensibility.Implementation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Booking ID")]
        public string booking_id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Booking title")]
        public string booking_title { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy-MM-dd Thh:mm:ss}")]
        [Display(Name = "Start time")]
        public DateTime start_time { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy-MM-dd Thh:mm:ss}")]
        [Display(Name = "End time")]
        public DateTime end_time { get; set; }

        [StringLength(1000)]
        [Display(Name = "Participants")]
        public string participants { get; set; }

        
        [StringLength(1000)]
        [Display(Name = "Note")]
        public string note { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Room ID")]
        public string room_id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "User ID")]
        public string User_id { get; set; }

        public virtual Room Room { get; set; }

        public virtual User_s User_s { get; set; }

        [NotMapped]
        public List<Room> RoomsCollection { get; set; }
    }
}
