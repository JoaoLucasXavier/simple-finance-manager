using Microsoft.EntityFrameworkCore;
using sfm.Entities.Entities;

namespace sfm.Infra.Configurations
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Category> Category { set; get; }
        public DbSet<Expense> Expense { set; get; }
        public DbSet<FinancialSystem> FinancialSystem { set; get; }
        public DbSet<SystemUser> SystemUser { set; get; }
        public DbSet<Suggestion> Suggestion { set; get; }
        public DbSet<Purchase> Purchase { set; get; }
        public DbSet<PurchaseItem> PurchaseItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer(GetConnectionString());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            return "Data Source=DESKTOP-NOII95F\\SimpleFinanceManager;Initial Catalog=FINANCEIRO;Integrated Security=False;User ID=sa;Password=@Sa170580;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";
        }
    }
}
