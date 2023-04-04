using Microsoft.AspNetCore.Mvc;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    public IEnumerable<Event> _events = new Event[] {
        new Event() {
                Id = 1,
                Theme = "Angular 11 e .NET 7",
                Local = "Curitiba",
                TicketBatch = "1º Lote",
                AmountPeople = 250,
                Date = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "photo.png"
            },
            new Event() {
                Id = 2,
                Theme = "Angular 11 e .NET 7",
                Local = "São Paulo",
                TicketBatch = "2º Lote",
                AmountPeople = 350,
                Date = DateTime.Now.AddDays(4).ToString(),
                ImageURL = "photo2.png"
            }
        };
    public EventsController() { }

    [HttpGet(Name = "GetEvents")]
    public IEnumerable<Event> Get()
    {
        return _events;
    }

    [HttpGet("{id}", Name = "GetEvent")]
    public Event Get(int id)
    {
        return _events.FirstOrDefault(@event => @event.Id == id);
    }
}
