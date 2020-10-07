using System;
using System.Collections.Generic;

namespace sfm.Domain.Interfaces
{
    public interface PurchaseItem : IGeneric<PurchaseItem>
    {
        void UpdatePurchaseItem(PurchaseItem purchaseItem);
        void DeleteItemById(Guid id);
        IList<PurchaseItem> ListPurchaseItems(Guid purchaseId);
    }
}
