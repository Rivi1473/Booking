using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using Booking.Core.Services;
using Booking.Service;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public async Task<ActionResult> Get()
        {
            var lst =await _orderService.GetAllOrdersAsync();
            var lstDto = new List<OrderDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<OrderDto>(item));
            }
            return Ok(lstDto);
        }
        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var o =await _orderService.GetOrderByIdAsync(id);
            return Ok(_mapper.Map<OrderDto>(o));
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OrderModel o)
        {
            //var order = new Orders
            //{
            //    TenantName = o.TenantName,
            //    TenantPhone = o.TenantPhone,
            //    OrderDate = o.OrderDate,
            //    ArrivalDate = o.ArrivalDate,
            //    DepartureDate = o.DepartureDate,
            //    ZimmerId = o.ZimmerId
            //};
            var order = new Orders();
            _mapper.Map(o, order);
            await _orderService.AddOrderAsync(order);
            return Ok(_mapper.Map<OrderDto>(order));
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] OrderModel o)
        {
            var existOrder=await _orderService.GetOrderByIdAsync(id);
            if(existOrder is null)
            {
                return NotFound();
            }
            _mapper.Map(o, existOrder);
            await _orderService.UpDateOrderAsync(id,existOrder);
            return Ok();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _orderService.DeleteOrderAsync(id);
        }
    }
}