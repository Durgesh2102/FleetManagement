
using FM_DotNet.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class StateController : ControllerBase
{
    public readonly IStates states;

    public StateController(IStates states)
    {
        this.states = states;
    }
    [HttpGet]public async Task<ActionResult<IEnumerable<StateMaster>?>> GetEmployees()
    {
        if(await states.GetAllStates() == null)
        {
            return null;
        }
        else
        return await states.GetAllStates();
    }

    [HttpGet("{id}")]public async Task<ActionResult<StateMaster>> GetEmployeeById(int id)
    {
        var state = await states.GetState(id);
       return state == null ? NotFound() : state;
    }
}