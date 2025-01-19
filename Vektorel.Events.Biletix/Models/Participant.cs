namespace Vektorel.Events.Biletix.Models;

internal class Participant
{
    public Participant()
    {
        TicketNumber = Guid.NewGuid();
    }
    public Guid TicketNumber { get; }
    public Organization Organization { get; set; }
}
