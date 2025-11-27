using FestivalCompanion.Models;
using Microsoft.EntityFrameworkCore;

namespace FestivalCompanion.Data
{
    public class FestivalContext : DbContext
    {
        public FestivalContext(DbContextOptions<FestivalContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Wallet> Wallets => Set<Wallet>();
        public DbSet<Festival> Festivals => Set<Festival>();
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<Schedule> Schedules => Set<Schedule>();
        public DbSet<Map> Maps => Set<Map>();
        public DbSet<MapPoint> MapPoints => Set<MapPoint>();
        public DbSet<Transaction> Transactions => Set<Transaction>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User 1–0..1 Wallet
            modelBuilder.Entity<User>()
                .HasOne(u => u.Wallet)
                .WithOne(w => w.User)
                .HasForeignKey<Wallet>(w => w.UserId);

            // User 1–* Tickets
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            // Wallet 1–* Transactions
            modelBuilder.Entity<Wallet>()
                .HasMany(w => w.Transactions)
                .WithOne(tr => tr.Wallet)
                .HasForeignKey(tr => tr.WalletId);

            // Festival 1–* Tickets
            modelBuilder.Entity<Festival>()
                .HasMany(f => f.Tickets)
                .WithOne(t => t.Festival)
                .HasForeignKey(t => t.FestivalId);

            // Festival 1–* Schedules
            modelBuilder.Entity<Festival>()
                .HasMany(f => f.Schedules)
                .WithOne(s => s.Festival)
                .HasForeignKey(s => s.FestivalId);

            // Festival 1–* Maps
            modelBuilder.Entity<Festival>()
                .HasMany(f => f.Maps)
                .WithOne(m => m.Festival)
                .HasForeignKey(m => m.FestivalId);

            // Map 1–* MapPoints
            modelBuilder.Entity<Map>()
                .HasMany(m => m.MapPoints)
                .WithOne(mp => mp.Map)
                .HasForeignKey(mp => mp.MapId);
        }
    }
}
