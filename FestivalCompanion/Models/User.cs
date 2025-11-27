using System.Collections.Generic;

namespace FestivalCompanion.Models
{
	public class User
	{
		public int Id { get; set; }                // PK
		public string Name { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Password { get; set; } = null!;

		// Navigation
		public Wallet? Wallet { get; set; }        // 0..1
		public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
	}
}
