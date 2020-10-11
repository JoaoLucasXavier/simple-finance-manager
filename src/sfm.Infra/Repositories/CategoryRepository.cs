using Microsoft.EntityFrameworkCore;
using sfm.Domain.Interfaces.ICategory;
using sfm.Entities.Entities;
using sfm.Infra.Configurations;
using System.Collections.Generic;
using System.Linq;

namespace sfm.Infra.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategory
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public CategoryRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public IList<Category> ListUserCategory(string userEmail)
        {
            using var db = new Context(_OptionsBuilder);
            return (from fs in db.FinancialSystem
                    join c in db.Category on fs.Id equals c.SystemId
                    join su in db.SystemUser on fs.Id equals su.SystemId
                    where su.UserEmail.Equals(userEmail) && su.CurrentSystem
                    select c).AsNoTracking().ToList();
        }
    }
}
