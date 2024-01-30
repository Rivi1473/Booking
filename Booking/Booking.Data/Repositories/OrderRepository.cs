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
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }
        public Orders GetOrdersById(int id)
        {
            return _context.Orders.Find(id);
        }
        public void AddOrder(Orders o)
        {
            _context.Orders.Add(o);
            _context.SaveChanges();

        }
        public void UpdateOrder(int id ,Orders o)
        {
            var order = GetOrdersById(id);
            if (order != null)
            {
                order.ZimmerId = o.ZimmerId;
                order.TenantName = o.TenantName;
                order.TenantPhone = o.TenantPhone;
                order.OrderDate = o.OrderDate;
                order.ArrivalDate = o.ArrivalDate;
                order.DepartureDate = o.DepartureDate;
                _context.SaveChanges();
            }
            
        }
        public void DeleteOrder(int id)
        {
            var order = GetOrdersById(id);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
 

}
