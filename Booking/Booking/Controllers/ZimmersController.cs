
using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using Booking.Core.Services;
using Booking.Data.Migrations;
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
        public async Task<ActionResult> Get()
        {
            var lst = await _zimmerService.GetAllZimmersAsync();
            var lstDto = new List<ZimmerDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<ZimmerDto>(item));
            }
            return Ok(lstDto);

        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int zimmerCode)
        {
            var z= await _zimmerService.GetZimmerByIdAsync(zimmerCode);
            return Ok(_mapper.Map<ZimmerDto>(z));
        }

        // POST api/<RentersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ZimmerModel z)
        {
            var zimmer = new Zimmer();
            await _zimmerService.AddZimmerAsync(zimmer);
            _mapper.Map(z, zimmer);
            return Ok(_mapper.Map<ZimmerDto>(zimmer));
        }
        
        
        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult>  Put(int id, [FromBody] ZimmerModel z)
        {
            var existZimmer = await _zimmerService.GetZimmerByIdAsync(id);
            if (existZimmer is null)
            {
                return NotFound();
            }
            _mapper.Map(z, existZimmer);
            await _zimmerService.UpdateZimmerAsync(id, existZimmer);
            return Ok();
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _zimmerService.DeleteZimmerAsync(id);

        }
    }
}
