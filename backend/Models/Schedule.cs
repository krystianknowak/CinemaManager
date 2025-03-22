namespace backend.Models;

public class Schedule
{
    public int Id { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }

    public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
}