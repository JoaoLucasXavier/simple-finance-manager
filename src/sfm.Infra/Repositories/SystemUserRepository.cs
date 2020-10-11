using Microsoft.EntityFrameworkCore;
using sfm.Domain.Interfaces.ISystemUser;
using sfm.Entities.Entities;
using sfm.Infra.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sfm.Infra.Repositories
{
    public class SystemUserRepository : GenericRepository<SystemUser>, ISystemUser
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public SystemUserRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public SystemUser GetUserByEmail(string userEmail)
        {
            using var db = new Context(_OptionsBuilder);
            return db.SystemUser.Where(u => u.UserEmail == userEmail).FirstOrDefault();
        }

        public IList<SystemUser> ListSystemUsers(Guid SystemId)
        {
            using var db = new Context(_OptionsBuilder);
            return db.SystemUser.Where(s => s.SystemId == SystemId).ToList();
        }

        public void RemoveUsers(List<SystemUser> users)
        {
            using var db = new Context(_OptionsBuilder);
            db.SystemUser.RemoveRange(users);
            db.SaveChanges();
        }
    }
}
