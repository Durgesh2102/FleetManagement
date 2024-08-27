
using FM_DotNet.Models;
using FM_DotNet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class hubServices : IHub
{
    public readonly FMContext context;

    public hubServices(FMContext context)
    {
        this.context = context;
    }

   public async Task<ActionResult<IEnumerable<Hub>>> GetAllHubs()
    {
        return await context.Hubs.ToListAsync();
    }

    public async Task<ActionResult<Hub>?> GetHub(int Id)
    {
        if(context.Hubs==null)
        {
            return null;
        }
        var State = await context.Hubs.FindAsync(Id);
        if(State == null)
        {
            return null;
        }
        return State;
    }
}
