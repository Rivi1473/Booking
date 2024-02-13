using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Date;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repositories
{
    public class RenterRepository:IRenterRepository
    {
        private readonly DataContext _context;
        public RenterRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Renter>> GetAllRentersAsync()
        {
            return await _context.Renters.ToListAsync();
            //return _context.Renters.Include(z => z.Renter);
        }
        public async Task<Renter> GetRenterByIdAsync(int id)
        {
            return await _context.Renters.FindAsync(id);
        }
        
        public async Task AddRenterAsync(Renter r)
        {
            _context.Renters.Add(r);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateRenterAsync(int id,Renter r)
        {
            var renter = GetRenterByIdAsync(id).Result;         
            renter.Name = r.Name;
            renter.Phone = r.Phone;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteRenterAsync(int id)
        {
            var renter = GetRenterByIdAsync(id);
            _context.Renters.Remove(renter.Result);
            await _context.SaveChangesAsync();
        }

    }
}
