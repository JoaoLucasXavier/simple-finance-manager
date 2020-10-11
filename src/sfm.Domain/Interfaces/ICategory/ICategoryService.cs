using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.ICategory
{
    public interface ICategoryService
    {
        void AddCategory(Category categoria);
        void updateCategory(Category categoria);
    }
}
