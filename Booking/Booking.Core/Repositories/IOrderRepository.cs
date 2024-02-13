using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booking.Core.Repositories
{
    public interface IOrderRepository
    {
        public Task<List<Order>> GetAllOrdersAsync();
        public Task<Order> GetOrdersByIdAsync(int id);
        public Task AddOrderAsync(Order o);
        public Task UpdateOrderAsync(int id, Order o);
        public Task DeleteOrderAsync(int id);
      
    }
}
