using System.Collections.Generic;

namespace FestivalCompanion.Models
{
    public class Map
    {
        public int Id { get; set; }                // PK
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;

        public int FestivalId { get; set; }        // FK → Festivals
        public Festival Festival { get; set; } = null!;

        // Navigation
        public ICollection<MapPoint> MapPoints { get; set; } = new List<MapPoint>();
    }
}
