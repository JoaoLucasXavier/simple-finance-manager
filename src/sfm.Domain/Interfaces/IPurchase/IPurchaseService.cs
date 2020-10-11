using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.IPurchase
{
    public interface IPurchaseService
    {
        void AddPurchase(Purchase purchase);
        void updatePurchase(Purchase purchase);
    }
}
