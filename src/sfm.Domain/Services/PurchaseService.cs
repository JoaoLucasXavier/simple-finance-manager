using System;
using sfm.Domain.Interfaces.IPurchase;
using sfm.Entities.Entities;

namespace sfm.Domain.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchase _iPurchase;

        public PurchaseService(IPurchase iPurchase)
        {
            _iPurchase = iPurchase;
        }

        public void AddPurchase(Purchase purchase)
        {
            purchase.RegisterDate = DateTime.Now;
            var valid = purchase.ValidateStringProperty(purchase.Name, "Name");
            if (valid) _iPurchase.Add(purchase);
        }

        public void updatePurchase(Purchase purchase)
        {
            purchase.RegisterDate = DateTime.Now;
            var valid = purchase.ValidateStringProperty(purchase.Name, "Name");
            if (valid) _iPurchase.Update(purchase);
        }
    }
}
