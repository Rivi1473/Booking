using AutoMapper;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core
{
    public class MappingProfile:Profile 
    {
        public MappingProfile()
        {
            CreateMap<Zimmer, ZimmerDto>().ReverseMap();
            CreateMap<Orders, OrderDto>().ReverseMap();
            CreateMap<Renter, RenterDto>().ReverseMap();
        }
    }
}
