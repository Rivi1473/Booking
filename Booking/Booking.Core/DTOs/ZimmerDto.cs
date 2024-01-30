using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.DTOs
{
    public class ZimmerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }


        public int RenterId { get; set; }
    }
}
