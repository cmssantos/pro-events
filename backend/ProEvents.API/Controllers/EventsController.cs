using Microsoft.AspNetCore.Mvc;
using ProEvents.API.Data;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly DataContext _context;

    public EventsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetEvents")]
    public IEnumerable<Event> Get()
    {
        return _context.Events;
    }

    [HttpGet("{id}", Name = "GetEvent")]
    public Event Get(int id)
    {
        return _context.Events
            .FirstOrDefault(@event => @event.Id == id);
    }
}
