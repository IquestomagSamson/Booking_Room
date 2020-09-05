using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Booking_Room.Data
{
    public class Users_sContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Users_sContext() : base("name=Users_sContext")
        {
        }

        public System.Data.Entity.DbSet<Booking.Models.Entities.User_s> Users { get; set; }
    }
}
