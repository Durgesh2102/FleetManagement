
using FM_DotNet.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    public readonly ICity city;

    public CityController(ICity states)
    {
        this.city = states;
    }
    [HttpGet]public async Task<ActionResult<IEnumerable<CityMaster>?>> GetEmployees()
    {
        if(await city.GetAllCities() == null)
        {
            return NotFound();
        }
        else  
        return await city.GetAllCities();
    }

    [HttpGet("{id}")]public async Task<ActionResult<CityMaster>> GetEmployeeById(int id)
    {
        var state = await city.GetCity(id);
       return state == null ? NotFound() : state;
    }

    [HttpGet("/getcitiybystateid/{id}")]public async Task<ActionResult<IEnumerable<CityMaster>?>> GetCitiesbyState(int id)
    {
       return await city.getcitybystateid(id);
    }


}