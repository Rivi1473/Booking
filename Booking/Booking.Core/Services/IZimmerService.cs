using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Services
{
    public interface IZimmerService
    {
        public Task<List<Zimmer>> GetAllZimmersAsync();
        public Task<Zimmer> GetZimmerByIdAsync(int id);
        public Task AddZimmerAsync(Zimmer z);
        public Task UpdateZimmerAsync(int id, Zimmer z);

        public Task DeleteZimmerAsync(int id);
    }
}
