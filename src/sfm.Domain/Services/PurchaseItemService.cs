using System;
using sfm.Domain.Interfaces;
using sfm.Entities.Entities;

namespace sfm.Domain.Services
{
    public class PurchaseItemService : IPurchaseItemService
    {
        private readonly IPurchaseItem _iPurchaseItem;

        public PurchaseItemService(IPurchaseItem iPurchaseItem)
        {
            _iPurchaseItem = iPurchaseItem;
        }

        public void AddPurchaseItem(PurchaseItem purchaseItem)
        {
            purchaseItem.RegisterDate = DateTime.Now;
            purchaseItem.ChangeDate = DateTime.MinValue;
            purchaseItem.PurchaseDate = DateTime.MinValue;
            var valid = purchaseItem.ValidateStringProperty(purchaseItem.Name, "Name");
            if (valid) _iPurchaseItem.Add(purchaseItem);
        }

        public void updatePurchaseItem(PurchaseItem purchaseItem)
        {
            purchaseItem.ChangeDate = DateTime.Now;
            if (purchaseItem.Purchased) purchaseItem.PurchaseDate = DateTime.Now;
            var valid = purchaseItem.ValidateStringProperty(purchaseItem.Name, "Name");
            if (valid) _iPurchaseItem.Update(purchaseItem);
        }
    }
}
