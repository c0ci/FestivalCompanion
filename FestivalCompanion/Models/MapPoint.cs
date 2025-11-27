namespace FestivalCompanion.Models
{
    public class MapPoint
    {
        public int Id { get; set; }                // PK
        public string Type { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int MapId { get; set; }             // FK → Maps
        public Map Map { get; set; } = null!;
    }
}
