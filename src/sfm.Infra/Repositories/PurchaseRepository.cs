using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using sfm.Domain.Interfaces.IPurchase;
using sfm.Entities.Entities;
using sfm.Infra.Configurations;

namespace sfm.Infra.Repositories
{
    public class PurchaseRepository : GenericRepository<Purchase>, IPurchase
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public PurchaseRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public IList<Purchase> ListUserPurchase(string userEmail)
        {
            using var db = new Context(_OptionsBuilder);
            return (from fs in db.FinancialSystem
                    join c in db.Category on fs.Id equals c.SystemId
                    join su in db.SystemUser on fs.Id equals su.SystemId
                    join p in db.Purchase on c.Id equals p.CategoryId
                    where su.UserEmail.Equals(userEmail)
                    select p).AsNoTracking().ToList();
        }
    }
}
