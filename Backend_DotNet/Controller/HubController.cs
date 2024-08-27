using Fleetmanagement_new.Services;
using FM_DotNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Fleetmanagement_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HubController : ControllerBase
    {
        private readonly IHub _service;

        public HubController(IHub service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hub>>> GetHubs()
        {
            return await _service.GetAllHubs();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hub>> GetHub(int id)
        {
            if (_service.GetHub(id) == null)
            {
                return NotFound();
            }
            return await _service.GetHub(id);
        }

    }
}
