using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;

namespace Booking.API.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<OrderModel, Orders>();
            CreateMap<RenterModel, Renter>();
            CreateMap<ZimmerModel, Zimmer>();
        }
    }
}
