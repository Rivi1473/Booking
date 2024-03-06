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
        public async Task<List<Orders>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }
        public Task<Orders> GetOrdersByIdAsync(int id)
        {
            return _context.Orders.FirstAsync(i=>i.Id==id);
        }
        public async Task DeleteOrderAsync(int id)
        {
            var order = GetOrdersByIdAsync(id).Result;         
            _context.Orders.Remove(order);  
           await _context.SaveChangesAsync(); 
        }
        public async Task UpDateOrderAsync(int id ,Orders o)
        {
            //change
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
        public async Task AddOrderAsync(Orders o)
        {
            _context.Orders.Add(o);
           await _context.SaveChangesAsync();

        }
    }
 

}
