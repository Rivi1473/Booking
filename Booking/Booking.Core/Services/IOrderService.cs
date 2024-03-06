using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Services
{
    public interface IOrderService
    {
        public Task<List<Orders>> GetAllOrdersAsync();
        public Task<Orders> GetOrderByIdAsync(int id);
        public Task AddOrderAsync(Orders o);
        public Task UpDateOrderAsync(int id,Orders o);
        public Task DeleteOrderAsync(int id);
      

    }
}
