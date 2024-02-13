using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;

namespace Booking.API
{
    public class APIMappingProfile: Profile
    {
        public APIMappingProfile()
        {
            CreateMap<ZimmerModel, Zimmer>();
            CreateMap<OrderModel, Order>();
            CreateMap<RenterModel, Renter>();
        }
    }
}
