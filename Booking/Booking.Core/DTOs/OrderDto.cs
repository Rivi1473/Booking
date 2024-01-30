using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string? TenantName { get; set; }
        public string? TenantPhone { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }

        public int ZimmerId { get; set; }
    }
}
