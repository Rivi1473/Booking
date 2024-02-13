using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Services
{
    public interface IRenterService
    {
        public Task<List<Renter>> GetAllRentersAsync();
        public Task<Renter> GetRenterByIdAsync(int id);
        public Task AddRenterAsync(Renter r);
        public Task UpdateRenterAsync(int id, Renter r);

        public Task DeleteRenterAsync(int id);
        
    }
}
