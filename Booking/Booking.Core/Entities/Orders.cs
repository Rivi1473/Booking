namespace Booking.Core.Entities
{
    public class Orders:BaseModel
    {
           
        public string? TenantName { get; set; }
        public string? TenantPhone { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }

        public int ZimmerId { get; set; }
        public Zimmer Zimmer { get; set; }

    }
}



