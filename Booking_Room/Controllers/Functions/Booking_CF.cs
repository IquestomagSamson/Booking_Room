using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booking_Room.Data;
using Booking_Room.Models.DbContext;

namespace Booking_Room.Controllers.Functions
{
    public class Booking_CF
    {
        private RoomContext context;
        public IQueryable<RoomsController> Rooms
        {
            get { return (IQueryable<RoomsController>)context.Rooms; }
        }
    }
}