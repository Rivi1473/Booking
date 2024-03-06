using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service
{
    public class ZimmerService:IZimmerService
    {
        private readonly IZimmerRepository _zimmerRepository;
        public ZimmerService(IZimmerRepository zimmerRepository)
        {
            _zimmerRepository = zimmerRepository;
        }
        public async Task<List<Zimmer>> GetAllZimmersAsync()
        {
            return await _zimmerRepository.GetAllZimmersAsync();
        }
        public async Task<Zimmer> GetZimmerByIdAsync(int id)
        {
            return await _zimmerRepository.GetZimmerByIdAsync(id);
        }
        public async Task DeleteZimmerAsync(int id)
        {
           await _zimmerRepository.DeleteZimmerAsync(id);
        }
        public async Task AddZimmerAsync(Zimmer zimmer)
        {
           await _zimmerRepository.AddZimmerAsync(zimmer);
        }
        public async Task UpDateZimmerAsync(int id,Zimmer zimmer)
        {
           await _zimmerRepository.UpDateZimmerAsync(id,zimmer);
        }
    }
}
