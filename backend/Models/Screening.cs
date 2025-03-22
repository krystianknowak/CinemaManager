namespace backend.Models;

public class Screening
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }

    // Relations
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int CinemaHallId { get; set; }
    public CinemaHall CinemaHall { get; set; }

    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; }
}