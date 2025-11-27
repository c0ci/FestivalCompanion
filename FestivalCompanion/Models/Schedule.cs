using System;

namespace FestivalCompanion.Models
{
    public class Schedule
    {
        public int Id { get; set; }                // PK
        public DateTime PerformanceTime { get; set; }
        public string Stage { get; set; } = null!;
        public string Artist { get; set; } = null!;

        public int FestivalId { get; set; }        // FK → Festivals
        public Festival Festival { get; set; } = null!;
    }
}
