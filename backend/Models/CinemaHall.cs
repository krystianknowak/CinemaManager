namespace backend.Models;

public class CinemaHall
{
    public int Id { get; set; }
    public int HallNumber { get; set; }
    public int SeatCount { get; set; }

    public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
}