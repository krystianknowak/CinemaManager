namespace backend.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public int ProductionYear { get; set; }
    public string Genre { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }

    public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
}