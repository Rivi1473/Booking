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
    public class ZimmerRepository:IZimmerRepository
    {
        private readonly DataContext _context;
        public ZimmerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Zimmer>> GetAllZimmersAsync()
        {
            return await _context.Zimmers.ToListAsync();
        //    return _context.Zimmers.Include(z => z.Zimmer)
        }
        public async Task<Zimmer> GetZimmerByIdAsync(int id)
        {
            return await _context.Zimmers.FindAsync(id);
        }

        public async Task AddZimmerAsync(Zimmer z)
        {
            _context.Zimmers.Add(z);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateZimmerAsync(int id,Zimmer z)
        {
            var zimmer = GetZimmerByIdAsync(id).Result;
            zimmer.Name = z.Name;
            zimmer.Price = z.Price;
            zimmer.Address = z.Address;
            zimmer.City = z.City;
            zimmer.Description = z.Description;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteZimmerAsync(int id)
        {
            var zimmer = GetZimmerByIdAsync(id);
            _context.Zimmers.Remove(zimmer.Result);
            await _context.SaveChangesAsync();

        }

    }
}
