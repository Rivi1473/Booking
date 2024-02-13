using Booking.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking.Date
{
    public class DataContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<Zimmer> Zimmers { get; set; }
        public int CntOrders { get; set; }
        public int CntRenters { get; set; }
        public int CntZimmers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Booking_DB");
        }

        //public DataContext()
        //{
        //    OrdersList = new List<Orders>();
        //    RentersList = new List<Renter>();
        //    ZimmersList = new List<Zimmer>();
        //    CntOrders = 1;
        //    CntRenters=1;
        //    CntZimmers=1;
        //}

    }
}
