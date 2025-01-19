namespace Vektorel.Events.Biletix.Models;

public class Participant
{
    public Participant()
    {
        TicketNumber = Guid.NewGuid();
    }
    public Guid TicketNumber { get; }
    public Organization Organization { get; set; }
}
