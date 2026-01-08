namespace ListeWebJsonMVC.Models
{
    public class Aufgabe
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Start date for the task
        public DateTime FromDate { get; set; }

        // Deadline for the task
        public DateTime ToDate { get; set; }

        // Reference to Kategorie
        public Guid CategoryId { get; set; }
    }
}
