using System;
using System.Collections.Generic;

namespace FestivalCompanion.Models
{
    public class Festival
    {
        public int Id { get; set; }                // PK
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Map> Maps { get; set; } = new List<Map>();
    }
}
