using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Date;
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
        public List<Renter> GetAllRenters()
        {
            return _context.Renters.ToList();
        }
        public Renter GetRenterById(int id)
        {
            return _context.Renters.Find(id);
        }
        
        public void AddRenter(Renter r)
        {
            _context.Renters.Add(r);
            _context.SaveChanges();
        }
        public void UpdateRenter(int id,Renter r)
        {
            var renter = GetRenterById(id);         
            renter.Name = r.Name;
            renter.Phone = r.Phone;
            _context.SaveChanges();
        }
        public void DeleteRenter(int id)
        {
            var renter = GetRenterById(id);
            _context.Renters.Remove(renter);
            _context.SaveChanges();
        }

    }
}
