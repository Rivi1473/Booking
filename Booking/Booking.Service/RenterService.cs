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
    public class RenterService:IRenterService
    {

        private readonly IRenterRepository _renterRepository;
        public RenterService(IRenterRepository renterRepository)
        {
            _renterRepository = renterRepository;
        }
        public async Task<List<Renter>> GetAllRentersAsync()
        {
            return await _renterRepository.GetAllRentersAsync();
        }
        public async Task<Renter> GetRenterByIdAsync(int id)
        {
            return await _renterRepository.GetRenterByIdAsync(id);
        }
        public async Task AddRenterAsync(Renter renter)
        {
            await _renterRepository.AddRenterAsync(renter);
        }
        
        public async Task UpdateRenterAsync(int id,Renter renter)
        {
            await _renterRepository.UpdateRenterAsync(id,renter);
        }
        public async Task DeleteRenterAsync(int id)
        {
            await _renterRepository.DeleteRenterAsync(id);
        }
    }
}
