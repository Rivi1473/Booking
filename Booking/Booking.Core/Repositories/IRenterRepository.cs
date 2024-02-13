using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Repositories
{
    public interface IRenterRepository
    {
        public Task<List<Renter>> GetAllRentersAsync();
        public Task<Renter> GetRenterByIdAsync(int id);
        public Task DeleteRenterAsync(int id);
        public Task UpdateRenterAsync(int id, Renter r);
        public Task AddRenterAsync(Renter r);
    }
}
