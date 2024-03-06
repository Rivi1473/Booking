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
        }
        public async Task<Renter> GetRenterByIdAsync(int id)
        {
            return await _context.Renters.FirstAsync(i=>i.Id==id);
        }
        public async Task<Renter> GetRenterByNameAndPhoneAsync(string name, string phone)
        {
            return await _context.Renters.Where(r => r.Name == name && r.Phone == phone).FirstOrDefaultAsync();
        }
        public async Task DeleteRenterAsync(int id)
        {
            var renter = GetRenterByIdAsync(id).Result;
            _context.Renters.Remove(renter);
           await _context.SaveChangesAsync();
        }
        public async Task UpDateRenterAsync(int id,Renter r)
        {
            //change
            var renter = GetRenterByIdAsync(id).Result;         
            renter.Name = r.Name;
            renter.Phone = r.Phone;
            await _context.SaveChangesAsync();
        }
        public  async Task AddRenterAsync(Renter r)
        {
            _context.Renters.Add(r);
           await _context.SaveChangesAsync();
        }

        public Task<Task<Renter>> GetByNameAndPhoneAsync(string name, string phone)
        {
            throw new NotImplementedException();
        }
    }
}
