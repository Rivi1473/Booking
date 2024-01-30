using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using Booking.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        public OrdersController(IOrderService orderService,IMapper mapper)
        {
            _mapper = mapper;
            _orderService = orderService;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult Get()
        {
            var lst = _orderService.GetAllOrders();
            var lstDto = new List<OrderDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<OrderDto>(item));
            }
            return Ok(lstDto);
        }
        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var o = _orderService.GetOrderById(id);
            return Ok(_mapper.Map<OrderDto>(o));
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] OrderModel o)
        {
            var order = new Orders
            {
                TenantName = o.TenantName,
                TenantPhone = o.TenantPhone,
                OrderDate = o.OrderDate,
                ArrivalDate = o.ArrivalDate,
                DepartureDate = o.DepartureDate,
                ZimmerId = o.ZimmerId
            };
            _orderService.AddOrder(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderModel o)
        {
            var order = new Orders
            {
                TenantName = o.TenantName,
                TenantPhone = o.TenantPhone,
                OrderDate = o.OrderDate,
                ArrivalDate = o.ArrivalDate,
                DepartureDate = o.DepartureDate,
                ZimmerId = o.ZimmerId
            };
            _orderService.UpdateOrder(id,order);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.DeleteOrder(id);
        }
    }
}