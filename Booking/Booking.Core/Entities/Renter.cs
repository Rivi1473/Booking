namespace Booking.Core.Entities
{
    public class Renter:BaseModel
    {
       
        public string? Name { get; set; }
        public string? Phone { get; set; }

        public List<Zimmer> Zimmers { get; set; }




    }
}
