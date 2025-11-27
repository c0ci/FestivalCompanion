using System.Collections.Generic;

namespace FestivalCompanion.Models
{
    public class Wallet
    {
        public int Id { get; set; }                // PK
        public decimal Balance { get; set; }

        public int UserId { get; set; }            // FK → Users
        public User User { get; set; } = null!;

        // Navigation
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
