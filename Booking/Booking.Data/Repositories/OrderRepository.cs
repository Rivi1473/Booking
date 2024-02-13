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
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
            //  return _context.Orders.Include(z=>z.Zimmer)
        }
        public async Task<Order> GetOrdersByIdAsync(int id)
        {
             return await _context.Orders.FindAsync(id);

           // return await _context.Orders.Include(o => o.Renter).FirstAsync(o => o.Id == id);
        }
        public async Task AddOrderAsync(Order o)
        {
            _context.Orders.Add(o);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateOrderAsync(int id ,Order o)
        {
            var order = GetOrdersByIdAsync(id).Result;
            if (order != null)
            {
                order.ZimmerId = o.ZimmerId;
                order.TenantName = o.TenantName;
                order.TenantPhone = o.TenantPhone;
                order.OrderDate = o.OrderDate;
                order.ArrivalDate = o.ArrivalDate;
                order.DepartureDate = o.DepartureDate;
                await _context.SaveChangesAsync();
            }          
        }
        public async Task DeleteOrderAsync(int id)
        {
            var order = GetOrdersByIdAsync(id);
            _context.Orders.Remove(order.Result);
            await _context.SaveChangesAsync();
        }

       
    }
 

}
