﻿using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Services
{
    public interface IOrderService
    {
        public Orders GetOrderById(int id);
        public List<Orders> GetAllOrders();
        public void AddOrder(Orders o);
        public void UpdateOrder(int id,Orders o);
        public void DeleteOrder(int id);
        
    }
}
