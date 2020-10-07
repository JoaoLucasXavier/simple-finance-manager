using System.Collections.Generic;

namespace sfm.Domain.Interfaces
{
    public interface Purchase : IGeneric<Purchase>
    {
        IList<Purchase> ListUserPurchase(string userEmail);
    }
}
