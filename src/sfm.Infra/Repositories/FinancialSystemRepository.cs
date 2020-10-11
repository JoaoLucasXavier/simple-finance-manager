using Microsoft.EntityFrameworkCore;
using sfm.Domain.Interfaces.IFinancialSystem;
using sfm.Entities.Entities;
using sfm.Infra.Configurations;
using System.Collections.Generic;
using System.Linq;

namespace sfm.Infra.Repositories
{
    public class FinancialSystemRepository : GenericRepository<FinancialSystem>, IFinancialSystem
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public FinancialSystemRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public IList<FinancialSystem> ListUserSystems(string userEmail)
        {
            using var db = new Context(_OptionsBuilder);
            return (from fs in db.FinancialSystem
                    join su in db.SystemUser on
                    fs.Id equals su.SystemId
                    where su.UserEmail.Equals(userEmail)
                    select fs).ToList();
        }
    }
}
