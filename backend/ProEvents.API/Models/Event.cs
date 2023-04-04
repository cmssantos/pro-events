namespace ProEvents.API.Models;

public class Event
{
    public int Id { get; set; }
    public string Local { get; set; }
    public string Date { get; set; }
    public string Theme { get; set; }
    public int AmountPeople { get; set; }
    public string TicketBatch { get; set; }
    public string ImageURL { get; set; }
}