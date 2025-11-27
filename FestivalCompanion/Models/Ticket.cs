namespace FestivalCompanion.Models
{
    public class Ticket
    {
        public int Id { get; set; }                // PK
        public string QrCode { get; set; } = null!;
        public string Type { get; set; } = null!;
        public decimal Price { get; set; }

        public int UserId { get; set; }            // FK → Users
        public User User { get; set; } = null!;

        public int FestivalId { get; set; }        // FK → Festivals
        public Festival Festival { get; set; } = null!;
    }
}
