namespace Booking_Room.Models.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookingDbContext : DbContext
    {
        public BookingDbContext()
            : base("name=BookingDbContext")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_s> User_s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.booking_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.room_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.users_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.room_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User_s>()
                .Property(e => e.users_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User_s>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.User_s)
                .WillCascadeOnDelete(false);
        }
    }
}
