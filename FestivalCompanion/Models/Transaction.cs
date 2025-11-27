using System;

namespace FestivalCompanion.Models
{
    public class Transaction
    {
        public int Id { get; set; }                // PK
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = null!; // e.g. "pending", "completed"

        public int WalletId { get; set; }          // FK → Wallets
        public Wallet Wallet { get; set; } = null!;
    }
}
