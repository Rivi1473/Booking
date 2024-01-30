namespace Booking.API.Models
{
    public class ZimmerModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int RenterId { get; set; }
    }
}
