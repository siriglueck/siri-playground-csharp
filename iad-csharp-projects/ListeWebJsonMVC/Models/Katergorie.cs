namespace ListeWebJsonMVC.Models
{
    public class Kategorie
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Hex color code (e.g. #ff0000)
        public string Color { get; set; } = "#ffffff";
    }
}
