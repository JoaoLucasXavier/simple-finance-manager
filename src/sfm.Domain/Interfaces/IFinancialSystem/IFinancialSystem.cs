using System.Collections.Generic;
using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystem : IGeneric<FinancialSystem>
    {
        IList<FinancialSystem> ListUserSystems(string userEmail);
    }
}
