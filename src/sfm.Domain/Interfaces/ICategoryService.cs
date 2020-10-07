using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface ICategoryService
    {
        void AddCategory(Category categoria);
        void updateCategory(Category categoria);
    }
}
