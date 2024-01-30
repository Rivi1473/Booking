using AutoMapper;
using Booking.API.Models;
using Booking.Core.DTOs;
using Booking.Core.Entities;
using Booking.Core.Services;
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
            this._renterService =renterService;

        }
        // GET: api/<RentersController>
        [HttpGet]
        public ActionResult Get()
        {
            var lst = _renterService.GetAllRenters();
            var lstDto = new List<RenterDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<RenterDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<RentersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var r= _renterService.GetRenterById(id);
            return Ok(_mapper.Map<RenterDto>(r));
        }

        // POST api/<RentersController>
        [HttpPost]
        public ActionResult Post([FromBody] RenterModel r)
        {
            var renter = new Renter { Name = r.Name, Phone = r.Phone };
            _renterService.AddRenter(renter);
            return Ok(_mapper.Map<RenterDto>(renter));
        }

        // PUT api/<RentersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RenterModel r)
        {
            var renter = new Renter { Name = r.Name, Phone = r.Phone };
            _renterService.UpdateRenter(id,renter);
        }

        // DELETE api/<RentersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _renterService.DeleteRenter(id);

        }
    }
}
