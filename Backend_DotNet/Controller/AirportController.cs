using Fleetmanagement_new.Services;
using FM_DotNet.Models;
using FM_DotNet.Repositories;
using FM_DotNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fleetmanagement_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService _service;
        public AirportController(IAirportService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Airport>>> GetAirports()
        {
            var airports = await _service.GetAllAirportsAsync();
            return Ok(airports);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Airport>> GetAirport(int id)
        {
            var airport = await _service.GetAirportById(id);
            if (airport == null)
            {
                return NotFound();
            }
            return Ok(airport);
        }

        [HttpGet("/getairportbyCityid/{id}")]
        public async Task<ActionResult<IEnumerable<Airport>>> GetAirportbycityid(int id)
        {
            var airports = await _service.GetAirportByCityId(id);
            return Ok(airports);
        }

        [HttpPost]
        public async Task<ActionResult<Airport>> PostAirport(Airport airport)
        {
            if (airport == null)
            {
                return BadRequest();
            }

            try
            {
                var createdAirport = await _service.PostAirport(airport);
                return CreatedAtAction(nameof(GetAirport), new { id = createdAirport.AirportId }, createdAirport);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAirport(long id, Airport airport)
        {
            if (id != airport.AirportId)
            {
                return BadRequest();
            }

            var updatedAirport = await _service.PutAirport(id, airport);
            if (updatedAirport == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAirport(long id)
        {
            var result = await _service.DeleteAirport(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
