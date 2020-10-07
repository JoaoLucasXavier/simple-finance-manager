using System.Collections.Generic;
using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface IPurchase : IGeneric<Purchase>
    {
        IList<Purchase> ListUserPurchase(string userEmail);
    }
}
