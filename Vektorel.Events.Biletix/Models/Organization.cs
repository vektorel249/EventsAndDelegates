namespace Vektorel.Events.Biletix.Models;

public class Organization
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Limit { get; set; }
    public int Count { get; set; }
}
