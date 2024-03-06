using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using Booking.Core.Services;
using Booking.Data.Migrations;
using Booking.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentersController : ControllerBase
    {
        private readonly IRenterService _renterService;
        private readonly IMapper _mapper;

        public RentersController(IRenterService renterService, IMapper mapper)
        {
            _mapper = mapper;
            _renterService =renterService;

        }
        // GET: api/<RentersController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var lst =await _renterService.GetAllRentersAsync();
            var lstDto = new List<RenterDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<RenterDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var r=await _renterService.GetRenterByIdAsync(id);
            return Ok(_mapper.Map<RenterDto>(r));
        }

        // POST api/<RentersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RenterModel r)
        {
            //var renter = new Renter { Name = r.Name, Phone = r.Phone };
            var renter = new Renter();
            _mapper.Map(r, renter);
            await _renterService.AddRenterAsync(renter);
            return Ok(_mapper.Map<RenterDto>(renter));
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] RenterModel r)
        {
            var existRenter =await _renterService.GetRenterByIdAsync(id);
            if (existRenter is null)
            {
                return NotFound();
            }
            _mapper.Map(r, existRenter);
            await _renterService.UpDateRenterAsync(id, existRenter);
            return Ok();
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _renterService.DeleteRenterAsync(id);
        }
    }
}
