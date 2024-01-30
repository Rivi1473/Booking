﻿using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Date;
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
        public List<Zimmer> GetAllZimmers()
        {
            return _context.Zimmers.ToList();
        }
        public Zimmer GetZimmerById(int id)
        {
            return _context.Zimmers.Find( id);
        }
        public void AddZimmer(Zimmer z)
        {
            _context.Zimmers.Add(z);
            _context.SaveChanges();
        }
        public void UpdateZimmer(int id,Zimmer z)
        {
            var zimmer = GetZimmerById(id);
            zimmer.Name = z.Name;
            zimmer.Price = z.Price;
            zimmer.Address = z.Address;
            zimmer.City = z.City;
            zimmer.Description = z.Description;
            _context.SaveChanges();
        }
        public void DeleteZimmer(int id)
        {
            var zimmer = GetZimmerById(id);
            _context.Zimmers.Remove(zimmer);
            _context.SaveChanges();
        }

    }
}
