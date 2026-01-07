namespace ListeWebJsonMVC.Models
{
    public class Termin
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public int DurationMinutes { get; set; }
        public string Location { get; set; } = string.Empty;
        public string ContactPerson { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
    }
}
