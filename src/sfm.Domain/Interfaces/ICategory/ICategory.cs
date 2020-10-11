using System.Collections.Generic;
using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.ICategory
{
    public interface ICategory : IGeneric<Category>
    {
        IList<Category> ListUserCategory(string userEmail);
    }
}
