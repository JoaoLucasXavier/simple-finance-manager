using sfm.Domain.Interfaces.ICategory;
using sfm.Entities.Entities;

namespace sfm.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategory _iCategory;

        public CategoryService(ICategory iCategory)
        {
            _iCategory = iCategory;
        }

        public void AddCategory(Category category)
        {
            var valid = category.ValidateStringProperty(category.Name, "Name");
            if (valid) _iCategory.Add(category);
        }

        public void updateCategory(Category category)
        {
            var valid = category.ValidateStringProperty(category.Name, "Name");
            if (valid) _iCategory.Update(category);
        }
    }
}
