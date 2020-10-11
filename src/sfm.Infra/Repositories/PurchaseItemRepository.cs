using Microsoft.EntityFrameworkCore;
using sfm.Domain.Interfaces.IPurchase;
using sfm.Entities.Entities;
using sfm.Infra.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sfm.Infra.Repositories
{
    public class PurchaseItemRepository : GenericRepository<PurchaseItem>, IPurchaseItem
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public PurchaseItemRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public void DeleteItemById(Guid id)
        {
            using var db = new Context(_OptionsBuilder);
            var purchaseItem = db.PurchaseItem.Find(id);
            db.PurchaseItem.Remove(purchaseItem);
            db.SaveChanges();
        }

        public IList<PurchaseItem> ListPurchaseItems(Guid purchaseId)
        {
            using var db = new Context(_OptionsBuilder);
            return (from fs in db.FinancialSystem
                    join c in db.Category on fs.Id equals c.SystemId
                    join su in db.SystemUser on fs.Id equals su.SystemId
                    join p in db.Purchase on c.Id equals p.CategoryId
                    join pi in db.PurchaseItem on p.Id equals pi.PurchaseId
                    where p.Id == purchaseId
                    select pi).AsNoTracking().Distinct().ToList();
        }

        public void UpdatePurchaseItem(PurchaseItem purchaseItem)
        {
            using var banco = new Context(_OptionsBuilder);
            var item = banco.PurchaseItem.Find(purchaseItem.Id);
            item.Purchased = purchaseItem.Purchased;
            banco.PurchaseItem.Update(item);
            banco.SaveChanges();
        }
    }
}
