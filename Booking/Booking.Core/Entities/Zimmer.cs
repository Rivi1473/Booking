namespace Booking.Core.Entities
{
    public class Zimmer:BaseModel
    {
     
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; } 
        public int Price { get; set; }
        public string Description { get; set; }


        public int RenterId { get; set; }
        public Renter Renter { get; set; }

        public List<Order> Orders { get; set; }



    }
}
