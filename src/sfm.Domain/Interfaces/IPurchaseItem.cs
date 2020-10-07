using System;
using System.Collections.Generic;
using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface IPurchaseItem : IGeneric<PurchaseItem>
    {
        void UpdatePurchaseItem(PurchaseItem purchaseItem);
        void DeleteItemById(Guid id);
        IList<PurchaseItem> ListPurchaseItems(Guid purchaseId);
    }
}
