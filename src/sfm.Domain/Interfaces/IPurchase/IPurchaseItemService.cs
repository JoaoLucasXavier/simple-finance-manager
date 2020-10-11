using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.IPurchase
{
    public interface IPurchaseItemService
    {
        void AddPurchaseItem(PurchaseItem purchaseItem);
        void updatePurchaseItem(PurchaseItem purchaseItem);
    }
}
