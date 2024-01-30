
using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using Booking.Core.Services;
using Booking.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmersController : ControllerBase
    {
        private readonly IZimmerService _zimmerService;
        private readonly IMapper _mapper;
        public ZimmersController(IZimmerService zimmerService, IMapper mapper)
        {
            _mapper = mapper;
            this._zimmerService = zimmerService;

        }
        // GET: api/<RentersController>
        [HttpGet]
        public ActionResult Get()
        {
            var lst = _zimmerService.GetAllZimmers();
            var lstDto = new List<ZimmerDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<ZimmerDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int zimmerCode)
        {
            var z = _zimmerService.GetZimmerById(zimmerCode);
            return Ok(_mapper.Map<ZimmerDto>(z));
        }

        // POST api/<RentersController>
        [HttpPost]
        public void Post([FromBody] ZimmerModel z)
        {
            var zimmer = new Zimmer { Name = z.Name, City = z.City, Address = z.Address, Price = z.Price, Description = z.Description, RenterId = z.RenterId };
            _zimmerService.AddZimmer(zimmer);
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ZimmerModel z)
        {
            var zimmer = new Zimmer { Name = z.Name, City = z.City, Address = z.Address, Price = z.Price, Description = z.Description, RenterId = z.RenterId };
            _zimmerService.UpdateZimmer(id, zimmer);
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _zimmerService.DeleteZimmer(id);

        }
    }
}
