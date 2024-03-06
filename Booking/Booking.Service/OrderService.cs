using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<Orders>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }
        public async Task<Orders> GetOrderByIdAsync(int id) 
        {
            return await _orderRepository.GetOrdersByIdAsync(id);
        }
        public async Task DeleteOrderAsync(int id)
        {
           await  _orderRepository.DeleteOrderAsync(id);
        }
        public async Task AddOrderAsync(Orders order)
        {
            await _orderRepository.AddOrderAsync(order);
        }
        public async Task UpDateOrderAsync(int id,Orders order)
        {
            await _orderRepository.UpDateOrderAsync(id,order);
        }
    }
}
